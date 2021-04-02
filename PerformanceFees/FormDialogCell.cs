using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SharedObjects;

namespace PerformanceFees
{
    public partial class FormDialogCCel : Form
    {
        public CCell _cell;
        public CCellMatrix _cellMatrix;

        public string _lastFeedback;

        public FormDialogCCel(CCell pCell, CCellMatrix pCellMatrix)
        {
            InitializeComponent();
            _cell = pCell;
            _cellMatrix = pCellMatrix;
            InitGui();
            _lastFeedback = _cell._calculationFeedback;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            if (this.radioButtonInupt.Checked)
                _cell._type = ECellType.Input;
            else
                _cell._type = ECellType.Script;

            _cell._overRidden = this.checkBoxIsOver.Checked;

            _cell._value = textBoxPrevCellValue.Text;

            _cell._calculationFeedback = _lastFeedback;

            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void InitGui()
        {
            // Build and populate the fields list view
            BuildListViewFields();

            // Display the different status of the cell
            DisplayCellStatus();

            // fill gui elements

            //      script ! two location: original header or at cell level (overide)
            //               it needs to be enhanced to get the script at cell level in case of override
            
            string tScript = "";
            
            try  // This is the Script at header level
            {
                tScript = (_cellMatrix._cellHeaderVector._cellHeaders.First(s => s._name == _cell._cellHeader._name ))._script;
            }
            catch (Exception) { tScript  = "";  } // Much better than linq.FirstOrDefault: in case of nothing found then empty script

            //richTextBoxScript.Text = _cell._cellHeader._script;
            richTextBoxScript.Text = tScript ;

            textBoxCellValue.Text = _cell._value.ToString();
            textBoxPrevCellValue.Text = _cell._value.ToString();

            this.Text = "Edit Cell: " + _cell._cellHeader._name;


        }

        private void DisplayCellStatus()
        {

            // 1. Cell type; input / script
            if ( _cell._type == ECellType.Input)
            {
                this.radioButtonInupt.Checked = true;
                this.radioButtonScript.Checked = false;
            }
            else
            {
                this.radioButtonInupt.Checked = false;
                this.radioButtonScript.Checked = true;
            }

            // 2. Cell Override
            this.checkBoxIsOver.Checked = _cell._overRidden;

            // 3. Main status 
            DisplayCellMainStatus(_cell._status);

            // 4. Nombre de cycle
            DisplayCellCycle();

            // 5. le dernier feedback
            this.richTextBoxFeedBack.Text = _cell._calculationFeedback;

        }

        private void DisplayCellCycle()
        {
            this.textBoxCycle.Text = _cell._runCompilerCycle.ToString();
        }

        private void DisplayCellMainStatus(ECellStatus pCellStatus)
        {
            
            //  Main status 
            switch (pCellStatus)
            {
                case ECellStatus.Clean:
                    this.textBox1.Text = "Clean";
                    break;
                case ECellStatus.Dirty:
                    this.textBox1.Text = "Dirty";
                    break;
                case ECellStatus.Error:
                    this.textBox1.Text = "Error";
                    break;
                case ECellStatus.N_A:
                    this.textBox1.Text = "N_A";
                    break;
                default:
                    this.textBox1.Text = "Other";
                    break;
            }

        }

        private void BuildListViewFields()
        {
            listViewField.View = View.Details;
            listViewField.GridLines = true;

            listViewField.Columns.Add("Field");
            listViewField.Columns.Add("Current Value");
            listViewField.Columns.Add("Prev Value");

            listViewField.Columns[0].Width = 80;
            listViewField.Columns[1].Width = 100;
            listViewField.Columns[2].Width = 100;

            int id_vecteur = _cell._idCellVector;
            int id_vecteurPrev = _cell._idCellVector - 1;

            if (id_vecteurPrev < 0) id_vecteurPrev = 0;

            CCellVector currentCellVector = _cellMatrix._Vectors[id_vecteur];
            CCellVector previousCellVector = _cellMatrix._Vectors[id_vecteurPrev];

            _cellMatrix._idCurrentVector = id_vecteur;
            _cellMatrix._idPreviousVector = id_vecteurPrev;
            _cellMatrix._currentVector = currentCellVector;
            _cellMatrix._previousVector = previousCellVector;


            foreach (var c_cell in currentCellVector._Cells)
            {
                string nomChamp = c_cell.Key;
                string curValeur = c_cell.Value._value.ToString();
                string prevValeur;

                if (id_vecteurPrev == id_vecteur)
                    prevValeur = "N/A";
                else
                    prevValeur = previousCellVector._Cells[nomChamp]._value.ToString();

                listViewField.Items.Add(new ListViewItem(new string[] { nomChamp, curValeur, prevValeur }));

            }

        }

        private void buttonEval_Click(object sender, EventArgs e)
        {
            DoEval();
 
        }

        private void DoEval()
        {

            CCompiler tCompiler = new CCompiler();

            // Apply Cycée counter to the cell evaluated            
            _cell.CycleInc();
            DisplayCellCycle();


            // Look for primitive properties in the settings
            CApplicationSettings settings = new CApplicationSettings();
            settings.Load("aurora_stettings.xml");

            // Really need another pointer ???
            CCellMatrix theMatrix = _cellMatrix;

            // Call the compiler and run the code;

            tCompiler._injection_definition= settings._compPrimitiveInit;
            tCompiler._injection_constructor = settings._compPrimitiveConstructor;
            tCompiler._injection_primitives = settings._compPrimitiveFunctions;

            string tScriptToTest = @richTextBoxScript.Text; // Main script to compile
            
            tCompiler.PreCompileScript(tScriptToTest);
            tCompiler.RunPrecompiledScript(theMatrix);
            

            // Get the feedback of the compilation/run;
            richTextBoxFeedBack.Text = tCompiler._compilerOutput;
            richTextBoxFeedBack.Text += tCompiler._runOutput;
            textBoxPrevCellValue.Text = _cellMatrix._lastEvaluatedValue; //.ToString();

            _lastFeedback = tCompiler._runOutput;

            DisplayCellMainStatus(_cellMatrix._lastCellStatus);

        }

        private void buttonChangeScript_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxCellTape_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonInupt_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radioButtonScript_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxIsOver_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _cell.CycleReset();
            DisplayCellCycle();

            if (this.textBox1.Text != "Clean")
                this.textBox1.Text = "Clean";
            else
                this.textBox1.Text = "Dirty";
        }

        private void buttonOver_Click(object sender, EventArgs e)
        {
            this.checkBoxIsOver.Checked = !this.checkBoxIsOver.Checked;
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerformanceFees
{
    public partial class FormDialogOptions : Form
    {

        
        public FormDialogOptions()
        {
            InitializeComponent();

            LoadSettings();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            SaveSettings();

            this.DialogResult = DialogResult.OK;
        }

        private void SaveSettings()
        {
            CApplicationSettings serial = new CApplicationSettings();

            serial._fileDefaultLocation = this.textBoxDefaultLocation.Text;
            serial._fileDefaultFile = this.textDefaultFile.Text;

            serial._compCore = this.richTextBoxCompCore.Text;
            serial._compPrimitiveInit = this.richTextBoxCompVar.Text;
            serial._compPrimitiveFunctions = this.richTextBoxCompPrim.Text ;
            serial._compPrimitiveConstructor = this.richTextBoxCompConst.Text; 

            serial.Save("aurora_stettings.xml");
        }

        private void LoadSettings()
        {
            CApplicationSettings serial = new CApplicationSettings();
            serial.Load("aurora_stettings.xml");

            this.textBoxDefaultLocation.Text = serial._fileDefaultLocation;
            this.textDefaultFile.Text = serial._fileDefaultFile ;

            this.richTextBoxCompCore.Text = serial._compCore;
            this.richTextBoxCompVar.Text = serial._compPrimitiveInit;
            this.richTextBoxCompPrim.Text = serial._compPrimitiveFunctions ;

            this.richTextBoxCompConst.Text = serial._compPrimitiveConstructor ;

        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {

            
            this.DialogResult = DialogResult.Cancel;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CCompiler tCompiler = new CCompiler();


            // Look for primitive properties in the settings
            CApplicationSettings settings = new CApplicationSettings();
            settings.Load("aurora_stettings.xml");

            // Really need another pointer ???
            // CCellMatrix theMatrix = _cellMatrix;

            // Call the compiler and run the code;


            //serial._compCore = this.richTextBoxCompCore.Text;
            
            tCompiler._injection_definition = this.richTextBoxCompVar.Text;
            tCompiler._injection_constructor = this.richTextBoxCompConst.Text;
            tCompiler._injection_primitives = this.richTextBoxCompPrim.Text;

            string tScriptToTest = ""; // @richTextBoxScript.Text; // Main script to compile

            //tCompiler.PreCompileScript(tScriptToTest);
            //tCompiler.RunPrecompiledScript(theMatrix);


            // Get the feedback of the compilation/run;
            //richTextBoxFeedBack.Text = tCompiler._compilerOutput;
            //richTextBoxFeedBack.Text += tCompiler._runOutput;
            //textBoxPrevCellValue.Text = _cellMatrix._lastEvaluatedValue; //.ToString();

            //_lastFeedback = tCompiler._runOutput;


            if (tCompiler.CheckSyntax(tScriptToTest))
            {
                MessageBox.Show("Script is ok.",
                                    "P2 C# Compiler 1.07");

            }
            else
            {
                MessageBox.Show(tCompiler._compilerOutput,
                                    "P2 C# Compiler 1.07");

            }


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

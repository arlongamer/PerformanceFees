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
    public partial class FormDialogHeader : Form
    {

        CCellHeader _cellHeader;

        public FormDialogHeader(CCellHeader pCellHeader)
        {
            InitializeComponent();
            _cellHeader = pCellHeader;

            textBoxName.Text = _cellHeader._name  ;
            textBoxHeader.Text = _cellHeader._header;
            richTextBoxScriptHeader.Text = _cellHeader._script;
            richTextBoxHeaderDescr.Text = _cellHeader._description;

            if ( _cellHeader._type == ECellType.Input)
            {
                radioButtonInupt.Checked = true;
                radioButtonScript.Checked = false;
            }
            else
            {
                radioButtonInupt.Checked = false;
                radioButtonScript.Checked = true;
            }
            VerifyRadioButton();
        }

        private void Header_Enter(object sender, EventArgs e)
        {

        }


        //Apply modif
        private void button4_Click(object sender, EventArgs e)
        {

            _cellHeader._name = textBoxName.Text;
            _cellHeader._header = textBoxHeader.Text;
            _cellHeader._script = richTextBoxScriptHeader.Text;
            _cellHeader._description = richTextBoxHeaderDescr.Text;

            if (radioButtonInupt.Checked)
                _cellHeader._type = ECellType.Input;
            else
                _cellHeader._type = ECellType.Script;

            this.DialogResult = DialogResult.OK;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        // Test compile
        private void button5_Click_1(object sender, EventArgs e)
        {
            CCompiler tCompiler = new CCompiler();

            string tScriptToTest = richTextBoxScriptHeader.Text;

            if ( tCompiler.CheckSyntax(tScriptToTest) )
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

        private void radioButtonInupt_CheckedChanged(object sender, EventArgs e)
        {
            VerifyRadioButton();

        }
        private void radioButtonScript_CheckedChanged(object sender, EventArgs e)
        {
            VerifyRadioButton();
        }

        private void VerifyRadioButton()
        {
            if (radioButtonInupt.Checked)
                this.richTextBoxScriptHeader.BackColor = SystemColors.ControlLight;
            else
                this.richTextBoxScriptHeader.BackColor = SystemColors.Window;

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

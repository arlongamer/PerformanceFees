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
    public partial class FormCreationSheet : Form
    {

        public string _physicalName;
        public string _inheritedPhysicalName;
        public string _description;
        public bool _isInherited;

        public FormCreationSheet()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            _physicalName = this.textBoxName.Text + ".xml";
            _inheritedPhysicalName = "NOT_USED";
            _description = richTextBoxDescription.Text ;

            _isInherited = this.radioButtonInhert.Checked;
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

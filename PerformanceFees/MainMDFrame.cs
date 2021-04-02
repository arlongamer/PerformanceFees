using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerformanceFees
{
    public partial class MainMDFrame : Form
    {
        public MainMDFrame()
        {
            InitializeComponent();

            FormFeeSheet feeSheet = new FormFeeSheet("LUX CAPITAL C1.xml", true);
            feeSheet.MdiParent = this;
            feeSheet.Show();

        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proto1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 proto = new Form1();
            proto.MdiParent = this;
            proto.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
                FormCreationSheet newSheet = new FormCreationSheet();

                newSheet.ShowDialog();

                if (newSheet.DialogResult == DialogResult.OK)
                {
                    FormFeeSheet feeSheet = new FormFeeSheet(newSheet._physicalName,false);
                    //feeSheet._fileName = newSheet._physicalName;

                    feeSheet.MdiParent = this;
                    feeSheet.Show();

                }



        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFeeSheet feeSheet = new FormFeeSheet("LUX CAPITAL C1.xml", true);
            feeSheet.MdiParent = this;
            feeSheet.Show();

        }

        /// <summary>
        /// Mainmenu : save a child
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mdiChild = this.ActiveMdiChild;
            if (mdiChild is FormFeeSheet) ((FormFeeSheet)mdiChild).SaveSheet();
        }

        /// <summary>
        /// MainMenu SaveAs a child
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mdiChild = this.ActiveMdiChild;
            if (mdiChild is FormFeeSheet) ((FormFeeSheet)mdiChild).SaveAsSheet();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Text Files (*.xml)|*.xml|All Files (*.*)|*.*";
            dlg.Multiselect = false;
            dlg.InitialDirectory = @"C:\Users\fil\source\repos\PerformanceFees\PerformanceFees\bin\Debug\";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FormFeeSheet feeSheet = new FormFeeSheet(dlg.FileName, true);
                feeSheet.MdiParent = this;
                feeSheet.Show();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDialogOptions  formOptions= new FormDialogOptions();

            formOptions.ShowDialog();

            if (formOptions.DialogResult == DialogResult.OK)
            {

            }

        }


    }
}

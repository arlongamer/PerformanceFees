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
    public partial class FormFeeSheet : Form
    {
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        private int rowIndex = 0; // for column deletion
        private int colIndex = 0; // for column deletion

        public string _fileName;
               
        public CGridFeeSheet _gridFeeSheetLogic;


        public string SlaveCurrentCellValue
        {
            get => this.textBoxCurrentCellValue.Text;
            set => this.textBoxCurrentCellValue.Text = value;
        }

        public bool SlaveRadioButtonInput
        {
            get => this.radioButtonInput.Checked;
            set => this.radioButtonInput.Checked = value;
        }

        public bool SlaveRadioButtonScript
        {
            get => this.radioButtonScript.Checked;
            set => this.radioButtonScript.Checked = value;
        }

        public string SlaveMainStatus
        {
            get => this.textBoxMainStatus.Text;
            set => this.textBoxMainStatus.Text = value;
        }

        public string SlaveScript
        {
            get => this.richTextBoxScript.Text;
            set => this.richTextBoxScript.Text = value;
        }

        public string SlaveEvaluation
        {
            get => this.richTextBoxEvaluation.Text;
            set => this.richTextBoxEvaluation.Text = value;
        }

        public bool SlaveOverridde
        {
            get => this.checkBoxIsOver.Checked;
            set => this.checkBoxIsOver.Checked = value;
        }

        public ListView ListViewField
        {
            get => this.listViewField;
            set => this.listViewField = value;
        }

        public ListView ListViewMonitor
        {
            get => this.listViewMonitor;
            set => this.listViewMonitor = value;
        }



        public string HeadersDescription
        {
            get => this.richTextBoxHeaderDescription.Text;
            set => this.richTextBoxHeaderDescription.Text = value;
        }
        
        public string HeadersScript
        {
            get => this.richTextBoxHeaderScript.Text;
            set => this.richTextBoxHeaderScript.Text = value;
        }
        
        public FormFeeSheet()
        {
            InitializeComponent();
            InitializeOtherGui();
            _fileName = "LUX CAPITAL C1.xml";
            _gridFeeSheetLogic  = new CGridFeeSheet(this,  dataGridViewFee);

            this.Text = "Fees Sheet for " + _fileName;
        }
       
        public FormFeeSheet(string pFileName, bool pLoadGrid)
        {
            InitializeComponent();
            InitializeOtherGui();

            ShowHideDetail();

            _fileName = pFileName;
            this.Text = "Fees Sheet for " + _fileName;

            _gridFeeSheetLogic = new CGridFeeSheet(this, dataGridViewFee);

            // in the grid exists and need to be loaded
            if (pLoadGrid) _gridFeeSheetLogic.LoadDatagrid_Data();

        }

        public void InitializeOtherGui()
        {
            CApplicationSettings serial = new CApplicationSettings();
            serial.Load("aurora_stettings.xml");

            this.richTextBoxCompVar.Text = serial._compPrimitiveInit;
            this.richTextBoxCompPrim.Text = serial._compPrimitiveFunctions;

            this.richTextBoxCompConst.Text = serial._compPrimitiveConstructor;
        }
        // open new sheet
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gridFeeSheetLogic.LoadDatagrid_Data();
        }

        // Double click on a cell
        private void dataGridViewFee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _gridFeeSheetLogic.CellDoubleClick(sender, e);
        }

        // Refresh the grid
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gridFeeSheetLogic.RefreshGrid();
        }

        // Clear the grid
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gridFeeSheetLogic.ClearGrid();
        }

        // Double click on header bring the column customization window
        private void dataGridViewFee_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _gridFeeSheetLogic.ColumnHeaderMouseDoubleClick(sender, e);
        }

        // Add a column
        private void addColomnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gridFeeSheetLogic.AddHeaderColumn();
        }

        private void dataGridViewFee_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _gridFeeSheetLogic.CellValueChanged(sender, e);

        }

        private void dataGridViewFee_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }


        /// <summary>
        /// Save the Grid And expose to MDI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveSheet();
        }
        public void SaveSheet()
        {
            _gridFeeSheetLogic.SaveDatagrid_Data();
        }

        /// <summary>
        /// Save As from menu and publi Save As to expose to MDI Container
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsSheet();
        }
        public void SaveAsSheet()
        {
            _gridFeeSheetLogic.SaveAsDatagrid_Data();

        }


        private void dataGridViewFee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _gridFeeSheetLogic.CellClick(sender, e);
        }

        private void listViewField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewField.SelectedItems.Count > 0)
            {
                ListViewItem lvItem = this.listViewField.SelectedItems[0];
                string description = lvItem.SubItems[3].Text;
                string script    = lvItem.SubItems[4].Text;
                
                this.HeadersDescription = description;
                this.HeadersScript = script;

            }

        }

        private void tabPageHeaders_Click(object sender, EventArgs e)
        {

        }

        private void listViewField_DoubleClick(object sender, EventArgs e)
        {


            if (this.listViewField.SelectedItems.Count > 0)
            {
                ListViewItem lvItem = this.listViewField.SelectedItems[0];
                string colName= lvItem.SubItems[1].Text;

                CCellHeader tCellHeader = _gridFeeSheetLogic._theMatrix._cellHeaderVector.GetCellHeaderByColName(colName);

                using (var modal = new FormDialogHeader(tCellHeader))
                {
                    modal.ShowDialog();
                    if (modal.DialogResult == DialogResult.OK)
                    {
                    }
                }
            }

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void showCellDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHideDetail();
        }
        private void ShowHideDetail()
        {
            if (this.splitContainer1.SplitterDistance > 700)
            {
                this.splitContainer1.SplitterDistance = 650;
                this.tabControl1.Visible = true;

            }
            else
            {
                this.splitContainer1.SplitterDistance = 1675;
                this.tabControl1.Visible = false;
                // this.tabControl1.Height = 1;

            }
        }


        private void listViewMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewMonitor.SelectedItems.Count > 0)
            {
                ListViewItem lvItem = this.listViewMonitor.SelectedItems[0];
                string script = lvItem.SubItems[7].Text;

                this.richTextBoxMonitorScript.Text = script;

            }
        }

        private void dataGridViewFee_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dataGridViewFee.DoDragDrop(
                          dataGridViewFee.Rows[rowIndexFromMouseDown],
                          DragDropEffects.Move);
                }
            }
        }

        private void dataGridViewFee_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void dataGridViewFee_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = dataGridViewFee.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop = dataGridViewFee.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                dataGridViewFee.Rows.RemoveAt(rowIndexFromMouseDown);
                dataGridViewFee.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);

            }
        }

        private void dataGridViewFee_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

        }

        private void dataGridViewFee_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = dataGridViewFee.HitTest(e.X, e.Y).RowIndex;

            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(
                          new Point(
                            e.X - (dragSize.Width / 2),
                            e.Y - (dragSize.Height / 2)),
                      dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dataGridViewFee_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
        {
            /*
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "Column", e.Column);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "ColumnDisplayIndexChanged Event");
            */

            _gridFeeSheetLogic.ReorganizeHeader();

        }


        private void deleteColummToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string colName = this.dataGridViewFee.Columns[colIndex].Name;

            DialogResult result = MessageBox.Show("Ok to delete column " + colName,
                                    "Column deletion" + colName,
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                dataGridViewFee.Columns.Remove(this.dataGridViewFee.Columns[colIndex]);
                _gridFeeSheetLogic.RebuildMatrix();
            }
            //CCellHeader tCellHeader = _theMatrix._cellHeaderVector.GetCellHeaderByColName(colName);

            // Get the row index of the item the mouse is below. 
            // rowIndexOfItemUnderMouseToDrop = dataGridViewFee.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

        }

        private void dataGridViewFee_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //this.dataGridView1.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.colIndex = e.ColumnIndex;
                //this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[1];
                //this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                //contextMenuStrip1.Show(Cursor.Position);
            }
        }
    }
}

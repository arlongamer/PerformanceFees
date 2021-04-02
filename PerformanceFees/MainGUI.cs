using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedObjects;

namespace PerformanceFees
{
    
    public partial class Form1 : Form
    {
        //public CCellHeaderVector _cellHeaderVector;
        public CCellMatrix _theMatrix; 
       
        public Form1()
        {

            InitializeComponent();
            _theMatrix = new CCellMatrix();
        //_cellHeaderVector = new CCellHeaderVector();

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }



        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridViewFees.Rows.Clear();
        }

        // test script
        private void buttonCheckSyntax_Click(object sender, EventArgs e)
        {
            CCompiler tCompiler = new CCompiler();

            string tScriptToTest = @richTextBoxScript.Text; ;
            
            tCompiler.CheckSyntax(tScriptToTest);

            richTextBoxCompilerOutput.Text = tCompiler._compilerOutput;

        }

        // precompile and run
        private void button1_Click_1(object sender, EventArgs e)
        {
            //CCompiler tCompiler = new CCompiler();
                       
            //string tScriptToTest = @richTextBoxScript.Text; ;

            //CCellMatrix theMatrix = new CCellMatrix(); ;

            //CCellVector theCellVertor = new CCellVector();
            //CCellVector theCellVertor2 = new CCellVector();

            /*
            theCellVertor.Add("c1", new CCell(0, 1000));
            theCellVertor.Add("c2", new CCell(0, 500));
            theCellVertor.Add("c3", new CCell(0, 1500));
            theCellVertor.Add("c4", new CCell(1) );

            theCellVertor2.Add("c1", new CCell(0, 1111));
            theCellVertor2.Add("c2", new CCell(0, 555));
            theCellVertor2.Add("c3", new CCell(0, 999));
            theCellVertor2.Add("c4", new CCell(1));
            */

            //theCellVertor.Add("c1", new CCell(1000,0));
            //theCellVertor.Add("c2", new CCell(1001,0));
            //theCellVertor.Add("c3", new CCell(1002,0));
            //theCellVertor.Add("c4", new CCell(1003,0));

            //theCellVertor2.Add("c1", new CCell(2000,1));
            //theCellVertor2.Add("c2", new CCell(2001,1));
            //theCellVertor2.Add("c3", new CCell(2002,1));
            //theCellVertor2.Add("c4", new CCell(2003,1));


            //theMatrix.AddVector(2, theCellVertor);
            //theMatrix.AddVector(1, theCellVertor2);
            
            //tCompiler.PreCompileScript(tScriptToTest);
            //tCompiler.RunPrecompiledScript(theMatrix);
                       
            //richTextBoxCompilerOutput.Text = tCompiler._compilerOutput;
            //richTextBoxUserOutputs.Text = tCompiler._runOutput;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewFees_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int colIndex = e.ColumnIndex;
        }


        // add cols dynagrids
        private void buttonAddField_Click(object sender, EventArgs e)
        {
            //this.dataGridViewDyn.Columns.Add("newColumnName", "Column Name in Text");

            this.dataGridViewDyn.Rows.Clear();
            this.dataGridViewDyn.Columns.Clear();

            CCellHeader newCellHeader1 = new CCellHeader(1, "col1", "header1", "Descr1", "script1");
            CCellHeader newCellHeader2 = new CCellHeader(2, "col2", "header2", "Descr2", "script2");
            CCellHeader newCellHeader3 = new CCellHeader(3, "col3", "header3", "Descr3", "script3");
            CCellHeader newCellHeader4 = new CCellHeader(4, "col4", "header4", "Descr4", "script4");
            CCellHeader newCellHeader5 = new CCellHeader(5, "col5", "header5", "Descr5", "script5");


            CCellHeaderVector _cellHeaderVector = new CCellHeaderVector();

            _cellHeaderVector.AddCellHeader(newCellHeader1);
            _cellHeaderVector.AddCellHeader(newCellHeader2);
            _cellHeaderVector.AddCellHeader(newCellHeader3);
            _cellHeaderVector.AddCellHeader(newCellHeader4);
            _cellHeaderVector.AddCellHeader(newCellHeader5);

            AddCellToGrid(dataGridViewDyn, _cellHeaderVector);

        }

        private void AddCellToGrid(DataGridView pGrid, CCellHeaderVector pCellHeaderVector)
        {

            pGrid.Columns.Clear();

            foreach (CCellHeader bCellHeader in pCellHeaderVector._cellHeaders)
            {
                
                string tColName = bCellHeader._name;
                string tColHeader = bCellHeader._header;

                pGrid.Columns.Add(tColName, tColHeader);

            }

        }

        private void AddDataToGrid(DataGridView pGrid, CCellMatrix pTheMatrix)
        {
            int t_row = 0;

            pGrid.Rows.Clear();
            pGrid.Columns.Clear();

            AddCellToGrid(pGrid, pTheMatrix._cellHeaderVector);


            foreach ( var kv_vector in pTheMatrix._Vectors )
            {
                var kv_vector_key = kv_vector.Key;
                var kv_vector_value = kv_vector.Value;
                
                int index = pGrid.Rows.Add();

                int t_col = 0;
                foreach (var kv_cell in kv_vector_value._Cells)
                {
                    CCell theCell = kv_cell.Value;

                    pGrid.Rows[t_row].Cells[t_col].Value = theCell._value ;
                    pGrid.Rows[t_row].Cells[t_col].Tag= theCell;

                    t_col++;
                }

                t_row++;
            }
        }



            // Clik on header
        private void dataGridViewDyn_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int colIndex = e.ColumnIndex;

            var col = dataGridViewDyn.Columns[colIndex];

            string colName = col.Name;

            CCellHeader tCellHeader = _theMatrix._cellHeaderVector.GetCellHeaderByColName(colName);

            AddDetailToDialogHeader(tCellHeader);

        }
        
        private void AddDetailToDialogHeader(CCellHeader pCellHeader)
        {
            if ( pCellHeader is object )
            {
                textBoxName.Text = pCellHeader._name;
                textBoxHeader.Text = pCellHeader._header;
                richTextBoxScriptHeader.Text = pCellHeader._script;
                richTextBoxHeaderDescr.Text = pCellHeader._description;


            }

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CCellHeader tCellHeader = _theMatrix._cellHeaderVector.GetCellHeaderByColName(textBoxName.Text);
                                   
            tCellHeader._header = textBoxHeader.Text ;
            tCellHeader._script = richTextBoxScriptHeader.Text ;
            tCellHeader._description = richTextBoxHeaderDescr.Text ;

        }

        // add a column
        private void buttonAddColumn_Click(object sender, EventArgs e)
        {
            CCellHeader tCellHeader = new CCellHeader();

            using (var modal = new FormDialogHeader(tCellHeader))
            {
                modal.ShowDialog();
                if (modal.DialogResult == DialogResult.OK)
                {
                    _theMatrix._cellHeaderVector.AddCellHeader(tCellHeader);

                    AddCellToGrid(dataGridViewDyn, _theMatrix._cellHeaderVector);

                }
                else if (modal.DialogResult == DialogResult.Cancel)
                {
                }
            }
        }


        // open again the header dialog 
        private void dataGridViewDyn_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int colIndex = e.ColumnIndex;

            var col = dataGridViewDyn.Columns[colIndex];

            string colName = col.Name;

            CCellHeader tCellHeader = _theMatrix._cellHeaderVector.GetCellHeaderByColName(colName);

            using (var modal = new FormDialogHeader(tCellHeader))
            {
                modal.ShowDialog();
                if (modal.DialogResult == DialogResult.OK)
                {
                    col.Name = tCellHeader._name;
                    col.HeaderText = tCellHeader._header;

                }
            }
        }

        private void buttonSaveStructure_Click(object sender, EventArgs e)
        {
            SaveDatagrid_Header("testperf.xml");
        }

        private void buttonLoadStructure_Click(object sender, EventArgs e)
        {
            LoadDatagrid_Header(dataGridViewDyn, "testperf.xml");
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            LoadDatagrid_Data(this.dataGridViewDyn, "LUX CAPITAL C1.xml");
        }

        private void buttonSaveDataGrid_Click(object sender, EventArgs e)
        {
            SaveDatagrid_Data(this.dataGridViewDyn, "LUX CAPITAL C1.xml");
        }

        private void LoadDatagrid_Header(DataGridView pDataGrid, string pFileName)
        {
            _theMatrix._cellHeaderVector = CCellHeaderVector.Load(pFileName);

            pDataGrid.Columns.Clear();

            AddCellToGrid(pDataGrid, _theMatrix._cellHeaderVector);

        }

        private void SaveDatagrid_Header(string pFileName)
        {
            _theMatrix._cellHeaderVector.Save(pFileName);

        }

        private void LoadDatagrid_Data(DataGridView pDataGrid, string pFileName)
        {
            CCellMatrixIO matrixIO = CCellMatrixIO.Load(pFileName);

            //CCellMatrix theMatrix = new CCellMatrix();
            
            this._theMatrix = new CCellMatrix();

            _theMatrix._cellHeaderVector = matrixIO._cellHeaderVector;

            foreach (CCellMatrixElementIO v in matrixIO._matrixIO)
            {
                int t_keyID = v._keyID;
                string t_keyName = v._keyName;
                CCell t_cell = v._cell;

                CCellVector currentCellVector;

                // 1. recherche si la key n'est pas déja présente dans le dico
                if (_theMatrix._Vectors.ContainsKey(t_keyID))
                {
                    // si présente, on prend comme référence  le cellvector pointé par la clé
                    currentCellVector = _theMatrix._Vectors[t_keyID];

                }
                else
                {
                    //    sinon on crée ce cellvector et on l'ajoute au dico
                    currentCellVector = new CCellVector();
                    _theMatrix._Vectors.Add(t_keyID, currentCellVector);
                }

                // add the key and the cell to the cell vector 
                currentCellVector.Add(t_keyName, t_cell);

            }

            AddDataToGrid(pDataGrid, _theMatrix);
        }

        private void SaveDatagrid_Data(DataGridView pDataGrid, string pFileName)
        {   
            CCellMatrix theMatrix = BuildMatrixFromGrid(pDataGrid);
            CCellHeaderVector tCellHeaderVector = _theMatrix._cellHeaderVector;
            
            _theMatrix = theMatrix;
            _theMatrix._cellHeaderVector = tCellHeaderVector;


            CCellMatrixIO matrixIO = new CCellMatrixIO();
            matrixIO.BuildMatrixIO(_theMatrix);
            matrixIO.Save(pFileName);
        } 

        
        private CCellMatrix BuildMatrixFromGrid(DataGridView pDataGrid)
        {
            CCellMatrix theMatrix = new CCellMatrix();
            CCellVector theCellVector;

            int i_row = 0;
            int i_col = 0;

            foreach (DataGridViewRow row in pDataGrid.Rows)
            {
                theCellVector = new CCellVector();
                //theMatrix.AddVector(i_row, theCellVector);

                i_col = 0;

                bool last_empty_line = true;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    string colName = _theMatrix._cellHeaderVector._cellHeaders[i_col]._name;

                    // check if the last row is completely empty in order to insert the vector
                    if (!(cell.Value is null))
                    {
                        last_empty_line = false;
                    }

                    double cell_value = Convert.ToDouble(cell.Value);

                    //CCell cellToInsert = new CCell(0, cell_value);
                    CCell cellToInsert = new CCell(cell_value.ToString(), i_row);

                    var x = _theMatrix._cellHeaderVector._cellHeaders[i_col];
                    cellToInsert._cellHeader = _theMatrix._cellHeaderVector._cellHeaders[i_col];

                    theCellVector.Add(colName, cellToInsert);

                    i_col++;
                }

                if (!last_empty_line) theMatrix.AddVector(i_row, theCellVector);


                i_row++;
            }

            return theMatrix;

        }


        private void buttonLoadDataGrig_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewFees_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.Value is CCell)
            {
                e.Value = ((CCell)e.Value)._value;
            }
       

        }

        private void buttonResetGrif_Click(object sender, EventArgs e)
        {
            dataGridViewDyn.Columns.Clear();
        }

        private void dataGridViewDyn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var val = dataGridViewDyn.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var tag = dataGridViewDyn.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag;

                if (tag is CCell)
                {

                    // CCellHeader tCellHeader = new CCellHeader();

                    CCellMatrix theMatrix = BuildMatrixFromGrid(dataGridViewDyn);


                    using (var modal = new FormDialogCCel((CCell)tag, theMatrix))
                    {
                        modal.ShowDialog();
                        if (modal.DialogResult == DialogResult.OK)
                        {
                            // _cellHeaderVector.AddCellHeader(tCellHeader);

                            // AddCellToGrid(dataGridViewDyn, _cellHeaderVector);

                            // refresh grid
                            this.dataGridViewDyn.Columns.Clear();
                            AddCellToGrid(this.dataGridViewDyn, _theMatrix._cellHeaderVector);
                            AddDataToGrid(this.dataGridViewDyn, _theMatrix);

                        }
                        else if (modal.DialogResult == DialogResult.Cancel)
                        {
                        }
                    }

                }

            }
        }

        private void buttonRefreshGrid_Click(object sender, EventArgs e)
        {
            this.dataGridViewDyn.Columns.Clear();
            AddCellToGrid(this.dataGridViewDyn, _theMatrix._cellHeaderVector);
            AddDataToGrid(this.dataGridViewDyn, _theMatrix);
        }

    }
}

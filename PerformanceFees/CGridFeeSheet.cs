using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SharedObjects;

namespace PerformanceFees
{
    public class CGridFeeSheet
    {
        public DataGridView _theDataGrid;
        public CCellMatrix _theMatrix;
        public string _fileName;
        FormFeeSheet _parentFormSheet;

        public CGridFeeSheet( FormFeeSheet pParentFormSheet , DataGridView pTheDataGrid)
        {
            _parentFormSheet = pParentFormSheet;
            _fileName = pParentFormSheet._fileName;
            _theDataGrid = pTheDataGrid;
            _theMatrix = new CCellMatrix();
        }

        // Load XML matrice xxxIo file and build a new matrix
        public void LoadDatagrid_Data()
        {
            // xxxIO allow to easily serialise/deserialise to xml, because no dictionary
            CCellMatrixIO matrixIO = CCellMatrixIO.Load(_fileName);

            // Create the new matrix
            _theMatrix = new CCellMatrix();

            // take back from xxxIO the Cell Columns header
            _theMatrix._cellHeaderVector = matrixIO._cellHeaderVector;

            // loop thru IO
            foreach (CCellMatrixElementIO v in matrixIO._matrixIO)
            {
                int t_keyID = v._keyID;
                string t_keyName = v._keyName;
                CCell t_cell = v._cell;

                CCellVector currentCellVector;

                // 1. determine wether the key is in the dico or not
                if (_theMatrix._Vectors.ContainsKey(t_keyID))
                {
                    // key is in: retrieve the pointe cellvector pointé par la clé
                    currentCellVector = _theMatrix._Vectors[t_keyID];
                }
                else
                {
                    // key not in, create a new cellvector and add it to the dico
                    currentCellVector = new CCellVector();
                    _theMatrix._Vectors.Add(t_keyID, currentCellVector);
                }

                // add the key and the cell to the cell vector 
                currentCellVector.Add(t_keyName, t_cell);

            }

            AddDataToGrid();
        }

        // Add the matrix data to the grid
        public void AddDataToGrid()
        {
            int t_row = 0;

            // Clear the grid
            ClearGrid();

            // Add the columns header
            AddHeaderToGrid();

            foreach (var kv_vector in _theMatrix._Vectors)
            {
                var kv_vector_key = kv_vector.Key;
                var kv_vector_value = kv_vector.Value;

                int index = _theDataGrid.Rows.Add();

                int t_col = 0;
                foreach (var kv_cell in kv_vector_value._Cells)
                {
                    CCell theCell = kv_cell.Value;

                    _theDataGrid.Rows[t_row].Cells[t_col].Value = theCell._value;
                    _theDataGrid.Rows[t_row].Cells[t_col].Tag = theCell;

                    t_col++;
                }

                t_row++;
            }
        }

        // Add header of colums to an empty grid
        public void AddHeaderToGrid()
        {
            ClearGrid();
            int iCount = 0;
            foreach (CCellHeader bCellHeader in _theMatrix.ColumnsHeader)
            {
                string tColName = bCellHeader._name;
                string tColHeader = bCellHeader._header;


                //DataGridViewColumn newColumn; //= new DataGridViewColumn();

                //newColumn.Name = tColName;
                // newColumn.HeaderText = tColHeader;

                _theDataGrid.Columns.Add(tColName, tColHeader);
                // _theDataGrid.Columns.Add(newColumn);

                DataGridViewColumn newColumn = _theDataGrid.Columns[tColName];

                if (bCellHeader._type == ECellType.Input)
                    newColumn.DefaultCellStyle.BackColor = Color.Bisque;
                else
                    newColumn.DefaultCellStyle.BackColor = Color.Beige;


                if (iCount++ > 0)
                {
                    newColumn = _theDataGrid.Columns[tColName];
                    newColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }

        }


        public CCellMatrix BuildMatrixFromGrid()
        {

            // back the headerVector
            CCellHeaderVector tCellHeaderVector = _theMatrix._cellHeaderVector;

            // back the new matrix
            CCellMatrix theMatrix = new CCellMatrix();

            // back the headerVector
            theMatrix._cellHeaderVector = tCellHeaderVector;
            
            CCellVector theCellVector;


            int i_row = 0;
            int i_col = 0;

            foreach (DataGridViewRow row in _theDataGrid.Rows)
            {
                theCellVector = new CCellVector();

                i_col = 0;

                bool last_empty_line = true;

                foreach (DataGridViewCell gridCell in row.Cells)
                {
                    string colName = _theMatrix.ColumnsHeader[i_col]._name;

                    // check if the last row is completely empty in order to insert the vector
                    // see also comment after the foreach loop
                    if (!(gridCell.Value is null)) last_empty_line = false;

                    CCell cellToInsert;

                    if (gridCell.Tag is null)
                    {
                        string cell_value = (string)gridCell.Value;
                        cellToInsert = new CCell(cell_value, i_row);

                        cellToInsert._cellHeader = _theMatrix.ColumnsHeader[i_col];
                    }
                    else cellToInsert = (CCell)gridCell.Tag;

                    theCellVector.Add(colName, cellToInsert);

                    i_col++;
                }

                // in the row is not empty it is added
                if (!last_empty_line) theMatrix.AddVector(i_row, theCellVector);


                i_row++;
            }

            return theMatrix;

        }

        public void RefreshGrid()
        {
            ClearGrid();
            AddHeaderToGrid();
            AddDataToGrid();
        }

        public void ClearGrid()
        {
            _theDataGrid.Rows.Clear();
            _theDataGrid.Columns.Clear();
        }

        // Save the data from the grid to a file
        public void SaveDatagrid_Data()
        {
            SaveDatagrid_ToFile(_fileName);
        }

        public void SaveAsDatagrid_Data()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveDatagrid_ToFile(saveFileDialog1.FileName);
            }

            
        }

        //private void SaveDatagrid_ToFile(string pFilename)
        //{
        //    _parentFormSheet.Text = "Fees Sheet for " + pFilename;

        //    // back the headerVector
        //    CCellHeaderVector tCellHeaderVector = _theMatrix._cellHeaderVector;

        //    // back the matrix description
        //    string _matrixPhysicalName = _theMatrix._matrixPhysicalName;
        //    string _matrixInheritedPhysicalName = _theMatrix._matrixInheritedPhysicalName;
        //    string _matrixDescription = _theMatrix._matrixDescription;
        //    bool _isInherited = _theMatrix._isInherited;

        //    // Build the new matrix from the grid
        //    _theMatrix = BuildMatrixFromGrid();

        //    // set back the headerVector
        //    _theMatrix._cellHeaderVector = tCellHeaderVector;

        //    // set back the matrix description
        //    _theMatrix._matrixPhysicalName = pFilename; // _matrixPhysicalName;
        //    _theMatrix._matrixInheritedPhysicalName = _matrixInheritedPhysicalName;
        //    _theMatrix._matrixDescription = _matrixDescription;
        //    _theMatrix._isInherited = _isInherited;

        //    // Persistance of the data
        //    CCellMatrixIO matrixIO = new CCellMatrixIO();
        //    matrixIO.BuildMatrixIO(_theMatrix);
        //    matrixIO.Save(pFilename);

        //}
        private void SaveDatagrid_ToFile(string pFilename)
        {
            _parentFormSheet.Text = "Fees Sheet for " + pFilename;

            RebuildMatrix();
                // set back the matrix description
            _theMatrix._matrixPhysicalName = pFilename; // _matrixPhysicalName;

            // Persistance of the data
            CCellMatrixIO matrixIO = new CCellMatrixIO();
            matrixIO.BuildMatrixIO(_theMatrix);
            matrixIO.Save(pFilename);

        }
        public void RebuildMatrix()
        {

            // back the headerVector
            CCellHeaderVector tCellHeaderVector = _theMatrix._cellHeaderVector;

            // back the matrix description
            string _matrixPhysicalName = _theMatrix._matrixPhysicalName;
            string _matrixInheritedPhysicalName = _theMatrix._matrixInheritedPhysicalName;
            string _matrixDescription = _theMatrix._matrixDescription;
            bool _isInherited = _theMatrix._isInherited;

            // Build the new matrix from the grid
            _theMatrix = BuildMatrixFromGrid();

            // set back the headerVector
            _theMatrix._cellHeaderVector = tCellHeaderVector;

            // set back the matrix description
            _theMatrix._matrixPhysicalName = _matrixPhysicalName;
            _theMatrix._matrixInheritedPhysicalName = _matrixInheritedPhysicalName;
            _theMatrix._matrixDescription = _matrixDescription;
            _theMatrix._isInherited = _isInherited;

        }


        // Add a column
        public void AddHeaderColumn()
        {
            CCellHeader tCellHeader = new CCellHeader();

            using (var modal = new FormDialogHeader(tCellHeader))
            {
                modal.ShowDialog();
                if (modal.DialogResult == DialogResult.OK)
                {
                    _theMatrix._cellHeaderVector.AddCellHeader(tCellHeader);
                    AddHeaderToGrid();
                    RefreshGrid();
                }
            }

        }

        // Event relay - double click on heaser
        // Double click on header bring the column customization window
        public void ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int colIndex = e.ColumnIndex;

            var col = _theDataGrid.Columns[colIndex];

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

        // Order has changed, need to be reflected in the header struture
        public void ReorganizeHeader()
        {

            int i = 0;
            foreach( DataGridViewColumn col in _theDataGrid.Columns)
            {
                string colName =  col.Name;
                string colNameIndex = _theDataGrid.Columns[i++].Name;
            }

//            CCellHeaderVector tCurrentCellHeaderVector = _theMatrix._cellHeaderVector;
            CCellHeaderVector tCellHeaderVector = new CCellHeaderVector();

            i = 0;
            foreach (DataGridViewColumn col in _theDataGrid.Columns.OfType<DataGridViewColumn>().OrderBy(x => x.DisplayIndex))
            {
                string colName = col.Name;
                string colNameIndex = _theDataGrid.Columns[i++].Name;

                CCellHeader tCellHeader = _theMatrix._cellHeaderVector.GetCellHeaderByColName(colName);

                tCellHeaderVector.AddCellHeader(tCellHeader);

            }

            // replace witht the new one
            _theMatrix._cellHeaderVector = tCellHeaderVector;

        }


        // Event relay - double click on a cell
        public void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var val = _theDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var tag = _theDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag;

                if (tag is CCell)
                {
                    CCellMatrix theMatrix = BuildMatrixFromGrid();

                    CCell theCurrentCell = (CCell)tag;

                    using (var modal = new FormDialogCCel(theCurrentCell, theMatrix))
                    {
                        modal.ShowDialog();
                        if (modal.DialogResult == DialogResult.OK)
                        {
                            // refresh grid
                            ClearGrid();
                            AddHeaderToGrid();
                            AddDataToGrid();
                        }
                    }

                }

            }
        }


        // Event relay - click on a cell
        public void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var val = _theDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var tag = _theDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag;

                if (tag is CCell)  RefreshSlave((CCell ) tag);

            }
        }

            // Event relay - Cell value was changed
        public void CellValueChangedOld(object sender, DataGridViewCellEventArgs e)
        {
         
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var val = _theDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                var tag = _theDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag;

                if (tag is CCell)
                {
                    CCell theCurrentCell = (CCell)tag;

                    theCurrentCell._value = (string) val;

                }

            }

        }

        public void CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var val = GetGridValue(e.RowIndex,e.ColumnIndex);

                CCell theCurrentCell = GetGridCell(e.RowIndex, e.ColumnIndex);

                if (!(theCurrentCell is null))
                {
                    // theCurrentCell._value = Convert.ToDouble(val);

                    theCurrentCell._value =  GetDouble(val,-99999.99999).ToString();

                }

            }

        }

        public double GetDouble(string value, double defaultValue)
        {
            double result;

            // Try parsing in the current culture
            if (!double.TryParse(value.Replace(',', '.'), System.Globalization.NumberStyles.Any, CultureInfo.CurrentCulture, out result)) 
            {
                result = defaultValue;
            }
            return result;
        }


        // Event relay - Cell value was changed
        public string  GetGridValue(int pRow, int pCol)
        {
            string returnValue = "";

            try
            {
                var gridvalue = _theDataGrid.Rows[pRow].Cells[pCol].Value;

                if (gridvalue is string)
                {
                    returnValue = (string)gridvalue;
                }
                else
                    returnValue = gridvalue.ToString();
            }
            catch (Exception) { returnValue = ""; }
            return returnValue;
        }

        public CCell GetGridCell(int pRow, int pCol)
        {
            CCell theCurrentCell;
            theCurrentCell = null;

            var tag = _theDataGrid.Rows[pRow].Cells[pCol].Tag;

            if (tag is CCell)
            {
                theCurrentCell = (CCell)tag;
            }

            return theCurrentCell;

        }

        private void RefreshSlave(CCell pCell)
        {
            RefreshSlaveCellDetails(pCell);
            RefreshSlaveHeaders(pCell, this._parentFormSheet.ListViewField);
            RefreshSlavePrimitives(pCell);
            RefreshSlaveHistoric(pCell);

            RefreshSlaveMonitors(pCell, this._parentFormSheet.ListViewMonitor);
        }

        private void RefreshSlaveCellDetails(CCell pCell)
        {
            // 1. value
            this._parentFormSheet.SlaveCurrentCellValue = pCell._value;

            // 2. input/script
            if (pCell._type == ECellType.Input)
            {
                this._parentFormSheet.SlaveRadioButtonInput = true;
                this._parentFormSheet.SlaveRadioButtonScript = false;
            }
            else
            {
                this._parentFormSheet.SlaveRadioButtonInput = false;
                this._parentFormSheet.SlaveRadioButtonScript = true;
            }

            //.3 Cell status
            switch (pCell._status)
            {
                case ECellStatus.Clean:
                    this._parentFormSheet.SlaveMainStatus = "Clean";
                    break;
                case ECellStatus.Dirty:
                    this._parentFormSheet.SlaveMainStatus = "Dirty";
                    break;
                case ECellStatus.Error:
                    this._parentFormSheet.SlaveMainStatus = "Error";
                    break;
                case ECellStatus.N_A:
                    this._parentFormSheet.SlaveMainStatus = "N_A";
                    break;
                default:
                    this._parentFormSheet.SlaveMainStatus = "Other";
                    break;
            }

            //4. Script
            string tScript = "";
            try  // This is the Script at header level
            {
                tScript = (_theMatrix._cellHeaderVector._cellHeaders.First(s => s._name == pCell._cellHeader._name))._script;
            }
            catch (Exception) { tScript = ""; } // Much better than linq.FirstOrDefault: in case of nothing found then empty script
            this._parentFormSheet.SlaveScript = tScript;

            //5. Evaluation
            this._parentFormSheet.SlaveEvaluation = pCell._calculationFeedback;

            //6. Overidde
            this._parentFormSheet.SlaveOverridde = pCell._overRidden;


        }

        private void RefreshSlaveHeaders(CCell pCell,  ListView pListView)
        {
            pListView.Clear();
            pListView.View = View.Details;
            pListView.GridLines = true;

            pListView.Columns.Add("Header");
            pListView.Columns.Add("Name");
            pListView.Columns.Add("Type");
            pListView.Columns.Add("Description");
            pListView.Columns.Add("Script");

            pListView.Columns[0].Width = 80;
            pListView.Columns[1].Width = 100;
            pListView.Columns[2].Width = 60;
            pListView.Columns[3].Width = 200;
            pListView.Columns[4].Width = 200;

            string tHeader = "";
            string tName = "";
            string tType = "";
            string tScript= "";
            string tDescriptiom = "";
            
            foreach (var tColHeader in _theMatrix.ColumnsHeader)
            {
                tHeader = tColHeader._header;
                tName = tColHeader._name;
                tType = (tColHeader._type == ECellType.Input) ? "Input" : "Script";
                tDescriptiom = tColHeader._description;
                tScript = tColHeader._script;

                pListView.Items.Add(new ListViewItem(new string[] { tHeader, tName,tType,tDescriptiom,tScript}));

            }
        }

        private void RefreshSlaveMonitors(CCell pCell, ListView pListView)
        {
            pListView.Clear();
            pListView.View = View.Details;
            pListView.GridLines = true;

            pListView.Columns.Add("Field");
            pListView.Columns.Add("Status");
            pListView.Columns.Add("Cycle");
            pListView.Columns.Add("Type");
            pListView.Columns.Add("Value");

            pListView.Columns.Add("PreValue");
            pListView.Columns.Add("NewValue");
            pListView.Columns.Add("Script");

            int colId = 0;
            pListView.Columns[colId++].Width = 80;
            pListView.Columns[colId++].Width = 60;
            pListView.Columns[colId++].Width = 30;
            pListView.Columns[colId++].Width = 60;
            pListView.Columns[colId++].Width = 60;
            
            pListView.Columns[colId++].Width = 60;
            pListView.Columns[colId++].Width = 60;
            pListView.Columns[colId++].Width = 200;

            int id_vecteur = pCell._idCellVector;
            int id_vecteurPrev = pCell._idCellVector - 1;

            if (id_vecteurPrev < 0) id_vecteurPrev = 0;

            CCellVector currentCellVector = _theMatrix._Vectors[id_vecteur];
            CCellVector previousCellVector = _theMatrix._Vectors[id_vecteurPrev];

            _theMatrix._idCurrentVector = id_vecteur;
            _theMatrix._idPreviousVector = id_vecteurPrev;
            _theMatrix._currentVector = currentCellVector;
            _theMatrix._previousVector = previousCellVector;


            foreach (var c_cell in currentCellVector._Cells)
            {
                string nomChamp = c_cell.Key;
                
                string curValeur = "";
                if (!(c_cell.Value._value is null)) curValeur = c_cell.Value._value.ToString();

                string prevValeur;
                string script ="";
                string cellType = "?";
                string cellStatus = "?";
                string cycle = c_cell.Value._calculationPass.ToString();

                if (id_vecteurPrev == id_vecteur)
                    prevValeur = "N/A";
                else
                    prevValeur = previousCellVector._Cells[nomChamp]._value.ToString();

                try  // This is the Script at header level
                {
                    var ceelH = _theMatrix._cellHeaderVector._cellHeaders;

                    script =  (ceelH.First(s => s._name == nomChamp))._script;
                    cellType = ((ceelH.First(s => s._name == nomChamp))._type == ECellType.Input) ? "Input" : "Script";

                    
                    switch (c_cell.Value._status)
                    {
                        case ECellStatus.Clean:
                            cellStatus = "Clean";
                            break;
                        case ECellStatus.Dirty:
                            cellStatus = "Dirty";
                            break;
                        case ECellStatus.Error:
                            cellStatus = "Error";
                            break;
                        case ECellStatus.N_A:
                            cellStatus = "N_A";
                            break;
                        default:
                            cellStatus = "Other";
                            break;
                    }

                }
                catch (Exception) { script = ""; } // Much better than linq.FirstOrDefault: in case of nothing found then empty script



                pListView.Items.Add(new ListViewItem(new string[] { nomChamp, cellStatus, cycle , cellType, curValeur, prevValeur,"", script }));

            }


        }
        /*
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

        }        */

        private void RefreshSlavePrimitives(CCell pCell)
        {
        }
        
        private void RefreshSlaveHistoric(CCell pCell)
        {
        }




    }
}

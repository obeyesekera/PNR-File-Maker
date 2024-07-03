using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ExcelApp = Microsoft.Office.Interop.Excel;


namespace PNR_File_Maker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Create COM Objects.
        ExcelApp.Application excelApp = new ExcelApp.Application();
        DataRow myNewRow;
        DataTable myTable;

        private DataTable dtExcel;

        private NameValueCollection applicationSettings = ConfigurationManager.GetSection("DefaultFlight") as NameValueCollection;


        private void frmMain_Load(object sender, EventArgs e)
        {
            if (excelApp == null)
            {
                MessageBox.Show("Excel is not installed!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            if (applicationSettings.Count == 0)
            {
                MessageBox.Show("Application Settings are not defined", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (var key in applicationSettings.AllKeys)
                {
                    TextBox txtBox = this.Controls["txt" + key] as TextBox;
                    txtBox.Text = applicationSettings[key];
                    
                }
            }

            dtArrivalTime.CustomFormat = "hh:mm:ss";
            dtArrivalTime.Format = DateTimePickerFormat.Custom;
            txtArrivalDate.Text = dtArrivalTime.Value.ToString("yyyy-MM-dd");
            dtDepartureTime.CustomFormat = "hh:mm:ss";
            dtDepartureTime.Format = DateTimePickerFormat.Custom;
            txtDepartureDate.Text = dtDepartureTime.Value.ToString("yyyy-MM-dd");

            dataGridView.MultiSelect = false;
            txtNoofPassengers.ReadOnly = true;

            updatePaxCount();
        }

        private void updateConfig()
        {

            if (applicationSettings.Count == 0)
            {
                MessageBox.Show("Application Settings are not defined", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (var key in applicationSettings.AllKeys)
                {
                    TextBox txtBox = this.Controls["txt" + key] as TextBox;

                    applicationSettings.Remove(key);
                    applicationSettings.Add(key, txtBox.Text);

                    

                   

                }
                ConfigurationManager.RefreshSection("DefaultFlight");


            }


            

        }

        private static void SetSetting(string key, string value)
        {
            
        }

        private DataTable ReadExcel(string fileName)
        {
            //Open Excel file
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(fileName);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int rows = excelRange.Rows.Count;
            int cols = excelRange.Columns.Count;

            //Set DataTable Name and Columns Name
            myTable = new DataTable(excelSheet.Name);

            //first row using for heading
            for (int i = 1; i <= cols; i++)
            {
                myTable.Columns.Add(excelRange.Cells[1, i].Value2.ToString(), typeof(string));
            }

            if (rows > 1)
            {
                //first row using for heading, start second row for data
                for (int r = 2; r <= rows; r++)
                {
                    myNewRow = myTable.NewRow();
                    for (int c = 1; c <= cols; c++)
                    {
                        string cellVal = "";

                        if (myTable.Columns[c - 1].ColumnName.Contains("Date"))
                        {
                            DateTime conv = DateTime.FromOADate(excelRange.Cells[r, c].Value2);
                            cellVal = conv.ToShortDateString();
                        }
                        else
                        {
                            cellVal = Convert.ToString(excelRange.Cells[r, c].Value2);
                        }
                        myNewRow[c - 1] = cellVal;


                    }
                    myTable.Rows.Add(myNewRow);
                }
            }
            else
            {
                DataRow newrow = myTable.NewRow();

                for (int i = 0; i < cols; i++)
                {
                    newrow[i] = "";
                }

                myTable.Rows.Add(newrow);
            }

            return myTable;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file
            file.CheckFileExists = true;
            file.Title = "Open Excel Files";
            file.Filter = "Excel files (*.xls)|*.xls|Excel XML files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            file.FilterIndex = 3;

            if (file.ShowDialog() == DialogResult.OK) //if there is a file chosen by the user
            {
                string fileExt = Path.GetExtension(file.FileName); //get the file extension

                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        dtExcel = ReadExcel(file.FileName); //read excel file
                        dataGridView.Visible = true;
                        dataGridView.DataSource = dtExcel;
                        updatePaxCount();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please choose .xls or .xlsx file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); //custom messageBox to show error
                }
            }
        }

        private void SetDateFormat()
        {
            foreach (DataRow row in dtExcel.Rows)
            {
                DateTime dtDateOfBirth = DateTime.Parse(row["DateOfBirth"].ToString());
                row["DateOfBirth"] = dtDateOfBirth.ToString("dd/MM/yyyy");

                DateTime dtExpireDate = DateTime.Parse(row["ExpireDate"].ToString());
                row["ExpireDate"] = dtExpireDate.ToString("dd/MM/yyyy");

                DateTime dtBookingDate = DateTime.Parse(row["BookingDate"].ToString());
                row["BookingDate"] = dtBookingDate.ToString("dd/MM/yyyy");

                DateTime dtVisaExpiryDate = DateTime.Parse(row["VisaExpiryDate"].ToString());
                row["VisaExpiryDate"] = dtVisaExpiryDate.ToString("dd/MM/yyyy");

                DateTime dtPaymentExpirationDate = DateTime.Parse(row["PaymentExpirationDate"].ToString());
                row["PaymentExpirationDate"] = dtPaymentExpirationDate.ToString("dd/MM/yyyy");

                DateTime dtPaymentDatePaid = DateTime.Parse(row["PaymentDatePaid"].ToString());
                row["PaymentDatePaid"] = dtPaymentDatePaid.ToString("dd/MM/yyyy");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save PNR file ?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    saveFile();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

                
            }
            else
            {
                MessageBox.Show("Incomplete Records Found !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void saveFile()
        {
            try
            {
                SaveFileDialog file = new SaveFileDialog();
                file.Title = "Save PNR Files";
                file.CheckPathExists = true;
                file.DefaultExt = "xml";
                file.Filter = "PNR files (*.xml)|*.xml";
                file.RestoreDirectory = true;
                if (file.ShowDialog() == DialogResult.OK)
                {
                    writeXML(file.FileName);
                    MessageBox.Show("Successfully Saved", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                var GetDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                dtExcel = ReadExcel(GetDirectory + "\\PNR_Template.xlsx"); //read excel file
                dataGridView.Visible = true;
                dataGridView.DataSource = dtExcel;
                updatePaxCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void writeXML(string newFilename)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");
            settings.CloseOutput = true;
            settings.Encoding = Encoding.UTF8;
            settings.OmitXmlDeclaration = false;
            using (XmlWriter writer = XmlWriter.Create(newFilename, settings))
            {
                writer.WriteStartDocument();

                writer.WriteStartElement("root");

                writer.WriteStartElement("FlightDetails");
                writer.WriteElementString("FlightNumber", txtFlightNumber.Text);
                writer.WriteElementString("NoofSeatofFlight", txtNoofSeatofFlight.Text);
                writer.WriteElementString("FlightSeatType", txtFlightSeatType.Text);
                writer.WriteElementString("NoOfBusinessClassRows", txtNoOfBusinessClassRows.Text);
                writer.WriteElementString("NoOfPremiumClassRows", txtNoOfPremiumClassRows.Text);
                writer.WriteElementString("NoofPassengers", txtNoofPassengers.Text);
                writer.WriteElementString("OriginPort", txtOriginPort.Text);
                writer.WriteElementString("DestinationPort", txtDestinationPort.Text);
                writer.WriteElementString("DepartureDateTime", txtDepartureDate.Text+"T"+dtDepartureTime.Text.ToString());
                writer.WriteElementString("ArrivalDateTime", txtArrivalDate.Text + "T" + dtArrivalTime.Text.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("Passengers");

                foreach (DataRow row in dtExcel.Rows)
                {
                    writer.WriteStartElement("Passenger");

                    foreach (DataColumn column in row.Table.Columns)  //loop through the columns. 
                    {
                        writer.WriteStartElement(column.ColumnName);
                        writer.WriteString(row[column.ColumnName].ToString());
                        writer.WriteFullEndElement();
                    }

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();

                writer.WriteEndElement();

                writer.WriteEndDocument();
                writer.Flush();
            }
        }

        private bool validateData()
        {
            bool noBlankData = true;
            foreach (DataRow row in dtExcel.Rows)
            {
                int rowSize = 0;
                foreach (DataColumn column in row.Table.Columns)  //loop through the columns. 
                {
                    rowSize = rowSize + row[column.ColumnName].ToString().Trim().Length;
                    if (rowSize==0)
                    {
                        noBlankData = false;
                    }
                }

            }

            return noBlankData;
        }

        private void dtDepartureTime_ValueChanged(object sender, EventArgs e)
        {
            txtDepartureDate.Text = dtDepartureTime.Value.ToString("yyyy-MM-dd");
        }

        private void dtArrivalTime_ValueChanged(object sender, EventArgs e)
        {
            txtArrivalDate.Text = dtArrivalTime.Value.ToString("yyyy-MM-dd");
        }

        private void btnDuplicateRow_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView currentDataRowView = (DataRowView)dataGridView.CurrentRow.DataBoundItem;
                DataRow row = currentDataRowView.Row;
                DataRow newrow = dtExcel.NewRow();

                for (int i = 0; i < row.Table.Columns.Count; i++)
                {
                    newrow[i] = row.ItemArray[i];
                }

                dtExcel.Rows.Add(newrow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updatePaxCount();
        }

        private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            updatePaxCount();
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            updatePaxCount();
        }

        private void updatePaxCount()
        {
            int paxCount = dataGridView.Rows.Count - 1;
            
            if (paxCount <= 0)
            {
                txtNoofPassengers.Text = "0";
                btnSave.Enabled = false;
                btnCopyPax.Enabled = false;
                btnDelPax.Enabled = false;
                btnAddPax.Enabled = false;
            }
            else
            {
                txtNoofPassengers.Text = paxCount.ToString();
                btnSave.Enabled = true;
                btnCopyPax.Enabled = true;
                btnDelPax.Enabled = true;
                btnAddPax.Enabled = true;
            }
        }

        private void btnAddPax_Click(object sender, EventArgs e)
        {
            try
            {
                addPaxRow(dtExcel.Columns.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addPaxRow(int cols)
        {
            DataRow newrow = dtExcel.NewRow();

            for (int i = 0; i < cols; i++)
            {
                newrow[i] = "";
            }

            dtExcel.Rows.Add(newrow);
        }

        private void btnDelPax_Click(object sender, EventArgs e)
        {
            try
            {
                int rowCount = dataGridView.Rows.Count;
                dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);

                if (rowCount == 2)
                {
                    dataGridView.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //updateConfig();
        }
    }
}

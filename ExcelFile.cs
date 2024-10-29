using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.IO;
using System.Windows.Forms;
using Action = Microsoft.Office.Interop.Excel.Action;
using System.Globalization;

namespace Gait_analysis
{
    class ExcelFile
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        public DataTable Datatable { get; private set; }
        DataTable accelerometerData;

        public ExcelFile(string path, int sheet)
        {
            this.path = path;
            string fileExtension = Path.GetExtension(path).ToLower();
            if (fileExtension == ".xlsx" || fileExtension == ".xls")
            {
                try
                {
                    LoadExcelFile(sheet); // Load Excel file
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Excel file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (fileExtension == ".csv")
            {
                try
                {
                    Datatable = LoadCsvDataToDataTable(path); // Load CSV file
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading CSV file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                throw new NotSupportedException("Unsupported file format: " + fileExtension);
            }
        }


        //-------------------------------------Method to load Excel file--------------------------------------
        private void LoadExcelFile(int sheet)
        {
            try
            {
                excel = new _Excel.Application();
                wb = excel.Workbooks.Open(path);
                ws = wb.Worksheets[sheet];
                Datatable = LoadExcelDataToDataTable();
            }
            finally
            {
                if (wb != null) wb.Close(false);
                if (excel != null) excel.Quit();
            }
        }

        public DataTable LoadExcelDataToDataTable()
        {
            DataTable dataTable = new DataTable();
            for (int col = 1; col <= ws.UsedRange.Columns.Count; col++)
            {
                string header = ws.Cells[1, col].Value2.ToString();
                dataTable.Columns.Add(header);
            }
            for (int row = 2; row <= ws.UsedRange.Rows.Count; row++) 
            {
                DataRow dataRow = dataTable.NewRow();
                for (int col = 1; col <= ws.UsedRange.Columns.Count; col++)
                {
                    dataRow[col - 1] = ws.Cells[row, col].Value2;
                }
                dataTable.Rows.Add(dataRow);
            }
            wb.Close(false);
            excel.Quit();

            return dataTable;
        }

        //----------------------------------Method to load CSV data into DataTable-------------------------------------
        public DataTable LoadCsvDataToDataTable(string filePath)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dataRow[i] = rows[i];
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Make sure the File isn't Opened On your Laptop and Restart App");
            }

            return dataTable;
        }

    //------------------------------------------method will load the Excel data into the DataTable------------------
    private DataTable LoadExcelDataToDataTable(string filePath)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        DataRow dataRow = dataTable.NewRow();

                        for (int i = 0; i < headers.Length; i++)
                        {
                            dataRow[i] = rows[i];
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data from Excel: " + ex.Message);
            }

            return dataTable;
        }

        public void LoadAccelerometerFile(string filePath)
        {
            accelerometerData = LoadExcelDataToDataTable(filePath);
            MessageBox.Show("Accelerometer data loaded successfully.");
        }

        public double ReadCell(double timevalue)
        {
            double videoHeelTimeInMs = timevalue * 1000;
            double targetTimestamp = GetStartTimestamp() + videoHeelTimeInMs;
            double closestTime = 0;
            double closestDifference = double.MaxValue;

            for (int i = 0; i < Datatable.Rows.Count; i++)
            {
                try
                {
                    if (Datatable.Rows[i] != null)
                    {
                        string data = Datatable.Rows[i][0].ToString();
                        string[] numbers = data.Split(';');
                        double timestamp = double.Parse(numbers[0], CultureInfo.InvariantCulture);
                        double difference = Math.Abs(timestamp - targetTimestamp);
                        if (difference < closestDifference)
                        {
                            closestDifference = difference;
                            closestTime = timestamp;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error processing row {i}: {ex.Message}");
                }
            }
            return closestTime;


        }

        public double getdifference(double timevalue)
        {
            double videoHeelTimeInMs = timevalue * 1000;
            double targetTimestamp = GetStartTimestamp() + videoHeelTimeInMs;
            double timeDifferenceMs = targetTimestamp - ReadCell(timevalue);
            return timeDifferenceMs;
        }

        public string GetCorrespondingData(double timestamp)
        {
            for (int i = 0; i < Datatable.Rows.Count; i++)
            {
                string data = Datatable.Rows[i][0].ToString();
                string[] numbers = data.Split(';');
                double accelTimestamp = double.Parse(numbers[0], CultureInfo.InvariantCulture);
                if (Math.Abs(accelTimestamp - timestamp) < 1e-3) 
                {
                    double xAxis = Convert.ToDouble(numbers[2]);
                    double yAxis = Convert.ToDouble(numbers[3]);
                    double zAxis = Convert.ToDouble(numbers[4]);
                    return $"X: {xAxis}, Y: {yAxis}, Z: {zAxis}";
                }
            }
            return null;
        }

        public double GetStartTimestamp()
        {
            if (Datatable.Rows.Count > 0)
            {
                string data = Datatable.Rows[0][0].ToString();
                string[] numbers = data.Split(';');
                double timestamp = double.Parse(numbers[0], CultureInfo.InvariantCulture);
                return timestamp;
            }
            return 0;
        }

    }
}

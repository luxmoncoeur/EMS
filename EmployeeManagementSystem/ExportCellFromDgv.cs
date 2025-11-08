using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class ExportCellFromDgv
    {
        public static void ExportFromTemplate(string templatePath, string savePath, params object[] cellValuePairs)
        {
            if (!File.Exists(templatePath))
            {
                MessageBox.Show($"Template not found:\n{templatePath}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cellValuePairs.Length % 2 != 0)
            {
                MessageBox.Show("Invalid number of arguments. Must be in cell-value pairs.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Microsoft.Office.Interop.Excel.Application excelApp = null;
            Microsoft.Office.Interop.Excel.Workbook workbook = null;

            try
            {
                excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.DisplayAlerts = false; // prevent overwrite prompt


                workbook = excelApp.Workbooks.Open(templatePath);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = workbook.ActiveSheet;

                for (int i = 0; i < cellValuePairs.Length; i += 2)
                {
                    string cellAddress = cellValuePairs[i].ToString();
                    string cellValue = cellValuePairs[i + 1]?.ToString() ?? "";
                    worksheet.Range[cellAddress].Value = cellValue;
                }
                string path = savePath.Replace(".xlsx", DateTime.Now.ToString("MMddyyyy") + ".xlsx");

                // Save as new file (or overwrite if same path)
                workbook.SaveAs(path);
                workbook.Close(false);
                excelApp.Quit();

                MessageBox.Show($"Excel file successfully exported!\n\nSaved to:\n{path}",
                                "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel:\n" + ex.Message,
                                "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (workbook != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                if (excelApp != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                workbook = null;
                excelApp = null;
                GC.Collect();
            }
        }
    }




}

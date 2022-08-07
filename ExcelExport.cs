using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Excel = Microsoft.Office.Interop.Excel;

namespace WorkParser2
{
    internal class ExcelExport
    {
        public void Export(DataObject data)
        {
            //if (data == null) return;            
            //Clipboard.SetDataObject(data);
            
            //Excel.Application ExcelApp = new();
            //ExcelApp.Visible = true;
            //Excel.Workbook workbook;
            //Excel.Worksheet worksheet;
            
            //object values = System.Reflection.Missing.Value;
            //workbook = ExcelApp.Workbooks.Add(values);
            //worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
            //Excel.Range c_range = (Excel.Range)worksheet.Cells[1, 1];
            //c_range.Select();
            //worksheet.PasteSpecial(c_range);

            //Clipboard.Clear();
        }
    }
}
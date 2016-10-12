using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Excel;

namespace excelinterop
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new Application { Visible = true };
            app.Workbooks.Add();
            Worksheet worksheet = app.ActiveSheet;
            Range start = worksheet.Cells[1, 1];
            Range end = worksheet.Cells[1, 20];
            worksheet.Range[start, end].Value = Enumerable.Range(1, 20).ToArray();

        }
    }
}

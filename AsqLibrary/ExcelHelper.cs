using Excel = Microsoft.Office.Interop.Excel;

namespace AsqLibrary
{
    public class ExcelHelper
    {
        public Excel.Application App { get; set; }
        public Excel.Workbook Workbook { get; set; }
        public Excel.Worksheet Worksheet { get; set; }

        public ExcelHelper()
        {
            App = new Excel.Application();
        }
        
        public void AddRow(AsqModel asqModel)
        {
            Workbook = App.Workbooks.Open(@"C:\Users\Mark\Downloads\test.xlsx");
            Worksheet = (Excel.Worksheet)Workbook.Worksheets[1];

            Excel.Range range = (Excel.Range)Worksheet.Cells[Worksheet.Rows.Count, 1];
            int lastRow = range.get_End(Excel.XlDirection.xlUp).Row;
            int newRow = lastRow + 1;

            App.Cells[newRow, 1] = asqModel.DateAsqCompleted;
            App.Cells[newRow, 2] = asqModel.Id;
            App.Cells[newRow, 3] = asqModel.Gender;
            App.Cells[newRow, 4] = asqModel.DateOfBirth;

            App.Cells[newRow, 6] = asqModel.CommunicationScore;
            App.Cells[newRow, 7] = asqModel.CommunicationRecommendation;
            App.Cells[newRow, 8] = asqModel.GrossMotorScore;
            App.Cells[newRow, 9] = asqModel.GrossMotorRecommendation;
            App.Cells[newRow, 10] = asqModel.FineMotorScore;
            App.Cells[newRow, 11] = asqModel.FineMotorRecommendation;
            App.Cells[newRow, 12] = asqModel.ProblemSolvingScore;
            App.Cells[newRow, 13] = asqModel.ProblemSolvingRecommendation;
            App.Cells[newRow, 14] = asqModel.PersonalSocialScore;
            App.Cells[newRow, 15] = asqModel.PersonalSocialRecommendation;

            Workbook.Close(true);
        }
    }
}

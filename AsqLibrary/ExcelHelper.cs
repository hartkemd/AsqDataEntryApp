using Excel = Microsoft.Office.Interop.Excel;

namespace AsqLibrary
{
    public class ExcelHelper
    {
        public string FilePath { get; set; }
        public Excel.Application App { get; set; }
        public Excel.Workbook Workbook { get; set; }
        public Excel.Worksheet Worksheet { get; set; }

        public ExcelHelper()
        {
            App = new Excel.Application();
        }
        
        public void AddRow(AsqModel asqModel)
        {
            Workbook = App.Workbooks.Open(FilePath);
            Worksheet = (Excel.Worksheet)Workbook.Worksheets[1];

            Excel.Range range = (Excel.Range)Worksheet.Cells[Worksheet.Rows.Count, 1];
            int lastRow = range.get_End(Excel.XlDirection.xlUp).Row;
            int newRow = lastRow + 1;

            App.Cells[newRow, 1] = asqModel.DateAsqCompleted;
            App.Cells[newRow, 2] = asqModel.Id;
            App.Cells[newRow, 3] = asqModel.Gender;

            (string age, string ageCode) = GetAgeAndAgeCode(asqModel.DateOfBirth, asqModel.DateAsqCompleted);
            App.Cells[newRow, 4] = age;
            App.Cells[newRow, 5] = ageCode;

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

        private (string, string) GetAgeAndAgeCode(DateTime dateOfBirth, DateTime dateAsqCompleted)
        {
            int age = GetAgeInMonths(dateOfBirth, dateAsqCompleted);
            string ageCode = "M";

            if (age > 11)
            {
                age = GetAgeInYears(dateOfBirth, dateAsqCompleted);
                ageCode = "Y";
            }

            return (age.ToString(), ageCode);
        }

        private int GetAgeInMonths(DateTime dateOfBirth, DateTime dateAsqCompleted)
        {
            int age = ((dateAsqCompleted.Year - dateOfBirth.Year) * 12) + dateAsqCompleted.Month - dateOfBirth.Month;

            return age;
        }

        private int GetAgeInYears(DateTime dateOfBirth, DateTime dateAsqCompleted)
        {
            int age = dateAsqCompleted.Year - dateOfBirth.Year;

            // Go back to the year in which the person was born in case of a leap year
            if (dateOfBirth.Date > dateAsqCompleted.AddYears(-age)) age--;

            return age;
        }
    }
}

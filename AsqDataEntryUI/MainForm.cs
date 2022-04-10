using AsqLibrary;
using System.ComponentModel;

namespace AsqDataEntryUI
{
    public partial class MainForm : Form
    {
        private static string classLevelFilePath;
        private static List<string> recommendations = new List<string>() { "", "3", "2", "1" };
        private static ExcelHelper excelHelper = new ExcelHelper();

        public MainForm()
        {
            InitializeComponent();

            SetDateTimePickers();
            SetComboBoxDataSources();

            AutoValidate = AutoValidate.Disable;
            AddValidatingEvents();

            SetFilePath();
        }

        private static void SetFilePath()
        {
            classLevelFilePath = FileIO.ReadFilePathFromConfigFile();
            excelHelper.FilePath = classLevelFilePath;

            if (classLevelFilePath == string.Empty)
            {
                MessageBox.Show("Excel file path must be selected from File menu.", "Excel File Path Missing", MessageBoxButtons.OK);
            }
        }

        private void AddValidatingEvents()
        {
            idTextBox.Validating += TextBox_Validating;
            commTextBox.Validating += TextBox_Validating;
            grossMotorTextBox.Validating += TextBox_Validating;
            fineMotorTextBox.Validating += TextBox_Validating;
            probSolvTextBox.Validating += TextBox_Validating;
            persSocTextBox.Validating += TextBox_Validating;

            commRecComboBox.Validating += ComboBox_Validating;
            grossMotorRecComboBox.Validating += ComboBox_Validating;
            fineMotorRecComboBox.Validating += ComboBox_Validating;
            probSolvRecComboBox.Validating += ComboBox_Validating;
            persSocRecComboBox.Validating += ComboBox_Validating;
        }

        private void ComboBox_Validating(object? sender, CancelEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox.Text.Length == 0)
            {
                e.Cancel = true;
            }
        }

        private void TextBox_Validating(object? sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.Text.Length == 0)
            {
                e.Cancel = true;
            }
        }

        private void SetDateTimePickers()
        {
            dateAsqCompletedDateTimePicker.Format = DateTimePickerFormat.Short;
            dateOfBirthDateTimePicker.Format = DateTimePickerFormat.Short;

            dateAsqCompletedDateTimePicker.Value = DateTime.Today;
            dateOfBirthDateTimePicker.Value = DateTime.Today;
        }

        private void SetComboBoxDataSources()
        {
            commRecComboBox.DataSource = recommendations;
            grossMotorRecComboBox.DataSource = new List<string>(recommendations);
            fineMotorRecComboBox.DataSource = new List<string>(recommendations);
            probSolvRecComboBox.DataSource = new List<string>(recommendations);
            persSocRecComboBox.DataSource = new List<string>(recommendations);
        }

        private bool ValidateInput()
        {
            if (ValidateChildren() && ValidateGender())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateGender()
        {
            if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                MessageBox.Show("Gender was not valid");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ClearForm()
        {
            idTextBox.Clear();
            dateAsqCompletedDateTimePicker.Value = DateTime.Today;
            dateOfBirthDateTimePicker.Value = DateTime.Today;
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            commTextBox.Clear();
            grossMotorTextBox.Clear();
            fineMotorTextBox.Clear();
            probSolvTextBox.Clear();
            persSocTextBox.Clear();
            commRecComboBox.SelectedIndex = 0;
            grossMotorRecComboBox.SelectedIndex = 0;
            fineMotorRecComboBox.SelectedIndex = 0;
            probSolvRecComboBox.SelectedIndex = 0;
            persSocRecComboBox.SelectedIndex = 0;

            idTextBox.Focus();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            bool inputIsValid = ValidateInput();

            if (inputIsValid == true)
            {
                AsqModel asqModel = new AsqModel();
                asqModel.Id = idTextBox.Text;
                asqModel.DateAsqCompleted = dateAsqCompletedDateTimePicker.Value;
                asqModel.DateOfBirth = dateOfBirthDateTimePicker.Value;
                if (maleRadioButton.Checked == true)
                {
                    asqModel.Gender = "M";
                }
                else if (femaleRadioButton.Checked == true)
                {
                    asqModel.Gender = "F";
                }
                asqModel.CommunicationScore = commTextBox.Text;
                asqModel.CommunicationRecommendation = commRecComboBox.SelectedItem.ToString();
                asqModel.GrossMotorScore = grossMotorTextBox.Text;
                asqModel.GrossMotorRecommendation = grossMotorRecComboBox.SelectedItem.ToString();
                asqModel.FineMotorScore = fineMotorTextBox.Text;
                asqModel.FineMotorRecommendation = fineMotorRecComboBox.SelectedItem.ToString();
                asqModel.ProblemSolvingScore = probSolvTextBox.Text;
                asqModel.ProblemSolvingRecommendation = probSolvRecComboBox.SelectedItem.ToString();
                asqModel.PersonalSocialScore = persSocTextBox.Text;
                asqModel.PersonalSocialRecommendation = persSocRecComboBox.SelectedItem.ToString();
                
                excelHelper.AddRow(asqModel);
                statusLabel.Text = "Row added!";
                ClearForm();
                await Task.Delay(5000);
                statusLabel.Text = "";
            }
            else
            {
                MessageBox.Show("Validation failed.");
            }
        }

        private void SelectExcelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "xlsx files (*.xlsx)|*.xlsx|all files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    classLevelFilePath = filePath;
                    FileIO.WriteFilePathToConfigFile(filePath);
                    MessageBox.Show($"The file path you selected is: {filePath}", "File Path", MessageBoxButtons.OK);
                }
            }
        }
    }
}

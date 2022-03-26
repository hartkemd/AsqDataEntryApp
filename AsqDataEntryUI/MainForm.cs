using System.ComponentModel;

namespace AsqDataEntryUI
{
    public partial class MainForm : Form
    {
        private List<string> recommendations = new List<string>() { "", "0. normal", "1. monitor", "2. professional assessment" };

        public MainForm()
        {
            InitializeComponent();

            SetDateTimePickers();
            SetComboBoxDataSources();

            AutoValidate = AutoValidate.Disable;
            AddValidatingEvents();
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

        private void ClearButton_Click(object sender, EventArgs e)
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

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool inputIsValid = ValidateInput();

            if (inputIsValid == true)
            {
                MessageBox.Show("Validation succeeded!");
            }
            else
            {
                MessageBox.Show("Validation failed.");
            }
        }
    }
}

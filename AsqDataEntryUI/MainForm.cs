namespace AsqDataEntryUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            SetDateTimePickers();
        }

        private void SetDateTimePickers()
        {
            dateAsqCompletedDateTimePicker.Format = DateTimePickerFormat.Short;
            dateOfBirthDateTimePicker.Format = DateTimePickerFormat.Short;

            dateAsqCompletedDateTimePicker.Value = DateTime.Today;
            dateOfBirthDateTimePicker.Value = DateTime.Today;
        }
    }
}

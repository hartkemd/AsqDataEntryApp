namespace AsqDataEntryUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dateAsqCompletedLabel = new System.Windows.Forms.Label();
            this.dateAsqCompletedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.scoresGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.personalSocialLabel = new System.Windows.Forms.Label();
            this.problemSolvingTextBox = new System.Windows.Forms.TextBox();
            this.problemSolvingLabel = new System.Windows.Forms.Label();
            this.fineMotorTextBox = new System.Windows.Forms.TextBox();
            this.fineMotorLabel = new System.Windows.Forms.Label();
            this.grossMotorTextBox = new System.Windows.Forms.TextBox();
            this.grossMotorLabel = new System.Windows.Forms.Label();
            this.communicationTextBox = new System.Windows.Forms.TextBox();
            this.communicationLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.scoresGroupBox.SuspendLayout();
            this.genderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(160, 28);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 21);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(194, 25);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(75, 29);
            this.idTextBox.TabIndex = 1;
            // 
            // dateAsqCompletedLabel
            // 
            this.dateAsqCompletedLabel.AutoSize = true;
            this.dateAsqCompletedLabel.Location = new System.Drawing.Point(31, 66);
            this.dateAsqCompletedLabel.Name = "dateAsqCompletedLabel";
            this.dateAsqCompletedLabel.Size = new System.Drawing.Size(157, 21);
            this.dateAsqCompletedLabel.TabIndex = 0;
            this.dateAsqCompletedLabel.Text = "Date ASQ completed:";
            // 
            // dateAsqCompletedDateTimePicker
            // 
            this.dateAsqCompletedDateTimePicker.Location = new System.Drawing.Point(194, 60);
            this.dateAsqCompletedDateTimePicker.Name = "dateAsqCompletedDateTimePicker";
            this.dateAsqCompletedDateTimePicker.Size = new System.Drawing.Size(155, 29);
            this.dateAsqCompletedDateTimePicker.TabIndex = 2;
            this.dateAsqCompletedDateTimePicker.Value = new System.DateTime(2022, 3, 19, 12, 41, 28, 0);
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(194, 95);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(155, 29);
            this.dateOfBirthDateTimePicker.TabIndex = 3;
            this.dateOfBirthDateTimePicker.Value = new System.DateTime(2022, 3, 19, 12, 41, 28, 0);
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(88, 101);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(100, 21);
            this.dateOfBirthLabel.TabIndex = 0;
            this.dateOfBirthLabel.Text = "Date of birth:";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(6, 19);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(62, 25);
            this.maleRadioButton.TabIndex = 0;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(74, 19);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(75, 25);
            this.femaleRadioButton.TabIndex = 1;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // scoresGroupBox
            // 
            this.scoresGroupBox.Controls.Add(this.textBox4);
            this.scoresGroupBox.Controls.Add(this.personalSocialLabel);
            this.scoresGroupBox.Controls.Add(this.problemSolvingTextBox);
            this.scoresGroupBox.Controls.Add(this.problemSolvingLabel);
            this.scoresGroupBox.Controls.Add(this.fineMotorTextBox);
            this.scoresGroupBox.Controls.Add(this.fineMotorLabel);
            this.scoresGroupBox.Controls.Add(this.grossMotorTextBox);
            this.scoresGroupBox.Controls.Add(this.grossMotorLabel);
            this.scoresGroupBox.Controls.Add(this.communicationTextBox);
            this.scoresGroupBox.Controls.Add(this.communicationLabel);
            this.scoresGroupBox.Location = new System.Drawing.Point(386, 25);
            this.scoresGroupBox.Name = "scoresGroupBox";
            this.scoresGroupBox.Size = new System.Drawing.Size(240, 219);
            this.scoresGroupBox.TabIndex = 5;
            this.scoresGroupBox.TabStop = false;
            this.scoresGroupBox.Text = "Total Scores:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(159, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(51, 29);
            this.textBox4.TabIndex = 5;
            // 
            // personalSocialLabel
            // 
            this.personalSocialLabel.AutoSize = true;
            this.personalSocialLabel.Location = new System.Drawing.Point(34, 172);
            this.personalSocialLabel.Name = "personalSocialLabel";
            this.personalSocialLabel.Size = new System.Drawing.Size(119, 21);
            this.personalSocialLabel.TabIndex = 0;
            this.personalSocialLabel.Text = "Personal-Social:";
            // 
            // problemSolvingTextBox
            // 
            this.problemSolvingTextBox.Location = new System.Drawing.Point(159, 134);
            this.problemSolvingTextBox.Name = "problemSolvingTextBox";
            this.problemSolvingTextBox.Size = new System.Drawing.Size(51, 29);
            this.problemSolvingTextBox.TabIndex = 4;
            // 
            // problemSolvingLabel
            // 
            this.problemSolvingLabel.AutoSize = true;
            this.problemSolvingLabel.Location = new System.Drawing.Point(25, 137);
            this.problemSolvingLabel.Name = "problemSolvingLabel";
            this.problemSolvingLabel.Size = new System.Drawing.Size(128, 21);
            this.problemSolvingLabel.TabIndex = 0;
            this.problemSolvingLabel.Text = "Problem Solving:";
            // 
            // fineMotorTextBox
            // 
            this.fineMotorTextBox.Location = new System.Drawing.Point(159, 99);
            this.fineMotorTextBox.Name = "fineMotorTextBox";
            this.fineMotorTextBox.Size = new System.Drawing.Size(51, 29);
            this.fineMotorTextBox.TabIndex = 3;
            // 
            // fineMotorLabel
            // 
            this.fineMotorLabel.AutoSize = true;
            this.fineMotorLabel.Location = new System.Drawing.Point(64, 102);
            this.fineMotorLabel.Name = "fineMotorLabel";
            this.fineMotorLabel.Size = new System.Drawing.Size(89, 21);
            this.fineMotorLabel.TabIndex = 0;
            this.fineMotorLabel.Text = "Fine Motor:";
            // 
            // grossMotorTextBox
            // 
            this.grossMotorTextBox.Location = new System.Drawing.Point(159, 64);
            this.grossMotorTextBox.Name = "grossMotorTextBox";
            this.grossMotorTextBox.Size = new System.Drawing.Size(51, 29);
            this.grossMotorTextBox.TabIndex = 2;
            // 
            // grossMotorLabel
            // 
            this.grossMotorLabel.AutoSize = true;
            this.grossMotorLabel.Location = new System.Drawing.Point(53, 67);
            this.grossMotorLabel.Name = "grossMotorLabel";
            this.grossMotorLabel.Size = new System.Drawing.Size(100, 21);
            this.grossMotorLabel.TabIndex = 0;
            this.grossMotorLabel.Text = "Gross Motor:";
            // 
            // communicationTextBox
            // 
            this.communicationTextBox.Location = new System.Drawing.Point(159, 29);
            this.communicationTextBox.Name = "communicationTextBox";
            this.communicationTextBox.Size = new System.Drawing.Size(51, 29);
            this.communicationTextBox.TabIndex = 1;
            // 
            // communicationLabel
            // 
            this.communicationLabel.AutoSize = true;
            this.communicationLabel.Location = new System.Drawing.Point(29, 32);
            this.communicationLabel.Name = "communicationLabel";
            this.communicationLabel.Size = new System.Drawing.Size(124, 21);
            this.communicationLabel.TabIndex = 0;
            this.communicationLabel.Text = "Communication:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(226, 272);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(97, 42);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(342, 272);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 42);
            this.clearButton.TabIndex = 0;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.maleRadioButton);
            this.genderGroupBox.Controls.Add(this.femaleRadioButton);
            this.genderGroupBox.Location = new System.Drawing.Point(194, 130);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Size = new System.Drawing.Size(155, 58);
            this.genderGroupBox.TabIndex = 4;
            this.genderGroupBox.TabStop = false;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(124, 153);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(64, 21);
            this.genderLabel.TabIndex = 0;
            this.genderLabel.Text = "Gender:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 353);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.genderGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.scoresGroupBox);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.dateAsqCompletedDateTimePicker);
            this.Controls.Add(this.dateAsqCompletedLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "ASQ Data Entry";
            this.scoresGroupBox.ResumeLayout(false);
            this.scoresGroupBox.PerformLayout();
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label idLabel;
        private TextBox idTextBox;
        private Label dateAsqCompletedLabel;
        private DateTimePicker dateAsqCompletedDateTimePicker;
        private DateTimePicker dateOfBirthDateTimePicker;
        private Label dateOfBirthLabel;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private GroupBox scoresGroupBox;
        private TextBox textBox4;
        private Label personalSocialLabel;
        private TextBox problemSolvingTextBox;
        private Label problemSolvingLabel;
        private TextBox fineMotorTextBox;
        private Label fineMotorLabel;
        private TextBox grossMotorTextBox;
        private Label grossMotorLabel;
        private TextBox communicationTextBox;
        private Label communicationLabel;
        private Button submitButton;
        private Button clearButton;
        private GroupBox genderGroupBox;
        private Label genderLabel;
    }
}
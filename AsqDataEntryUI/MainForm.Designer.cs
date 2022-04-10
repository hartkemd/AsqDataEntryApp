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
            this.recLabel = new System.Windows.Forms.Label();
            this.persSocRecComboBox = new System.Windows.Forms.ComboBox();
            this.probSolvRecComboBox = new System.Windows.Forms.ComboBox();
            this.fineMotorRecComboBox = new System.Windows.Forms.ComboBox();
            this.grossMotorRecComboBox = new System.Windows.Forms.ComboBox();
            this.commRecComboBox = new System.Windows.Forms.ComboBox();
            this.persSocTextBox = new System.Windows.Forms.TextBox();
            this.persSocLabel = new System.Windows.Forms.Label();
            this.probSolvTextBox = new System.Windows.Forms.TextBox();
            this.probSolvLabel = new System.Windows.Forms.Label();
            this.fineMotorTextBox = new System.Windows.Forms.TextBox();
            this.fineMotorLabel = new System.Windows.Forms.Label();
            this.grossMotorTextBox = new System.Windows.Forms.TextBox();
            this.grossMotorLabel = new System.Windows.Forms.Label();
            this.commTextBox = new System.Windows.Forms.TextBox();
            this.commLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectExcelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLabel = new System.Windows.Forms.Label();
            this.scoresGroupBox.SuspendLayout();
            this.genderGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(161, 50);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 21);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(195, 47);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(75, 29);
            this.idTextBox.TabIndex = 1;
            // 
            // dateAsqCompletedLabel
            // 
            this.dateAsqCompletedLabel.AutoSize = true;
            this.dateAsqCompletedLabel.Location = new System.Drawing.Point(32, 88);
            this.dateAsqCompletedLabel.Name = "dateAsqCompletedLabel";
            this.dateAsqCompletedLabel.Size = new System.Drawing.Size(157, 21);
            this.dateAsqCompletedLabel.TabIndex = 0;
            this.dateAsqCompletedLabel.Text = "Date ASQ completed:";
            // 
            // dateAsqCompletedDateTimePicker
            // 
            this.dateAsqCompletedDateTimePicker.Location = new System.Drawing.Point(195, 82);
            this.dateAsqCompletedDateTimePicker.Name = "dateAsqCompletedDateTimePicker";
            this.dateAsqCompletedDateTimePicker.Size = new System.Drawing.Size(155, 29);
            this.dateAsqCompletedDateTimePicker.TabIndex = 2;
            this.dateAsqCompletedDateTimePicker.Value = new System.DateTime(2022, 3, 19, 12, 41, 28, 0);
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(195, 117);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(155, 29);
            this.dateOfBirthDateTimePicker.TabIndex = 3;
            this.dateOfBirthDateTimePicker.Value = new System.DateTime(2022, 3, 19, 12, 41, 28, 0);
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(89, 123);
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
            this.scoresGroupBox.Controls.Add(this.recLabel);
            this.scoresGroupBox.Controls.Add(this.persSocRecComboBox);
            this.scoresGroupBox.Controls.Add(this.probSolvRecComboBox);
            this.scoresGroupBox.Controls.Add(this.fineMotorRecComboBox);
            this.scoresGroupBox.Controls.Add(this.grossMotorRecComboBox);
            this.scoresGroupBox.Controls.Add(this.commRecComboBox);
            this.scoresGroupBox.Controls.Add(this.persSocTextBox);
            this.scoresGroupBox.Controls.Add(this.persSocLabel);
            this.scoresGroupBox.Controls.Add(this.probSolvTextBox);
            this.scoresGroupBox.Controls.Add(this.probSolvLabel);
            this.scoresGroupBox.Controls.Add(this.fineMotorTextBox);
            this.scoresGroupBox.Controls.Add(this.fineMotorLabel);
            this.scoresGroupBox.Controls.Add(this.grossMotorTextBox);
            this.scoresGroupBox.Controls.Add(this.grossMotorLabel);
            this.scoresGroupBox.Controls.Add(this.commTextBox);
            this.scoresGroupBox.Controls.Add(this.commLabel);
            this.scoresGroupBox.Location = new System.Drawing.Point(387, 47);
            this.scoresGroupBox.Name = "scoresGroupBox";
            this.scoresGroupBox.Size = new System.Drawing.Size(442, 306);
            this.scoresGroupBox.TabIndex = 5;
            this.scoresGroupBox.TabStop = false;
            this.scoresGroupBox.Text = "Total Scores:";
            // 
            // recLabel
            // 
            this.recLabel.AutoSize = true;
            this.recLabel.Location = new System.Drawing.Point(221, 25);
            this.recLabel.MaximumSize = new System.Drawing.Size(225, 0);
            this.recLabel.Name = "recLabel";
            this.recLabel.Size = new System.Drawing.Size(207, 84);
            this.recLabel.TabIndex = 11;
            this.recLabel.Text = "Recommendation\r\n3 = normal\r\n2 = monitor\r\n1 = professional assessment";
            // 
            // persSocRecComboBox
            // 
            this.persSocRecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.persSocRecComboBox.FormattingEnabled = true;
            this.persSocRecComboBox.Location = new System.Drawing.Point(221, 252);
            this.persSocRecComboBox.Name = "persSocRecComboBox";
            this.persSocRecComboBox.Size = new System.Drawing.Size(65, 29);
            this.persSocRecComboBox.TabIndex = 10;
            // 
            // probSolvRecComboBox
            // 
            this.probSolvRecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.probSolvRecComboBox.FormattingEnabled = true;
            this.probSolvRecComboBox.Location = new System.Drawing.Point(221, 217);
            this.probSolvRecComboBox.Name = "probSolvRecComboBox";
            this.probSolvRecComboBox.Size = new System.Drawing.Size(65, 29);
            this.probSolvRecComboBox.TabIndex = 8;
            // 
            // fineMotorRecComboBox
            // 
            this.fineMotorRecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fineMotorRecComboBox.FormattingEnabled = true;
            this.fineMotorRecComboBox.Location = new System.Drawing.Point(221, 182);
            this.fineMotorRecComboBox.Name = "fineMotorRecComboBox";
            this.fineMotorRecComboBox.Size = new System.Drawing.Size(65, 29);
            this.fineMotorRecComboBox.TabIndex = 6;
            // 
            // grossMotorRecComboBox
            // 
            this.grossMotorRecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grossMotorRecComboBox.FormattingEnabled = true;
            this.grossMotorRecComboBox.Location = new System.Drawing.Point(221, 147);
            this.grossMotorRecComboBox.Name = "grossMotorRecComboBox";
            this.grossMotorRecComboBox.Size = new System.Drawing.Size(65, 29);
            this.grossMotorRecComboBox.TabIndex = 4;
            // 
            // commRecComboBox
            // 
            this.commRecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commRecComboBox.FormattingEnabled = true;
            this.commRecComboBox.Location = new System.Drawing.Point(221, 112);
            this.commRecComboBox.Name = "commRecComboBox";
            this.commRecComboBox.Size = new System.Drawing.Size(65, 29);
            this.commRecComboBox.TabIndex = 2;
            // 
            // persSocTextBox
            // 
            this.persSocTextBox.Location = new System.Drawing.Point(164, 252);
            this.persSocTextBox.Name = "persSocTextBox";
            this.persSocTextBox.Size = new System.Drawing.Size(51, 29);
            this.persSocTextBox.TabIndex = 9;
            // 
            // persSocLabel
            // 
            this.persSocLabel.AutoSize = true;
            this.persSocLabel.Location = new System.Drawing.Point(39, 255);
            this.persSocLabel.Name = "persSocLabel";
            this.persSocLabel.Size = new System.Drawing.Size(119, 21);
            this.persSocLabel.TabIndex = 0;
            this.persSocLabel.Text = "Personal-Social:";
            // 
            // probSolvTextBox
            // 
            this.probSolvTextBox.Location = new System.Drawing.Point(164, 217);
            this.probSolvTextBox.Name = "probSolvTextBox";
            this.probSolvTextBox.Size = new System.Drawing.Size(51, 29);
            this.probSolvTextBox.TabIndex = 7;
            // 
            // probSolvLabel
            // 
            this.probSolvLabel.AutoSize = true;
            this.probSolvLabel.Location = new System.Drawing.Point(30, 220);
            this.probSolvLabel.Name = "probSolvLabel";
            this.probSolvLabel.Size = new System.Drawing.Size(128, 21);
            this.probSolvLabel.TabIndex = 0;
            this.probSolvLabel.Text = "Problem Solving:";
            // 
            // fineMotorTextBox
            // 
            this.fineMotorTextBox.Location = new System.Drawing.Point(164, 182);
            this.fineMotorTextBox.Name = "fineMotorTextBox";
            this.fineMotorTextBox.Size = new System.Drawing.Size(51, 29);
            this.fineMotorTextBox.TabIndex = 5;
            // 
            // fineMotorLabel
            // 
            this.fineMotorLabel.AutoSize = true;
            this.fineMotorLabel.Location = new System.Drawing.Point(69, 185);
            this.fineMotorLabel.Name = "fineMotorLabel";
            this.fineMotorLabel.Size = new System.Drawing.Size(89, 21);
            this.fineMotorLabel.TabIndex = 0;
            this.fineMotorLabel.Text = "Fine Motor:";
            // 
            // grossMotorTextBox
            // 
            this.grossMotorTextBox.Location = new System.Drawing.Point(164, 147);
            this.grossMotorTextBox.Name = "grossMotorTextBox";
            this.grossMotorTextBox.Size = new System.Drawing.Size(51, 29);
            this.grossMotorTextBox.TabIndex = 3;
            // 
            // grossMotorLabel
            // 
            this.grossMotorLabel.AutoSize = true;
            this.grossMotorLabel.Location = new System.Drawing.Point(58, 150);
            this.grossMotorLabel.Name = "grossMotorLabel";
            this.grossMotorLabel.Size = new System.Drawing.Size(100, 21);
            this.grossMotorLabel.TabIndex = 0;
            this.grossMotorLabel.Text = "Gross Motor:";
            // 
            // commTextBox
            // 
            this.commTextBox.Location = new System.Drawing.Point(164, 112);
            this.commTextBox.Name = "commTextBox";
            this.commTextBox.Size = new System.Drawing.Size(51, 29);
            this.commTextBox.TabIndex = 1;
            // 
            // commLabel
            // 
            this.commLabel.AutoSize = true;
            this.commLabel.Location = new System.Drawing.Point(34, 115);
            this.commLabel.Name = "commLabel";
            this.commLabel.Size = new System.Drawing.Size(124, 21);
            this.commLabel.TabIndex = 0;
            this.commLabel.Text = "Communication:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(329, 381);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(97, 42);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(445, 381);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 42);
            this.clearButton.TabIndex = 0;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.maleRadioButton);
            this.genderGroupBox.Controls.Add(this.femaleRadioButton);
            this.genderGroupBox.Location = new System.Drawing.Point(195, 152);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Size = new System.Drawing.Size(155, 58);
            this.genderGroupBox.TabIndex = 4;
            this.genderGroupBox.TabStop = false;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(125, 175);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(64, 21);
            this.genderLabel.TabIndex = 0;
            this.genderLabel.Text = "Gender:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectExcelFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectExcelFileToolStripMenuItem
            // 
            this.selectExcelFileToolStripMenuItem.Name = "selectExcelFileToolStripMenuItem";
            this.selectExcelFileToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.selectExcelFileToolStripMenuItem.Text = "Select Excel File";
            this.selectExcelFileToolStripMenuItem.Click += new System.EventHandler(this.SelectExcelFileToolStripMenuItem_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 445);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 21);
            this.statusLabel.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 475);
            this.Controls.Add(this.statusLabel);
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
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "ASQ Data Entry";
            this.scoresGroupBox.ResumeLayout(false);
            this.scoresGroupBox.PerformLayout();
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private TextBox persSocTextBox;
        private Label persSocLabel;
        private TextBox probSolvTextBox;
        private Label probSolvLabel;
        private TextBox fineMotorTextBox;
        private Label fineMotorLabel;
        private TextBox grossMotorTextBox;
        private Label grossMotorLabel;
        private TextBox commTextBox;
        private Label commLabel;
        private Button submitButton;
        private Button clearButton;
        private GroupBox genderGroupBox;
        private Label genderLabel;
        private ComboBox commRecComboBox;
        private ComboBox persSocRecComboBox;
        private ComboBox probSolvRecComboBox;
        private ComboBox fineMotorRecComboBox;
        private ComboBox grossMotorRecComboBox;
        private Label recLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem selectExcelFileToolStripMenuItem;
        private Label statusLabel;
    }
}
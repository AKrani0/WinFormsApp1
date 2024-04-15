namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtShowGradesStudentNumber;
        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreateStudent = new Button();
            btnDisplayStudents = new Button();
            lstStudents = new ListBox();
            txtStudentNumber = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            lblStudentNumber = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            btnCreateCourse = new Button();
            btnDisplayCourses = new Button();
            lstCourses = new ListBox();
            txtCourseNumber = new TextBox();
            txtCourseCode = new TextBox();
            txtCourseTitle = new TextBox();
            lblCourseCode = new Label();
            lblCourseTitle = new Label();
            btnEnterGrade = new Button();
            btnShowGrades = new Button();
            lstGrades = new ListBox();
            txtGradeStudentNumber = new TextBox();
            txtGradeCourseNumber = new TextBox();
            txtGrade = new TextBox();
            lblGradeStudentNumber = new Label();
            lblGradeCourseNumber = new Label();
            lblGrade = new Label();
            btnSaveTranscript = new Button();
            txtTranscriptStudentNumber = new TextBox();
            lblTranscriptStudentNumber = new Label();
            txtShowGradesStudentNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCreateStudent
            // 
            btnCreateStudent.Location = new Point(539, 78);
            btnCreateStudent.Name = "btnCreateStudent";
            btnCreateStudent.Size = new Size(133, 35);
            btnCreateStudent.TabIndex = 0;
            btnCreateStudent.Text = "Create Student";
            btnCreateStudent.UseVisualStyleBackColor = true;
            btnCreateStudent.Click += btnCreateStudent_Click;
            // 
            // btnDisplayStudents
            // 
            btnDisplayStudents.Location = new Point(279, 135);
            btnDisplayStudents.Name = "btnDisplayStudents";
            btnDisplayStudents.Size = new Size(133, 35);
            btnDisplayStudents.TabIndex = 1;
            btnDisplayStudents.Text = "Display Students";
            btnDisplayStudents.UseVisualStyleBackColor = true;
            btnDisplayStudents.Click += btnDisplayStudents_Click;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.Location = new Point(11, 12);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(249, 224);
            lstStudents.TabIndex = 2;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new Point(360, 12);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(160, 27);
            txtStudentNumber.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(360, 45);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(160, 27);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(360, 78);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(160, 27);
            txtLastName.TabIndex = 5;
            // 
            // lblStudentNumber
            // 
            lblStudentNumber.AutoSize = true;
            lblStudentNumber.Location = new Point(279, 15);
            lblStudentNumber.Name = "lblStudentNumber";
            lblStudentNumber.Size = new Size(66, 20);
            lblStudentNumber.TabIndex = 6;
            lblStudentNumber.Text = "Number:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(279, 48);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(83, 20);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(279, 81);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(82, 20);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "Last Name:";
            // 
            // btnCreateCourse
            // 
            btnCreateCourse.Location = new Point(788, 228);
            btnCreateCourse.Name = "btnCreateCourse";
            btnCreateCourse.Size = new Size(133, 35);
            btnCreateCourse.TabIndex = 9;
            btnCreateCourse.Text = "Create Course";
            btnCreateCourse.UseVisualStyleBackColor = true;
            btnCreateCourse.Click += btnCreateCourse_Click;
            // 
            // btnDisplayCourses
            // 
            btnDisplayCourses.Location = new Point(302, 285);
            btnDisplayCourses.Name = "btnDisplayCourses";
            btnDisplayCourses.Size = new Size(133, 35);
            btnDisplayCourses.TabIndex = 10;
            btnDisplayCourses.Text = "Display Courses";
            btnDisplayCourses.UseVisualStyleBackColor = true;
            btnDisplayCourses.Click += btnDisplayCourses_Click;
            // 
            // lstCourses
            // 
            lstCourses.FormattingEnabled = true;
            lstCourses.Location = new Point(279, 195);
            lstCourses.Name = "lstCourses";
            lstCourses.Size = new Size(178, 84);
            lstCourses.TabIndex = 11;
            // 
            // txtCourseNumber
            // 
            txtCourseNumber.Location = new Point(588, 195);
            txtCourseNumber.Name = "txtCourseNumber";
            txtCourseNumber.Size = new Size(160, 27);
            txtCourseNumber.TabIndex = 12;
            // 
            // txtCourseCode
            // 
            txtCourseCode.Location = new Point(588, 228);
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.Size = new Size(160, 27);
            txtCourseCode.TabIndex = 13;
            // 
            // txtCourseTitle
            // 
            txtCourseTitle.Location = new Point(588, 261);
            txtCourseTitle.Name = "txtCourseTitle";
            txtCourseTitle.Size = new Size(160, 27);
            txtCourseTitle.TabIndex = 14;
            // 
            // lblCourseCode
            // 
            lblCourseCode.AutoSize = true;
            lblCourseCode.Location = new Point(531, 228);
            lblCourseCode.Name = "lblCourseCode";
            lblCourseCode.Size = new Size(47, 20);
            lblCourseCode.TabIndex = 16;
            lblCourseCode.Text = "Code:";
            // 
            // lblCourseTitle
            // 
            lblCourseTitle.AutoSize = true;
            lblCourseTitle.Location = new Point(537, 259);
            lblCourseTitle.Name = "lblCourseTitle";
            lblCourseTitle.Size = new Size(41, 20);
            lblCourseTitle.TabIndex = 17;
            lblCourseTitle.Text = "Title:";
            // 
            // btnEnterGrade
            // 
            btnEnterGrade.Location = new Point(773, 392);
            btnEnterGrade.Name = "btnEnterGrade";
            btnEnterGrade.Size = new Size(133, 35);
            btnEnterGrade.TabIndex = 18;
            btnEnterGrade.Text = "Enter Grade";
            btnEnterGrade.UseVisualStyleBackColor = true;
            btnEnterGrade.Click += btnEnterGrade_Click;
            // 
            // btnShowGrades
            // 
            btnShowGrades.Location = new Point(302, 441);
            btnShowGrades.Name = "btnShowGrades";
            btnShowGrades.Size = new Size(133, 35);
            btnShowGrades.TabIndex = 19;
            btnShowGrades.Text = "Show Grades";
            btnShowGrades.UseVisualStyleBackColor = true;
            btnShowGrades.Click += btnShowGrades_Click;
            // 
            // lstGrades
            // 
            lstGrades.FormattingEnabled = true;
            lstGrades.Location = new Point(279, 345);
            lstGrades.Name = "lstGrades";
            lstGrades.Size = new Size(178, 84);
            lstGrades.TabIndex = 20;
            // 
            // txtGradeStudentNumber
            // 
            txtGradeStudentNumber.Location = new Point(588, 345);
            txtGradeStudentNumber.Name = "txtGradeStudentNumber";
            txtGradeStudentNumber.Size = new Size(160, 27);
            txtGradeStudentNumber.TabIndex = 21;
            // 
            // txtGradeCourseNumber
            // 
            txtGradeCourseNumber.Location = new Point(588, 378);
            txtGradeCourseNumber.Name = "txtGradeCourseNumber";
            txtGradeCourseNumber.Size = new Size(160, 27);
            txtGradeCourseNumber.TabIndex = 22;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(588, 411);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(160, 27);
            txtGrade.TabIndex = 23;
            // 
            // lblGradeStudentNumber
            // 
            lblGradeStudentNumber.AutoSize = true;
            lblGradeStudentNumber.Location = new Point(457, 348);
            lblGradeStudentNumber.Name = "lblGradeStudentNumber";
            lblGradeStudentNumber.Size = new Size(121, 20);
            lblGradeStudentNumber.TabIndex = 24;
            lblGradeStudentNumber.Text = "Student Number:";
            // 
            // lblGradeCourseNumber
            // 
            lblGradeCourseNumber.AutoSize = true;
            lblGradeCourseNumber.Location = new Point(463, 378);
            lblGradeCourseNumber.Name = "lblGradeCourseNumber";
            lblGradeCourseNumber.Size = new Size(115, 20);
            lblGradeCourseNumber.TabIndex = 25;
            lblGradeCourseNumber.Text = "Course Number:";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(526, 414);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(52, 20);
            lblGrade.TabIndex = 26;
            lblGrade.Text = "Grade:";
            // 
            // btnSaveTranscript
            // 
            btnSaveTranscript.Location = new Point(279, 498);
            btnSaveTranscript.Name = "btnSaveTranscript";
            btnSaveTranscript.Size = new Size(133, 35);
            btnSaveTranscript.TabIndex = 27;
            btnSaveTranscript.Text = "Save Transcript";
            btnSaveTranscript.UseVisualStyleBackColor = true;
            btnSaveTranscript.Click += btnSaveTranscript_Click;
            // 
            // txtTranscriptStudentNumber
            // 
            txtTranscriptStudentNumber.Location = new Point(566, 503);
            txtTranscriptStudentNumber.Name = "txtTranscriptStudentNumber";
            txtTranscriptStudentNumber.Size = new Size(160, 27);
            txtTranscriptStudentNumber.TabIndex = 28;
            // 
            // lblTranscriptStudentNumber
            // 
            lblTranscriptStudentNumber.AutoSize = true;
            lblTranscriptStudentNumber.Location = new Point(430, 506);
            lblTranscriptStudentNumber.Name = "lblTranscriptStudentNumber";
            lblTranscriptStudentNumber.Size = new Size(121, 20);
            lblTranscriptStudentNumber.TabIndex = 29;
            lblTranscriptStudentNumber.Text = "Student Number:";
            // 
            // txtShowGradesStudentNumber
            // 
            txtShowGradesStudentNumber.Location = new Point(588, 445);
            txtShowGradesStudentNumber.Name = "txtShowGradesStudentNumber";
            txtShowGradesStudentNumber.Size = new Size(160, 27);
            txtShowGradesStudentNumber.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(461, 448);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 31;
            label1.Text = "Student Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 195);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 32;
            label2.Text = "Number:";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(931, 535);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtShowGradesStudentNumber);
            Controls.Add(lblTranscriptStudentNumber);
            Controls.Add(txtTranscriptStudentNumber);
            Controls.Add(btnSaveTranscript);
            Controls.Add(lblGrade);
            Controls.Add(lblGradeCourseNumber);
            Controls.Add(lblGradeStudentNumber);
            Controls.Add(txtGrade);
            Controls.Add(txtGradeCourseNumber);
            Controls.Add(txtGradeStudentNumber);
            Controls.Add(lstGrades);
            Controls.Add(btnShowGrades);
            Controls.Add(btnEnterGrade);
            Controls.Add(lblCourseTitle);
            Controls.Add(lblCourseCode);
            Controls.Add(txtCourseTitle);
            Controls.Add(txtCourseCode);
            Controls.Add(txtCourseNumber);
            Controls.Add(lstCourses);
            Controls.Add(btnDisplayCourses);
            Controls.Add(btnCreateCourse);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblStudentNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtStudentNumber);
            Controls.Add(lstStudents);
            Controls.Add(btnDisplayStudents);
            Controls.Add(btnCreateStudent);
            Name = "Form1";
            Text = "Student Grade Management App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button btnDisplayStudents;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnCreateCourse;
        private System.Windows.Forms.Button btnDisplayCourses;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.TextBox txtCourseNumber;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.Button btnEnterGrade;
        private System.Windows.Forms.Button btnShowGrades;
        private System.Windows.Forms.ListBox lstGrades;
        private System.Windows.Forms.TextBox txtGradeStudentNumber;
        private System.Windows.Forms.TextBox txtGradeCourseNumber;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblGradeStudentNumber;
        private System.Windows.Forms.Label lblGradeCourseNumber;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnSaveTranscript;
        private System.Windows.Forms.TextBox txtTranscriptStudentNumber;
        private System.Windows.Forms.Label lblTranscriptStudentNumber;
        private Label label1;
        private Label label2;
    }
}

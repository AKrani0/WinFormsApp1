using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<Grade> grades = new List<Grade>();

        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
            courses = new List<Course>();
            grades = new List<Grade>();
        }


        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            int studentNumber;
            if (!int.TryParse(txtStudentNumber.Text, out studentNumber))
            {
                MessageBox.Show("Please enter a valid student number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (students.Any(s => s.StudentNumber == studentNumber))
            {
                MessageBox.Show("Student number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            students.Add(new Student { StudentNumber = studentNumber, FirstName = firstName, LastName = lastName });

            MessageBox.Show("Student created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearStudentFields();
        }


        private void btnDisplayStudents_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();
            foreach (var student in students)
            {
                lstStudents.Items.Add(student);
            }
        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            int courseNumber;
            if (!int.TryParse(txtCourseNumber.Text, out courseNumber))
            {
                MessageBox.Show("Please enter a valid course number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string code = txtCourseCode.Text.Trim();
            string title = txtCourseTitle.Text.Trim();


            if (courses.Any(c => c.Code == code))
            {
                MessageBox.Show("Course code already exists. Please enter a unique course code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            courses.Add(new Course { CourseNumber = courseNumber, Code = code, Title = title });

            MessageBox.Show("Course created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearCourseFields();
        }


        private void btnDisplayCourses_Click(object sender, EventArgs e)
        {
            lstCourses.Items.Clear();
            foreach (var course in courses)
            {
                lstCourses.Items.Add(course);
            }
        }

        private void btnEnterGrade_Click(object sender, EventArgs e)
        {
            int studentNumber;
            if (!int.TryParse(txtGradeStudentNumber.Text, out studentNumber))
            {
                MessageBox.Show("Please enter a valid student number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int courseNumber;
            if (!int.TryParse(txtGradeCourseNumber.Text, out courseNumber))
            {
                MessageBox.Show("Please enter a valid course number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double note;
            if (!double.TryParse(txtGrade.Text, out note))
            {
                MessageBox.Show("Please enter a valid grade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var student = students.Find(s => s.StudentNumber == studentNumber);
            if (student == null)
            {
                MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var course = courses.Find(c => c.CourseNumber == courseNumber);
            if (course == null)
            {
                MessageBox.Show("Course not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            grades.Add(new Grade { StudentNumber = studentNumber, CourseNumber = courseNumber, Note = note });

            MessageBox.Show("Grade entered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearGradeFields();
        }


        private void btnShowGrades_Click(object sender, EventArgs e)
        {
            lstGrades.Items.Clear();
            int studentNumber;
            if (!int.TryParse(txtShowGradesStudentNumber.Text, out studentNumber))
            {
                MessageBox.Show("Please enter a valid student number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var grade in grades)
            {
                if (grade.StudentNumber == studentNumber)
                {
                    lstGrades.Items.Add($"Course: {grade.CourseNumber}, Grade: {grade.Note}");
                }
            }
        }

        private void btnSaveTranscript_Click(object sender, EventArgs e)
        {
            int studentNumber;
            if (!int.TryParse(txtTranscriptStudentNumber.Text, out studentNumber))
            {
                MessageBox.Show("Please enter a valid student number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var student = students.Find(s => s.StudentNumber == studentNumber);
            if (student != null)
            {
                string folderPath = Application.StartupPath;
                string fileName = $"transcript_{student.StudentNumber}.txt";
                string filePath = Path.Combine(folderPath, fileName);

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"Student Number: {student.StudentNumber}");
                    writer.WriteLine($"Name: {student.FirstName} {student.LastName}");
                    writer.WriteLine();
                    writer.WriteLine("Grades:");
                    foreach (var grade in grades)
                    {
                        if (grade.StudentNumber == student.StudentNumber)
                        {
                            writer.WriteLine($"Course: {grade.CourseNumber}, Grade: {grade.Note}");
                        }
                    }
                }

                string message = $"Transcript saved for student {student.StudentNumber} ({student.FirstName} {student.LastName}).\n\n";
                message += "Grades:\n";
                foreach (var grade in grades)
                {
                    if (grade.StudentNumber == student.StudentNumber)
                    {
                        message += $"Course: {grade.CourseNumber}, Grade: {grade.Note}\n";
                    }
                }

                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void ClearStudentFields()
        {
            txtStudentNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
        }

        private void ClearCourseFields()
        {
            txtCourseNumber.Clear();
            txtCourseCode.Clear();
            txtCourseTitle.Clear();
        }

        private void ClearGradeFields()
        {
            txtGradeStudentNumber.Clear();
            txtGradeCourseNumber.Clear();
            txtGrade.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

    public class Student
    {
        public int StudentNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public override string ToString()
        {
            return $"{StudentNumber} - {FirstName} {LastName}";
        }
    }

    public class Course
    {
        public int CourseNumber { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return $"{CourseNumber} - {Title}";
        }
    }

    public class Grade
    {
        public int StudentNumber { get; set; }
        public int CourseNumber { get; set; }
        public double Note { get; set; }
    }
}
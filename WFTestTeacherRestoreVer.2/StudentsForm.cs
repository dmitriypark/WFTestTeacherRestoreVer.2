using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFTestTeacherRestoreVer._2.Models;

namespace WFTestTeacherRestoreVer._2
{
    public partial class StudentsForm : Form
    {
        User user;
        IEnumerable<HandbookStudents> students;
        public StudentsForm(User user, IEnumerable<HandbookStudents> students)
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                // ВАЖНО: Устанавливать язык нужно до создания элементов формы!
                // Это можно сделать глобально, в рамках приложения в классе Program (см. файл Program.cs).
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }
            InitializeComponent();
            this.user = user;
            this.students = students;
            dataGridView.AllowUserToAddRows = false;
            
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.ReadOnly = true;




            var cbStudentGrade = students.ToList().GroupBy(s => s.gradeNumberName).Where(r => r.Count() > 1);
            foreach (var student in cbStudentGrade)
            {
                if (student.Key.ToString() != " ")
                    cbGrade.Items.Add(student.Key);

            }


            var cbStudentName = students.ToList();
            foreach (var student in cbStudentName)
            {
                cbName.Items.Add(student.userName);
            }


            var cbStudetnSubject = students.ToList().GroupBy(s => s.subject).Where(r => r.Count() > 1);
            foreach (var student in cbStudetnSubject)
            {
                if (student.Key.ToString() != " ")
                    cbSubject.Items.Add(student.Key);
            }

            var cbStudentTest = students.ToList().GroupBy(s => s.test).Where(r => r.Count() > 1);
            foreach (var student in cbStudentTest)
            {
                if (student.Key != " ")
                    cbTest.Items.Add(student.Key);
            }



            foreach (var student in students)
            {




                var rowNumber = dataGridView.Rows.Add();
                dataGridView.Rows[rowNumber].Cells["Grade"].Value = student.gradeNumberName;
                dataGridView.Rows[rowNumber].Cells["studentName"].Value = student.userName;
                dataGridView.Rows[rowNumber].Cells["Subject"].Value = student.subject;
                dataGridView.Rows[rowNumber].Cells["Test"].Value = student.test;
                dataGridView.Rows[rowNumber].Cells["taskId"].Value = student.taskId;
                dataGridView.Rows[rowNumber].Cells["DateStart"].Value = student.taskStart;
                if (student.taskSum >= student.taskPas && student.taskSum != -1)
                {
                    dataGridView.Rows[rowNumber].Cells["Pass"].Value = "Yes";
                }
                else
                {
                    dataGridView.Rows[rowNumber].Cells["Pass"].Value = "No";
                }

            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            IEnumerable<HandbookStudents> tempStudents;


            tempStudents = students;
            if (chbGrade.Checked == true)
                tempStudents = tempStudents.ToList().Where(s => s.gradeNumberName == cbGrade.Text);
            if (chbName.Checked == true)
                tempStudents = tempStudents.ToList().Where(s => s.userName == cbName.Text);
            if (chbSubject.Checked == true)
                tempStudents = tempStudents.ToList().Where(s => s.subject == cbSubject.Text);
            if (chbTest.Checked == true)
                tempStudents = tempStudents.ToList().Where(s => s.test == cbTest.Text);


            dataGridView.Rows.Clear();

            foreach (var student in tempStudents)
            {




                var rowNumber = dataGridView.Rows.Add();
                dataGridView.Rows[rowNumber].Cells["Grade"].Value = student.gradeNumberName;
                dataGridView.Rows[rowNumber].Cells["studentName"].Value = student.userName;
                dataGridView.Rows[rowNumber].Cells["Subject"].Value = student.subject;
                dataGridView.Rows[rowNumber].Cells["Test"].Value = student.test;

                if (student.taskSum >= student.taskPas && student.taskSum != -1)
                {
                    dataGridView.Rows[rowNumber].Cells["Pass"].Value = "Yes";
                }
                else
                {
                    dataGridView.Rows[rowNumber].Cells["Pass"].Value = "No";
                }

            }
        }

        private void chbGrade_CheckedChanged(object sender, EventArgs e)
        {
            if (chbGrade.Checked == true)
            {
                cbName.Items.Clear();
                var cbStudentName = students.ToList().Where(s => s.gradeNumberName == cbGrade.Text);
                foreach (var student in cbStudentName)
                {
                    cbName.Items.Add(student.userName);
                }
            }
            else
            {
                cbName.Items.Clear();
                var cbStudentName = students.ToList();
                foreach (var student in cbStudentName)
                {
                    cbName.Items.Add(student.userName);
                }
            }
        }

        private void chbName_CheckedChanged(object sender, EventArgs e)
        {
            if (chbName.Checked == true)
            {
                cbGrade.Items.Clear();
                if (cbName.Text != "")
                    cbGrade.Text = students.ToList().Where(s => s.userName == cbName.Text).FirstOrDefault().gradeNumberName;
            }
            else
            {
                cbGrade.Items.Clear();
                var cbStudentGrade = students.ToList().GroupBy(s => s.gradeNumberName).Where(r => r.Count() > 1);
                foreach (var student in cbStudentGrade)
                {
                    if (student.Key.ToString() != " ")
                        cbGrade.Items.Add(student.Key);

                }
            }
        }

        private void chbSubject_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSubject.Checked == true)
            {
                cbTest.Items.Clear();
                var cbStudentTest = students.ToList().Where(s => s.subject == cbSubject.Text).GroupBy(r => r.test).Where(d => d.Count() > 1);
                foreach (var student in cbStudentTest)
                {
                    cbTest.Items.Add(student.Key);
                }
            }
            else
            {
                cbTest.Items.Clear();
                var cbStudentTest = students.ToList().GroupBy(s => s.test).Where(r => r.Count() > 1);
                foreach (var student in cbStudentTest)
                {
                    if (student.Key != " ")
                        cbTest.Items.Add(student.Key);
                }
            }
        }

        private void chbTest_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTest.Checked == true)
            {
                cbSubject.Items.Clear();
                if (cbTest.Text != "")
                    cbSubject.Text = students.ToList().Where(s => s.test == cbTest.Text).FirstOrDefault().subject;
            }
            else
            {
                cbSubject.Items.Clear();
                var cbStudetnSubject = students.ToList().GroupBy(s => s.subject).Where(r => r.Count() > 1);
                foreach (var student in cbStudetnSubject)
                {
                    if (student.Key.ToString() != " ")
                        cbSubject.Items.Add(student.Key);
                }
            }
        }

        private async void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();

            var student = students.ToList().Where(s => s.gradeNumberName == dataGridView.Rows[e.RowIndex].Cells["Grade"].FormattedValue.ToString() && s.userName == dataGridView.Rows[e.RowIndex].Cells["studentName"].FormattedValue.ToString() && s.taskId == Int32.Parse(dataGridView.Rows[e.RowIndex].Cells["taskId"].FormattedValue.ToString())).FirstOrDefault();
            await applicationViewModel.GetStudentTest(user.Login, user.Password, student.userId, student.testId, student.taskId);

            StudentFormTestForm studentFormTestForm = new StudentFormTestForm(student, applicationViewModel.handbookStudentTests);
            studentFormTestForm.Show();
        }

        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            chbGrade.Checked = true;
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            chbName.Checked = true;
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            chbSubject.Checked = true;
        }

        private void cbTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            chbTest.Checked = true;
        }
    }
}

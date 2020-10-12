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
    public partial class SubjectsForm : Form
    {
        User user;
        public SubjectsForm(User user, IEnumerable<HandbookSubjects> handbookSubjects)
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
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.ReadOnly = true;
            foreach (var subject in handbookSubjects)
            {

                var rowNumber = dataGridView.Rows.Add();
                dataGridView.Rows[rowNumber].Cells["Id"].Value = subject.Id;
                dataGridView.Rows[rowNumber].Cells["subjectName"].Value = subject.Name;
                dataGridView.Rows[rowNumber].Cells["Grade"].Value = subject.Grade;
                dataGridView.Rows[rowNumber].Cells["GradeNumber"].Value = subject.GradeNumber;
                dataGridView.Rows[rowNumber].Cells["GradeName"].Value = subject.GradeName;

            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            await applicationViewModel.GetGrades(user.Login, user.Password);
            AddSubjectForm subjectsForm = new AddSubjectForm(user, applicationViewModel.handbookGrades, this);
            subjectsForm.Show();
        }

        private async void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string Name = dataGridView.Rows[e.RowIndex].Cells["subjectName"].FormattedValue.ToString();
            string GradeId = dataGridView.Rows[e.RowIndex].Cells["Grade"].FormattedValue.ToString();
            string Id = dataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            await applicationViewModel.GetGrades(user.Login, user.Password);
            AddSubjectForm gradeForm = new AddSubjectForm(user, applicationViewModel.handbookGrades, this,Id,Name,GradeId);
            gradeForm.Show();
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.txtId.Text = dataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
        }

        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(MyStrings.Sure, "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool success;
                HandbookSubjects handbookSubjects = new HandbookSubjects();
                int id = Int32.Parse(txtId.Text);
                ApplicationViewModel applicationViewModel = new ApplicationViewModel();
                success = await applicationViewModel.DeleteSubject(user.Login, user.Password, id);

                dataGridView.Rows.Clear();
                await applicationViewModel.GetSubjects(user.Login, user.Password);

                foreach (var subject in applicationViewModel.handbookSubjects)
                {
                    var rowNumber = dataGridView.Rows.Add();
                    dataGridView.Rows[rowNumber].Cells["Id"].Value = subject.Id;
                    dataGridView.Rows[rowNumber].Cells["subjectName"].Value = subject.Name;
                    dataGridView.Rows[rowNumber].Cells["Grade"].Value = subject.Grade;
                    dataGridView.Rows[rowNumber].Cells["GradeNumber"].Value = subject.GradeNumber;
                    dataGridView.Rows[rowNumber].Cells["GradeName"].Value = subject.GradeName;
                }

                if (success)
                {
                    MessageBox.Show(MyStrings.Delete);
                }
                else
                {
                    MessageBox.Show(MyStrings.Cant);
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}

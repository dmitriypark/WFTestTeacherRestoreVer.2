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
    public partial class AddSubjectForm : Form
    {
        User user;
        IEnumerable<HandbookGrade> grades;
        HandbookGrade grade;
        SubjectsForm SubjectForm;
        public AddSubjectForm(User user, IEnumerable<HandbookGrade> grades,SubjectsForm SubjectForm)
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                // ВАЖНО: Устанавливать язык нужно до создания элементов формы!
                // Это можно сделать глобально, в рамках приложения в классе Program (см. файл Program.cs).
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }
            InitializeComponent();
            cmbGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            this.user = user;
            this.grades = grades;
            this.SubjectForm = SubjectForm;
            
            foreach (var grade in grades)
            {
                
                    cmbGrade.Items.Add(grade.Number+grade.Name);

            }

            cmbGrade.SelectedIndexChanged += delegate
             {
                 var index = cmbGrade.SelectedIndex;
                 var list = grades.ToList();
                 this.grade = list[index];
             };
        }


        public AddSubjectForm(User user, IEnumerable<HandbookGrade> grades, SubjectsForm SubjectForm,string id,string name,string gradeId)
        {
            

            InitializeComponent();
            cmbGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            this.user = user;
            this.grades = grades;
            this.SubjectForm = SubjectForm;

            

            txtId.Text = id;
            txtName.Text = name;
            var grade = grades.ToList().Where(g => g.Id == Int32.Parse(gradeId)).FirstOrDefault();
            
            this.grade = grade;
            var indexOfIntegerValue = grades.ToList().IndexOf(grade);


            foreach (var grade2 in grades)
            {

                cmbGrade.Items.Add(grade2.Number + grade2.Name);

            }

            cmbGrade.SelectedIndexChanged += delegate
            {
                var index = cmbGrade.SelectedIndex;
                var list = grades.ToList();
                this.grade = list[index];
            };

            cmbGrade.SelectedItem = cmbGrade.Items[indexOfIntegerValue];
            

           
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {

            

            var grade = this.grade;

            




            HandbookSubjects handbookSubjects = new HandbookSubjects();
            if (txtId.Text != "")
            {
                handbookSubjects.Id = Int32.Parse(txtId.Text);
            }
            handbookSubjects.Name = txtName.Text;
            handbookSubjects.GradeNumber = grade.Number;
            handbookSubjects.GradeName = grade.Name;
            handbookSubjects.Grade = grade.Id;
            HandbookSubjectsService handbookSubjectsService = new HandbookSubjectsService();
            await handbookSubjectsService.Add(user.Login, user.Password, handbookSubjects);

            SubjectForm.dataGridView.Rows.Clear();
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            await applicationViewModel.GetSubjects(user.Login, user.Password);
            foreach (var subject in applicationViewModel.handbookSubjects)
            {
                var rowNumber = SubjectForm.dataGridView.Rows.Add();
                SubjectForm.dataGridView.Rows[rowNumber].Cells["Id"].Value = subject.Id;
                SubjectForm.dataGridView.Rows[rowNumber].Cells["subjectName"].Value = subject.Name;
                SubjectForm.dataGridView.Rows[rowNumber].Cells["Grade"].Value = subject.Grade;
                SubjectForm.dataGridView.Rows[rowNumber].Cells["GradeNumber"].Value = subject.GradeNumber;
                SubjectForm.dataGridView.Rows[rowNumber].Cells["GradeName"].Value = subject.GradeName;
            }
            this.Close();

        }
    }
}

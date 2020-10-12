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
    public partial class handbookForm : Form
    {
        User user;
        Boolean close = true;
        public handbookForm(User user)
        {
            // Если в настройках есть язык, устанавлияем его для текущего потока, в котором выполняется приложение.
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                // ВАЖНО: Устанавливать язык нужно до создания элементов формы!
                // Это можно сделать глобально, в рамках приложения в классе Program (см. файл Program.cs).
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }
            // Вызов создания элементов формы (создан Visual Studio автоматически)

            InitializeComponent();
            this.user = user;
        }

       

        private async void testsResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            await applicationViewModel.GetStudents(user.Login, user.Password);
            StudentsForm studentsForm = new StudentsForm(user, applicationViewModel.handbookStudents);
            studentsForm.Show();
        }

        private async void gradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            await applicationViewModel.GetGrades(user.Login, user.Password);
            GradeForm gradeForm = new GradeForm(user, applicationViewModel.handbookGrades);
            gradeForm.Show();
        }

        private void handbookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Properties.Settings.Default.Save();
            
            if (close)
            {
                Application.Exit();
            }

            close = true;        
            
        }

        private async void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            await applicationViewModel.GetSubjects(user.Login, user.Password);
            SubjectsForm subjectsForm = new SubjectsForm(user, applicationViewModel.handbookSubjects);
            subjectsForm.Show();
        }

        private async void testsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            await applicationViewModel.GetTests(user.Login, user.Password);
            await applicationViewModel.GetSubjects(user.Login, user.Password);
            TestForm testForm = new TestForm(user, applicationViewModel.handbookTests, applicationViewModel.handbookSubjects);
            testForm.Show();
        }

        private async void questionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            await applicationViewModel.GetQuestions(user.Login, user.Password);
            await applicationViewModel.GetTests(user.Login, user.Password);
            QuestionForm questionsForm = new QuestionForm(user, applicationViewModel.handbookTests, applicationViewModel.handbookQuestions);
            questionsForm.Show();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private async void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language= System.Globalization.CultureInfo.GetCultureInfo("en-US").Name;
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            await applicationViewModel.ChekTeacher(user.Login, user.Password);
            if (applicationViewModel.user != null)
            {
                close = false;
                this.Close();
                handbookForm handbookForm = new handbookForm(applicationViewModel.user);
                
                handbookForm.Show();
                
            }
        }

        private async void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language= System.Globalization.CultureInfo.GetCultureInfo("ru-RU").Name;
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            await applicationViewModel.ChekTeacher(user.Login, user.Password);
            if (applicationViewModel.user != null)
            {
                close = false;
                this.Close();
                handbookForm handbookForm = new handbookForm(applicationViewModel.user);

                handbookForm.Show();
                
            }
        }
    }
}

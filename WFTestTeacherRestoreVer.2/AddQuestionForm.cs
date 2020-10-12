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
    public partial class AddQuestionForm : Form
    {
        User user;
        HandbookTest test;
        QuestionForm questionForm;
        public AddQuestionForm(User user, HandbookTest test, QuestionForm questionForm)
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
            this.test = test;
            this.questionForm = questionForm;
        }



        public AddQuestionForm(User user, HandbookTest test, QuestionForm questionForm, QuestionDB question)
        {
            InitializeComponent();
            this.user = user;
            this.test = test;
            this.questionForm = questionForm;
            txtId.Text = question.Id.ToString();
            txtContent.Text = question.Content;
            txtAnswer.Text = question.Answer.ToString();
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            int i = 1;
            HandbookQuestionsService handbookQuestionsService = new HandbookQuestionsService();
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            QuestionDB question = new QuestionDB();
            if (txtId.Text != "")
            {
                question.Id = Int32.Parse(txtId.Text);
            }
            question.Content = txtContent.Text;
            question.Answer = Int32.Parse(txtAnswer.Text);
            question.Test = test.Id;
            await applicationViewModel.GetQuestions(user.Login, user.Password);

            if (applicationViewModel.handbookQuestions.ToList().Where(q => q.TestId == test.Id).Count() <= test.Quantity)
            {
                await handbookQuestionsService.Add(user.Login, user.Password, question);
                questionForm.dataGridView.Rows.Clear();

                await applicationViewModel.GetQuestions(user.Login, user.Password);
                var Questions = applicationViewModel.handbookQuestions.Where(q => q.TestId == test.Id).ToList();
                foreach (var questions in Questions)
                {

                    var rowNumber = questionForm.dataGridView.Rows.Add();
                    questionForm.dataGridView.Rows[rowNumber].Cells["Id"].Value = questions.Id;
                    questionForm.dataGridView.Rows[rowNumber].Cells["No"].Value = i++;
                    questionForm.dataGridView.Rows[rowNumber].Cells["TestId"].Value = questions.TestId;
                    questionForm.dataGridView.Rows[rowNumber].Cells["TestName"].Value = questions.TestName;
                    questionForm.dataGridView.Rows[rowNumber].Cells["TestQuantity"].Value = questions.TestQuantity;
                    questionForm.dataGridView.Rows[rowNumber].Cells["TestQuantityPass"].Value = questions.TestQuantityPass;
                    questionForm.dataGridView.Rows[rowNumber].Cells["SubjectId"].Value = questions.SubjectId;
                    questionForm.dataGridView.Rows[rowNumber].Cells["SubjectName"].Value = questions.SubjectName;
                    questionForm.dataGridView.Rows[rowNumber].Cells["GradeId"].Value = questions.GradeId;
                    questionForm.dataGridView.Rows[rowNumber].Cells["GradeNumber"].Value = questions.GradeNumber;
                    questionForm.dataGridView.Rows[rowNumber].Cells["Content"].Value = questions.Content;
                    questionForm.dataGridView.Rows[rowNumber].Cells["Answer"].Value = questions.Answer;

                }
                this.Close();

            }
            else
            {
                MessageBox.Show("cannot add, maximum number reached");
            }
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}

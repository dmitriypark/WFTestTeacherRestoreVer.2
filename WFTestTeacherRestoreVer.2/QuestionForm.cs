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
    public partial class QuestionForm : Form
    {
        User user;
        HandbookTest test;
        IEnumerable<HandbookTest> handbookTests;
        IEnumerable<HandbookQuestions> handbookQuestions;
        public QuestionForm(User user, IEnumerable<HandbookTest> handbookTests, IEnumerable<HandbookQuestions> handbookQuestions)
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
            this.handbookTests = handbookTests;
            this.handbookQuestions = handbookQuestions;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.ReadOnly = true;
            cbTest.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var test in handbookTests)
            {
                cbTest.Items.Add(test.Name);
            }
        }

        private async void cbTest_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int i = 1;
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            var index = cbTest.SelectedIndex;
            test = handbookTests.ToList()[index];
            lblGradeName.Visible = true;
            lblGradeName.Text = test.GradeName;
            lblGradeNumber.Visible = true;
            lblGradeNumber.Text = test.GradeNumber.ToString();
            lblSubjectName.Visible = true;
            lblSubjectName.Text = test.SubjectName;
            await applicationViewModel.GetQuestions(user.Login, user.Password);

            var Questions = applicationViewModel.handbookQuestions.Where(q => q.TestId == test.Id).ToList();
            dataGridView.Rows.Clear();
            foreach (var question in Questions)
            {

                var rowNumber = dataGridView.Rows.Add();
                dataGridView.Rows[rowNumber].Cells["Id"].Value = question.Id;
                dataGridView.Rows[rowNumber].Cells["No"].Value = i++;
                dataGridView.Rows[rowNumber].Cells["TestId"].Value = question.TestId;
                dataGridView.Rows[rowNumber].Cells["TestName"].Value = question.TestName;
                dataGridView.Rows[rowNumber].Cells["TestQuantity"].Value = question.TestQuantity;
                dataGridView.Rows[rowNumber].Cells["TestQuantityPass"].Value = question.TestQuantityPass;
                dataGridView.Rows[rowNumber].Cells["SubjectId"].Value = question.SubjectId;
                dataGridView.Rows[rowNumber].Cells["SubjectName"].Value = question.SubjectName;
                dataGridView.Rows[rowNumber].Cells["GradeId"].Value = question.GradeId;
                dataGridView.Rows[rowNumber].Cells["GradeNumber"].Value = question.GradeNumber;
                dataGridView.Rows[rowNumber].Cells["Content"].Value = question.Content;
                dataGridView.Rows[rowNumber].Cells["Answer"].Value = question.Answer;

            }
        }

        //private async void btnAdd_Click(object sender, EventArgs e)
        //{
        //    if (test != null)
        //    {
        //        ApplicationViewModel applicationViewModel = new ApplicationViewModel();
        //        await applicationViewModel.GetGrades(user.Login, user.Password);
        //        AddQuestionForm questionForm = new AddQuestionForm(user, test, this);
        //        questionForm.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Choose test");
        //    }
        //}

        private async void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            QuestionDB questionDB = new QuestionDB();
            questionDB.Id =Int32.Parse(dataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
            questionDB.Content = dataGridView.Rows[e.RowIndex].Cells["Content"].FormattedValue.ToString();
            questionDB.Answer = Int32.Parse(dataGridView.Rows[e.RowIndex].Cells["Answer"].FormattedValue.ToString());
            questionDB.Test = Int32.Parse(dataGridView.Rows[e.RowIndex].Cells["TestId"].FormattedValue.ToString());


            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            await applicationViewModel.GetGrades(user.Login, user.Password);
            AddQuestionForm questionForm = new AddQuestionForm(user, test, this, questionDB);
            questionForm.Show();
        }

        //private async void btnDelete_Click(object sender, EventArgs e)
        //{
        //    DialogResult dialogResult = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
        //    if (dialogResult == DialogResult.Yes)
        //    {
        //        int i = 1;
        //        bool success;

        //        int id = Int32.Parse(txtId.Text);
        //        ApplicationViewModel applicationViewModel = new ApplicationViewModel();
        //        success = await applicationViewModel.DeleteQuestion(user.Login, user.Password, id);

        //        dataGridView.Rows.Clear();


        //        await applicationViewModel.GetQuestions(user.Login, user.Password);
        //        foreach (var questions in applicationViewModel.handbookQuestions.ToList().Where(q => q.TestId == test.Id))
        //        {

        //            var rowNumber = dataGridView.Rows.Add();
        //            dataGridView.Rows[rowNumber].Cells["Id"].Value = questions.Id;
        //            dataGridView.Rows[rowNumber].Cells["No"].Value = i++;
        //            dataGridView.Rows[rowNumber].Cells["TestId"].Value = questions.TestId;
        //            dataGridView.Rows[rowNumber].Cells["TestName"].Value = questions.TestName;
        //            dataGridView.Rows[rowNumber].Cells["TestQuantity"].Value = questions.TestQuantity;
        //            dataGridView.Rows[rowNumber].Cells["TestQuantityPass"].Value = questions.TestQuantityPass;
        //            dataGridView.Rows[rowNumber].Cells["SubjectId"].Value = questions.SubjectId;
        //            dataGridView.Rows[rowNumber].Cells["SubjectName"].Value = questions.SubjectName;
        //            dataGridView.Rows[rowNumber].Cells["GradeId"].Value = questions.GradeId;
        //            dataGridView.Rows[rowNumber].Cells["GradeNumber"].Value = questions.GradeNumber;
        //            dataGridView.Rows[rowNumber].Cells["Content"].Value = questions.Content;
        //            dataGridView.Rows[rowNumber].Cells["Answer"].Value = questions.Answer;

        //        }

        //        if (success)
        //        {
        //            MessageBox.Show("Subject delete");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Subject cannot be deleted because other tables are linked to it");
        //        }

        //    }
        //    else if (dialogResult == DialogResult.No)
        //    {
        //        //do something else
        //    }
        //}

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.txtId.Text = dataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            if (test != null)
            {
                ApplicationViewModel applicationViewModel = new ApplicationViewModel();
                await applicationViewModel.GetGrades(user.Login, user.Password);
                AddQuestionForm questionForm = new AddQuestionForm(user, test, this);
                questionForm.Show();
            }
            else
            {
                MessageBox.Show("Choose test");
            }
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(MyStrings.Sure, "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int i = 1;
                bool success;

                int id = Int32.Parse(txtId.Text);
                ApplicationViewModel applicationViewModel = new ApplicationViewModel();
                success = await applicationViewModel.DeleteQuestion(user.Login, user.Password, id);

                dataGridView.Rows.Clear();


                await applicationViewModel.GetQuestions(user.Login, user.Password);
                foreach (var questions in applicationViewModel.handbookQuestions.ToList().Where(q => q.TestId == test.Id))
                {

                    var rowNumber = dataGridView.Rows.Add();
                    dataGridView.Rows[rowNumber].Cells["Id"].Value = questions.Id;
                    dataGridView.Rows[rowNumber].Cells["No"].Value = i++;
                    dataGridView.Rows[rowNumber].Cells["TestId"].Value = questions.TestId;
                    dataGridView.Rows[rowNumber].Cells["TestName"].Value = questions.TestName;
                    dataGridView.Rows[rowNumber].Cells["TestQuantity"].Value = questions.TestQuantity;
                    dataGridView.Rows[rowNumber].Cells["TestQuantityPass"].Value = questions.TestQuantityPass;
                    dataGridView.Rows[rowNumber].Cells["SubjectId"].Value = questions.SubjectId;
                    dataGridView.Rows[rowNumber].Cells["SubjectName"].Value = questions.SubjectName;
                    dataGridView.Rows[rowNumber].Cells["GradeId"].Value = questions.GradeId;
                    dataGridView.Rows[rowNumber].Cells["GradeNumber"].Value = questions.GradeNumber;
                    dataGridView.Rows[rowNumber].Cells["Content"].Value = questions.Content;
                    dataGridView.Rows[rowNumber].Cells["Answer"].Value = questions.Answer;

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
        }

    }
}

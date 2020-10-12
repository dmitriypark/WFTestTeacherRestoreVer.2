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
    public partial class TestForm : Form
    {
        User user;
        IEnumerable<HandbookTest> handbookTests;
        IEnumerable<HandbookSubjects> handbookSubjects;
        public TestForm(User user, IEnumerable<HandbookTest> handbookTests, IEnumerable<HandbookSubjects> handbookSubjects)
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
            this.handbookSubjects = handbookSubjects;
            this.handbookTests = handbookTests;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.ReadOnly = true;
            foreach (var test in handbookTests)
            {

                var rowNumber = dataGridView.Rows.Add();
                dataGridView.Rows[rowNumber].Cells["Id"].Value = test.Id;
                dataGridView.Rows[rowNumber].Cells["GradeName"].Value = test.GradeNumber.ToString() + test.GradeName;
                dataGridView.Rows[rowNumber].Cells["GradeId"].Value = test.GradeId;
                dataGridView.Rows[rowNumber].Cells["GradeNumber"].Value = test.GradeNumber;
                dataGridView.Rows[rowNumber].Cells["testName"].Value = test.Name;
                dataGridView.Rows[rowNumber].Cells["SubjectId"].Value = test.SubjectId;
                dataGridView.Rows[rowNumber].Cells["SubjectName"].Value = test.SubjectName;
                dataGridView.Rows[rowNumber].Cells["Quantity"].Value = test.Quantity;
                dataGridView.Rows[rowNumber].Cells["QuantityPass"].Value = test.QuantityPass;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTestForm testForm = new AddTestForm(user, handbookTests, handbookSubjects, this);
            testForm.Show();
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            HandbookTest handbookTest = new HandbookTest();
            handbookTest.GradeName = dataGridView.Rows[e.RowIndex].Cells["GradeName"].FormattedValue.ToString();
            handbookTest.GradeId = Int32.Parse(dataGridView.Rows[e.RowIndex].Cells["GradeId"].FormattedValue.ToString());
            handbookTest.GradeNumber = Int32.Parse(dataGridView.Rows[e.RowIndex].Cells["GradeNumber"].FormattedValue.ToString());
            handbookTest.Name = dataGridView.Rows[e.RowIndex].Cells["testName"].FormattedValue.ToString();
            handbookTest.SubjectName = dataGridView.Rows[e.RowIndex].Cells["SubjectName"].FormattedValue.ToString() + " " + dataGridView.Rows[e.RowIndex].Cells["GradeName"].FormattedValue.ToString();
            handbookTest.SubjectId =Int32.Parse(dataGridView.Rows[e.RowIndex].Cells["SubjectId"].FormattedValue.ToString());
            handbookTest.Quantity = Int32.Parse(dataGridView.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString());
            handbookTest.QuantityPass = Int32.Parse(dataGridView.Rows[e.RowIndex].Cells["QuantityPass"].FormattedValue.ToString());
            handbookTest.Id = Int32.Parse(dataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
            AddTestForm testForm = new AddTestForm(user, handbookTests, handbookSubjects, this, handbookTest);
            testForm.Show();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(MyStrings.Sure, "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool success;

                int id = Int32.Parse(txtId.Text);
                ApplicationViewModel applicationViewModel = new ApplicationViewModel();
                success = await applicationViewModel.DeleteTest(user.Login, user.Password, id);

                dataGridView.Rows.Clear();


                await applicationViewModel.GetTests(user.Login, user.Password);
                foreach (var t in applicationViewModel.handbookTests)
                {

                    var rowNumber = dataGridView.Rows.Add();
                    dataGridView.Rows[rowNumber].Cells["Id"].Value = t.Id;
                    dataGridView.Rows[rowNumber].Cells["GradeName"].Value = t.GradeNumber.ToString() + t.GradeName;
                    dataGridView.Rows[rowNumber].Cells["GradeId"].Value = t.GradeId;
                    dataGridView.Rows[rowNumber].Cells["GradeNumber"].Value = t.GradeNumber;
                    dataGridView.Rows[rowNumber].Cells["testName"].Value = t.Name;
                    dataGridView.Rows[rowNumber].Cells["SubjectId"].Value = t.SubjectId;
                    dataGridView.Rows[rowNumber].Cells["SubjectName"].Value = t.SubjectName;
                    dataGridView.Rows[rowNumber].Cells["Quantity"].Value = t.Quantity;
                    dataGridView.Rows[rowNumber].Cells["QuantityPass"].Value = t.QuantityPass;

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

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.txtId.Text = dataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
        }
    }
}

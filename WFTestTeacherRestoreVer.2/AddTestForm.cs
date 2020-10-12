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
    public partial class AddTestForm : Form
    {
        User user;
        TestForm testForm;
        HandbookSubjects subject;
        public AddTestForm(User user, IEnumerable<HandbookTest> handbookTests, IEnumerable<HandbookSubjects> handbookSubjects, TestForm testForm)
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                // ВАЖНО: Устанавливать язык нужно до создания элементов формы!
                // Это можно сделать глобально, в рамках приложения в классе Program (см. файл Program.cs).
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }
            InitializeComponent();
            cbSubjectAndGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            this.user = user;
            this.testForm = testForm;
            foreach (var subject in handbookSubjects)
            {

                cbSubjectAndGrade.Items.Add(subject.Name + " " + subject.GradeNumber + subject.GradeName);



            }

            cbSubjectAndGrade.SelectionChangeCommitted += delegate
            {
                var index = cbSubjectAndGrade.SelectedIndex;
                var list = handbookSubjects.ToList();
                subject = list[index];
            };
        }


        public AddTestForm(User user, IEnumerable<HandbookTest> handbookTests, IEnumerable<HandbookSubjects> handbookSubjects, TestForm testForm,HandbookTest handbookTest)
        {
            InitializeComponent();
            cbSubjectAndGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            this.user = user;
            this.testForm = testForm;
            this.txtId.Text = handbookTest.Id.ToString();
            this.txtSubjectId.Text = handbookTest.SubjectId.ToString();
            this.txtName.Text = handbookTest.Name.ToString();
            this.cbSubjectAndGrade.Text = handbookTest.SubjectName.ToString() + " "+ handbookTest.GradeName.ToString();
            this.txtQuantity.Text = handbookTest.Quantity.ToString();
            this.txtQuantityPass.Text = handbookTest.QuantityPass.ToString();
            subject = handbookSubjects.ToList().Where(s => s.Id == handbookTest.SubjectId).FirstOrDefault();

            var indexOfIntegerValue = handbookSubjects.ToList().IndexOf(subject);



            foreach (var subject in handbookSubjects)
            {

                cbSubjectAndGrade.Items.Add(subject.Name + " " + subject.GradeNumber + subject.GradeName);



            }

            cbSubjectAndGrade.SelectionChangeCommitted += delegate
            {
                var index = cbSubjectAndGrade.SelectedIndex;
                var list = handbookSubjects.ToList();
                subject = list[index];
            };

            cbSubjectAndGrade.SelectedItem = cbSubjectAndGrade.Items[indexOfIntegerValue];

        }



        private async void btnAdd_Click(object sender, EventArgs e)
        {
            TestDB test = new TestDB();
            if (txtId.Text != "Id")
            {
                test.Id = Int32.Parse(txtId.Text);
            }

            test.Name = txtName.Text;
            //if (txtSubjectId.Text != "SubjectId")
            //{
            //    test.Subject = Int32.Parse(txtSubjectId.Text);
            //}
            //else
            //{
            //    test.Subject = subject.Id;
            //}
            test.Subject = subject.Id;

            test.Quantity = Int32.Parse(txtQuantity.Text);
            test.QuantityPass = Int32.Parse(txtQuantityPass.Text);
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            await applicationViewModel.AddTest(user.Login, user.Password, test);

            testForm.dataGridView.Rows.Clear();
            await applicationViewModel.GetTests(user.Login, user.Password);
            foreach (var t in applicationViewModel.handbookTests)
            {

                var rowNumber = testForm.dataGridView.Rows.Add();
                testForm.dataGridView.Rows[rowNumber].Cells["Id"].Value = t.Id;
                testForm.dataGridView.Rows[rowNumber].Cells["GradeName"].Value = t.GradeNumber.ToString() + t.GradeName;
                testForm.dataGridView.Rows[rowNumber].Cells["GradeId"].Value = t.GradeId;
                testForm.dataGridView.Rows[rowNumber].Cells["GradeNumber"].Value = t.GradeNumber;
                testForm.dataGridView.Rows[rowNumber].Cells["testName"].Value = t.Name;
                testForm.dataGridView.Rows[rowNumber].Cells["SubjectId"].Value = t.SubjectId;
                testForm.dataGridView.Rows[rowNumber].Cells["SubjectName"].Value = t.SubjectName;
                testForm.dataGridView.Rows[rowNumber].Cells["Quantity"].Value = t.Quantity;
                testForm.dataGridView.Rows[rowNumber].Cells["QuantityPass"].Value = t.QuantityPass;

            }
            this.Close();
        }
    }
}

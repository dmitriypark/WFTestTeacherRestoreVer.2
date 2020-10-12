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
    public partial class AddGradeForm : Form
    {
        User user;
        GradeForm gradeForm;
        public AddGradeForm(User user, IEnumerable<HandbookGrade> handbookGrades, GradeForm gradeForm)
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
            this.gradeForm = gradeForm;
            

        }

        public AddGradeForm(User user, IEnumerable<HandbookGrade> handbookGrades, GradeForm gradeForm,string Id,string Number, string gradeName)
        {
            InitializeComponent();
            this.user = user;
            this.gradeForm = gradeForm;
            txtId.Text = Id;
            txtName.Text = gradeName;
            txtNumber.Text = Number;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            HandbookGrade handbookGrade = new HandbookGrade();
            if (txtId.Text != "Id")
            {
                handbookGrade.Id = Int32.Parse(txtId.Text);
            }
            handbookGrade.Name = txtName.Text;
            handbookGrade.Number = Int32.Parse(txtNumber.Text);
            HandbookGradeService handbookGradeService = new HandbookGradeService();
            await handbookGradeService.Add(user.Login, user.Password, handbookGrade);
            gradeForm.dataGridView.Rows.Clear();

            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            await applicationViewModel.GetGrades(user.Login, user.Password);
            foreach (var grade in applicationViewModel.handbookGrades)
            {

                var rowNumber = gradeForm.dataGridView.Rows.Add();
                gradeForm.dataGridView.Rows[rowNumber].Cells["Id"].Value = grade.Id;
                gradeForm.dataGridView.Rows[rowNumber].Cells["gradeName"].Value = grade.Name;
                gradeForm.dataGridView.Rows[rowNumber].Cells["Number"].Value = grade.Number;

            }
            this.Close();
        }
    }
}

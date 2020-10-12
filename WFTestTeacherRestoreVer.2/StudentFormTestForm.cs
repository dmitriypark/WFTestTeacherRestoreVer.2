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
    public partial class StudentFormTestForm : Form
    {
        public StudentFormTestForm(HandbookStudents student, IEnumerable<HandbookStudentTest> handbookStudentTest)
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                // ВАЖНО: Устанавливать язык нужно до создания элементов формы!
                // Это можно сделать глобально, в рамках приложения в классе Program (см. файл Program.cs).
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }
            InitializeComponent();
            this.Sname.Text = student.userName;
            this.SGrade.Text = student.gradeNumberName;
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.ReadOnly = true;
            foreach (var test in handbookStudentTest)
            {


                var rowNumber = dataGridView.Rows.Add();
                dataGridView.Rows[rowNumber].Cells["Question"].Value = test.QuestionContent;
                dataGridView.Rows[rowNumber].Cells["StudentAnswer"].Value = test.StudentAnswer;
                dataGridView.Rows[rowNumber].Cells["CorrectAnswer"].Value = test.CorrectAnswer;




            }
        }
    }
}

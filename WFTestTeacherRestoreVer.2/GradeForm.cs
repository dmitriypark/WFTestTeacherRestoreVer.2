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
    public partial class GradeForm : Form
    {
        User user;
        IEnumerable<HandbookGrade> handbookGrades;
        public GradeForm(User user, IEnumerable<HandbookGrade> handbookGrades)
        {
            // Если в настройках есть язык, устанавлияем его для текущего потока, в котором выполняется приложение.
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                // ВАЖНО: Устанавливать язык нужно до создания элементов формы!
                // Это можно сделать глобально, в рамках приложения в классе Program (см. файл Program.cs).
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }

            InitializeComponent();
            
            this.handbookGrades = handbookGrades;
            this.user = user;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.ReadOnly = true;
            foreach (var grade in handbookGrades)
            {

                var rowNumber = dataGridView.Rows.Add();
                dataGridView.Rows[rowNumber].Cells["Id"].Value = grade.Id;
                dataGridView.Rows[rowNumber].Cells["gradeName"].Value = grade.Name;
                dataGridView.Rows[rowNumber].Cells["Number"].Value = grade.Number;

            }
            
        }

        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            await applicationViewModel.GetGrades(user.Login, user.Password);
            AddGradeForm gradeForm = new AddGradeForm(user, applicationViewModel.handbookGrades,this);
            gradeForm.Show();
        }

        private async void btnDeleteGrade_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(MyStrings.Sure,"", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool success;

                int id = Int32.Parse(txtId.Text);
                ApplicationViewModel applicationViewModel = new ApplicationViewModel();
                success = await applicationViewModel.DeleteGrade(user.Login, user.Password, id);

                dataGridView.Rows.Clear();


                await applicationViewModel.GetGrades(user.Login, user.Password);
                foreach (var grade in applicationViewModel.handbookGrades)
                {

                    var rowNumber = dataGridView.Rows.Add();
                    dataGridView.Rows[rowNumber].Cells["Id"].Value = grade.Id;
                    dataGridView.Rows[rowNumber].Cells["gradeName"].Value = grade.Name;
                    dataGridView.Rows[rowNumber].Cells["Number"].Value = grade.Number;

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

        private async void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string Name= dataGridView.Rows[e.RowIndex].Cells["gradeName"].FormattedValue.ToString();
            string Number = dataGridView.Rows[e.RowIndex].Cells["Number"].FormattedValue.ToString();
            string Id= dataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            await applicationViewModel.GetGrades(user.Login, user.Password);
            AddGradeForm gradeForm = new AddGradeForm(user, applicationViewModel.handbookGrades, this,Id,Number,Name);
            gradeForm.Show();
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.txtId.Text = dataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
        }
    }
}

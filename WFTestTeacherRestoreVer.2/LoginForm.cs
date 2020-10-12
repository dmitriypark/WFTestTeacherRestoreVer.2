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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.LoginTxt.Text = "teacher";
            this.PasswordTxt.Text = "130730";
            PasswordTxt.UseSystemPasswordChar = true;
        }

        private async void btnEnter_Click(object sender, EventArgs e)
        {
            ApplicationViewModel applicationViewModel = new ApplicationViewModel();
            await applicationViewModel.ChekTeacher(LoginTxt.Text, PasswordTxt.Text);
            if (applicationViewModel.user != null)
            {

                handbookForm handbookForm = new handbookForm(applicationViewModel.user);

                handbookForm.Show();
                this.Hide();
            }
        }
    }
}

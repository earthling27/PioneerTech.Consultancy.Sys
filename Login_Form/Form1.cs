using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
            PassWord_textbox.PasswordChar = '*';
            PassWord_textbox.MaxLength = 16;
        }

        private void PassWord_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {

        }
    }
}

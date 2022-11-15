using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualityShims.Forms
{
    public partial class LoginForm : Form
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbUsername.Text) && !string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                var user = _context.Users.FirstOrDefault(x => x.Username == tbUsername.Text);
                if (user != null)
                {
                    if (user.Password == tbPassword.Text)
                    {
                        DialogResult = DialogResult.OK;
                        LoggedUser.Id = user.Id;
                        LoggedUser.FirstName = user.FirstName;
                        LoggedUser.LastName = user.LastName;
                        LoggedUser.IsAdministrator = user.IsAdministrator;
                    }
                    else
                    {
                        MessageBox.Show("Podaj poprawne dane");
                    }
                }
                else
                {
                    MessageBox.Show("Podaj poprawne dane");
                }
            }
            else
            {
                MessageBox.Show("Podaj nazwę użytkownika i hasło");
            }
        }
    }
}

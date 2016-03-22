using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using FSR.Entities;
using FSR.Repositories;
using FSR.DesktopUI.Code;
using FSR.Repositories.Interfaces;
using FSR.Repositories.Classes; 

namespace FSR.DesktopUI.Forms
{
    public partial class LoginForm : Form
    {
        #region Constructors

        public LoginForm()
        {
            _userRepository = new SqlUserRepository(ConfigurationManager.ConnectionStrings["FSR"].ConnectionString);

            InitializeComponent();
        }

        #endregion

        #region Methods

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = Encryptor.MD5Hash(txtPassword.Text);

            User user = _userRepository.GetUserByLogin(login, password);
            if (user == null)
            {
                MessageBox.Show(this, "Invalid user name or password", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CurrentUser.Initialize(user);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        #endregion

        #region Private Fields

        private readonly IUserRepository _userRepository;

        #endregion
    }
}

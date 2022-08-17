using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSystem.DAL;
using POSystem.GUI;
using POSystem.Validation;

namespace POSystem.GUI
{
    public partial class UserAdmin : Form
    {
        private bool accessAdmin = false;

        public UserAdmin()
        {
            InitializeComponent();
        }

        private void UserAdmin_Load(object sender, EventArgs e)
        {
            textBoxName.Focus();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            if(Validator.IsEmpty(textBoxName.Text) && Validator.IsEmpty(textBoxPassword.Text))
            {
                if (DA_departement.VerifyPassword(textBoxName.Text, textBoxPassword.Text))
                {
                    accessAdmin = true;
                    this.Close();
                }
                else
                    MessageBox.Show("Mauvais utilisateur, réessayez", "arrêt", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public bool adminAccess()
        {
            return accessAdmin;
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Validator.IsEmpty(textBoxName.Text) && Validator.IsEmpty(textBoxPassword.Text))
                {
                    btnLogin_Click(sender, e);
                    e.SuppressKeyPress = true;
                }
            }
        }
    }
}

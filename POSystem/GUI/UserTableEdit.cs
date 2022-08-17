using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSystem.BLL;
using POSystem.DAL;
using POSystem.Validation;

namespace POSystem.GUI
{
    public partial class UserTableEdit : Form
    {
        string nameUser;
        List<Users_List> userList = new List<Users_List>();

        public UserTableEdit()
        {
            InitializeComponent();
        }

        private void ClearAll()
        {
            textBoxName.Clear();
            textBoxPassword.Clear();
        }

        private void UserTableEdit_Load(object sender, EventArgs e)
        {
            DA_departement.Display_AdminUsers(listViewUsers);
            textBoxName.Focus();
        }

        private void btnSauvegardez_Click(object sender, EventArgs e)
        {
            if(Validator.IsEmpty(textBoxName.Text) && Validator.IsEmpty(textBoxPassword.Text))
            {
                if (Validator.IsValidPass(textBoxPassword.Text))
                {
                    if (Validator.IsExist(textBoxName.Text))
                    {
                        MessageBox.Show("Le nom existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Users_List listUser = new Users_List(textBoxName.Text, textBoxPassword.Text);
                        DA_departement.SaveUsers(listUser);
                        MessageBox.Show("Enregistré avec succès", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                        DA_departement.Display_AdminUsers(listViewUsers);
                    }
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxName.Text) && Validator.IsEmpty(textBoxPassword.Text))
            {
                if (Validator.IsValidPass(textBoxPassword.Text))
                {
                    Users_List listUser = new Users_List(textBoxName.Text, textBoxPassword.Text);
                    DA_departement.UpdateUsers(listUser, nameUser);
                    MessageBox.Show("Modifié avec succès", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                    DA_departement.Display_AdminUsers(listViewUsers);
                }
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxPassword.Clear();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxName.Text) && Validator.IsEmpty(textBoxPassword.Text))
            {
                DialogResult = MessageBox.Show("Etes-vous sûr que vous voulez supprimer", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (DialogResult == DialogResult.Yes)
                {
                    DA_departement.DeleteUsers(textBoxName.Text);
                    MessageBox.Show("Supprimé avec succès", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                    DA_departement.Display_AdminUsers(listViewUsers);
                }
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listViewUsers.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                if (textBoxName.Text == item.Text)
                {
                    MessageBox.Show("Nom a été sélectionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] nomPass = DA_departement.ShowNomPass(item.Text);
                    nameUser = nomPass[0];
                    textBoxName.Text = nomPass[0];
                    textBoxPassword.Text = nomPass[1];
                }
            }
            else
            {
                this.listViewUsers.SelectedItems.Clear();
                MessageBox.Show("Aucun élément n'est sélectionné", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

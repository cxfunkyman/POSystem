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
using POSystem.Validation;

namespace POSystem.GUI
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewListPO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            DA_listePO.Display_ListePO(listViewListPO);
        }

        private void comboBoxListeDepartement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxListeDepartement.SelectedIndex == 0)
                DA_listePO.Display_ListePO(listViewListPO);
            
            else 
            DA_ListForm.ComboBoxIndex(comboBoxListeDepartement.SelectedIndex, listViewListPO);   
        }

        private void comboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxRecherche.Text))
            {
                DA_ListForm.SearchByCB(comboBoxSearchBy.SelectedIndex, listViewListPO, textBoxRecherche.Text);
            }
        }

        private void textBoxRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Validator.IsEmpty(textBoxRecherche.Text))
                {
                    btnRecherche_Click(sender, e);
                    e.SuppressKeyPress = true;
                }
            }
        }
    }
}

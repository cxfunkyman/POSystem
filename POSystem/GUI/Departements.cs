using POSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSystem.Validation;
using POSystem.BLL;

namespace POSystem.GUI
{
    public partial class Departements : Form
    {
        List<Departement_List> deptList = new List<Departement_List>();
        string approbationName;

        public Departements()
        {
            InitializeComponent();
        }

        private void EffaceChamps()// clear all the texbox and set the radiobutton to default and textbox montant to default
        {
            textBoxDepartement.Clear();
            textBoxApprobation.Clear();
            textBoxMontant.Text = "CAD$";
            radioButtonCAD.Checked = true;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxApprobation.Text) && Validator.IsEmpty(textBoxMontant.Text) && Validator.IsEmpty(textBoxDepartement.Text)) //check if the textbox are empty
            {                
                Departement_List listDept = new Departement_List(textBoxDepartement.Text, textBoxApprobation.Text, textBoxMontant.Text); //call parametirized constructor for departement
                DA_departement.updateDetailsDept(listDept, approbationName); //process to update fields               
                MessageBox.Show("Modifié avec succès", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DA_listePO.Display_department(listViewDepartementD); //refresh the values in the listview
                EffaceChamps();
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            EffaceChamps();

        }

        private void btnNewApprovation_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxApprobation.Text) && Validator.IsEmpty(textBoxMontant.Text) && Validator.IsEmpty(textBoxDepartement.Text))//check if the textbox are empty
            {
                Departement_List listDept = new Departement_List(textBoxDepartement.Text, textBoxApprobation.Text, textBoxMontant.Text);//call parametirized constructor for departement
                DA_departement.SaveDept(listDept);      //process to save values in the database           
                MessageBox.Show("Enregistré avec succès", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DA_listePO.Display_department(listViewDepartementD);
                EffaceChamps();
            }
        }

        private void Departements_Load(object sender, EventArgs e)
        {
            // loads data into the 'dataSet1.Dept_dept' table
            this.dept_deptTableAdapter.Fill(this.dataSet1.Dept_dept);
            // loads data into the 'dataSetDept.departements_test' table
            this.departements_testTableAdapter.Fill(this.dataSetDept.departements_test);
            DA_listePO.Display_department(listViewDepartementD);
            if (radioButtonCAD.Checked == true)
                textBoxMontant.Text = "CAD$";
        }

        private void comboBoxListeDepartement_SelectedIndexChanged(object sender, EventArgs e)
        {
            int gestionnaireChoice = comboBoxListeDepartement.SelectedIndex; //combobox filter change index option
            string selected = comboBoxListeDepartement.Text;

            DA_listePO.Display_department(listViewDepartementD, selected);
        }

        private void listViewDepartementD_MouseDoubleClick(object sender, MouseEventArgs e)//activate double click on the listview to select the approvation field
        {
            ListViewHitTestInfo info = listViewDepartementD.HitTest(e.X, e.Y);//find the position of the mouse where the dobleclick event ocurred
            ListViewItem item = info.Item;//set the value to the item view

            if (item != null)
            {
                if (textBoxDepartement.Text == item.SubItems[0].Text && textBoxApprobation.Text == item.SubItems[1].Text && textBoxMontant.Text == item.SubItems[2].Text)//check if the textbox already have the filed selected
                {
                    MessageBox.Show("Nom a été sélectionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxDepartement.Text == "" || textBoxApprobation.Text == "" || textBoxMontant.Text == "")//if texbox approbe is empty set the value selected
                {
                    approbationName = item.SubItems[1].Text;
                    textBoxDepartement.Text = item.SubItems[0].Text;
                    textBoxApprobation.Text = item.SubItems[1].Text;
                    textBoxMontant.Text = item.SubItems[2].Text;                    
                }
                else
                {
                    DialogResult result = MessageBox.Show("Voulez-vous modifier votre sélection",
                        "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   
                    if (result == DialogResult.Yes)
                    {
                        textBoxDepartement.Text = item.SubItems[0].Text;
                        textBoxApprobation.Text = item.SubItems[1].Text;
                        textBoxMontant.Text = item.SubItems[2].Text;
                    }

                }
            }
            else
            {
                this.listViewDepartementD.SelectedItems.Clear();
                MessageBox.Show("No Item is selected", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonSansLimite_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMontant.Text = "Sans Limite";
        }

        private void radioButtonCAD_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMontant.Text = "CAD$";
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            DA_listePO.Display_department(listViewDepartementD);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.departements_testTableAdapter.FillBy(this.dataSetDept.departements_test);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.departements_testTableAdapter.FillBy(this.dataSetDept.departements_test);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

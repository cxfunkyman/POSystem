using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using POSystem.DAL;
using POSystem.Validation;
using POSystem.BLL;

namespace POSystem
{
    public partial class POsystem : Form
    {
        List<PO_List> POList = new List<PO_List>(); //Call bussines layer for the PO data management
        
        public POsystem()
        {
            InitializeComponent();           
        }

        public void ClearDetails() //Clear textBox details
        {
            textBoxFournisseur.Clear();
            textBoxDemandePar.Clear();
            textBoxSoumission.Clear();
            textBoxComentaire.Clear();
            radioButtonLP.Checked = true;

        }

        public void ClearAll() // Clear all the textBox
        {
            textBoxRecherche.Clear();
            textBoxFournisseur.Clear();
            textBoxDemandePar.Clear();
            textBoxSoumission.Clear();
            textBoxComentaire.Clear();
            textBoxApprobe.Clear();
            textBoxDeuxiemeAprovation.Clear();
            radioButtonLP.Checked = true;
            radioButtonEnAttente.Checked = true;
            textBoxNumeroPO.Text = DA_listePO.Display_Next_PO();

        } 

        private void POsystem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Dept_dept' table. You can move, or remove it, as needed.
            this.dept_deptTableAdapter1.Fill(this.dataSet2.Dept_dept);
            if (Validator.TestConn()) // Check for connection to database in case of not having a connection close the application
            {
                DA_listePO.Display_department(listViewDepartement);// display departement table in the listviewdepartement             
                this.dept_deptTableAdapter.Fill(this.dataSet1.Dept_dept);// This line of code loads data into the 'dataSet1.Dept_dept' table. You can move, or remove it, as needed.                
                this.departements_testTableAdapter.Fill(this.dataSetDept.departements_test);// This line of code loads data into the 'dataSetDept.departements_test' table. You can move, or remove it, as needed.
                textBoxDernierPO.Text = DA_listePO.Display_last();// get the last po created and place it in the textbox for the las po
                textBoxNumeroPO.Text = DA_listePO.Display_Next_PO();// get the next po to be created and place it in the textbox for the next po
                DA_listePO.CreateFolder(); //if the system doesn't found a folder for the next PO, will create one
                DA_listePO.CreateSubFolder(DA_listePO.Next_PO());//if the system doesn't found a the 3 subfolders for the next PO, will create all the subfolders
                textBoxPDFDocument.Text = DA_listePO.getDirectoryPath(DA_listePO.Next_PO());//Fill the textbox for the pdf folder with the location address of the main folder for the PO
                labelDateNow.Text = DateTime.Now.ToString(); //Display the date at the bottom of the windows form
                btnModifierDepartements.Visible = false; //these 3 options only available if enter the admin code
                editStripMenuItem1.Enabled = false;
                logoutStripMenuItem1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Impossible de se connecter à la base de données", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnNewPO_Click(object sender, EventArgs e) //save po
        {
            string radioPO, radioStatut;

            if(Validator.IsEmpty(textBoxFournisseur.Text) && Validator.IsEmpty(textBoxDemandePar.Text) && Validator.IsEmpty(textBoxApprobe.Text)) //checks if textbox are empty
            {
                PO_List listPO = new PO_List(); //Create a new object from po_list

                if (radioButtonLP.Checked) //Check radiobuttons to set a value for the variable
                {
                    radioPO = "LP";
                }
                else
                {
                    radioPO = "NG";
                }
                if (radioButtonEnAttente.Checked)
                {
                    radioStatut = "En Attente";
                }
                else if (radioComplete.Checked)
                {
                    radioStatut = "Compltéte";
                }
                else
                {
                    radioStatut = "Partielle";
                }
                //Add values to the object created from po_list
                listPO.RadioPO = radioPO;                
                listPO.Fournisseur = textBoxFournisseur.Text;
                listPO.DemandePar = textBoxDemandePar.Text;
                listPO.Soumission = textBoxSoumission.Text;
                listPO.Commentaire = textBoxComentaire.Text;
                listPO.RadioStatut = radioStatut;
                listPO.Approbe = textBoxApprobe.Text;
                listPO.DeuxiemeApprovation = textBoxDeuxiemeAprovation.Text;

                DA_listePO.SavePO(listPO); // save the data in the database
                ClearAll();
                textBoxDernierPO.Text = DA_listePO.Display_last();// get the last po created and place it in the textbox for the las po
                textBoxNumeroPO.Text = DA_listePO.Display_Next_PO();// get the next po to be created and place it in the textbox for the next po
                DA_listePO.CreateSubFolder(textBoxDernierPO.Text);//if the system doesn't found a folder for the next PO, will create one
                DA_listePO.CreateSubFolder(DA_listePO.Next_PO());//if the system doesn't found a the 3 subfolders for the next PO, will create all the subfolders
                textBoxPDFDocument.Text = DA_listePO.getDirectoryPath(DA_listePO.Next_PO());//Fill the textbox for the pdf folder with the location address of the main folder for the PO
                MessageBox.Show("PO enregistré", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } 

        private void btnRecherche_Click(object sender, EventArgs e) //search po
        {
            if (Validator.IsEmpty(textBoxRecherche.Text) && Validator.IsADigit(textBoxRecherche.Text))//Validate if the textbox is empty
            {
               PO_List listPO = DA_listePO.Search(Convert.ToInt32(textBoxRecherche.Text)); //search and set the result to listpo

                if (listPO.Numero == null || listPO.Numero == "")
                {
                    MessageBox.Show("Ce PO n’existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //if found fill the textbox with the data retrieved
                    textBoxNumeroPO.Text = listPO.Numero;
                    textBoxFournisseur.Text = listPO.Fournisseur;
                    textBoxDemandePar.Text = listPO.DemandePar;
                    textBoxSoumission.Text = listPO.Soumission;
                    textBoxComentaire.Text = listPO.Commentaire;
                    textBoxApprobe.Text = listPO.Approbe;
                    textBoxDeuxiemeAprovation.Text = listPO.DeuxiemeApprovation;

                    if (listPO.RadioStatut.Equals("Complete") || listPO.RadioStatut.Equals("Compléte"))
                    {
                        radioComplete.Checked = true;
                    }
                    else if (listPO.RadioStatut.Equals("En Attente"))
                    {
                        radioButtonEnAttente.Checked = true;
                    }
                    else if (listPO.RadioStatut.Equals("Partielle"))
                    {
                        radioPartielle.Checked = true;
                    }
                    if (listPO.RadioPO.Equals("NG"))
                    {
                        radioButtonNG.Checked = true;
                    }
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e) //modify only the details of the po
        {
            if (Validator.IsEmpty(textBoxFournisseur.Text) && Validator.IsEmpty(textBoxDemandePar.Text) && Validator.IsEmpty(textBoxApprobe.Text)) //Check if the textbox are empty
            {
                
                string radioPO;

                if (radioButtonLP.Checked)
                {
                    radioPO = "LP";
                }
                else
                {
                    radioPO = "NG";
                }

                PO_List listPO = new PO_List(textBoxRecherche.Text, radioPO, textBoxFournisseur.Text, textBoxDemandePar.Text, textBoxSoumission.Text, textBoxComentaire.Text); //save the values in the object

                DA_listePO.updateDetailsPO(listPO); //update the values in the database
                MessageBox.Show("PO modifié", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } 

        private void btnSupprimer_Click(object sender, EventArgs e)//delete po
        {
            if (Validator.IsEmpty(textBoxFournisseur.Text) && Validator.IsEmpty(textBoxDemandePar.Text) && Validator.IsEmpty(textBoxApprobe.Text)) //check if the textbox are empty
            {
                if (textBoxFournisseur.Text.Equals("Indisponible") && textBoxDemandePar.Text.Equals("Indisponible"))//check if the po is already deleted
                {
                    MessageBox.Show("PO déja supprime", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult = MessageBox.Show("Etes-vous sûr que vous voulez supprimer", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if(DialogResult == DialogResult.Yes) //set default values to the deleted po because they will be reused
                    {
                        string radioStatut = "En Attente";
                        string supprimerDefaultValue = "Indisponible";
                        string defaultValues = "Aucun";

                        PO_List listPO = new PO_List();

                        listPO.Search = textBoxRecherche.Text;
                        listPO.Fournisseur = supprimerDefaultValue;
                        listPO.DemandePar = supprimerDefaultValue;
                        listPO.Soumission = defaultValues;
                        listPO.Commentaire = defaultValues;
                        listPO.RadioStatut = radioStatut;
                        listPO.Approbe = defaultValues;
                        listPO.DeuxiemeApprovation = defaultValues;

                        DA_listePO.supprimerPO(listPO);
                        MessageBox.Show("PO supprimé", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                    }
                }
            }
        } 

        private void btnAjouterPDF_Click(object sender, EventArgs e)//add pdf document to a designated folder
        {
            string radioOption, folderLocation; //when saving a pdf, goes directly to the folder location plus the option for the subfolder
            if (radioButtonEnAttente.Checked == true)
                radioOption = "En_Attente";
            else if (radioPartielle.Checked == true)
                radioOption = "Partielle";
            else radioOption = "Complete";

            folderLocation = textBoxPDFDocument.Text + "\\" + radioOption;

            DA_listePO.CopyPDF(folderLocation);//Save the pdf in the designated location
        }

        private void btnList_Click(object sender, EventArgs e) //opens listform
        {
            GUI.ListForm listForm = new GUI.ListForm(); //opens the windows form listform

            listForm.ShowDialog();
        }

        private void btnEffacerChamps_Click(object sender, EventArgs e) //clear textboxes
        {
            ClearAll(); //clear textboxes
        }

        private void btnExporterversExcel_Click(object sender, EventArgs e) //export excel document
        {
            DA_listePO.ExporteExcel(); //create a excel file with the content of list po database
            DialogResult = MessageBox.Show("Document Excel exporté avec succès, voulez-vous ouvrir le fichier Excel",
                                            "Informations", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(DialogResult == DialogResult.Yes)
            {
                DA_listePO.OpenExcel();//open the excel if the user desire
            }
        }

        private void btnOuvrirPDF_Click(object sender, EventArgs e) //open principal folder
        {
            DA_listePO.OpenFolderPO(textBoxPDFDocument.Text); //open de folder where the subfolders with the pdfs are located for the selected po
        }

        private void btnModifierStatut_Click(object sender, EventArgs e) //modify only the status of the po
        {
            if (Validator.IsEmpty(textBoxFournisseur.Text) && Validator.IsEmpty(textBoxDemandePar.Text) && Validator.IsEmpty(textBoxApprobe.Text))//check if the texboxes are empty
            {
                string radioStatut;

                if (radioButtonEnAttente.Checked)
                {
                    radioStatut = "En Attente";
                }
                else if (radioComplete.Checked)
                {
                    radioStatut = "Compltéte";
                }
                else
                {
                    radioStatut = "Partielle";
                }

                PO_List listPO = new PO_List(textBoxRecherche.Text, radioStatut); //modify only the status from the parametirized po_list
                DA_listePO.updateStatut(listPO); //update the status field
                MessageBox.Show("PO statut modifié", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } // Done

        private void btnModifierApprobe_Click(object sender, EventArgs e)//modify only the person/s approbe fileds of the po
        {
            if (Validator.IsEmpty(textBoxFournisseur.Text) && Validator.IsEmpty(textBoxDemandePar.Text) && Validator.IsEmpty(textBoxApprobe.Text)) //check if textboxes are empty
            {
                PO_List listPO = new PO_List(textBoxRecherche.Text, textBoxApprobe.Text, textBoxDeuxiemeAprovation.Text);//modify only the approbe from the parametirized po_list
                DA_listePO.updateApprobe(listPO);//update the approbe field
                MessageBox.Show("PO approvation modifié", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } // Done

        private void btnListeDepartement_Click(object sender, EventArgs e)//list the complete list of departments
        {
            DA_listePO.Display_department(listViewDepartement);            
        }

        private void btnModifierDepartements_Click(object sender, EventArgs e) //open the modify departments windows when the button is available
        {
            GUI.Departements departement = new GUI.Departements();

            departement.ShowDialog();
        }        

        private void btnEfaccerDeuxieme_Click(object sender, EventArgs e)//clear the textBoxDeuxiemeAprovation if there's any
        {
            textBoxDeuxiemeAprovation.Clear();
        }

        private void textBoxRecherche_KeyDown(object sender, KeyEventArgs e)//activate the enter key option for the serach textbox
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

        private void listViewDepartement_MouseDoubleClick(object sender, MouseEventArgs e)//activate double click on the listview to select the approvation field
        {
            ListViewHitTestInfo info = listViewDepartement.HitTest(e.X, e.Y);//find the position of the mouse where the dobleclick event ocurred
            ListViewItem item = info.Item;//set the value to the item view

            if (item != null)
            {
                if (textBoxApprobe.Text == item.SubItems[1].Text || textBoxDeuxiemeAprovation.Text == item.SubItems[1].Text)//check if the textbox already have the filed selected
                {
                    MessageBox.Show("Nom a été sélectionné", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (textBoxApprobe.Text == "") //if texbox approbe is empty set the value selected
                {
                    textBoxApprobe.Text = item.SubItems[1].Text;
                }
                else
                {
                    DialogResult = MessageBox.Show("Le nom a été sélectionné, souhaitez-vous ajouter une deuxième approbation",
                        "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (DialogResult == DialogResult.Yes) //if the approbe is not empty and the filed value is different ask to change approbe field or just adde to the second approbe
                    {
                        textBoxDeuxiemeAprovation.Text = item.SubItems[1].Text;
                    }
                    else
                    {
                        DialogResult = MessageBox.Show("Voulez-vous modifier la première approbation ",
                         "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        if (DialogResult == DialogResult.Yes)
                        {
                            textBoxApprobe.Text = item.SubItems[1].Text;
                        }
                    }
                }
            }
            else
            {
                this.listViewDepartement.SelectedItems.Clear();
                MessageBox.Show("No Item is selected", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBoxListeDepartement_SelectedIndexChanged(object sender, EventArgs e) //filter for the departements view
        {
            string selected = comboBoxListeDepartement.Text;
            DA_listePO.Display_department(listViewDepartement, selected);
        }

        private void btnSortir_Click(object sender, EventArgs e) //exit the whole application
        {
            DialogResult = MessageBox.Show("Are you sure you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void loginStripMenuItem_Click(object sender, EventArgs e)//menu option for admin uses
        {
            GUI.UserAdmin admin = new GUI.UserAdmin();//open admin login

            admin.ShowDialog();

            if (admin.adminAccess()) //if password and name are correct activate the 3 options banned from normal users
            {
                
                btnModifierDepartements.Visible = true;
                editStripMenuItem1.Enabled = true;
                logoutStripMenuItem1.Enabled = true;

                MessageBox.Show("Vous êtes connecté", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void editStripMenuItem1_Click(object sender, EventArgs e)//opens the usertableedit to add, delete, or modify
        {
            GUI.UserTableEdit userEdit = new GUI.UserTableEdit();

            userEdit.ShowDialog();
        }

        private void logoutStripMenuItem1_Click(object sender, EventArgs e) //logout and deactivate the 3 admin options available
        {
            DialogResult = MessageBox.Show("Êtes-vous sûr de vouloir vous déconnecter", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(DialogResult == DialogResult.Yes)
            {
                btnModifierDepartements.Visible = false;
                editStripMenuItem1.Enabled = false;
                logoutStripMenuItem1.Enabled = false;

                MessageBox.Show("Vous êtes déconnecté", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

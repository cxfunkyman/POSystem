using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;
using POSystem.DB;
using System.IO;
using System.Diagnostics;
using POSystem.DAL;
using POSystem.BLL;

namespace POSystem.DAL
{
    public static class DA_listePO
    {        
        public static void Display_department(ListView listViewDepartement) //display departement database in the departement list view usin datatable
        {
            int i = 0;
            listViewDepartement.Items.Clear();

            string query = "SELECT * FROM departement_view";

            DataTable dt = Db_Connect_Queries.Query_Connect_DB(query);

            if(dt != null)
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i].ItemArray[1].ToString());
                item.SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                item.SubItems.Add(dt.Rows[i].ItemArray[3].ToString());

                listViewDepartement.Items.Add(item);
                i++;
            }
            else
                Application.Exit();

        }

        public static void Display_department(ListView listViewDepartement, string index) //display departement database in the departement list view usin datatable usin the filter from the combobox
        {
            int i = 0;
            listViewDepartement.Items.Clear();

            string query = "SELECT * FROM departement_view WHERE departement = '" + index + "' COLLATE NOCASE";

            DataTable dt = Db_Connect_Queries.Query_Connect_DB(query);

            if (dt != null)
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i].ItemArray[1].ToString());
                item.SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                item.SubItems.Add(dt.Rows[i].ItemArray[3].ToString());

                listViewDepartement.Items.Add(item);
                i++;
            }

        }

        public static void Display_ListePO(ListView listViewListPO) //display listpo database in the listform list view usin datatable
        {
            int i = 0;
            listViewListPO.Items.Clear();

            string query = "SELECT * FROM liste_tout";
            DataTable dt = Db_Connect_Queries.Query_Connect_DB(query);

            
            if(dt != null)
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i].ItemArray[0].ToString()); // numéro de po
                item.SubItems.Add(dt.Rows[i].ItemArray[1].ToString()); // fournisseur
                item.SubItems.Add(dt.Rows[i].ItemArray[2].ToString()); // demande par
                item.SubItems.Add(dt.Rows[i].ItemArray[3].ToString()); // no de soumission
                item.SubItems.Add(dt.Rows[i].ItemArray[4].ToString()); // commentaire
                item.SubItems.Add(dt.Rows[i].ItemArray[5].ToString()); // statut

                if (dt.Rows[i].ItemArray[7].ToString() == "N/A" || dt.Rows[i].ItemArray[7].ToString() == "" || dt.Rows[i].ItemArray[7].ToString() == "Aucun")//if approve is only one person display only one field
                {

                    item.SubItems.Add(dt.Rows[i].ItemArray[6].ToString()); // approve par
                   
                }
                else
                {
                    item.SubItems.Add(dt.Rows[i].ItemArray[6].ToString() + " et " + dt.Rows[i].ItemArray[7].ToString()); // if approve is two person display only the two fields separated by " et "

                    }

                item.SubItems.Add(dt.Rows[i].ItemArray[8].ToString()); // date de création
                item.SubItems.Add(dt.Rows[i].ItemArray[9].ToString()); // derniér mise a jour

                listViewListPO.Items.Add(item);

                i++;
            }
        }

        public static PO_List Search(int numero_PO) //serach by po number and fill the corresponding textboxes using datatable
        {            
            PO_List listPO = new PO_List();

            string query = "SELECT * FROM liste_complete WHERE numero=" + numero_PO; //fix here

            DataTable dt = Db_Connect_Queries.Query_Connect_DB(query);

            if (dt != null)
                if (dt.Rows.Count != 0)
                {
                    listPO.RadioPO = dt.Rows[0].ItemArray[0].ToString(); //po
                    listPO.Numero = dt.Rows[0].ItemArray[1].ToString(); //numero
                    listPO.Fournisseur = dt.Rows[0].ItemArray[2].ToString(); //fournisseur
                    listPO.DemandePar = dt.Rows[0].ItemArray[3].ToString(); //demande_par
                    listPO.Soumission = dt.Rows[0].ItemArray[4].ToString(); //description
                    listPO.Commentaire = dt.Rows[0].ItemArray[5].ToString(); // commentaire
                    listPO.RadioStatut = dt.Rows[0].ItemArray[6].ToString(); // statut
                    listPO.Approbe = dt.Rows[0].ItemArray[7].ToString(); // approbe
                    listPO.DeuxiemeApprovation = dt.Rows[0].ItemArray[8].ToString();// deuxieme approbation
                }

            return listPO;
        }

        public static string Display_last() //make a query in dec order, take the first entry and display it in the texbox lastpo textbox
        {
            string lastInput = null;

            string query = "select po, numero from liste_de_po_test order by numero DESC";

            
            DataTable dt = Db_Connect_Queries.Query_Connect_DB(query);

            if(dt != null)
            lastInput = dt.Rows[0].ItemArray[0].ToString() + dt.Rows[0].ItemArray[1].ToString();

            return lastInput;
        }

        public static string Display_Next_PO()//make a query, take the first entry and display it in the texbox for the next po
        {
            int lastInput = 0;

            string query = "select po, numero from liste_de_po_test order by numero DESC";

            DataTable dt = Db_Connect_Queries.Query_Connect_DB(query);

            if (dt != null)
                lastInput = int.Parse(dt.Rows[0].ItemArray[1].ToString()) + 1;
            string location = lastInput.ToString();

            return lastInput.ToString();
        }

        public static string Next_PO()//make a query to know the last entry and set the next entry for PO.
        {
            string query = "select po, numero from liste_de_po_test order by numero DESC";
            int lastInput = 0;
            string modifierPO = null;

            DataTable dt = Db_Connect_Queries.Query_Connect_DB(query);

            if (dt != null)
            {
                lastInput = int.Parse(dt.Rows[0].ItemArray[1].ToString()) + 1;
                modifierPO = dt.Rows[0].ItemArray[0].ToString() + lastInput.ToString();
            }


            string location = lastInput.ToString();

            return modifierPO;
        }

        public static void CreateFolder() //folder creation
        {
            string folderPath = Application.StartupPath + @"\PO_Documents"; //path for creation folder in the same directory as the application
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\PDF_Documents"; //path for accesing the desktop directory

            if (!Directory.Exists(folderPath)) //checkif the folder exist before attempting to create one
            {               

                try
                {
                    Directory.CreateDirectory(folderPath);                    
                }
                catch (Exception e)
                {

                }
            }
            if (!Directory.Exists(desktopPath))
            {

                try
                {
                    Directory.CreateDirectory(desktopPath);
                }
                catch (Exception e)
                {

                }
            }

        }

        public static void CreateSubFolder(string subFolder) //subfolder creation inside the main po folder
        {
            string folderPath = Application.StartupPath + @"\PO_Documents\" + subFolder; //path for subfolder with the option location inside the pricipal folder
            string[] subFolderPath = { "En_Attente", "Partielle", "Complete" };

            if (!Directory.Exists(folderPath))//check the if the subfolder exist
            {

                try
                {
                    Directory.CreateDirectory(folderPath);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur, le dossier ne peut pas être créé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            foreach (string subF in subFolderPath) //in case of selecting more than one file save every document selected
            {
                folderPath = Application.StartupPath + @"\PO_Documents\" + subFolder + "\\" + subF;

                if (!Directory.Exists(folderPath))
                {

                    try
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Erreur, le dossier ne peut pas être créé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        public static string getDirectoryPath(string folder) //get the path for the pricipal directory and display it in the texbox for pdf folder
        {
            string directoryPath = Application.StartupPath + @"\PO_Documents\" + folder + "\\";
            FileInfo fileInfo = new FileInfo(directoryPath);
            string directoryFullPath = fileInfo.DirectoryName; // 

            return directoryFullPath;            
        }

        public static void OpenFolderPO(string location)// if the users wants to open the folder to see the content of the main folder 
        {
            string folderPath = @"" + location;

            if (Directory.Exists(folderPath))
            {
                Process.Start(folderPath);
            }
            else
                MessageBox.Show("Dossier n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void SavePO(PO_List POList) // save the new po
        {
            string p_approbe = "SELECT id FROM departements_test WHERE premiere_approbe = '" + POList.Approbe + "' COLLATE NOCASE";
            DataTable dt = Db_Connect_Queries.Query_Connect_DB(p_approbe);// because the approbe name is a number in the database get the id and set the name from the list
            POList.Approbe = dt.Rows[0].ItemArray[0].ToString();

            if (POList.DeuxiemeApprovation == null || POList.DeuxiemeApprovation == "")
            {
                POList.DeuxiemeApprovation = "Aucun"; //to not have null values set the empty field to a default value
            }
            else
            {
                string d_approbe = "SELECT id FROM departements_test WHERE deuxieme_approbe = '" + POList.DeuxiemeApprovation + "' COLLATE NOCASE";
                dt = Db_Connect_Queries.Query_Connect_DB(d_approbe);

                POList.DeuxiemeApprovation = dt.Rows[0].ItemArray[0].ToString();
            }

            string query = "INSERT INTO liste_de_po_test (po, fournisseur, demande_par , description , commentaire, statut, premiere_approbe, deuxieme_approbe) VALUES('" + POList.RadioPO + "','" + POList.Fournisseur + "','" + POList.DemandePar + "','" + POList.Soumission + "','" + POList.Commentaire + "','" + POList.RadioStatut + "','" + POList.Approbe + "','" + POList.DeuxiemeApprovation + "')";

            Db_Connect_Queries.Save_Connect_DB(query);
        } 

        public static void updateDetailsPO(PO_List POList)//update only the details fields
        {
            string query = "UPDATE liste_de_po_test SET po = '" + POList.RadioPO + "', fournisseur = '"+ POList.Fournisseur + "', demande_par = '"+ POList.DemandePar + "', description = '"+ POList.Soumission + "', commentaire = '"+ POList.Commentaire + "' WHERE numero = '"+ POList.Search + "'";

            Db_Connect_Queries.Save_Connect_DB(query);
        }

        public static void updateStatut(PO_List POList) //update only the status field
        {
            string query = "UPDATE liste_de_po_test SET statut = '" + POList.RadioStatut + "' WHERE numero = '" + POList.Search + "'";

            Db_Connect_Queries.Save_Connect_DB(query);
        }

        public static void updateApprobe(PO_List POList) //update only the approbe field
        {
            string p_approbe = "SELECT id FROM departements_test WHERE premiere_approbe = '" + POList.Approbe + "' COLLATE NOCASE";
            DataTable dt = Db_Connect_Queries.Query_Connect_DB(p_approbe);
            POList.Approbe = dt.Rows[0].ItemArray[0].ToString();

            if (POList.DeuxiemeApprovation == null || POList.DeuxiemeApprovation == "")
            {
                POList.DeuxiemeApprovation = "Aucun"; //default value if the deuxieme approbe field is empty
            }
            else
            {
                string d_approbe = "SELECT id FROM departements_test WHERE deuxieme_approbe = '" + POList.DeuxiemeApprovation + "' COLLATE NOCASE";
                dt = Db_Connect_Queries.Query_Connect_DB(d_approbe);

                POList.DeuxiemeApprovation = dt.Rows[0].ItemArray[0].ToString();
            }
            string query = "UPDATE liste_de_po_test SET premiere_approbe = '" + POList.Approbe + "', deuxieme_approbe = '" + POList.DeuxiemeApprovation + "' WHERE numero = '" + POList.Search + "'";

            Db_Connect_Queries.Save_Connect_DB(query);
        }

        public static void supprimerPO(PO_List POList) //delete po details only, po number are reusable
        {
            string query = "UPDATE liste_de_po_test SET fournisseur = '" + POList.Fournisseur + "', demande_par = '" + POList.DemandePar + "', description = '" + POList.Soumission + "', commentaire = '" + POList.Commentaire + "', statut = '" + POList.RadioStatut + "', premiere_approbe = '"  + POList.Approbe + "', deuxieme_approbe = '" + POList.DeuxiemeApprovation + "' WHERE numero = '" + POList.Search + "'";

            Db_Connect_Queries.Save_Connect_DB(query);
            
        }

        public static void ExporteExcel() //export the list po table to excel
        {
            string excelPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Liste PO Complete " + DateTime.Now.ToShortDateString() + ".xlsx"; //path to save the export excel file in the user desktop ecpecial folder
            string query = "select * from liste_tout";

            DataTable dt = Db_Connect_Queries.Query_Connect_DB(query);

            Excel_Export.DBToExcel(dt, "Liste de PO", excelPath, "Établie");
        }

        public static void OpenExcel() // option to open the excel file after created
        {
            string excelPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Liste PO Complete " + DateTime.Now.ToShortDateString() + ".xlsx";
            Process.Start(excelPath);
        }

        public static void CopyPDF(string location) //copy a pdf file into the designated directory
        {
            string folderPath = @"" + location + "\\";
            string destFile;

            OpenFileDialog OD = new OpenFileDialog(); //open filedialog to choose the document to copy onto the designated folder
            OD.FileName = "";
            OD.Filter = "Supported files| *.pdf; *.*";
            OD.Multiselect = true;

            if (OD.ShowDialog() == DialogResult.OK)
            {
                
                foreach (string file in OD.FileNames)
                {
                    destFile = Path.Combine(folderPath, Path.GetFileName(file));
                    File.Copy(file, destFile, true);
                }
            }
            MessageBox.Show("PDF ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


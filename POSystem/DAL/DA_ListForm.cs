using POSystem.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSystem.DAL
{
    public static class DA_ListForm
    {
        public static void ComboBoxIndex(int indexCB, ListView list) //filter to display the list with different options selected by the user
        {
            string query = "";

            switch (indexCB)
            {
                case -1:
                    MessageBox.Show("Veuillez sélectionner une option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 1:
                    query = "SELECT * FROM liste_tout_desc";
                    
                    break;

                case 2:
                    query = "SELECT * FROM liste_tout ORDER by fournisseur";
                    break;

                case 3:
                    query = "SELECT * FROM liste_tout ORDER by \"Demande Par\"";
                    break;

                case 4:
                    query = "SELECT * FROM liste_tout ORDER by Statut";
                    break;

                case 5:
                    query = "SELECT * FROM liste_tout ORDER by \"Premiere Approbe\"";
                    break;

                default:
                    break;
            }
            if(query != "")
                FillListView(list, query);
        }

        private static void FillListView(ListView list, string query)// display the listview with the 
        {
            DataTable dt = Db_Connect_Queries.Query_Connect_DB(query);
            int i = 0;
            list.Items.Clear();


            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i].ItemArray[0].ToString()); // numéro de po
                item.SubItems.Add(dt.Rows[i].ItemArray[1].ToString()); // fournisseur
                item.SubItems.Add(dt.Rows[i].ItemArray[2].ToString()); // demande par
                item.SubItems.Add(dt.Rows[i].ItemArray[3].ToString()); // no de soumission
                item.SubItems.Add(dt.Rows[i].ItemArray[4].ToString()); // commentaire
                item.SubItems.Add(dt.Rows[i].ItemArray[5].ToString()); // statut

                if (dt.Rows[i].ItemArray[7].ToString() == "N/A" || dt.Rows[i].ItemArray[7].ToString() == "" || dt.Rows[i].ItemArray[7].ToString() == "Aucun")
                {

                    item.SubItems.Add(dt.Rows[i].ItemArray[6].ToString()); // approve par

                }
                else
                {
                    item.SubItems.Add(dt.Rows[i].ItemArray[6].ToString() + " et " + dt.Rows[i].ItemArray[7].ToString()); // approve par

                }

                item.SubItems.Add(dt.Rows[i].ItemArray[8].ToString()); // date de création
                item.SubItems.Add(dt.Rows[i].ItemArray[9].ToString()); // derniér mise a jour

                list.Items.Add(item);

                i++;
            }
        }

        public static void SearchByCB(int indexCB, ListView list, string textBoxSearch) //Searh dependoing of the option from the search by combo box option
        {
            string query = "";

            switch (indexCB)
            {
                case -1:
                    MessageBox.Show("Veuillez sélectionner une option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 0:
                    query = "SELECT * FROM liste_tout WHERE Fournisseur LIKE '" + textBoxSearch + "%' COLLATE NOCASE";
                    break;
                
                case 1:
                    query = "SELECT * FROM liste_tout WHERE \"Demande par\" LIKE '" + textBoxSearch + "%' COLLATE NOCASE";

                    break;

                case 2:
                    query = "SELECT * FROM liste_tout WHERE Description LIKE '" + textBoxSearch + "%' COLLATE NOCASE";
                    break;

                case 3:
                    query = "SELECT * FROM liste_tout WHERE Statut LIKE '" + textBoxSearch + "%' COLLATE NOCASE";
                    break;

                case 4:
                    query = "SELECT * FROM liste_tout WHERE \"Premiere Approbe\" LIKE '" + textBoxSearch + "%' COLLATE NOCASE";
                    break;

                default:
                    break;
            }
            if (query != "")
                FillListView(list, query);
        }
    }
}

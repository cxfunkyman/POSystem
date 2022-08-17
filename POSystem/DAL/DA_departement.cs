using POSystem.BLL;
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
    public static class DA_departement 
    {
        public static void Display_AdminUsers(ListView listViewListPO)//display the database for departement in the list view using datatables
        {
            int i = 0;
            listViewListPO.Items.Clear();

            string query = "SELECT name, STRFTIME('%d/%m/%Y', last_update) AS last_update FROM users";
            DataTable dt = Db_Connect_Queries.Query_Connect_DB(query);



            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i].ItemArray[0].ToString()); // nom
                item.SubItems.Add(dt.Rows[i].ItemArray[1].ToString()); // date

                listViewListPO.Items.Add(item);
                i++;
            }
        }

        public static bool VerifyPassword(string name, string pass) //check from the database whether or not the username and password entered is correct
        {
            string query = "SELECT * FROM users WHERE name='" + name + "' COLLATE NOCASE"; //fix here

            DataTable dt = Db_Connect_Queries.Query_Connect_DB(query);

            if (dt.Rows.Count != 0)
            {
                if (name.Equals(dt.Rows[0].ItemArray[1].ToString()) && pass.Equals(dt.Rows[0].ItemArray[2].ToString()))
                {
                    return true;
                }
                else
                    return false;
            }
            else 
            return false;
        }

        public static void SaveUsers(Users_List listUser)//save new users with admin privilages 
        {
            string query = "INSERT INTO users (name, password) VALUES('" + listUser.Name + "','" + listUser.Password + "')";

            Db_Connect_Queries.Save_Connect_DB(query);
        }

        public static void UpdateUsers(Users_List listUser, string userName)//update users with admin privilages
        {
            string query = "UPDATE users SET name = '" + listUser.Name + "', password = '" + listUser.Password + "' WHERE name = '" + userName + "'";

            Db_Connect_Queries.Save_Connect_DB(query);
        }

        public static void DeleteUsers(string text) //delete users
        {
            string query = "DELETE FROM users WHERE name = '" + text + "'";

            Db_Connect_Queries.Save_Connect_DB(query);
        }

        public static string[] ShowNomPass(string name) //show only the name in the listview
        {
            string query = "SELECT * FROM users WHERE name='" + name + "' COLLATE NOCASE"; //fix here
            

            DataTable dt = Db_Connect_Queries.Query_Connect_DB(query);

            if (dt.Rows.Count != 0)
            {
                string[] namePass = { dt.Rows[0].ItemArray[1].ToString(), dt.Rows[0].ItemArray[2].ToString()};
                return namePass;
            }
            else
                return null;
        }

        public static void updateDetailsDept(Departement_List deptList, string name) //update name, password or both
        {            
            string p_approbe = "SELECT id FROM departement_view WHERE approbe_par = '" + name + "' COLLATE NOCASE";
            DataTable dt = Db_Connect_Queries.Query_Connect_DB(p_approbe);
            deptList.DeptID = dt.Rows[0].ItemArray[0].ToString();

            string query = "UPDATE departements_test SET departement = '" + deptList.Departement + "', premiere_approbe = '" + deptList.Approbation + "', deuxieme_approbe = '" + deptList.Approbation + "', montant = '" + deptList.Montant + "' WHERE id = '" + deptList.DeptID + "'";

            Db_Connect_Queries.Save_Connect_DB(query);
        }

        public static void SaveDept(Departement_List deptList)// save new admin privilages users
        {
            string query = "INSERT INTO departements_test (departement, premiere_approbe, deuxieme_approbe, montant) VALUES('" + deptList.Departement + "','" + deptList.Approbation + "','" + deptList.Approbation + "','" + deptList.Montant + "')";

            Db_Connect_Queries.Save_Connect_DB(query);
        }

    }
}

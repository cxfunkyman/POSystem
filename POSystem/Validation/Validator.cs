using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSystem.DB;
using System.IO;

namespace POSystem.Validation
{
    class Validator
    {
        static readonly string dbFile = @".\DAL\test.db"; // path for default folder

        public static bool IsValidPass(string input) //check if the password is 5 characters or more
        {            
            if (input.Length < 5)
            {
                MessageBox.Show("Le mot de passe doit comporter 5 chiffres ou plus", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else
            {
                return true;
            }
            
        }

        public static bool IsEmpty(string text) //check if the textbox is empty
        {
            if (text == "")
            {
                MessageBox.Show("Informations manquantes, données vides non acceptées", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool IsExist(string text) //check if data required exist within the database in case of search or save a new entry
        {
            string existName = "SELECT * FROM users WHERE name = '" + text + "' COLLATE NOCASE";

            DataTable dt = Db_Connect_Queries.Query_Connect_DB(existName);

            if(dt != null)
                return false;
            else
                return true;
        }

        public static bool IsADigit(string text)
        {
            int tempID;
            
            if (!(Int32.TryParse(text, out tempID)))
            {
                MessageBox.Show("Attention, seuls les chiffres sont acceptés", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }            

            else
                return true;
        }

        public static bool TestConn() //check if the database connection is available and can connect to the database
        {
            if (File.Exists(dbFile))
            {
                return true;
            }

            else
                return false;
        }
    }
}

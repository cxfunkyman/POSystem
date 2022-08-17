using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;


namespace POSystem.DB
{
    internal class Db_Connect_Queries
    {
        static readonly SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\DAL\test.db");

        public static DataTable Query_Connect_DB(String query) //database connection returning the datatable dt with the database data required, like search and display database
        {
            try
            {
                conn.Open();

                SQLiteCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);

                conn.Close();

                return dt;
            }
            catch(SQLiteException e)
            {
               MessageBox.Show("Impossible de se connecter à la base de données", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

               return null;
            }
            finally
            {
                conn.Close();                
            }
        }

        public static void Save_Connect_DB(String query) //database connection without returning a value, not necessary for save, update or delete
        {
            try
            {
                conn.Open();

                SQLiteCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch(SQLiteException e)
            {
                MessageBox.Show("Impossible de se connecter à la base de données", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

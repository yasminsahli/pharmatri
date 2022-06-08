using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace PharmaTri2
{
    class DB_Dechet
    {

        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost; port=3306; username=root; password=; database=pharmatri2";
            MySqlConnection con = new MySqlConnection(sql);

            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MYSQL Connection ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }


        public static void AddDechet(Dechet dechet)
        {
            string sql = "INSERT INTO dechets VALUES (@DECHETId, @DECHETLibelle, @LABOId)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@DECHETId", MySqlDbType.Int32).Value = dechet.DECHETId;
            cmd.Parameters.Add("@DECHETLibelle", MySqlDbType.VarChar).Value = dechet.DECHETLibelle;
            //cmd.Parameters.Add("@LABOId", MySqlDbType.VarChar).Value = dechet.LABOId;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Déchet ajouté avec succès");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Echec de l'ajout ...\n" + ex.Message);
            }
            con.Close();
        }


        // UPDATE
        public static void UpdateDechet(Dechet dechet, string id)
        {
            string sql = "UPDATE dechets SET DECHETId = @DECHETId, DECHETLibelle = @DECHETLibelle, LABOId = @LABOId WHERE DECHETId = @DECHETId";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@LABOId", MySqlDbType.Int32).Value = dechet.DECHETId;
            cmd.Parameters.Add("@LABOLocalisation", MySqlDbType.VarChar).Value = dechet.DECHETLibelle;
            //cmd.Parameters.Add("@LABONom", MySqlDbType.VarChar).Value = dechet.LABOId;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Déchet mis à jour avec succès");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Echec de la mise à jour ...\n" + ex.Message);
            }
            con.Close();
        }


        // DELETE
        public static void DeleteDechet(string id)
        {
            string sql = "DELETE FROM dechets WHERE DECHETId = @DECHETId";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@LABOId", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Laboratoire supprimé avec succès");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Echec de la suppression ...\n" + ex.Message);
            }
            con.Close();
        }



        // READ & SEARCH
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}

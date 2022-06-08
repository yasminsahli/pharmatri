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
    class DB_Laboratoire
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost; port=3306; username=root; password=; database=pharmatri2";
            MySqlConnection con = new MySqlConnection(sql);

            try
            {
                con.Open();
            } catch (MySqlException ex)
            {
                MessageBox.Show("MYSQL Connection ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        // CREATE
        public static void AddLaboratoire(Laboratoire labo)
        {
            string sql = "INSERT INTO laboratoire VALUES (@LABOId, @LABOLocalisation, @LABONom)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@LABOId", MySqlDbType.VarChar).Value = labo.LABOId;
            cmd.Parameters.Add("@LABOLocalisation", MySqlDbType.VarChar).Value = labo.LABOLocalisation;
            cmd.Parameters.Add("@LABONom", MySqlDbType.VarChar).Value = labo.LABONom;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Laboratoire ajouté avec succès");
            } catch(MySqlException ex)
            {
                MessageBox.Show("Echec de l'ajout ...\n" + ex.Message);
            }
            con.Close();
        }


        // UPDATE
        public static void UpdateLaboratoire(Laboratoire labo, string id)
        {
            string sql = "UPDATE laboratoire SET LABOId = @LABOId, LABOLocalisation = @LABOLocalisation, LABONom = @LABONom WHERE LABOId = @LABOId";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@LABOId", MySqlDbType.VarChar).Value = labo.LABOId;
            cmd.Parameters.Add("@LABOLocalisation", MySqlDbType.VarChar).Value = labo.LABOLocalisation;
            cmd.Parameters.Add("@LABONom", MySqlDbType.VarChar).Value = labo.LABONom;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Laboratoire mis à jour avec succès");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Echec de la mise à jour ...\n" + ex.Message);
            }
            con.Close();
        }

        
        // DELETE
        public static void DeleteLaboratoire(string id)
        {
            string sql = "DELETE FROM laboratoire WHERE LABOId = @LABOId";
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

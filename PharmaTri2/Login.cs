using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmaTri2
{
    public partial class Login : Form
    {
        MySqlConnection connexion = new MySqlConnection("Server = localhost; User = root; Database = pharmatri2; Port = 3306; Password =; SSL Mode = None");
        int i;

        public Login()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            i = 0;
            connexion.Open();
            MySqlCommand cmd = connexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM utilisateur WHERE UTILMail = @UTILMail AND UTILMdp = @UTILMdp";
            cmd.Parameters.AddWithValue("@UTILMail", txtUsername.Text);
            cmd.Parameters.AddWithValue("@UTILMdp", txtPassword.Text);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect");
                connexion.Close();
            } else
            {
                this.Hide();
                FormLaboratoire fl = new FormLaboratoire();
                fl.Show();
            }
            
        }
    }
}

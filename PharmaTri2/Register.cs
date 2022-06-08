using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace PharmaTri2
{
    public partial class Register : Form
    {
        MySqlConnection connexion = new MySqlConnection("Server = localhost; User = root; Database = pharmatri2; Port = 3306; Password =; SSL Mode = None");

        public Register()
        {
            InitializeComponent();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            if (txtMdp.Text == txtConfMdp.Text)
            {
                if (Regex.IsMatch(txtMdp.Text, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$") && Regex.IsMatch(txtMail.Text, @"[a-z0-9]+@[a-z]+\.[a-z]{2,3}"))
                {
                    connexion.Open();
                    MySqlCommand cmd = connexion.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO utilisateur (UTILMail, UTILMdp) VALUES (@username, @password)";
                    cmd.Parameters.AddWithValue("@username", txtMail.Text);
                    cmd.Parameters.AddWithValue("@password", txtMdp.Text);
                    cmd.ExecuteNonQuery();
                    connexion.Close();

                    this.Hide();
                    FormLaboratoire fl = new FormLaboratoire();
                    fl.Show();
                }
                else
                {
                    MessageBox.Show("Merci de respecter le format de l'adresse mail et du mot de passe ...\n\n- 8 caractères minimum\n- Lettre\n- Caractère numérique");
                }
            }
            else
            {
                MessageBox.Show("Les mots de passe ne correspondent pas ...");
            }
        }
    }
}

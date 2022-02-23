using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using Database;
using Database.Models;

namespace AgendaApp
{
    public partial class FrmLogin : Form
    {
        private ServicioContacto _servicio;

        public FrmLogin()
        {
            InitializeComponent();
        }

        public void Logueo()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Usuario, Contraseña FROM Usuarios where Usuario ='" + TxtUsuario.Text + "' AND Contraseña ='" + TxtPass.Text + "'", connection))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        FrmPrincipal form = new FrmPrincipal();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("HA OCURRIDO UN ERROR", "ERROR");

                    }
                }
            }
        }

        private void PboxRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistrar registro = new FrmRegistrar();
            registro.Show();
            this.Hide();
        }

        private void PboxLogin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtUsuario.Text) || !String.IsNullOrEmpty(TxtPass.Text))
            {
                Logueo();

            }
            else
            {
                MessageBox.Show("POR FAVOR LLENE TODO LOS CAMPOS O REGISTRESE", "INFORMACION");
            }
        }
    }
}

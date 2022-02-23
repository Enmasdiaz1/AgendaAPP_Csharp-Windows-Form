using BussinessLayer;
using Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgendaApp
{
    public partial class FrmRegistrar : Form
    {
        private ServicioContacto _servicio;
        public FrmRegistrar()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _servicio = new ServicioContacto(connection);
        }

        private void PboxBtnConfirmar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNombre.Text) || !String.IsNullOrEmpty(TxtApellidos.Text)|| !String.IsNullOrEmpty(TxtUser.Text) || !String.IsNullOrEmpty(TxtPass.Text)|| !String.IsNullOrEmpty(TxtConfirmPass.Text) || TxtPass == TxtConfirmPass)
            {
                int aa = Logica.Instancia.ID = 1;

                Contact contact = new Contact();
                contact.Nombre = txtNombre.Text;
                contact.Apellidos = TxtApellidos.Text;
                contact.Usuario = TxtUser.Text;
                contact.Pass = TxtPass.Text;
                contact.Pass2 = TxtConfirmPass.Text;
                contact.IdUsuario = aa;

                bool result = _servicio.AddUser(contact);
                if (result)
                {
                    MessageBox.Show("Usuario Añadido", "Notificacion");
                }
                else
                {
                    MessageBox.Show("ERROR, Algo no anda bien", "Notificacion");
                }

            }
        }

        private void PboxBtnCancelar_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.Show();
            this.Close();
        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

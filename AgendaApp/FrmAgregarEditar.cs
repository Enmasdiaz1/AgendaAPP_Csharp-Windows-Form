using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using AgendaApp.Elementos;
using System.Windows.Forms;
using Database.Models;
using Database;
using BussinessLayer;
using System.Data.SqlClient;
using System.Configuration;

namespace AgendaApp
{
    public partial class FrmAgregarEditar : Form
    {
        private ServicioContacto _servicio;
        private ContactTypeService _contactTypeService;
        public int? id = null;
        public int? selectedIndex;
        int index = Convert.ToInt32(Logica.Instancia.INDEX);

        private void FrmAgregarEditar_Load(object sender, EventArgs e)
        {

            if (index>= 0)
            {
                LoadEdit();
            }
            else
            {
                AgregarContacto();
            }
        }
        public FrmAgregarEditar()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _servicio = new ServicioContacto(connection);

            

        }

        #region EVENTOS

        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            
                AgregarContacto();

        }

        private void BtnEditarContacto_Click(object sender, EventArgs e)
        {
            LoadEdit();
            EditContacto();
        }

        #endregion

        #region METODOS


        private void AgregarContacto()
        {

            if (!String.IsNullOrEmpty(txtNombre.Text)|| !String.IsNullOrEmpty(TxtApellidos.Text)|| !String.IsNullOrEmpty(TxtDireccion.Text)|| !String.IsNullOrEmpty(TxtApellidos.Text)|| !String.IsNullOrEmpty(TxtDireccion.Text) || !String.IsNullOrEmpty(MtxtTelefono.Text) || !String.IsNullOrEmpty(MtxtTelefonoTrabajo.Text))
            {
                int aa= Logica.Instancia.ID = 1;

                Contact contact = new Contact();
                contact.Nombre = txtNombre.Text;
                contact.Apellidos = TxtApellidos.Text;
                contact.Direccion = TxtDireccion.Text;
                contact.TelefonoPersonal = MtxtTelefono.Text;
                contact.TelefonoTrabajo = MtxtTelefonoTrabajo.Text;
                contact.IdUsuario = aa;

                bool result = _servicio.Add(contact);

                if (result)
                {
                    MessageBox.Show("Operacion Realizada Exitosamente", "Notificacion");
                }
                else
                {
                    MessageBox.Show("ERROR, Algo no anda bien", "Notificacion");
                }

                FrmPrincipal form = new FrmPrincipal();
                form.LoadData();
                ClearData();
                form.Deselect();
            }
            else
            {
                MessageBox.Show("Debe Llenar todos los campos", "Notificacion");
            }


        }


        public  void EditContacto()
        {
            

            FrmAgregarEditar formu = new FrmAgregarEditar();
            if (!String.IsNullOrEmpty(txtNombre.Text) || !String.IsNullOrEmpty(TxtApellidos.Text) || !String.IsNullOrEmpty(TxtDireccion.Text) || MtxtTelefono.MaskCompleted||MtxtTelefonoTrabajo.MaskCompleted)
            {
                int aa = Logica.Instancia.ID2 = 1;

                Contact contact = new Contact();
                contact.Nombre = txtNombre.Text;
                contact.Apellidos = TxtApellidos.Text;
                contact.Direccion = TxtDireccion.Text;
                contact.TelefonoPersonal = MtxtTelefono.Text;
                contact.TelefonoTrabajo = MtxtTelefonoTrabajo.Text;
                contact.IdUsuario = aa;
                contact.Id = Logica.Instancia.ID;

                bool result = _servicio.Edit(contact);
                if (result)
                {
                    MessageBox.Show("Se ha Editado con exito", "Notificacion");
                }
                else
                {
                    MessageBox.Show("ERROR, Algo no anda bien", "Notificacion");

                }
                FrmPrincipal form = new FrmPrincipal();                
                ClearData();
                form.LoadData();
                form.Deselect();
                form.CargarDGV();

            }
            else
            {
                MessageBox.Show("No Se ha podido Editar por que los campos no estan llenos", "Notificacion");
            }
        }

        public void LoadEdit()
        {

            if (Logica.Instancia.ID>0)
            {
                Contact contact = new Contact();
                contact = _servicio.GetById(Logica.Instancia.ID);
                txtNombre.Text = contact.Nombre;
                TxtApellidos.Text = contact.Apellidos;
                TxtDireccion.Text = contact.Direccion;
                MtxtTelefono.Text = contact.TelefonoPersonal;
                MtxtTelefonoTrabajo.Text = contact.TelefonoTrabajo;
            }
        }
        public void ClearData()
        {
            txtNombre.Clear();
            TxtApellidos.Clear();
            TxtDireccion.Clear();
            MtxtTelefono.Clear();
            MtxtTelefonoTrabajo.Clear();
            selectedIndex = null;


        }




        #endregion

        private void BtnCancelarContacto_Click(object sender, EventArgs e)
        {
            FrmPrincipal form = new FrmPrincipal();
            form.Show();
            this.Close();
        }

        
    }
}

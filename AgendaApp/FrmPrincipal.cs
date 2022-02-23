using BussinessLayer;
using Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database.DSconexionTableAdapters;
using System.Data.SqlClient;
using Database;
using System.Configuration;

namespace AgendaApp
{
    public partial class FrmPrincipal : Form
    {
        private ServicioContacto _servicio;
        private ContactTypeService _contactTypeService;
        public int? id = null;
        public int? selectedIndex;

        public FrmPrincipal()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _servicio = new ServicioContacto(connection);
        }
        private void BtnDeseleccionar_Click(object sender, EventArgs e)
        {
            Deseleccionar();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmPrincipal form = new FrmPrincipal();
            form.Deselect(); 
            CargarDGV();           

        }
        public void CargarDGV()
        {
            DgvContactos.ClearSelection();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _servicio = new ServicioContacto(connection);

            string consulta = "select * from Contactos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, connection);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DgvContactos.DataSource = dt;
        }
        public void DgvContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FrmAgregarEditar form = new FrmAgregarEditar();
                selectedIndex = e.RowIndex;
                id = Convert.ToInt32(DgvContactos.Rows[e.RowIndex].Cells[0].Value.ToString());
                int abc = (int)selectedIndex;


                int aa = Logica.Instancia.ID = (int)id;
                int ab = Logica.Instancia.INDEX =Convert.ToInt32(abc);

                Contact contact = new Contact();
                contact = _servicio.GetById(id.Value);

                form.txtNombre.Text = contact.Nombre;
                form.TxtApellidos.Text = contact.Apellidos;
                form.TxtDireccion.Text = contact.Direccion;
                form.MtxtTelefono.Text = contact.TelefonoPersonal;
                form.MtxtTelefonoTrabajo.Text = contact.TelefonoTrabajo;


                BtnDeseleccionar.Visible = true;
            }
            else
            {
                FrmAgregarEditar form = new FrmAgregarEditar();
                selectedIndex = null;
            }
        }
        private void Deseleccionar()
        {
            FrmAgregarEditar form = new FrmAgregarEditar();
            DgvContactos.ClearSelection();
            BtnDeseleccionar.Visible = false;
            id = null;
            selectedIndex = null;
            form.ClearData();

        }
        private void btnNuevoContacto_Click(object sender, EventArgs e)
        {
            FrmAgregarEditar formAgg = new FrmAgregarEditar();
            formAgg.Show();
            this.Hide();
        }
        public  void LoadData()
        {
            DgvContactos.DataSource = _servicio.GetAll();
            DgvContactos.ClearSelection();
        }     
        public void Deselect()
        {
            DgvContactos.ClearSelection();
            BtnDeseleccionar.Visible = false;
            id = null;
            FrmAgregarEditar form = new FrmAgregarEditar();
            form.ClearData();
        }
        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            DeleteContact();
            CargarDGV();
        }
        private void DeleteContact()
        {
            FrmAgregarEditar formu = new FrmAgregarEditar();
            if (formu.selectedIndex == null)
            {
                MessageBox.Show("Debes seleccionar un contacto", "Notificacion");
            }
            else
            {
                DialogResult response = MessageBox.Show("Esta seguro que desea eliminar este contacto",
                    "Advertencia", MessageBoxButtons.OKCancel);

                if (response == DialogResult.OK)
                {
                    bool result = _servicio.Delete(id.Value);

                    if (result)
                    {
                        MessageBox.Show("Se ha eliminado con exito", "Notificacion");
                    }
                    else
                    {
                        MessageBox.Show("Oopss ha ocurrido un error", "Notificacion");
                    }
                    FrmPrincipal form = new FrmPrincipal();
                    form.LoadData();
                    form.Deselect();
                }

            }
        }
        private void btnEditarContacto_Click(object sender, EventArgs e)
        {
            FrmAgregarEditar form =new FrmAgregarEditar();
            form.BtnEditarContacto.Visible = true;
            form.btnAgregarContacto.Visible = false;
            form.Show();            
            this.Hide();
            
        }

        
    }
}

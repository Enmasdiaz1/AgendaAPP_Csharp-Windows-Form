
namespace AgendaApp
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.DgvContactos = new System.Windows.Forms.DataGridView();
            this.LblPrincipal = new System.Windows.Forms.Label();
            this.MstripContactos = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TlpBtnContactos = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevoContacto = new System.Windows.Forms.Button();
            this.BtnDeseleccionar = new System.Windows.Forms.Button();
            this.btnEliminarContacto = new System.Windows.Forms.Button();
            this.btnEditarContacto = new System.Windows.Forms.Button();
            this.TlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContactos)).BeginInit();
            this.MstripContactos.SuspendLayout();
            this.TlpBtnContactos.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 3;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.25806F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.74194F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.TlpPrincipal.Controls.Add(this.DgvContactos, 0, 2);
            this.TlpPrincipal.Controls.Add(this.LblPrincipal, 1, 1);
            this.TlpPrincipal.Controls.Add(this.MstripContactos, 0, 0);
            this.TlpPrincipal.Controls.Add(this.TlpBtnContactos, 2, 2);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 3;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.52381F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.47619F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 331F));
            this.TlpPrincipal.Size = new System.Drawing.Size(962, 422);
            this.TlpPrincipal.TabIndex = 0;
            // 
            // DgvContactos
            // 
            this.DgvContactos.AllowUserToAddRows = false;
            this.DgvContactos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvContactos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvContactos.BackgroundColor = System.Drawing.Color.Black;
            this.DgvContactos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvContactos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvContactos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TlpPrincipal.SetColumnSpan(this.DgvContactos, 2);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvContactos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvContactos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvContactos.GridColor = System.Drawing.Color.Black;
            this.DgvContactos.Location = new System.Drawing.Point(3, 93);
            this.DgvContactos.MultiSelect = false;
            this.DgvContactos.Name = "DgvContactos";
            this.DgvContactos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvContactos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvContactos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvContactos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.DgvContactos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SandyBrown;
            this.DgvContactos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SandyBrown;
            this.DgvContactos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvContactos.RowTemplate.Height = 25;
            this.DgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvContactos.ShowCellErrors = false;
            this.DgvContactos.ShowCellToolTips = false;
            this.DgvContactos.ShowEditingIcon = false;
            this.DgvContactos.ShowRowErrors = false;
            this.DgvContactos.Size = new System.Drawing.Size(746, 326);
            this.DgvContactos.TabIndex = 0;
            this.DgvContactos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvContactos_CellClick);
            // 
            // LblPrincipal
            // 
            this.LblPrincipal.AutoSize = true;
            this.LblPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblPrincipal.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPrincipal.ForeColor = System.Drawing.Color.SandyBrown;
            this.LblPrincipal.Location = new System.Drawing.Point(245, 31);
            this.LblPrincipal.Name = "LblPrincipal";
            this.LblPrincipal.Size = new System.Drawing.Size(504, 59);
            this.LblPrincipal.TabIndex = 3;
            this.LblPrincipal.Text = "  MIS CONTACTOS";
            // 
            // MstripContactos
            // 
            this.MstripContactos.BackColor = System.Drawing.Color.Black;
            this.TlpPrincipal.SetColumnSpan(this.MstripContactos, 2);
            this.MstripContactos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MstripContactos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.MstripContactos.Location = new System.Drawing.Point(0, 0);
            this.MstripContactos.Name = "MstripContactos";
            this.MstripContactos.Size = new System.Drawing.Size(752, 24);
            this.MstripContactos.TabIndex = 4;
            this.MstripContactos.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.cerrarSesionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // TlpBtnContactos
            // 
            this.TlpBtnContactos.ColumnCount = 1;
            this.TlpBtnContactos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpBtnContactos.Controls.Add(this.btnNuevoContacto, 0, 0);
            this.TlpBtnContactos.Controls.Add(this.BtnDeseleccionar, 0, 5);
            this.TlpBtnContactos.Controls.Add(this.btnEliminarContacto, 0, 3);
            this.TlpBtnContactos.Controls.Add(this.btnEditarContacto, 0, 2);
            this.TlpBtnContactos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpBtnContactos.Location = new System.Drawing.Point(755, 93);
            this.TlpBtnContactos.Name = "TlpBtnContactos";
            this.TlpBtnContactos.RowCount = 6;
            this.TlpBtnContactos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.94118F));
            this.TlpBtnContactos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.TlpBtnContactos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.TlpBtnContactos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.TlpBtnContactos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.TlpBtnContactos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpBtnContactos.Size = new System.Drawing.Size(204, 326);
            this.TlpBtnContactos.TabIndex = 5;
            // 
            // btnNuevoContacto
            // 
            this.btnNuevoContacto.BackColor = System.Drawing.Color.Black;
            this.btnNuevoContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevoContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoContacto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoContacto.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnNuevoContacto.Location = new System.Drawing.Point(3, 3);
            this.btnNuevoContacto.Name = "btnNuevoContacto";
            this.btnNuevoContacto.Size = new System.Drawing.Size(198, 39);
            this.btnNuevoContacto.TabIndex = 0;
            this.btnNuevoContacto.Text = "Nuevo Contacto";
            this.btnNuevoContacto.UseVisualStyleBackColor = false;
            this.btnNuevoContacto.Click += new System.EventHandler(this.btnNuevoContacto_Click);
            // 
            // BtnDeseleccionar
            // 
            this.BtnDeseleccionar.BackColor = System.Drawing.Color.Black;
            this.BtnDeseleccionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDeseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeseleccionar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDeseleccionar.ForeColor = System.Drawing.Color.SandyBrown;
            this.BtnDeseleccionar.Location = new System.Drawing.Point(3, 288);
            this.BtnDeseleccionar.Name = "BtnDeseleccionar";
            this.BtnDeseleccionar.Size = new System.Drawing.Size(198, 35);
            this.BtnDeseleccionar.TabIndex = 3;
            this.BtnDeseleccionar.Text = "Deseleccionar";
            this.BtnDeseleccionar.UseVisualStyleBackColor = false;
            this.BtnDeseleccionar.Visible = false;
            this.BtnDeseleccionar.Click += new System.EventHandler(this.BtnDeseleccionar_Click);
            // 
            // btnEliminarContacto
            // 
            this.btnEliminarContacto.BackColor = System.Drawing.Color.Black;
            this.btnEliminarContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarContacto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarContacto.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnEliminarContacto.Location = new System.Drawing.Point(3, 132);
            this.btnEliminarContacto.Name = "btnEliminarContacto";
            this.btnEliminarContacto.Size = new System.Drawing.Size(198, 35);
            this.btnEliminarContacto.TabIndex = 2;
            this.btnEliminarContacto.Text = "Eliminar Contacto";
            this.btnEliminarContacto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminarContacto.UseVisualStyleBackColor = false;
            this.btnEliminarContacto.Click += new System.EventHandler(this.btnEliminarContacto_Click);
            // 
            // btnEditarContacto
            // 
            this.btnEditarContacto.BackColor = System.Drawing.Color.Black;
            this.btnEditarContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarContacto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarContacto.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnEditarContacto.Location = new System.Drawing.Point(3, 88);
            this.btnEditarContacto.Name = "btnEditarContacto";
            this.btnEditarContacto.Size = new System.Drawing.Size(198, 38);
            this.btnEditarContacto.TabIndex = 1;
            this.btnEditarContacto.Text = "Editar Contacto";
            this.btnEditarContacto.UseVisualStyleBackColor = false;
            this.btnEditarContacto.Click += new System.EventHandler(this.btnEditarContacto_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(962, 422);
            this.Controls.Add(this.TlpPrincipal);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.MstripContactos;
            this.MinimumSize = new System.Drawing.Size(965, 461);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContactos)).EndInit();
            this.MstripContactos.ResumeLayout(false);
            this.MstripContactos.PerformLayout();
            this.TlpBtnContactos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private System.Windows.Forms.Label LblPrincipal;
        private System.Windows.Forms.MenuStrip MstripContactos;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel TlpBtnContactos;
        private System.Windows.Forms.Button btnEliminarContacto;
        private System.Windows.Forms.Button btnEditarContacto;
        private System.Windows.Forms.Button btnNuevoContacto;
        private System.Windows.Forms.Button BtnDeseleccionar;
        public System.Windows.Forms.DataGridView DgvContactos;
    }
}
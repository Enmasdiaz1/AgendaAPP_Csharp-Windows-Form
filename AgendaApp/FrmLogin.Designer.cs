
namespace AgendaApp
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TlpLogin = new System.Windows.Forms.TableLayoutPanel();
            this.PboxLogin = new System.Windows.Forms.PictureBox();
            this.TlpRegistrarmeLabel = new System.Windows.Forms.TableLayoutPanel();
            this.PboxRegistrar = new System.Windows.Forms.PictureBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.LblPass = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TlpLoginLabel = new System.Windows.Forms.TableLayoutPanel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TlpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxLogin)).BeginInit();
            this.TlpRegistrarmeLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxRegistrar)).BeginInit();
            this.TlpLoginLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpLogin
            // 
            this.TlpLogin.ColumnCount = 3;
            this.TlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.92746F));
            this.TlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.07254F));
            this.TlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.TlpLogin.Controls.Add(this.PboxLogin, 2, 0);
            this.TlpLogin.Controls.Add(this.TlpRegistrarmeLabel, 0, 3);
            this.TlpLogin.Controls.Add(this.TxtUsuario, 0, 2);
            this.TlpLogin.Controls.Add(this.TxtPass, 1, 2);
            this.TlpLogin.Controls.Add(this.LblPass, 1, 1);
            this.TlpLogin.Controls.Add(this.LblUsuario, 0, 1);
            this.TlpLogin.Controls.Add(this.TlpLoginLabel, 0, 0);
            this.TlpLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpLogin.Location = new System.Drawing.Point(0, 0);
            this.TlpLogin.Name = "TlpLogin";
            this.TlpLogin.RowCount = 5;
            this.TlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.TlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.TlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.TlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.TlpLogin.Size = new System.Drawing.Size(605, 202);
            this.TlpLogin.TabIndex = 0;
            // 
            // PboxLogin
            // 
            this.PboxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PboxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PboxLogin.Image = global::AgendaApp.Properties.Resources.Entrar2;
            this.PboxLogin.Location = new System.Drawing.Point(368, 3);
            this.PboxLogin.Name = "PboxLogin";
            this.TlpLogin.SetRowSpan(this.PboxLogin, 4);
            this.PboxLogin.Size = new System.Drawing.Size(234, 180);
            this.PboxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PboxLogin.TabIndex = 0;
            this.PboxLogin.TabStop = false;
            this.PboxLogin.Click += new System.EventHandler(this.PboxLogin_Click);
            // 
            // TlpRegistrarmeLabel
            // 
            this.TlpRegistrarmeLabel.ColumnCount = 3;
            this.TlpLogin.SetColumnSpan(this.TlpRegistrarmeLabel, 2);
            this.TlpRegistrarmeLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpRegistrarmeLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.TlpRegistrarmeLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.TlpRegistrarmeLabel.Controls.Add(this.PboxRegistrar, 1, 0);
            this.TlpRegistrarmeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpRegistrarmeLabel.Location = new System.Drawing.Point(3, 134);
            this.TlpRegistrarmeLabel.Name = "TlpRegistrarmeLabel";
            this.TlpRegistrarmeLabel.RowCount = 1;
            this.TlpRegistrarmeLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpRegistrarmeLabel.Size = new System.Drawing.Size(359, 49);
            this.TlpRegistrarmeLabel.TabIndex = 7;
            // 
            // PboxRegistrar
            // 
            this.PboxRegistrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PboxRegistrar.Image = global::AgendaApp.Properties.Resources.Registrarme2;
            this.PboxRegistrar.Location = new System.Drawing.Point(87, 3);
            this.PboxRegistrar.Name = "PboxRegistrar";
            this.PboxRegistrar.Size = new System.Drawing.Size(183, 43);
            this.PboxRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PboxRegistrar.TabIndex = 8;
            this.PboxRegistrar.TabStop = false;
            this.PboxRegistrar.Click += new System.EventHandler(this.PboxRegistrar_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.Black;
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtUsuario.ForeColor = System.Drawing.Color.White;
            this.TxtUsuario.Location = new System.Drawing.Point(3, 108);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(169, 23);
            this.TxtUsuario.TabIndex = 3;
            // 
            // TxtPass
            // 
            this.TxtPass.BackColor = System.Drawing.Color.Black;
            this.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtPass.ForeColor = System.Drawing.Color.White;
            this.TxtPass.Location = new System.Drawing.Point(178, 108);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(184, 23);
            this.TxtPass.TabIndex = 4;
            // 
            // LblPass
            // 
            this.LblPass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblPass.AutoSize = true;
            this.LblPass.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPass.ForeColor = System.Drawing.Color.SandyBrown;
            this.LblPass.Location = new System.Drawing.Point(219, 78);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(102, 27);
            this.LblPass.TabIndex = 2;
            this.LblPass.Text = "Contraseña:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUsuario.ForeColor = System.Drawing.Color.SandyBrown;
            this.LblUsuario.Location = new System.Drawing.Point(50, 78);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(75, 27);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Usuario:";
            // 
            // TlpLoginLabel
            // 
            this.TlpLoginLabel.ColumnCount = 3;
            this.TlpLogin.SetColumnSpan(this.TlpLoginLabel, 2);
            this.TlpLoginLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.TlpLoginLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.TlpLoginLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.TlpLoginLabel.Controls.Add(this.txtID, 2, 0);
            this.TlpLoginLabel.Controls.Add(this.LblLogin, 1, 0);
            this.TlpLoginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpLoginLabel.Location = new System.Drawing.Point(3, 3);
            this.TlpLoginLabel.Name = "TlpLoginLabel";
            this.TlpLoginLabel.RowCount = 1;
            this.TlpLoginLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpLoginLabel.Size = new System.Drawing.Size(359, 64);
            this.TlpLoginLabel.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Black;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(269, 3);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '*';
            this.txtID.Size = new System.Drawing.Size(87, 23);
            this.txtID.TabIndex = 8;
            this.txtID.Visible = false;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblLogin.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLogin.ForeColor = System.Drawing.Color.SandyBrown;
            this.LblLogin.Location = new System.Drawing.Point(79, 0);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(184, 64);
            this.LblLogin.TabIndex = 6;
            this.LblLogin.Text = "LOGIN";
            this.LblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(605, 202);
            this.Controls.Add(this.TlpLogin);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(621, 241);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logueo";
            this.TlpLogin.ResumeLayout(false);
            this.TlpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxLogin)).EndInit();
            this.TlpRegistrarmeLabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PboxRegistrar)).EndInit();
            this.TlpLoginLabel.ResumeLayout(false);
            this.TlpLoginLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpLogin;
        private System.Windows.Forms.PictureBox PboxLogin;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel TlpLoginLabel;
        private System.Windows.Forms.PictureBox PboxRegistrar;
        private System.Windows.Forms.TableLayoutPanel TlpRegistrarmeLabel;
        private System.Windows.Forms.TextBox txtID;
    }
}


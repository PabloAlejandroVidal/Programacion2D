namespace Aplicacion
{
    partial class frmApp
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApp));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.dtgInfo = new System.Windows.Forms.DataGridView();
            this.pnlMenuSub = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAgregarVuelo = new System.Windows.Forms.Button();
            this.btnAgregarPasajero = new System.Windows.Forms.Button();
            this.btnVerAviones = new System.Windows.Forms.Button();
            this.btnVerLugares = new System.Windows.Forms.Button();
            this.btnVerVuelos = new System.Windows.Forms.Button();
            this.btnVerPasajeros = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlLogin.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            this.pnlLogin.Controls.Add(this.cmbUser);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtPass);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1344, 754);
            this.pnlLogin.TabIndex = 3;
            this.pnlLogin.TabStop = true;
            // 
            // cmbUser
            // 
            this.cmbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbUser.DropDownWidth = 186;
            this.cmbUser.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(532, 249);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(280, 35);
            this.cmbUser.TabIndex = 1;
            this.cmbUser.Text = "Usuario";
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbUser_SelectedIndexChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(532, 423);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(280, 42);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.Location = new System.Drawing.Point(532, 312);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderText = "Contraseña";
            this.txtPass.Size = new System.Drawing.Size(280, 34);
            this.txtPass.TabIndex = 2;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlPrincipal.Controls.Add(this.pnlInfo);
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1344, 754);
            this.pnlPrincipal.TabIndex = 4;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfo.Controls.Add(this.panelDatos);
            this.pnlInfo.Controls.Add(this.panelMenu);
            this.pnlInfo.Location = new System.Drawing.Point(0, 56);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1344, 698);
            this.pnlInfo.TabIndex = 0;
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.dtgInfo);
            this.panelDatos.Controls.Add(this.pnlMenuSub);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatos.Location = new System.Drawing.Point(213, 0);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1131, 698);
            this.panelDatos.TabIndex = 6;
            // 
            // dtgInfo
            // 
            this.dtgInfo.AllowUserToResizeColumns = false;
            this.dtgInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.dtgInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgInfo.BackgroundColor = System.Drawing.Color.Black;
            this.dtgInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgInfo.ColumnHeadersHeight = 41;
            this.dtgInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgInfo.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgInfo.EnableHeadersVisualStyles = false;
            this.dtgInfo.Location = new System.Drawing.Point(6, 0);
            this.dtgInfo.Name = "dtgInfo";
            this.dtgInfo.ReadOnly = true;
            this.dtgInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgInfo.RowHeadersVisible = false;
            this.dtgInfo.RowHeadersWidth = 60;
            this.dtgInfo.RowTemplate.Height = 33;
            this.dtgInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgInfo.Size = new System.Drawing.Size(1122, 644);
            this.dtgInfo.TabIndex = 4;
            // 
            // pnlMenuSub
            // 
            this.pnlMenuSub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenuSub.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuSub.Location = new System.Drawing.Point(7, 648);
            this.pnlMenuSub.Name = "pnlMenuSub";
            this.pnlMenuSub.Size = new System.Drawing.Size(1121, 50);
            this.pnlMenuSub.TabIndex = 7;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.btnAgregarVuelo);
            this.panelMenu.Controls.Add(this.btnAgregarPasajero);
            this.panelMenu.Controls.Add(this.btnVerAviones);
            this.panelMenu.Controls.Add(this.btnVerLugares);
            this.panelMenu.Controls.Add(this.btnVerVuelos);
            this.panelMenu.Controls.Add(this.btnVerPasajeros);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(213, 698);
            this.panelMenu.TabIndex = 5;
            // 
            // btnAgregarVuelo
            // 
            this.btnAgregarVuelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarVuelo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVuelo.Location = new System.Drawing.Point(3, 603);
            this.btnAgregarVuelo.Name = "btnAgregarVuelo";
            this.btnAgregarVuelo.Size = new System.Drawing.Size(210, 40);
            this.btnAgregarVuelo.TabIndex = 1;
            this.btnAgregarVuelo.Text = "Agregar Vuelo";
            this.btnAgregarVuelo.UseVisualStyleBackColor = true;
            this.btnAgregarVuelo.Click += new System.EventHandler(this.btnAgregarVuelo_Click);
            // 
            // btnAgregarPasajero
            // 
            this.btnAgregarPasajero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarPasajero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarPasajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPasajero.Location = new System.Drawing.Point(3, 557);
            this.btnAgregarPasajero.Name = "btnAgregarPasajero";
            this.btnAgregarPasajero.Size = new System.Drawing.Size(210, 40);
            this.btnAgregarPasajero.TabIndex = 1;
            this.btnAgregarPasajero.Text = "Agregar Pasajero";
            this.btnAgregarPasajero.UseVisualStyleBackColor = false;
            this.btnAgregarPasajero.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnVerAviones
            // 
            this.btnVerAviones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerAviones.Location = new System.Drawing.Point(3, 139);
            this.btnVerAviones.Name = "btnVerAviones";
            this.btnVerAviones.Size = new System.Drawing.Size(210, 40);
            this.btnVerAviones.TabIndex = 3;
            this.btnVerAviones.Text = "Aviones";
            this.btnVerAviones.UseVisualStyleBackColor = true;
            this.btnVerAviones.Click += new System.EventHandler(this.btnMostrarAviones_Click);
            // 
            // btnVerLugares
            // 
            this.btnVerLugares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerLugares.Location = new System.Drawing.Point(3, 93);
            this.btnVerLugares.Name = "btnVerLugares";
            this.btnVerLugares.Size = new System.Drawing.Size(210, 40);
            this.btnVerLugares.TabIndex = 2;
            this.btnVerLugares.Text = "Lugares";
            this.btnVerLugares.UseVisualStyleBackColor = true;
            this.btnVerLugares.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnVerVuelos
            // 
            this.btnVerVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerVuelos.Location = new System.Drawing.Point(3, 47);
            this.btnVerVuelos.Name = "btnVerVuelos";
            this.btnVerVuelos.Size = new System.Drawing.Size(210, 40);
            this.btnVerVuelos.TabIndex = 0;
            this.btnVerVuelos.Text = "Vuelos";
            this.btnVerVuelos.UseVisualStyleBackColor = false;
            this.btnVerVuelos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerPasajeros
            // 
            this.btnVerPasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPasajeros.Location = new System.Drawing.Point(3, 1);
            this.btnVerPasajeros.Name = "btnVerPasajeros";
            this.btnVerPasajeros.Size = new System.Drawing.Size(210, 40);
            this.btnVerPasajeros.TabIndex = 1;
            this.btnVerPasajeros.Text = "Pasajeros";
            this.btnVerPasajeros.UseVisualStyleBackColor = true;
            this.btnVerPasajeros.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.cmbTema);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 50);
            this.panel1.TabIndex = 10;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFecha.Location = new System.Drawing.Point(220, 12);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 27);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "label1";
            // 
            // cmbTema
            // 
            this.cmbTema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTema.BackColor = System.Drawing.Color.Black;
            this.cmbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTema.ForeColor = System.Drawing.Color.White;
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Location = new System.Drawing.Point(1150, 9);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(182, 33);
            this.cmbTema.TabIndex = 1;
            this.cmbTema.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUsuario.Location = new System.Drawing.Point(12, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 27);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "label1";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlContenedor.Controls.Add(this.pnlPrincipal);
            this.pnlContenedor.Controls.Add(this.pnlLogin);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1344, 754);
            this.pnlContenedor.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 754);
            this.Controls.Add(this.pnlContenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "frmApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pachuli-Air";
            this.Load += new System.EventHandler(this.FormApp_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlLogin;
        private ComboBox cmbUser;
        private Button btnLogin;
        private TextBox txtPass;
        private Panel pnlPrincipal;
        private DataGridView dtgInfo;
        private Button btnAgregarPasajero;
        private Panel pnlInfo;
        private Button btnVerPasajeros;
        private Button btnVerVuelos;
        private Panel pnlContenedor;
        private Button btnAgregarVuelo;
        private Panel panelDatos;
        private Panel panelMenu;
        private Panel panel1;
        private Label lblUsuario;
        private Button btnVerLugares;
        private ComboBox cmbTema;
        private System.Windows.Forms.Timer timer1;
        private Label lblFecha;
        private Button btnVerAviones;
        private Panel pnlMenuSub;
    }
}
namespace Aplicacion
{
    partial class FormAgregarPasajero : Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbWifi = new System.Windows.Forms.ComboBox();
            this.lblWifi = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnSeleccionarVuelo = new System.Windows.Forms.Button();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lstVuelosDisponibles = new System.Windows.Forms.ListBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstPasajeros = new System.Windows.Forms.ListBox();
            this.cmbClase = new System.Windows.Forms.ComboBox();
            this.lblClase = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.cmbTipoComida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstResumen = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbWifi);
            this.panel1.Controls.Add(this.lblWifi);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.btnSeleccionarVuelo);
            this.panel1.Controls.Add(this.cmbDestino);
            this.panel1.Controls.Add(this.lblDestino);
            this.panel1.Controls.Add(this.lstVuelosDisponibles);
            this.panel1.Controls.Add(this.cmbOrigen);
            this.panel1.Controls.Add(this.lblOrigen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 517);
            this.panel1.TabIndex = 37;
            // 
            // cmbWifi
            // 
            this.cmbWifi.FormattingEnabled = true;
            this.cmbWifi.Location = new System.Drawing.Point(57, 140);
            this.cmbWifi.Name = "cmbWifi";
            this.cmbWifi.Size = new System.Drawing.Size(239, 33);
            this.cmbWifi.TabIndex = 39;
            // 
            // lblWifi
            // 
            this.lblWifi.AutoSize = true;
            this.lblWifi.Location = new System.Drawing.Point(57, 112);
            this.lblWifi.Name = "lblWifi";
            this.lblWifi.Size = new System.Drawing.Size(53, 25);
            this.lblWifi.TabIndex = 45;
            this.lblWifi.Text = "Wi-Fi";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(418, 140);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(239, 34);
            this.dtpFecha.TabIndex = 40;
            // 
            // btnSeleccionarVuelo
            // 
            this.btnSeleccionarVuelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeleccionarVuelo.Location = new System.Drawing.Point(182, 442);
            this.btnSeleccionarVuelo.Name = "btnSeleccionarVuelo";
            this.btnSeleccionarVuelo.Size = new System.Drawing.Size(350, 34);
            this.btnSeleccionarVuelo.TabIndex = 42;
            this.btnSeleccionarVuelo.Text = "Seleccionar Vuelo";
            this.btnSeleccionarVuelo.UseVisualStyleBackColor = true;
            this.btnSeleccionarVuelo.Click += new System.EventHandler(this.btnSeleccionarVuelo_Click);
            // 
            // cmbDestino
            // 
            this.cmbDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(418, 57);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(239, 33);
            this.cmbDestino.TabIndex = 38;
            this.cmbDestino.SelectedValueChanged += new System.EventHandler(this.cmbDestino_SelectedValueChanged);
            // 
            // lblDestino
            // 
            this.lblDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(417, 29);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(73, 25);
            this.lblDestino.TabIndex = 44;
            this.lblDestino.Text = "Destino";
            // 
            // lstVuelosDisponibles
            // 
            this.lstVuelosDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVuelosDisponibles.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstVuelosDisponibles.FormattingEnabled = true;
            this.lstVuelosDisponibles.ItemHeight = 22;
            this.lstVuelosDisponibles.Location = new System.Drawing.Point(57, 193);
            this.lstVuelosDisponibles.Name = "lstVuelosDisponibles";
            this.lstVuelosDisponibles.Size = new System.Drawing.Size(600, 180);
            this.lstVuelosDisponibles.TabIndex = 41;
            this.lstVuelosDisponibles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstVuelosDisponibles_MouseDoubleClick);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(57, 57);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(239, 33);
            this.cmbOrigen.TabIndex = 37;
            this.cmbOrigen.SelectedValueChanged += new System.EventHandler(this.cmbOrigen_SelectedValueChanged);
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(57, 29);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(66, 25);
            this.lblOrigen.TabIndex = 43;
            this.lblOrigen.Text = "Origen";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lstPasajeros);
            this.panel2.Controls.Add(this.cmbClase);
            this.panel2.Controls.Add(this.lblClase);
            this.panel2.Controls.Add(this.lblDni);
            this.panel2.Controls.Add(this.txtDni);
            this.panel2.Controls.Add(this.cmbTipoComida);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 517);
            this.panel2.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Ingrese los datos del nuevo pasajero para el vuelo ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(57, 279);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(239, 34);
            this.button5.TabIndex = 57;
            this.button5.Text = "Quitar Pasajero";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.QuitarPasajero);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(417, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(239, 34);
            this.button4.TabIndex = 56;
            this.button4.Text = "Agregar Pasajero";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AgregarPasajero);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 34);
            this.button2.TabIndex = 55;
            this.button2.Text = "Atras";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(496, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 34);
            this.button1.TabIndex = 54;
            this.button1.Text = "Realizar Pago";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstPasajeros
            // 
            this.lstPasajeros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPasajeros.FormattingEnabled = true;
            this.lstPasajeros.ItemHeight = 25;
            this.lstPasajeros.Location = new System.Drawing.Point(58, 324);
            this.lstPasajeros.Name = "lstPasajeros";
            this.lstPasajeros.Size = new System.Drawing.Size(598, 129);
            this.lstPasajeros.TabIndex = 53;
            // 
            // cmbClase
            // 
            this.cmbClase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbClase.FormattingEnabled = true;
            this.cmbClase.Location = new System.Drawing.Point(339, 227);
            this.cmbClase.Name = "cmbClase";
            this.cmbClase.Size = new System.Drawing.Size(318, 33);
            this.cmbClase.TabIndex = 51;
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(58, 230);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(53, 25);
            this.lblClase.TabIndex = 50;
            this.lblClase.Text = "Clase";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(58, 81);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(43, 25);
            this.lblDni.TabIndex = 49;
            this.lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDni.Location = new System.Drawing.Point(339, 78);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(318, 31);
            this.txtDni.TabIndex = 48;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // cmbTipoComida
            // 
            this.cmbTipoComida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoComida.FormattingEnabled = true;
            this.cmbTipoComida.Location = new System.Drawing.Point(339, 176);
            this.cmbTipoComida.Name = "cmbTipoComida";
            this.cmbTipoComida.Size = new System.Drawing.Size(318, 33);
            this.cmbTipoComida.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Tipo de Comida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nombre Completo";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(339, 127);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(318, 31);
            this.txtNombre.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lstResumen);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(715, 517);
            this.panel3.TabIndex = 39;
            // 
            // lstResumen
            // 
            this.lstResumen.FormattingEnabled = true;
            this.lstResumen.ItemHeight = 25;
            this.lstResumen.Location = new System.Drawing.Point(58, 271);
            this.lstResumen.Name = "lstResumen";
            this.lstResumen.Size = new System.Drawing.Size(599, 104);
            this.lstResumen.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(57, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Resumen De Vuelos";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(470, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Finalizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pasajes Turista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pasajes Premium";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Total Turista";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(474, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "Total Premium";
            // 
            // FormAgregarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 517);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormAgregarPasajero";
            this.Text = "FormSeleccionVuelo";
            this.Load += new System.EventHandler(this.FormSeleccionVuelo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox cmbWifi;
        private Label lblWifi;
        private DateTimePicker dtpFecha;
        private Button btnSeleccionarVuelo;
        private ComboBox cmbDestino;
        private Label lblDestino;
        private ListBox lstVuelosDisponibles;
        private ComboBox cmbOrigen;
        private Label lblOrigen;
        private Panel panel2;
        private ListBox lstPasajeros;
        private ComboBox cmbClase;
        private Label lblClase;
        private Label lblDni;
        private TextBox txtDni;
        private ComboBox cmbTipoComida;
        private Label label4;
        private Label label2;
        private TextBox txtNombre;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private ListBox lstResumen;
        private Label label5;
        private Label label1;
        private Label label11;
        private Label label12;
        private Label label9;
        private Label label10;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label3;
    }
}
namespace Aplicacion
{
    partial class FormAgregarVuelo
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
            this.button1 = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lstVuelosDisponibles = new System.Windows.Forms.ListBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(483, 154);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(239, 34);
            this.dtpFecha.TabIndex = 49;
            // 
            // cmbDestino
            // 
            this.cmbDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(483, 75);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(239, 33);
            this.cmbDestino.TabIndex = 47;
            // 
            // lblDestino
            // 
            this.lblDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(483, 47);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(73, 25);
            this.lblDestino.TabIndex = 52;
            this.lblDestino.Text = "Destino";
            // 
            // lstVuelosDisponibles
            // 
            this.lstVuelosDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVuelosDisponibles.FormattingEnabled = true;
            this.lstVuelosDisponibles.ItemHeight = 25;
            this.lstVuelosDisponibles.Location = new System.Drawing.Point(79, 253);
            this.lstVuelosDisponibles.Name = "lstVuelosDisponibles";
            this.lstVuelosDisponibles.Size = new System.Drawing.Size(643, 129);
            this.lstVuelosDisponibles.TabIndex = 50;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(75, 75);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(239, 33);
            this.cmbOrigen.TabIndex = 46;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(75, 47);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(66, 25);
            this.lblOrigen.TabIndex = 51;
            this.lblOrigen.Text = "Origen";
            // 
            // FormAgregarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lstVuelosDisponibles);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.button1);
            this.Name = "FormAgregarVuelo";
            this.Text = "FormAgregarVuelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private DateTimePicker dtpFecha;
        private ComboBox cmbDestino;
        private Label lblDestino;
        private ListBox lstVuelosDisponibles;
        private ComboBox cmbOrigen;
        private Label lblOrigen;
    }
}
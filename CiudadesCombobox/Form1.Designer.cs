namespace CiudadesCombobox
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAgregarCiudad = new System.Windows.Forms.TextBox();
            this.comboBoxProvincias = new System.Windows.Forms.ComboBox();
            this.comboBoxCiudades = new System.Windows.Forms.ComboBox();
            this.labelProvincias = new System.Windows.Forms.Label();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.labelAgregarCiudad = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAgregarCiudad
            // 
            this.textBoxAgregarCiudad.Location = new System.Drawing.Point(143, 135);
            this.textBoxAgregarCiudad.MaxLength = 50;
            this.textBoxAgregarCiudad.Name = "textBoxAgregarCiudad";
            this.textBoxAgregarCiudad.Size = new System.Drawing.Size(274, 20);
            this.textBoxAgregarCiudad.TabIndex = 0;
            this.textBoxAgregarCiudad.Leave += new System.EventHandler(this.textBoxAgregarCiudad_Leave);
            // 
            // comboBoxProvincias
            // 
            this.comboBoxProvincias.FormattingEnabled = true;
            this.comboBoxProvincias.Location = new System.Drawing.Point(143, 47);
            this.comboBoxProvincias.Name = "comboBoxProvincias";
            this.comboBoxProvincias.Size = new System.Drawing.Size(274, 21);
            this.comboBoxProvincias.TabIndex = 1;
            this.comboBoxProvincias.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvincias_SelectedIndexChanged);
            // 
            // comboBoxCiudades
            // 
            this.comboBoxCiudades.FormattingEnabled = true;
            this.comboBoxCiudades.Location = new System.Drawing.Point(143, 89);
            this.comboBoxCiudades.Name = "comboBoxCiudades";
            this.comboBoxCiudades.Size = new System.Drawing.Size(274, 21);
            this.comboBoxCiudades.TabIndex = 2;
            // 
            // labelProvincias
            // 
            this.labelProvincias.AutoSize = true;
            this.labelProvincias.Location = new System.Drawing.Point(31, 50);
            this.labelProvincias.Name = "labelProvincias";
            this.labelProvincias.Size = new System.Drawing.Size(54, 13);
            this.labelProvincias.TabIndex = 3;
            this.labelProvincias.Text = "Provincia:";
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Location = new System.Drawing.Point(31, 97);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(43, 13);
            this.labelCiudad.TabIndex = 4;
            this.labelCiudad.Text = "Ciudad:";
            // 
            // labelAgregarCiudad
            // 
            this.labelAgregarCiudad.AutoSize = true;
            this.labelAgregarCiudad.Location = new System.Drawing.Point(31, 135);
            this.labelAgregarCiudad.Name = "labelAgregarCiudad";
            this.labelAgregarCiudad.Size = new System.Drawing.Size(82, 13);
            this.labelAgregarCiudad.TabIndex = 5;
            this.labelAgregarCiudad.Text = "Agregar ciudad:";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Enabled = false;
            this.buttonAgregar.Location = new System.Drawing.Point(143, 179);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(153, 23);
            this.buttonAgregar.TabIndex = 6;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 225);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.labelAgregarCiudad);
            this.Controls.Add(this.labelCiudad);
            this.Controls.Add(this.labelProvincias);
            this.Controls.Add(this.comboBoxCiudades);
            this.Controls.Add(this.comboBoxProvincias);
            this.Controls.Add(this.textBoxAgregarCiudad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAgregarCiudad;
        private System.Windows.Forms.ComboBox comboBoxProvincias;
        private System.Windows.Forms.ComboBox comboBoxCiudades;
        private System.Windows.Forms.Label labelProvincias;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelAgregarCiudad;
        private System.Windows.Forms.Button buttonAgregar;
    }
}


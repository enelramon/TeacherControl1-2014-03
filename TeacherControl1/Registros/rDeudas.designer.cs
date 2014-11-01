namespace TeacherControl1
{
    partial class rDeudas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rDeudas));
            this.IdDeudalabel = new System.Windows.Forms.Label();
            this.IdEstudiantelabel = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.VencedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.Vencelabel = new System.Windows.Forms.Label();
            this.Cantidadlabel = new System.Windows.Forms.Label();
            this.Balancelabel = new System.Windows.Forms.Label();
            this.IdEstudiantecomboBox = new System.Windows.Forms.ComboBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.IdDeudatextBox = new System.Windows.Forms.TextBox();
            this.BalancetextBox = new System.Windows.Forms.TextBox();
            this.Actualizarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdDeudalabel
            // 
            this.IdDeudalabel.AutoSize = true;
            this.IdDeudalabel.Location = new System.Drawing.Point(12, 15);
            this.IdDeudalabel.Name = "IdDeudalabel";
            this.IdDeudalabel.Size = new System.Drawing.Size(48, 13);
            this.IdDeudalabel.TabIndex = 2;
            this.IdDeudalabel.Text = "IdDeuda";
            // 
            // IdEstudiantelabel
            // 
            this.IdEstudiantelabel.AutoSize = true;
            this.IdEstudiantelabel.Location = new System.Drawing.Point(11, 75);
            this.IdEstudiantelabel.Name = "IdEstudiantelabel";
            this.IdEstudiantelabel.Size = new System.Drawing.Size(66, 13);
            this.IdEstudiantelabel.TabIndex = 3;
            this.IdEstudiantelabel.Text = "IdEstudiante";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(83, 38);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(123, 20);
            this.FechadateTimePicker.TabIndex = 1;
            this.FechadateTimePicker.Value = new System.DateTime(2014, 10, 26, 8, 8, 0, 0);
            // 
            // VencedateTimePicker
            // 
            this.VencedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VencedateTimePicker.Location = new System.Drawing.Point(291, 70);
            this.VencedateTimePicker.Name = "VencedateTimePicker";
            this.VencedateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.VencedateTimePicker.TabIndex = 2;
            this.VencedateTimePicker.Value = new System.DateTime(2014, 10, 26, 8, 8, 0, 0);
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(12, 44);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(40, 13);
            this.Fechalabel.TabIndex = 6;
            this.Fechalabel.Text = "Fecha ";
            // 
            // Vencelabel
            // 
            this.Vencelabel.AutoSize = true;
            this.Vencelabel.Location = new System.Drawing.Point(220, 72);
            this.Vencelabel.Name = "Vencelabel";
            this.Vencelabel.Size = new System.Drawing.Size(65, 13);
            this.Vencelabel.TabIndex = 7;
            this.Vencelabel.Text = "Vencimiento";
            // 
            // Cantidadlabel
            // 
            this.Cantidadlabel.AutoSize = true;
            this.Cantidadlabel.Location = new System.Drawing.Point(11, 108);
            this.Cantidadlabel.Name = "Cantidadlabel";
            this.Cantidadlabel.Size = new System.Drawing.Size(49, 13);
            this.Cantidadlabel.TabIndex = 10;
            this.Cantidadlabel.Text = "Cantidad";
            // 
            // Balancelabel
            // 
            this.Balancelabel.AutoSize = true;
            this.Balancelabel.Location = new System.Drawing.Point(220, 107);
            this.Balancelabel.Name = "Balancelabel";
            this.Balancelabel.Size = new System.Drawing.Size(46, 13);
            this.Balancelabel.TabIndex = 11;
            this.Balancelabel.Text = "Balance";
            // 
            // IdEstudiantecomboBox
            // 
            this.IdEstudiantecomboBox.DisplayMember = "1";
            this.IdEstudiantecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdEstudiantecomboBox.FormattingEnabled = true;
            this.IdEstudiantecomboBox.Location = new System.Drawing.Point(83, 72);
            this.IdEstudiantecomboBox.Name = "IdEstudiantecomboBox";
            this.IdEstudiantecomboBox.Size = new System.Drawing.Size(123, 21);
            this.IdEstudiantecomboBox.TabIndex = 12;
            this.IdEstudiantecomboBox.ValueMember = "1";
            this.IdEstudiantecomboBox.SelectedValueChanged += new System.EventHandler(this.IdEstudiantecomboBox_SelectedValueChanged);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackgroundImage = global::TeacherControl1.Properties.Resources.Guardar;
            this.Guardarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guardarbutton.CausesValidation = false;
            this.Guardarbutton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Guardarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardarbutton.Location = new System.Drawing.Point(212, 141);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(95, 45);
            this.Guardarbutton.TabIndex = 15;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackgroundImage = global::TeacherControl1.Properties.Resources.Eliminar;
            this.Eliminarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Eliminarbutton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbutton.Location = new System.Drawing.Point(313, 141);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(94, 45);
            this.Eliminarbutton.TabIndex = 14;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.BackgroundImage")));
            this.Nuevobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Nuevobutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Nuevobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevobutton.Location = new System.Drawing.Point(12, 141);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(94, 45);
            this.Nuevobutton.TabIndex = 16;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackgroundImage = global::TeacherControl1.Properties.Resources.Buscar;
            this.Buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Buscarbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Buscarbutton.Location = new System.Drawing.Point(223, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(105, 41);
            this.Buscarbutton.TabIndex = 17;
            this.Buscarbutton.Tag = "";
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(83, 103);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(123, 20);
            this.CantidadtextBox.TabIndex = 18;
            // 
            // IdDeudatextBox
            // 
            this.IdDeudatextBox.Location = new System.Drawing.Point(83, 12);
            this.IdDeudatextBox.Name = "IdDeudatextBox";
            this.IdDeudatextBox.Size = new System.Drawing.Size(123, 20);
            this.IdDeudatextBox.TabIndex = 19;
            // 
            // BalancetextBox
            // 
            this.BalancetextBox.Location = new System.Drawing.Point(289, 104);
            this.BalancetextBox.Name = "BalancetextBox";
            this.BalancetextBox.Size = new System.Drawing.Size(100, 20);
            this.BalancetextBox.TabIndex = 20;
            // 
            // Actualizarbutton
            // 
            this.Actualizarbutton.BackgroundImage = global::TeacherControl1.Properties.Resources.actualizacion;
            this.Actualizarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Actualizarbutton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Actualizarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizarbutton.Location = new System.Drawing.Point(112, 141);
            this.Actualizarbutton.Name = "Actualizarbutton";
            this.Actualizarbutton.Size = new System.Drawing.Size(94, 45);
            this.Actualizarbutton.TabIndex = 22;
            this.Actualizarbutton.Text = "Actualizar";
            this.Actualizarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Actualizarbutton.UseVisualStyleBackColor = true;
            this.Actualizarbutton.Click += new System.EventHandler(this.Actualizarbutton_Click);
            // 
            // rDeudas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 198);
            this.Controls.Add(this.Actualizarbutton);
            this.Controls.Add(this.BalancetextBox);
            this.Controls.Add(this.IdDeudatextBox);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.IdEstudiantecomboBox);
            this.Controls.Add(this.Balancelabel);
            this.Controls.Add(this.Cantidadlabel);
            this.Controls.Add(this.Vencelabel);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.VencedateTimePicker);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.IdEstudiantelabel);
            this.Controls.Add(this.IdDeudalabel);
            this.Name = "rDeudas";
            this.Text = "Deudas";
            this.Load += new System.EventHandler(this.rDeudas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdDeudalabel;
        private System.Windows.Forms.Label IdEstudiantelabel;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.DateTimePicker VencedateTimePicker;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label Vencelabel;
        private System.Windows.Forms.Label Cantidadlabel;
        private System.Windows.Forms.Label Balancelabel;
        private System.Windows.Forms.ComboBox IdEstudiantecomboBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.TextBox IdDeudatextBox;
        private System.Windows.Forms.TextBox BalancetextBox;
        private System.Windows.Forms.Button Actualizarbutton;
    }
}
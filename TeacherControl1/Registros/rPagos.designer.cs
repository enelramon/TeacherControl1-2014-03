namespace TeacherControl1
{
    partial class rPagosDeudas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rPagosDeudas));
            this.IdPagoslabel = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.IdDeudalabel = new System.Windows.Forms.Label();
            this.IdEstudiantelabel = new System.Windows.Forms.Label();
            this.Cantidadlabel = new System.Windows.Forms.Label();
            this.IdPagotextBox = new System.Windows.Forms.TextBox();
            this.IdEstudiantecomboBox = new System.Windows.Forms.ComboBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.IdDeudacomboBox = new System.Windows.Forms.ComboBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Actualizarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdPagoslabel
            // 
            this.IdPagoslabel.AutoSize = true;
            this.IdPagoslabel.Location = new System.Drawing.Point(13, 18);
            this.IdPagoslabel.Name = "IdPagoslabel";
            this.IdPagoslabel.Size = new System.Drawing.Size(41, 13);
            this.IdPagoslabel.TabIndex = 3;
            this.IdPagoslabel.Text = "IdPago";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(281, 51);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.FechadateTimePicker.TabIndex = 4;
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(226, 51);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(37, 13);
            this.Fechalabel.TabIndex = 5;
            this.Fechalabel.Text = "Fecha";
            // 
            // IdDeudalabel
            // 
            this.IdDeudalabel.AutoSize = true;
            this.IdDeudalabel.Location = new System.Drawing.Point(13, 93);
            this.IdDeudalabel.Name = "IdDeudalabel";
            this.IdDeudalabel.Size = new System.Drawing.Size(48, 13);
            this.IdDeudalabel.TabIndex = 6;
            this.IdDeudalabel.Text = "IdDeuda";
            // 
            // IdEstudiantelabel
            // 
            this.IdEstudiantelabel.AutoSize = true;
            this.IdEstudiantelabel.Location = new System.Drawing.Point(13, 51);
            this.IdEstudiantelabel.Name = "IdEstudiantelabel";
            this.IdEstudiantelabel.Size = new System.Drawing.Size(66, 13);
            this.IdEstudiantelabel.TabIndex = 7;
            this.IdEstudiantelabel.Text = "IdEstudiante";
            // 
            // Cantidadlabel
            // 
            this.Cantidadlabel.AutoSize = true;
            this.Cantidadlabel.Location = new System.Drawing.Point(226, 93);
            this.Cantidadlabel.Name = "Cantidadlabel";
            this.Cantidadlabel.Size = new System.Drawing.Size(49, 13);
            this.Cantidadlabel.TabIndex = 10;
            this.Cantidadlabel.Text = "Cantidad";
            // 
            // IdPagotextBox
            // 
            this.IdPagotextBox.Location = new System.Drawing.Point(85, 11);
            this.IdPagotextBox.Name = "IdPagotextBox";
            this.IdPagotextBox.Size = new System.Drawing.Size(121, 20);
            this.IdPagotextBox.TabIndex = 11;
            // 
            // IdEstudiantecomboBox
            // 
            this.IdEstudiantecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdEstudiantecomboBox.FormattingEnabled = true;
            this.IdEstudiantecomboBox.Location = new System.Drawing.Point(85, 48);
            this.IdEstudiantecomboBox.Name = "IdEstudiantecomboBox";
            this.IdEstudiantecomboBox.Size = new System.Drawing.Size(121, 21);
            this.IdEstudiantecomboBox.TabIndex = 12; 
            this.IdEstudiantecomboBox.SelectedValueChanged += new System.EventHandler(this.IdEstudiantecomboBox_SelectedValueChanged);
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(281, 90);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(121, 20);
            this.CantidadtextBox.TabIndex = 13;
            // 
            // IdDeudacomboBox
            // 
            this.IdDeudacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdDeudacomboBox.FormattingEnabled = true;
            this.IdDeudacomboBox.Location = new System.Drawing.Point(85, 90);
            this.IdDeudacomboBox.Name = "IdDeudacomboBox";
            this.IdDeudacomboBox.Size = new System.Drawing.Size(121, 21);
            this.IdDeudacomboBox.TabIndex = 14;
            this.IdDeudacomboBox.SelectedIndexChanged += new System.EventHandler(this.IdDeudacomboBox_SelectedIndexChanged);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.BackgroundImage")));
            this.Nuevobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Nuevobutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Nuevobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevobutton.Location = new System.Drawing.Point(9, 128);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(94, 45);
            this.Nuevobutton.TabIndex = 19;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackgroundImage = global::TeacherControl1.Properties.Resources.Eliminar;
            this.Eliminarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Eliminarbutton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbutton.Location = new System.Drawing.Point(310, 128);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(94, 45);
            this.Eliminarbutton.TabIndex = 17;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackgroundImage = global::TeacherControl1.Properties.Resources.Guardar;
            this.Guardarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guardarbutton.CausesValidation = false;
            this.Guardarbutton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Guardarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardarbutton.Location = new System.Drawing.Point(209, 128);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(95, 45);
            this.Guardarbutton.TabIndex = 18;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click_1);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackgroundImage = global::TeacherControl1.Properties.Resources.Buscar;
            this.Buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Buscarbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Buscarbutton.Location = new System.Drawing.Point(229, 4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(105, 41);
            this.Buscarbutton.TabIndex = 20;
            this.Buscarbutton.Tag = "";
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Actualizarbutton
            // 
            this.Actualizarbutton.BackgroundImage = global::TeacherControl1.Properties.Resources.actualizacion;
            this.Actualizarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Actualizarbutton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Actualizarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizarbutton.Location = new System.Drawing.Point(109, 128);
            this.Actualizarbutton.Name = "Actualizarbutton";
            this.Actualizarbutton.Size = new System.Drawing.Size(94, 45);
            this.Actualizarbutton.TabIndex = 21;
            this.Actualizarbutton.Text = "Actualizar";
            this.Actualizarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Actualizarbutton.UseVisualStyleBackColor = true;
            this.Actualizarbutton.Click += new System.EventHandler(this.Actualizarbutton_Click);
            // 
            // rPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 188);
            this.Controls.Add(this.Actualizarbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.IdDeudacomboBox);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.IdEstudiantecomboBox);
            this.Controls.Add(this.IdPagotextBox);
            this.Controls.Add(this.Cantidadlabel);
            this.Controls.Add(this.IdEstudiantelabel);
            this.Controls.Add(this.IdDeudalabel);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.IdPagoslabel);
            this.Name = "rPagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.rPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdPagoslabel;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label IdDeudalabel;
        private System.Windows.Forms.Label IdEstudiantelabel;
        private System.Windows.Forms.Label Cantidadlabel;
        private System.Windows.Forms.TextBox IdPagotextBox;
        private System.Windows.Forms.ComboBox IdEstudiantecomboBox;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.ComboBox IdDeudacomboBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Actualizarbutton;

    }
}
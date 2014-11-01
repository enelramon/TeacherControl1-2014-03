namespace TeacherControl1
{
    partial class rEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rEstudiante));
            this.idEstudiantelabel = new System.Windows.Forms.Label();
            this.Matriculalabel = new System.Windows.Forms.Label();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.Apellidolabel = new System.Windows.Forms.Label();
            this.FechaNaclabel = new System.Windows.Forms.Label();
            this.Direccionlabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.ApellidotextBox = new System.Windows.Forms.TextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.FechaNacdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Telefonolabel = new System.Windows.Forms.Label();
            this.Cedulalabel = new System.Windows.Forms.Label();
            this.Generolabel = new System.Windows.Forms.Label();
            this.GenerocomboBox = new System.Windows.Forms.ComboBox();
            this.MatriculamaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.TelefonfomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CedulamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.IdEstudiantemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Actualizarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idEstudiantelabel
            // 
            this.idEstudiantelabel.AutoSize = true;
            this.idEstudiantelabel.Location = new System.Drawing.Point(13, 13);
            this.idEstudiantelabel.Name = "idEstudiantelabel";
            this.idEstudiantelabel.Size = new System.Drawing.Size(66, 13);
            this.idEstudiantelabel.TabIndex = 0;
            this.idEstudiantelabel.Text = "IdEstudiante";
            // 
            // Matriculalabel
            // 
            this.Matriculalabel.AutoSize = true;
            this.Matriculalabel.Location = new System.Drawing.Point(12, 41);
            this.Matriculalabel.Name = "Matriculalabel";
            this.Matriculalabel.Size = new System.Drawing.Size(50, 13);
            this.Matriculalabel.TabIndex = 1;
            this.Matriculalabel.Text = "Matricula";
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(13, 71);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(44, 13);
            this.Nombrelabel.TabIndex = 2;
            this.Nombrelabel.Text = "Nombre";
            // 
            // Apellidolabel
            // 
            this.Apellidolabel.AutoSize = true;
            this.Apellidolabel.Location = new System.Drawing.Point(13, 107);
            this.Apellidolabel.Name = "Apellidolabel";
            this.Apellidolabel.Size = new System.Drawing.Size(44, 13);
            this.Apellidolabel.TabIndex = 3;
            this.Apellidolabel.Text = "Apellido";
            // 
            // FechaNaclabel
            // 
            this.FechaNaclabel.AutoSize = true;
            this.FechaNaclabel.Location = new System.Drawing.Point(13, 142);
            this.FechaNaclabel.Name = "FechaNaclabel";
            this.FechaNaclabel.Size = new System.Drawing.Size(75, 13);
            this.FechaNaclabel.TabIndex = 4;
            this.FechaNaclabel.Text = "Fecha de Nac";
            // 
            // Direccionlabel
            // 
            this.Direccionlabel.AutoSize = true;
            this.Direccionlabel.Location = new System.Drawing.Point(13, 179);
            this.Direccionlabel.Name = "Direccionlabel";
            this.Direccionlabel.Size = new System.Drawing.Size(52, 13);
            this.Direccionlabel.TabIndex = 5;
            this.Direccionlabel.Text = "Direccion";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(13, 214);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(32, 13);
            this.Emaillabel.TabIndex = 6;
            this.Emaillabel.Text = "Email";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(86, 71);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(145, 20);
            this.NombretextBox.TabIndex = 3;
            this.NombretextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombretextBox_KeyPress);
            // 
            // ApellidotextBox
            // 
            this.ApellidotextBox.Location = new System.Drawing.Point(86, 107);
            this.ApellidotextBox.Name = "ApellidotextBox";
            this.ApellidotextBox.Size = new System.Drawing.Size(145, 20);
            this.ApellidotextBox.TabIndex = 4;
            this.ApellidotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidotextBox_KeyPress);
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(86, 179);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(335, 20);
            this.DirecciontextBox.TabIndex = 9;
            // 
            // FechaNacdateTimePicker
            // 
            this.FechaNacdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaNacdateTimePicker.Location = new System.Drawing.Point(86, 142);
            this.FechaNacdateTimePicker.Name = "FechaNacdateTimePicker";
            this.FechaNacdateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.FechaNacdateTimePicker.TabIndex = 5;
            this.FechaNacdateTimePicker.Value = new System.DateTime(2014, 10, 11, 0, 0, 0, 0);
            // 
            // Telefonolabel
            // 
            this.Telefonolabel.AutoSize = true;
            this.Telefonolabel.Location = new System.Drawing.Point(259, 71);
            this.Telefonolabel.Name = "Telefonolabel";
            this.Telefonolabel.Size = new System.Drawing.Size(49, 13);
            this.Telefonolabel.TabIndex = 15;
            this.Telefonolabel.Text = "Telefono";
            // 
            // Cedulalabel
            // 
            this.Cedulalabel.AutoSize = true;
            this.Cedulalabel.Location = new System.Drawing.Point(262, 107);
            this.Cedulalabel.Name = "Cedulalabel";
            this.Cedulalabel.Size = new System.Drawing.Size(40, 13);
            this.Cedulalabel.TabIndex = 16;
            this.Cedulalabel.Text = "Cedula";
            // 
            // Generolabel
            // 
            this.Generolabel.AutoSize = true;
            this.Generolabel.Location = new System.Drawing.Point(262, 142);
            this.Generolabel.Name = "Generolabel";
            this.Generolabel.Size = new System.Drawing.Size(42, 13);
            this.Generolabel.TabIndex = 17;
            this.Generolabel.Text = "Genero";
            // 
            // GenerocomboBox
            // 
            this.GenerocomboBox.FormattingEnabled = true;
            this.GenerocomboBox.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.GenerocomboBox.Location = new System.Drawing.Point(311, 142);
            this.GenerocomboBox.Name = "GenerocomboBox";
            this.GenerocomboBox.Size = new System.Drawing.Size(110, 21);
            this.GenerocomboBox.TabIndex = 8;
            // 
            // MatriculamaskedTextBox1
            // 
            this.MatriculamaskedTextBox1.Location = new System.Drawing.Point(86, 41);
            this.MatriculamaskedTextBox1.Mask = "0000-0000";
            this.MatriculamaskedTextBox1.Name = "MatriculamaskedTextBox1";
            this.MatriculamaskedTextBox1.Size = new System.Drawing.Size(95, 20);
            this.MatriculamaskedTextBox1.TabIndex = 2;
            // 
            // TelefonfomaskedTextBox
            // 
            this.TelefonfomaskedTextBox.Location = new System.Drawing.Point(311, 68);
            this.TelefonfomaskedTextBox.Mask = "(000)000-0000";
            this.TelefonfomaskedTextBox.Name = "TelefonfomaskedTextBox";
            this.TelefonfomaskedTextBox.Size = new System.Drawing.Size(110, 20);
            this.TelefonfomaskedTextBox.TabIndex = 6;
            // 
            // CedulamaskedTextBox
            // 
            this.CedulamaskedTextBox.Location = new System.Drawing.Point(311, 104);
            this.CedulamaskedTextBox.Mask = "000-0000000-0";
            this.CedulamaskedTextBox.Name = "CedulamaskedTextBox";
            this.CedulamaskedTextBox.Size = new System.Drawing.Size(110, 20);
            this.CedulamaskedTextBox.TabIndex = 7;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(86, 214);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(335, 20);
            this.EmailtextBox.TabIndex = 10;
            // 
            // IdEstudiantemaskedTextBox
            // 
            this.IdEstudiantemaskedTextBox.Location = new System.Drawing.Point(85, 15);
            this.IdEstudiantemaskedTextBox.Mask = "99999";
            this.IdEstudiantemaskedTextBox.Name = "IdEstudiantemaskedTextBox";
            this.IdEstudiantemaskedTextBox.Size = new System.Drawing.Size(96, 20);
            this.IdEstudiantemaskedTextBox.TabIndex = 1;
            this.IdEstudiantemaskedTextBox.ValidatingType = typeof(int);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackgroundImage = global::TeacherControl1.Properties.Resources.Buscar;
            this.Buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Buscarbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Buscarbutton.Location = new System.Drawing.Point(206, 13);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(105, 41);
            this.Buscarbutton.TabIndex = 14;
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
            this.Actualizarbutton.Location = new System.Drawing.Point(126, 256);
            this.Actualizarbutton.Name = "Actualizarbutton";
            this.Actualizarbutton.Size = new System.Drawing.Size(94, 45);
            this.Actualizarbutton.TabIndex = 13;
            this.Actualizarbutton.Text = "Actualizar";
            this.Actualizarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Actualizarbutton.UseVisualStyleBackColor = true;
            this.Actualizarbutton.Click += new System.EventHandler(this.Actualizarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackgroundImage = global::TeacherControl1.Properties.Resources.Eliminar;
            this.Eliminarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Eliminarbutton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbutton.Location = new System.Drawing.Point(327, 256);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(94, 45);
            this.Eliminarbutton.TabIndex = 11;
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
            this.Guardarbutton.Location = new System.Drawing.Point(226, 256);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(95, 45);
            this.Guardarbutton.TabIndex = 12;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.BackgroundImage")));
            this.Nuevobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Nuevobutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Nuevobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevobutton.Location = new System.Drawing.Point(26, 256);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(94, 45);
            this.Nuevobutton.TabIndex = 13;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // RegistroEstudianteForm
            // 
            this.AcceptButton = this.Buscarbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(445, 313);
            this.Controls.Add(this.IdEstudiantemaskedTextBox);
            this.Controls.Add(this.CedulamaskedTextBox);
            this.Controls.Add(this.TelefonfomaskedTextBox);
            this.Controls.Add(this.MatriculamaskedTextBox1);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.GenerocomboBox);
            this.Controls.Add(this.Generolabel);
            this.Controls.Add(this.Cedulalabel);
            this.Controls.Add(this.Telefonolabel);
            this.Controls.Add(this.FechaNacdateTimePicker);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.ApellidotextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.Direccionlabel);
            this.Controls.Add(this.FechaNaclabel);
            this.Controls.Add(this.Apellidolabel);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.Matriculalabel);
            this.Controls.Add(this.idEstudiantelabel);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Actualizarbutton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistroEstudianteForm";
            this.Text = "Registro de Estudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idEstudiantelabel;
        private System.Windows.Forms.Label Matriculalabel;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.Label Apellidolabel;
        private System.Windows.Forms.Label FechaNaclabel;
        private System.Windows.Forms.Label Direccionlabel;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox ApellidotextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.DateTimePicker FechaNacdateTimePicker;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label Telefonolabel;
        private System.Windows.Forms.Label Cedulalabel;
        private System.Windows.Forms.Label Generolabel;
        private System.Windows.Forms.ComboBox GenerocomboBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.MaskedTextBox MatriculamaskedTextBox1;
        private System.Windows.Forms.MaskedTextBox TelefonfomaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CedulamaskedTextBox;
        private System.Windows.Forms.Button Actualizarbutton;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.MaskedTextBox IdEstudiantemaskedTextBox;
    }
}


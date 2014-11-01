namespace TeacherControl1.Consultas
{
    partial class cDeudas
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
            this.DatosdataGridView = new System.Windows.Forms.DataGridView();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.CampocomboBox = new System.Windows.Forms.ComboBox();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FiltrarFechascheckBox = new System.Windows.Forms.CheckBox();
            this.Fechaspanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).BeginInit();
            this.Fechaspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatosdataGridView
            // 
            this.DatosdataGridView.AllowUserToAddRows = false;
            this.DatosdataGridView.AllowUserToDeleteRows = false;
            this.DatosdataGridView.AllowUserToOrderColumns = true;
            this.DatosdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridView.Location = new System.Drawing.Point(12, 62);
            this.DatosdataGridView.Name = "DatosdataGridView";
            this.DatosdataGridView.ReadOnly = true;
            this.DatosdataGridView.Size = new System.Drawing.Size(597, 264);
            this.DatosdataGridView.TabIndex = 0;
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(43, 9);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.DesdedateTimePicker.TabIndex = 1;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(205, 9);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.HastadateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscarbutton.BackgroundImage = global::TeacherControl1.Properties.Resources.Buscar;
            this.Buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Buscarbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Buscarbutton.Location = new System.Drawing.Point(504, 15);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(105, 41);
            this.Buscarbutton.TabIndex = 15;
            this.Buscarbutton.Tag = "";
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // CampocomboBox
            // 
            this.CampocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CampocomboBox.FormattingEnabled = true;
            this.CampocomboBox.Items.AddRange(new object[] {
            "Matricula",
            "Nombre"});
            this.CampocomboBox.Location = new System.Drawing.Point(105, 35);
            this.CampocomboBox.Name = "CampocomboBox";
            this.CampocomboBox.Size = new System.Drawing.Size(121, 21);
            this.CampocomboBox.TabIndex = 16;
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltrotextBox.Location = new System.Drawing.Point(232, 36);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(266, 20);
            this.FiltrotextBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Campo a Filtrar";
            // 
            // FiltrarFechascheckBox
            // 
            this.FiltrarFechascheckBox.AutoSize = true;
            this.FiltrarFechascheckBox.Checked = true;
            this.FiltrarFechascheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FiltrarFechascheckBox.Location = new System.Drawing.Point(105, 13);
            this.FiltrarFechascheckBox.Name = "FiltrarFechascheckBox";
            this.FiltrarFechascheckBox.Size = new System.Drawing.Size(89, 17);
            this.FiltrarFechascheckBox.TabIndex = 19;
            this.FiltrarFechascheckBox.Text = "Filtrar Fechas";
            this.FiltrarFechascheckBox.UseVisualStyleBackColor = true;
            this.FiltrarFechascheckBox.CheckedChanged += new System.EventHandler(this.FiltrarFechascheckBox_CheckedChanged);
            // 
            // Fechaspanel
            // 
            this.Fechaspanel.Controls.Add(this.label2);
            this.Fechaspanel.Controls.Add(this.label1);
            this.Fechaspanel.Controls.Add(this.HastadateTimePicker);
            this.Fechaspanel.Controls.Add(this.DesdedateTimePicker);
            this.Fechaspanel.Location = new System.Drawing.Point(196, 1);
            this.Fechaspanel.Name = "Fechaspanel";
            this.Fechaspanel.Size = new System.Drawing.Size(308, 35);
            this.Fechaspanel.TabIndex = 20;
            // 
            // cDeudas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 338);
            this.Controls.Add(this.Fechaspanel);
            this.Controls.Add(this.FiltrarFechascheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.CampocomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.DatosdataGridView);
            this.Name = "cDeudas";
            this.Text = "cDeudas";
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).EndInit();
            this.Fechaspanel.ResumeLayout(false);
            this.Fechaspanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatosdataGridView;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ComboBox CampocomboBox;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox FiltrarFechascheckBox;
        private System.Windows.Forms.Panel Fechaspanel;
    }
}
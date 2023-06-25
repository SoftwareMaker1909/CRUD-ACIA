﻿namespace CRUD_ACIA
{
    partial class CRUD
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NombreUsuarioTXT = new System.Windows.Forms.TextBox();
            this.ClaveTXT = new System.Windows.Forms.TextBox();
            this.RolCBX = new System.Windows.Forms.ComboBox();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCIADataSet = new CRUD_ACIA.ACIADataSet();
            this.rolTableAdapter = new CRUD_ACIA.ACIADataSetTableAdapters.RolTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CedulaTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ApellidoPTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ApellidoMTXT = new System.Windows.Forms.TextBox();
            this.dtpDATE = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.AgregarCredenBTN = new System.Windows.Forms.Button();
            this.BTNagregar2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCIADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 516);
            this.panel1.TabIndex = 0;
            // 
            // NombreUsuarioTXT
            // 
            this.NombreUsuarioTXT.Location = new System.Drawing.Point(371, 114);
            this.NombreUsuarioTXT.Multiline = true;
            this.NombreUsuarioTXT.Name = "NombreUsuarioTXT";
            this.NombreUsuarioTXT.Size = new System.Drawing.Size(173, 39);
            this.NombreUsuarioTXT.TabIndex = 1;
            this.NombreUsuarioTXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // ClaveTXT
            // 
            this.ClaveTXT.Location = new System.Drawing.Point(595, 114);
            this.ClaveTXT.Multiline = true;
            this.ClaveTXT.Name = "ClaveTXT";
            this.ClaveTXT.Size = new System.Drawing.Size(173, 39);
            this.ClaveTXT.TabIndex = 2;
            // 
            // RolCBX
            // 
            this.RolCBX.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rolBindingSource, "Rol_ID", true));
            this.RolCBX.DataSource = this.rolBindingSource;
            this.RolCBX.DisplayMember = "Rol_Nombre";
            this.RolCBX.FormattingEnabled = true;
            this.RolCBX.Location = new System.Drawing.Point(824, 114);
            this.RolCBX.Name = "RolCBX";
            this.RolCBX.Size = new System.Drawing.Size(176, 24);
            this.RolCBX.TabIndex = 3;
            this.RolCBX.ValueMember = "Rol_ID";
            this.RolCBX.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this.aCIADataSet;
            // 
            // aCIADataSet
            // 
            this.aCIADataSet.DataSetName = "ACIADataSet";
            this.aCIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de Usuario";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Location = new System.Drawing.Point(653, 95);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(42, 16);
            this.Clave.TabIndex = 5;
            this.Clave.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(856, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de Usuario";
            // 
            // CedulaTXT
            // 
            this.CedulaTXT.Location = new System.Drawing.Point(381, 283);
            this.CedulaTXT.Multiline = true;
            this.CedulaTXT.Name = "CedulaTXT";
            this.CedulaTXT.Size = new System.Drawing.Size(176, 31);
            this.CedulaTXT.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cedula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre";
            // 
            // NombreTXT
            // 
            this.NombreTXT.Location = new System.Drawing.Point(592, 283);
            this.NombreTXT.Multiline = true;
            this.NombreTXT.Name = "NombreTXT";
            this.NombreTXT.Size = new System.Drawing.Size(176, 31);
            this.NombreTXT.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(834, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Apellido Paterno";
            // 
            // ApellidoPTXT
            // 
            this.ApellidoPTXT.Location = new System.Drawing.Point(803, 283);
            this.ApellidoPTXT.Multiline = true;
            this.ApellidoPTXT.Name = "ApellidoPTXT";
            this.ApellidoPTXT.Size = new System.Drawing.Size(176, 31);
            this.ApellidoPTXT.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Apellido Materno";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ApellidoMTXT
            // 
            this.ApellidoMTXT.Location = new System.Drawing.Point(381, 371);
            this.ApellidoMTXT.Multiline = true;
            this.ApellidoMTXT.Name = "ApellidoMTXT";
            this.ApellidoMTXT.Size = new System.Drawing.Size(176, 31);
            this.ApellidoMTXT.TabIndex = 13;
            // 
            // dtpDATE
            // 
            this.dtpDATE.Checked = false;
            this.dtpDATE.Location = new System.Drawing.Point(602, 380);
            this.dtpDATE.Name = "dtpDATE";
            this.dtpDATE.Size = new System.Drawing.Size(227, 22);
            this.dtpDATE.TabIndex = 15;
            this.dtpDATE.Value = new System.DateTime(2023, 6, 24, 0, 0, 0, 0);
            this.dtpDATE.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(659, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fecha de Nacimiento";
            // 
            // AgregarCredenBTN
            // 
            this.AgregarCredenBTN.Location = new System.Drawing.Point(856, 185);
            this.AgregarCredenBTN.Name = "AgregarCredenBTN";
            this.AgregarCredenBTN.Size = new System.Drawing.Size(123, 30);
            this.AgregarCredenBTN.TabIndex = 17;
            this.AgregarCredenBTN.Text = "Agregar";
            this.AgregarCredenBTN.UseVisualStyleBackColor = true;
            this.AgregarCredenBTN.Click += new System.EventHandler(this.AgregarCredenBTN_Click);
            // 
            // BTNagregar2
            // 
            this.BTNagregar2.Location = new System.Drawing.Point(859, 378);
            this.BTNagregar2.Name = "BTNagregar2";
            this.BTNagregar2.Size = new System.Drawing.Size(123, 30);
            this.BTNagregar2.TabIndex = 18;
            this.BTNagregar2.Text = "Agregar";
            this.BTNagregar2.UseVisualStyleBackColor = true;
            this.BTNagregar2.Click += new System.EventHandler(this.BTNagregar2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1044, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 24);
            this.button2.TabIndex = 20;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 516);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNagregar2);
            this.Controls.Add(this.AgregarCredenBTN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDATE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ApellidoMTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ApellidoPTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NombreTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CedulaTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RolCBX);
            this.Controls.Add(this.ClaveTXT);
            this.Controls.Add(this.NombreUsuarioTXT);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUD";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCIADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NombreUsuarioTXT;
        private System.Windows.Forms.TextBox ClaveTXT;
        private System.Windows.Forms.ComboBox RolCBX;
        private ACIADataSet aCIADataSet;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private ACIADataSetTableAdapters.RolTableAdapter rolTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CedulaTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombreTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ApellidoPTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ApellidoMTXT;
        private System.Windows.Forms.DateTimePicker dtpDATE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AgregarCredenBTN;
        private System.Windows.Forms.Button BTNagregar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
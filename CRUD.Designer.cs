namespace CRUD_ACIA
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
            this.WelcomeToUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCIADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WelcomeToUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 419);
            this.panel1.TabIndex = 0;
            // 
            // NombreUsuarioTXT
            // 
            this.NombreUsuarioTXT.Location = new System.Drawing.Point(278, 93);
            this.NombreUsuarioTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NombreUsuarioTXT.Multiline = true;
            this.NombreUsuarioTXT.Name = "NombreUsuarioTXT";
            this.NombreUsuarioTXT.Size = new System.Drawing.Size(131, 32);
            this.NombreUsuarioTXT.TabIndex = 1;
            this.NombreUsuarioTXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // ClaveTXT
            // 
            this.ClaveTXT.Location = new System.Drawing.Point(444, 93);
            this.ClaveTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClaveTXT.Multiline = true;
            this.ClaveTXT.Name = "ClaveTXT";
            this.ClaveTXT.Size = new System.Drawing.Size(131, 32);
            this.ClaveTXT.TabIndex = 2;
            // 
            // RolCBX
            // 
            this.RolCBX.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rolBindingSource, "Rol_ID", true));
            this.RolCBX.DataSource = this.rolBindingSource;
            this.RolCBX.DisplayMember = "Rol_Nombre";
            this.RolCBX.FormattingEnabled = true;
            this.RolCBX.Location = new System.Drawing.Point(618, 93);
            this.RolCBX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RolCBX.Name = "RolCBX";
            this.RolCBX.Size = new System.Drawing.Size(133, 21);
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
            this.label1.Location = new System.Drawing.Point(290, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de Usuario";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Location = new System.Drawing.Point(485, 77);
            this.Clave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(34, 13);
            this.Clave.TabIndex = 5;
            this.Clave.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de Usuario";
            // 
            // CedulaTXT
            // 
            this.CedulaTXT.Location = new System.Drawing.Point(286, 230);
            this.CedulaTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CedulaTXT.Multiline = true;
            this.CedulaTXT.Name = "CedulaTXT";
            this.CedulaTXT.Size = new System.Drawing.Size(133, 26);
            this.CedulaTXT.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cedula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre";
            // 
            // NombreTXT
            // 
            this.NombreTXT.Location = new System.Drawing.Point(444, 230);
            this.NombreTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NombreTXT.Multiline = true;
            this.NombreTXT.Name = "NombreTXT";
            this.NombreTXT.Size = new System.Drawing.Size(133, 26);
            this.NombreTXT.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Apellido Paterno";
            // 
            // ApellidoPTXT
            // 
            this.ApellidoPTXT.Location = new System.Drawing.Point(602, 230);
            this.ApellidoPTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ApellidoPTXT.Multiline = true;
            this.ApellidoPTXT.Name = "ApellidoPTXT";
            this.ApellidoPTXT.Size = new System.Drawing.Size(133, 26);
            this.ApellidoPTXT.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 286);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Apellido Materno";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ApellidoMTXT
            // 
            this.ApellidoMTXT.Location = new System.Drawing.Point(286, 301);
            this.ApellidoMTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ApellidoMTXT.Multiline = true;
            this.ApellidoMTXT.Name = "ApellidoMTXT";
            this.ApellidoMTXT.Size = new System.Drawing.Size(133, 26);
            this.ApellidoMTXT.TabIndex = 13;
            // 
            // dtpDATE
            // 
            this.dtpDATE.Checked = false;
            this.dtpDATE.Location = new System.Drawing.Point(452, 309);
            this.dtpDATE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDATE.Name = "dtpDATE";
            this.dtpDATE.Size = new System.Drawing.Size(171, 20);
            this.dtpDATE.TabIndex = 15;
            this.dtpDATE.Value = new System.DateTime(2023, 6, 24, 0, 0, 0, 0);
            this.dtpDATE.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fecha de Nacimiento";
            // 
            // AgregarCredenBTN
            // 
            this.AgregarCredenBTN.Location = new System.Drawing.Point(463, 154);
            this.AgregarCredenBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AgregarCredenBTN.Name = "AgregarCredenBTN";
            this.AgregarCredenBTN.Size = new System.Drawing.Size(92, 24);
            this.AgregarCredenBTN.TabIndex = 17;
            this.AgregarCredenBTN.Text = "Agregar";
            this.AgregarCredenBTN.UseVisualStyleBackColor = true;
            this.AgregarCredenBTN.Click += new System.EventHandler(this.AgregarCredenBTN_Click);
            // 
            // BTNagregar2
            // 
            this.BTNagregar2.Location = new System.Drawing.Point(644, 307);
            this.BTNagregar2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNagregar2.Name = "BTNagregar2";
            this.BTNagregar2.Size = new System.Drawing.Size(92, 24);
            this.BTNagregar2.TabIndex = 18;
            this.BTNagregar2.Text = "Agregar";
            this.BTNagregar2.UseVisualStyleBackColor = true;
            this.BTNagregar2.Click += new System.EventHandler(this.BTNagregar2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 396);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.button2.Location = new System.Drawing.Point(738, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 20);
            this.button2.TabIndex = 20;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WelcomeToUser
            // 
            this.WelcomeToUser.AutoSize = true;
            this.WelcomeToUser.Location = new System.Drawing.Point(11, 4);
            this.WelcomeToUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeToUser.Name = "WelcomeToUser";
            this.WelcomeToUser.Size = new System.Drawing.Size(73, 13);
            this.WelcomeToUser.TabIndex = 21;
            this.WelcomeToUser.Text = "Buenos Dias! ";
            this.WelcomeToUser.Click += new System.EventHandler(this.WelcomeToUser_Click);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 419);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CRUD";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.CRUD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label WelcomeToUser;
    }
}
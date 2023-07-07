namespace CRUD_ACIA
{
    partial class CRUD_ASIGNATURAS
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
            this.CodigoMateriatbx = new System.Windows.Forms.TextBox();
            this.NombreMateriatbx = new System.Windows.Forms.TextBox();
            this.cuposmateriaUD = new System.Windows.Forms.NumericUpDown();
            this.HorarioMateriatbx = new System.Windows.Forms.TextBox();
            this.PrerrequisitosCBX = new System.Windows.Forms.ComboBox();
            this.CreditoUD = new System.Windows.Forms.NumericUpDown();
            this.Maestrocbx = new System.Windows.Forms.ComboBox();
            this.Guardarbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.materiasDataset = new CRUD_ACIA.MateriasDataset();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiasTableAdapter = new CRUD_ACIA.MateriasDatasetTableAdapters.MateriasTableAdapter();
            this.aCIADataSetMaestro_Credencial = new CRUD_ACIA.ACIADataSetMaestro_Credencial();
            this.maestroCredencialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maestro_CredencialTableAdapter = new CRUD_ACIA.ACIADataSetMaestro_CredencialTableAdapters.Maestro_CredencialTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cuposmateriaUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditoUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCIADataSetMaestro_Credencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestroCredencialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CodigoMateriatbx
            // 
            this.CodigoMateriatbx.Location = new System.Drawing.Point(666, 71);
            this.CodigoMateriatbx.Multiline = true;
            this.CodigoMateriatbx.Name = "CodigoMateriatbx";
            this.CodigoMateriatbx.Size = new System.Drawing.Size(132, 34);
            this.CodigoMateriatbx.TabIndex = 0;
            // 
            // NombreMateriatbx
            // 
            this.NombreMateriatbx.Location = new System.Drawing.Point(458, 71);
            this.NombreMateriatbx.Multiline = true;
            this.NombreMateriatbx.Name = "NombreMateriatbx";
            this.NombreMateriatbx.Size = new System.Drawing.Size(132, 34);
            this.NombreMateriatbx.TabIndex = 1;
            // 
            // cuposmateriaUD
            // 
            this.cuposmateriaUD.Location = new System.Drawing.Point(857, 83);
            this.cuposmateriaUD.Name = "cuposmateriaUD";
            this.cuposmateriaUD.Size = new System.Drawing.Size(96, 22);
            this.cuposmateriaUD.TabIndex = 2;
            // 
            // HorarioMateriatbx
            // 
            this.HorarioMateriatbx.Location = new System.Drawing.Point(458, 164);
            this.HorarioMateriatbx.Multiline = true;
            this.HorarioMateriatbx.Name = "HorarioMateriatbx";
            this.HorarioMateriatbx.Size = new System.Drawing.Size(132, 34);
            this.HorarioMateriatbx.TabIndex = 3;
            // 
            // PrerrequisitosCBX
            // 
            this.PrerrequisitosCBX.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materiasBindingSource, "ID_Materia", true));
            this.PrerrequisitosCBX.DataSource = this.materiasBindingSource;
            this.PrerrequisitosCBX.DisplayMember = "CodigoMateria";
            this.PrerrequisitosCBX.FormattingEnabled = true;
            this.PrerrequisitosCBX.Location = new System.Drawing.Point(666, 164);
            this.PrerrequisitosCBX.Name = "PrerrequisitosCBX";
            this.PrerrequisitosCBX.Size = new System.Drawing.Size(121, 24);
            this.PrerrequisitosCBX.TabIndex = 4;
            this.PrerrequisitosCBX.ValueMember = "ID_Materia";
            // 
            // CreditoUD
            // 
            this.CreditoUD.Location = new System.Drawing.Point(857, 164);
            this.CreditoUD.Name = "CreditoUD";
            this.CreditoUD.Size = new System.Drawing.Size(96, 22);
            this.CreditoUD.TabIndex = 5;
            // 
            // Maestrocbx
            // 
            this.Maestrocbx.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.maestroCredencialBindingSource, "ID_Credencial", true));
            this.Maestrocbx.DataSource = this.maestroCredencialBindingSource;
            this.Maestrocbx.DisplayMember = "Usuario";
            this.Maestrocbx.FormattingEnabled = true;
            this.Maestrocbx.Location = new System.Drawing.Point(458, 245);
            this.Maestrocbx.Name = "Maestrocbx";
            this.Maestrocbx.Size = new System.Drawing.Size(121, 24);
            this.Maestrocbx.TabIndex = 6;
            this.Maestrocbx.ValueMember = "ID_Credencial";
            // 
            // Guardarbtn
            // 
            this.Guardarbtn.Location = new System.Drawing.Point(872, 245);
            this.Guardarbtn.Name = "Guardarbtn";
            this.Guardarbtn.Size = new System.Drawing.Size(110, 48);
            this.Guardarbtn.TabIndex = 7;
            this.Guardarbtn.Text = "Guardar";
            this.Guardarbtn.UseVisualStyleBackColor = true;
            this.Guardarbtn.Click += new System.EventHandler(this.Guardarbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre de la materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Horario de la materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prerequisito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(842, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cupos de la materia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(663, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Codigo de la materia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(838, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad de creditos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Maestro de la materia";
            // 
            // materiasDataset
            // 
            this.materiasDataset.DataSetName = "MateriasDataset";
            this.materiasDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "Materias";
            this.materiasBindingSource.DataSource = this.materiasDataset;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // aCIADataSetMaestro_Credencial
            // 
            this.aCIADataSetMaestro_Credencial.DataSetName = "ACIADataSetMaestro_Credencial";
            this.aCIADataSetMaestro_Credencial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maestroCredencialBindingSource
            // 
            this.maestroCredencialBindingSource.DataMember = "Maestro_Credencial";
            this.maestroCredencialBindingSource.DataSource = this.aCIADataSetMaestro_Credencial;
            // 
            // maestro_CredencialTableAdapter
            // 
            this.maestro_CredencialTableAdapter.ClearBeforeFill = true;
            // 
            // CRUD_ASIGNATURAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 303);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardarbtn);
            this.Controls.Add(this.Maestrocbx);
            this.Controls.Add(this.CreditoUD);
            this.Controls.Add(this.PrerrequisitosCBX);
            this.Controls.Add(this.HorarioMateriatbx);
            this.Controls.Add(this.cuposmateriaUD);
            this.Controls.Add(this.NombreMateriatbx);
            this.Controls.Add(this.CodigoMateriatbx);
            this.Name = "CRUD_ASIGNATURAS";
            this.Text = "CRUD_ASIGNATURAS";
            this.Load += new System.EventHandler(this.CRUD_ASIGNATURAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuposmateriaUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditoUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCIADataSetMaestro_Credencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestroCredencialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodigoMateriatbx;
        private System.Windows.Forms.TextBox NombreMateriatbx;
        private System.Windows.Forms.NumericUpDown cuposmateriaUD;
        private System.Windows.Forms.TextBox HorarioMateriatbx;
        private System.Windows.Forms.ComboBox PrerrequisitosCBX;
        private System.Windows.Forms.NumericUpDown CreditoUD;
        private System.Windows.Forms.ComboBox Maestrocbx;
        private System.Windows.Forms.Button Guardarbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MateriasDataset materiasDataset;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private MateriasDatasetTableAdapters.MateriasTableAdapter materiasTableAdapter;
        private ACIADataSetMaestro_Credencial aCIADataSetMaestro_Credencial;
        private System.Windows.Forms.BindingSource maestroCredencialBindingSource;
        private ACIADataSetMaestro_CredencialTableAdapters.Maestro_CredencialTableAdapter maestro_CredencialTableAdapter;
    }
}
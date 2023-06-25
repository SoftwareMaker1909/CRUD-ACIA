namespace CRUD_ACIA
{
    partial class LOGIN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.USERTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CLAVETXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EntrarBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            // 
            // USERTXT
            // 
            this.USERTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.USERTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.USERTXT.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERTXT.ForeColor = System.Drawing.SystemColors.GrayText;
            this.USERTXT.Location = new System.Drawing.Point(367, 80);
            this.USERTXT.Name = "USERTXT";
            this.USERTXT.Size = new System.Drawing.Size(248, 20);
            this.USERTXT.TabIndex = 1;
            this.USERTXT.Text = "USUARIO";
            this.USERTXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(364, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "-------------------------------------------------------------";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(364, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "-------------------------------------------------------------";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CLAVETXT
            // 
            this.CLAVETXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CLAVETXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CLAVETXT.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLAVETXT.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CLAVETXT.Location = new System.Drawing.Point(367, 170);
            this.CLAVETXT.Name = "CLAVETXT";
            this.CLAVETXT.Size = new System.Drawing.Size(248, 20);
            this.CLAVETXT.TabIndex = 3;
            this.CLAVETXT.Text = "CLAVE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(436, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "LOGIN";
            // 
            // EntrarBTN
            // 
            this.EntrarBTN.BackColor = System.Drawing.Color.Black;
            this.EntrarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntrarBTN.ForeColor = System.Drawing.SystemColors.GrayText;
            this.EntrarBTN.Location = new System.Drawing.Point(308, 250);
            this.EntrarBTN.Name = "EntrarBTN";
            this.EntrarBTN.Size = new System.Drawing.Size(417, 46);
            this.EntrarBTN.TabIndex = 6;
            this.EntrarBTN.Text = "ENTRAR";
            this.EntrarBTN.UseVisualStyleBackColor = false;
            this.EntrarBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(744, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 24);
            this.button2.TabIndex = 7;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EntrarBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CLAVETXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.USERTXT);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox USERTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CLAVETXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EntrarBTN;
        private System.Windows.Forms.Button button2;
    }
}


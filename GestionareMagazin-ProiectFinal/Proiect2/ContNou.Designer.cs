namespace Proiect2
{
    partial class ContNou
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtConfirmParola = new System.Windows.Forms.TextBox();
            this.btnCreazaCont = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodAdmin = new System.Windows.Forms.TextBox();
            this.EroareNume = new System.Windows.Forms.Label();
            this.EroareParola = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREAZA CONT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume utilizator:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parola:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirma parola:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(50, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(316, 22);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(50, 154);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(316, 22);
            this.txtUtilizator.TabIndex = 6;
            this.txtUtilizator.TextChanged += new System.EventHandler(this.txtUtilizator_TextChanged);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(50, 227);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(316, 22);
            this.txtParola.TabIndex = 7;
            // 
            // txtConfirmParola
            // 
            this.txtConfirmParola.Location = new System.Drawing.Point(50, 282);
            this.txtConfirmParola.Name = "txtConfirmParola";
            this.txtConfirmParola.Size = new System.Drawing.Size(316, 22);
            this.txtConfirmParola.TabIndex = 8;
            this.txtConfirmParola.TextChanged += new System.EventHandler(this.txtConfirmParola_TextChanged);
            // 
            // btnCreazaCont
            // 
            this.btnCreazaCont.Location = new System.Drawing.Point(50, 336);
            this.btnCreazaCont.Name = "btnCreazaCont";
            this.btnCreazaCont.Size = new System.Drawing.Size(316, 35);
            this.btnCreazaCont.TabIndex = 9;
            this.btnCreazaCont.Text = "Creaza";
            this.btnCreazaCont.UseVisualStyleBackColor = true;
            this.btnCreazaCont.Click += new System.EventHandler(this.btnCreazaCont_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Creezi cont de administrator?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(334, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Daca da, introdu codul primit inainte de a apasa creaza";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "COD:";
            // 
            // txtCodAdmin
            // 
            this.txtCodAdmin.Location = new System.Drawing.Point(98, 446);
            this.txtCodAdmin.Name = "txtCodAdmin";
            this.txtCodAdmin.Size = new System.Drawing.Size(100, 22);
            this.txtCodAdmin.TabIndex = 13;
            // 
            // EroareNume
            // 
            this.EroareNume.AutoSize = true;
            this.EroareNume.Location = new System.Drawing.Point(50, 183);
            this.EroareNume.Name = "EroareNume";
            this.EroareNume.Size = new System.Drawing.Size(0, 16);
            this.EroareNume.TabIndex = 14;
            // 
            // EroareParola
            // 
            this.EroareParola.AutoSize = true;
            this.EroareParola.Location = new System.Drawing.Point(50, 314);
            this.EroareParola.Name = "EroareParola";
            this.EroareParola.Size = new System.Drawing.Size(0, 16);
            this.EroareParola.TabIndex = 15;
            // 
            // ContNou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 503);
            this.Controls.Add(this.EroareParola);
            this.Controls.Add(this.EroareNume);
            this.Controls.Add(this.txtCodAdmin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCreazaCont);
            this.Controls.Add(this.txtConfirmParola);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ContNou";
            this.Text = "ContNou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtConfirmParola;
        private System.Windows.Forms.Button btnCreazaCont;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodAdmin;
        private System.Windows.Forms.Label EroareNume;
        private System.Windows.Forms.Label EroareParola;
    }
}
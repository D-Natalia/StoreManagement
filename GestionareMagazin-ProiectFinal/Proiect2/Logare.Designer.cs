namespace Proiect2
{
    partial class Logare
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
            this.checkBoxuser = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxadmin = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnLogare = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnContNou = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSchimbaParola = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selecteazaLimba = new System.Windows.Forms.ToolStripMenuItem();
            this.romanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englezaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGARE UTILIZATOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume Utilizator:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parola:";
            // 
            // checkBoxuser
            // 
            this.checkBoxuser.AutoSize = true;
            this.checkBoxuser.Location = new System.Drawing.Point(72, 188);
            this.checkBoxuser.Name = "checkBoxuser";
            this.checkBoxuser.Size = new System.Drawing.Size(18, 17);
            this.checkBoxuser.TabIndex = 3;
            this.checkBoxuser.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Utilizator";
            // 
            // checkBoxadmin
            // 
            this.checkBoxadmin.AutoSize = true;
            this.checkBoxadmin.Location = new System.Drawing.Point(200, 188);
            this.checkBoxadmin.Name = "checkBoxadmin";
            this.checkBoxadmin.Size = new System.Drawing.Size(18, 17);
            this.checkBoxadmin.TabIndex = 5;
            this.checkBoxadmin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Administrator";
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(170, 94);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(184, 22);
            this.txtUtilizator.TabIndex = 7;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(170, 134);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(184, 22);
            this.txtParola.TabIndex = 8;
            // 
            // btnLogare
            // 
            this.btnLogare.Location = new System.Drawing.Point(56, 251);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(298, 33);
            this.btnLogare.TabIndex = 9;
            this.btnLogare.Text = "Logare";
            this.btnLogare.UseVisualStyleBackColor = true;
            this.btnLogare.Click += new System.EventHandler(this.btnLogare_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nu ai cont?";
            // 
            // btnContNou
            // 
            this.btnContNou.Location = new System.Drawing.Point(200, 340);
            this.btnContNou.Name = "btnContNou";
            this.btnContNou.Size = new System.Drawing.Size(109, 23);
            this.btnContNou.TabIndex = 11;
            this.btnContNou.Text = "Creeaza cont";
            this.btnContNou.UseVisualStyleBackColor = true;
            this.btnContNou.Click += new System.EventHandler(this.btnContNou_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ai uitat parola?";
            // 
            // btnSchimbaParola
            // 
            this.btnSchimbaParola.Location = new System.Drawing.Point(200, 312);
            this.btnSchimbaParola.Name = "btnSchimbaParola";
            this.btnSchimbaParola.Size = new System.Drawing.Size(131, 23);
            this.btnSchimbaParola.TabIndex = 13;
            this.btnSchimbaParola.Text = "Schimba Parola";
            this.btnSchimbaParola.UseVisualStyleBackColor = true;
            this.btnSchimbaParola.Click += new System.EventHandler(this.btnSchimbaParola_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selecteazaLimba});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selecteazaLimba
            // 
            this.selecteazaLimba.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.romanaToolStripMenuItem,
            this.englezaToolStripMenuItem});
            this.selecteazaLimba.Name = "selecteazaLimba";
            this.selecteazaLimba.Size = new System.Drawing.Size(139, 24);
            this.selecteazaLimba.Text = "Selecteaza Limba";
            // 
            // romanaToolStripMenuItem
            // 
            this.romanaToolStripMenuItem.Name = "romanaToolStripMenuItem";
            this.romanaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.romanaToolStripMenuItem.Text = "Romana";
            this.romanaToolStripMenuItem.Click += new System.EventHandler(this.romanaToolStripMenuItem_Click);
            // 
            // englezaToolStripMenuItem
            // 
            this.englezaToolStripMenuItem.Name = "englezaToolStripMenuItem";
            this.englezaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.englezaToolStripMenuItem.Text = "Engleza";
            this.englezaToolStripMenuItem.Click += new System.EventHandler(this.englezaToolStripMenuItem_Click);
            // 
            // Logare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 390);
            this.Controls.Add(this.btnSchimbaParola);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnContNou);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxadmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Logare";
            this.Text = "Logare";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxuser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxadmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnLogare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnContNou;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSchimbaParola;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selecteazaLimba;
        private System.Windows.Forms.ToolStripMenuItem romanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englezaToolStripMenuItem;
    }
}
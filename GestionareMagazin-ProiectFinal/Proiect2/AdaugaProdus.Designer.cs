namespace Proiect2
{
    partial class AdaugaProdus
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
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.dtpDataIntrare = new System.Windows.Forms.DateTimePicker();
            this.dtpDataExpirare = new System.Windows.Forms.DateTimePicker();
            this.nudCantitate = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantitate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(356, 353);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(153, 52);
            this.btnAdaugare.TabIndex = 1;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Denumire";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descriere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Intrare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data Expirare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantitate";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(214, 43);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(100, 22);
            this.txtDenumire.TabIndex = 7;
            this.txtDenumire.TextChanged += new System.EventHandler(this.txtDenumire_TextChanged);
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(214, 80);
            this.txtDescriere.Multiline = true;
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(218, 74);
            this.txtDescriere.TabIndex = 8;
            // 
            // dtpDataIntrare
            // 
            this.dtpDataIntrare.Location = new System.Drawing.Point(214, 180);
            this.dtpDataIntrare.Name = "dtpDataIntrare";
            this.dtpDataIntrare.Size = new System.Drawing.Size(200, 22);
            this.dtpDataIntrare.TabIndex = 9;
            // 
            // dtpDataExpirare
            // 
            this.dtpDataExpirare.Location = new System.Drawing.Point(214, 222);
            this.dtpDataExpirare.Name = "dtpDataExpirare";
            this.dtpDataExpirare.Size = new System.Drawing.Size(200, 22);
            this.dtpDataExpirare.TabIndex = 10;
            // 
            // nudCantitate
            // 
            this.nudCantitate.Location = new System.Drawing.Point(214, 261);
            this.nudCantitate.Maximum = new decimal(new int[] {
            -647710720,
            69,
            0,
            0});
            this.nudCantitate.Name = "nudCantitate";
            this.nudCantitate.Size = new System.Drawing.Size(120, 22);
            this.nudCantitate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Categorie";
            // 
            // txtCategorie
            // 
            this.txtCategorie.Location = new System.Drawing.Point(214, 305);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(100, 22);
            this.txtCategorie.TabIndex = 13;
            // 
            // AdaugaProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudCantitate);
            this.Controls.Add(this.dtpDataExpirare);
            this.Controls.Add(this.dtpDataIntrare);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdaugare);
            this.Name = "AdaugaProdus";
            this.Text = "AdaugaProdus";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.DateTimePicker dtpDataIntrare;
        private System.Windows.Forms.DateTimePicker dtpDataExpirare;
        private System.Windows.Forms.NumericUpDown nudCantitate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCategorie;
    }
}
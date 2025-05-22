namespace Proiect2
{
    partial class Vanzare
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
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCantitate = new System.Windows.Forms.NumericUpDown();
            this.btnVinde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantitate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumire Produs";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(222, 63);
            this.txtDenumire.Multiline = true;
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(143, 32);
            this.txtDenumire.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantitate";
            // 
            // nudCantitate
            // 
            this.nudCantitate.Location = new System.Drawing.Point(222, 145);
            this.nudCantitate.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.nudCantitate.Name = "nudCantitate";
            this.nudCantitate.Size = new System.Drawing.Size(143, 22);
            this.nudCantitate.TabIndex = 3;
            // 
            // btnVinde
            // 
            this.btnVinde.Location = new System.Drawing.Point(173, 255);
            this.btnVinde.Name = "btnVinde";
            this.btnVinde.Size = new System.Drawing.Size(96, 50);
            this.btnVinde.TabIndex = 4;
            this.btnVinde.Text = "Vinde";
            this.btnVinde.UseVisualStyleBackColor = true;
            this.btnVinde.Click += new System.EventHandler(this.btnVinde_Click);
            // 
            // Vanzare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 357);
            this.Controls.Add(this.btnVinde);
            this.Controls.Add(this.nudCantitate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.label1);
            this.Name = "Vanzare";
            this.Text = "Vanzare";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCantitate;
        private System.Windows.Forms.Button btnVinde;
    }
}
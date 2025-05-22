namespace Proiect2
{
    partial class Cumparare
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
            this.btnCumparare = new System.Windows.Forms.Button();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.nudCantitate = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantitate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumire Produs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantitate";
            // 
            // btnCumparare
            // 
            this.btnCumparare.Location = new System.Drawing.Point(151, 212);
            this.btnCumparare.Name = "btnCumparare";
            this.btnCumparare.Size = new System.Drawing.Size(113, 39);
            this.btnCumparare.TabIndex = 2;
            this.btnCumparare.Text = "Cumpara";
            this.btnCumparare.UseVisualStyleBackColor = true;
            this.btnCumparare.Click += new System.EventHandler(this.btnCumparare_Click);
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(220, 67);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(120, 22);
            this.txtDenumire.TabIndex = 3;
            // 
            // nudCantitate
            // 
            this.nudCantitate.Location = new System.Drawing.Point(220, 126);
            this.nudCantitate.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudCantitate.Name = "nudCantitate";
            this.nudCantitate.Size = new System.Drawing.Size(120, 22);
            this.nudCantitate.TabIndex = 4;
            // 
            // Cumparare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 337);
            this.Controls.Add(this.nudCantitate);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.btnCumparare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cumparare";
            this.Text = "Cumparare";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCumparare;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.NumericUpDown nudCantitate;
    }
}
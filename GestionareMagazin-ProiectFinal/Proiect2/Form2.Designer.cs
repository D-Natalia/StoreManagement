namespace Proiect2
{
    partial class Form2
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
            this.nudCantitate = new System.Windows.Forms.NumericUpDown();
            this.btnAddCantitate = new System.Windows.Forms.Button();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantitate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantitate";
            // 
            // nudCantitate
            // 
            this.nudCantitate.Location = new System.Drawing.Point(198, 113);
            this.nudCantitate.Maximum = new decimal(new int[] {
            -647710720,
            69,
            0,
            0});
            this.nudCantitate.Name = "nudCantitate";
            this.nudCantitate.Size = new System.Drawing.Size(100, 22);
            this.nudCantitate.TabIndex = 3;
            // 
            // btnAddCantitate
            // 
            this.btnAddCantitate.Location = new System.Drawing.Point(262, 183);
            this.btnAddCantitate.Name = "btnAddCantitate";
            this.btnAddCantitate.Size = new System.Drawing.Size(93, 36);
            this.btnAddCantitate.TabIndex = 5;
            this.btnAddCantitate.Text = "Adauga";
            this.btnAddCantitate.UseVisualStyleBackColor = true;
            this.btnAddCantitate.Click += new System.EventHandler(this.btnAddCantitate_Click);
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(198, 61);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(100, 22);
            this.txtDenumire.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 244);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.btnAddCantitate);
            this.Controls.Add(this.nudCantitate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCantitate;
        private System.Windows.Forms.Button btnAddCantitate;
        private System.Windows.Forms.TextBox txtDenumire;
    }
}
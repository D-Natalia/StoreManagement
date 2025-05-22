namespace Proiect2
{
    partial class ResetareParola
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
            this.txtParolaNoua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeUtilizator = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRepetaParola = new System.Windows.Forms.TextBox();
            this.btnResetareParola = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parola noua";
            // 
            // txtParolaNoua
            // 
            this.txtParolaNoua.Location = new System.Drawing.Point(52, 115);
            this.txtParolaNoua.Name = "txtParolaNoua";
            this.txtParolaNoua.Size = new System.Drawing.Size(220, 22);
            this.txtParolaNoua.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume utilizator:";
            // 
            // txtNumeUtilizator
            // 
            this.txtNumeUtilizator.Location = new System.Drawing.Point(52, 53);
            this.txtNumeUtilizator.Name = "txtNumeUtilizator";
            this.txtNumeUtilizator.Size = new System.Drawing.Size(220, 22);
            this.txtNumeUtilizator.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repeta parola";
            // 
            // txtRepetaParola
            // 
            this.txtRepetaParola.Location = new System.Drawing.Point(52, 178);
            this.txtRepetaParola.Name = "txtRepetaParola";
            this.txtRepetaParola.Size = new System.Drawing.Size(220, 22);
            this.txtRepetaParola.TabIndex = 5;
            // 
            // btnResetareParola
            // 
            this.btnResetareParola.Location = new System.Drawing.Point(52, 243);
            this.btnResetareParola.Name = "btnResetareParola";
            this.btnResetareParola.Size = new System.Drawing.Size(220, 30);
            this.btnResetareParola.TabIndex = 6;
            this.btnResetareParola.Text = "Reseteaza Parola";
            this.btnResetareParola.UseVisualStyleBackColor = true;
            this.btnResetareParola.Click += new System.EventHandler(this.btnResetareParola_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // ResetareParola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 309);
            this.Controls.Add(this.btnResetareParola);
            this.Controls.Add(this.txtRepetaParola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeUtilizator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParolaNoua);
            this.Controls.Add(this.label1);
            this.Name = "ResetareParola";
            this.Text = "ResetareParola";
            this.Load += new System.EventHandler(this.ResetareParola_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParolaNoua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeUtilizator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRepetaParola;
        private System.Windows.Forms.Button btnResetareParola;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}
namespace Proiect2
{
    partial class Form1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vizualizareDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istoricVanzariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produsNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaCantitateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautareProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dupaNumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDenumire = new System.Windows.Forms.ToolStripTextBox();
            this.cautadupanume = new System.Windows.Forms.ToolStripMenuItem();
            this.dupaCategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCategorie = new System.Windows.Forms.ToolStripTextBox();
            this.cautadupacategorie = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVanzare = new System.Windows.Forms.Button();
            this.btnIstoric = new System.Windows.Forms.Button();
            this.btnCumpara = new System.Windows.Forms.Button();
            this.adaugaCategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSterge = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stergeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.denumireCategorie = new System.Windows.Forms.ToolStripTextBox();
            this.denumiredesters = new System.Windows.Forms.ToolStripTextBox();
            this.adaugaCategorie = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeCategorie = new System.Windows.Forms.ToolStripMenuItem();
            this.produseInIstoricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtIstoricDupaNume = new System.Windows.Forms.ToolStripTextBox();
            this.IstoricDupaNume = new System.Windows.Forms.ToolStripMenuItem();
            this.txtIstoricCategorie = new System.Windows.Forms.ToolStripTextBox();
            this.IstoricDupaCategorie = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeContulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilizatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeContDupaNume = new System.Windows.Forms.ToolStripTextBox();
            this.stergeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1040, 422);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Verificare Conectiune la DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(997, 217);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareDateToolStripMenuItem,
            this.adaugaProdusToolStripMenuItem,
            this.adaugaCategorieToolStripMenuItem,
            this.cautareProdusToolStripMenuItem,
            this.stergeContulToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vizualizareDateToolStripMenuItem
            // 
            this.vizualizareDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produsToolStripMenuItem,
            this.categorieToolStripMenuItem,
            this.istoricVanzariToolStripMenuItem,
            this.utilizatorToolStripMenuItem});
            this.vizualizareDateToolStripMenuItem.Name = "vizualizareDateToolStripMenuItem";
            this.vizualizareDateToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.vizualizareDateToolStripMenuItem.Text = "Vizualizare DB";
            // 
            // produsToolStripMenuItem
            // 
            this.produsToolStripMenuItem.Name = "produsToolStripMenuItem";
            this.produsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.produsToolStripMenuItem.Text = "Produs";
            this.produsToolStripMenuItem.Click += new System.EventHandler(this.produsToolStripMenuItem_Click);
            // 
            // categorieToolStripMenuItem
            // 
            this.categorieToolStripMenuItem.Name = "categorieToolStripMenuItem";
            this.categorieToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.categorieToolStripMenuItem.Text = "Categorie";
            this.categorieToolStripMenuItem.Click += new System.EventHandler(this.categorieToolStripMenuItem_Click);
            // 
            // istoricVanzariToolStripMenuItem
            // 
            this.istoricVanzariToolStripMenuItem.Name = "istoricVanzariToolStripMenuItem";
            this.istoricVanzariToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.istoricVanzariToolStripMenuItem.Text = "Istoric Vanzari";
            this.istoricVanzariToolStripMenuItem.Click += new System.EventHandler(this.istoricVanzariToolStripMenuItem_Click);
            // 
            // adaugaProdusToolStripMenuItem
            // 
            this.adaugaProdusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareProduseToolStripMenuItem,
            this.produsNouToolStripMenuItem,
            this.adaugaCantitateToolStripMenuItem,
            this.stergeProdusToolStripMenuItem});
            this.adaugaProdusToolStripMenuItem.Name = "adaugaProdusToolStripMenuItem";
            this.adaugaProdusToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.adaugaProdusToolStripMenuItem.Text = "Produs";
            // 
            // produsNouToolStripMenuItem
            // 
            this.produsNouToolStripMenuItem.Name = "produsNouToolStripMenuItem";
            this.produsNouToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.produsNouToolStripMenuItem.Text = "Adauga produs";
            this.produsNouToolStripMenuItem.Click += new System.EventHandler(this.produsNouToolStripMenuItem_Click);
            // 
            // adaugaCantitateToolStripMenuItem
            // 
            this.adaugaCantitateToolStripMenuItem.Name = "adaugaCantitateToolStripMenuItem";
            this.adaugaCantitateToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.adaugaCantitateToolStripMenuItem.Text = "Actualizeaza cantitatea";
            this.adaugaCantitateToolStripMenuItem.Click += new System.EventHandler(this.adaugaCantitateToolStripMenuItem_Click);
            // 
            // cautareProdusToolStripMenuItem
            // 
            this.cautareProdusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dupaNumeToolStripMenuItem,
            this.dupaCategorieToolStripMenuItem,
            this.produseInIstoricToolStripMenuItem});
            this.cautareProdusToolStripMenuItem.Name = "cautareProdusToolStripMenuItem";
            this.cautareProdusToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.cautareProdusToolStripMenuItem.Text = "Cautare Produs";
            // 
            // dupaNumeToolStripMenuItem
            // 
            this.dupaNumeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDenumire,
            this.cautadupanume});
            this.dupaNumeToolStripMenuItem.Name = "dupaNumeToolStripMenuItem";
            this.dupaNumeToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.dupaNumeToolStripMenuItem.Text = "Dupa Nume";
            this.dupaNumeToolStripMenuItem.Click += new System.EventHandler(this.dupaNumeToolStripMenuItem_Click);
            // 
            // txtDenumire
            // 
            this.txtDenumire.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(100, 27);
            this.txtDenumire.Text = "scrie aici..";
            // 
            // cautadupanume
            // 
            this.cautadupanume.Name = "cautadupanume";
            this.cautadupanume.Size = new System.Drawing.Size(258, 26);
            this.cautadupanume.Text = "apasa aici pentru cautare";
            this.cautadupanume.Click += new System.EventHandler(this.cautadupanume_Click);
            // 
            // dupaCategorieToolStripMenuItem
            // 
            this.dupaCategorieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtCategorie,
            this.cautadupacategorie});
            this.dupaCategorieToolStripMenuItem.Name = "dupaCategorieToolStripMenuItem";
            this.dupaCategorieToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.dupaCategorieToolStripMenuItem.Text = "Dupa Categorie";
            // 
            // txtCategorie
            // 
            this.txtCategorie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(100, 27);
            this.txtCategorie.Text = "...";
            // 
            // cautadupacategorie
            // 
            this.cautadupacategorie.Name = "cautadupacategorie";
            this.cautadupacategorie.Size = new System.Drawing.Size(224, 26);
            this.cautadupacategorie.Text = "Cauta";
            this.cautadupacategorie.Click += new System.EventHandler(this.cautadupacategorie_Click);
            // 
            // btnVanzare
            // 
            this.btnVanzare.Location = new System.Drawing.Point(178, 72);
            this.btnVanzare.Name = "btnVanzare";
            this.btnVanzare.Size = new System.Drawing.Size(129, 52);
            this.btnVanzare.TabIndex = 7;
            this.btnVanzare.Text = "Vanzare Produs";
            this.btnVanzare.UseVisualStyleBackColor = true;
            this.btnVanzare.Click += new System.EventHandler(this.btnVanzare_Click);
            // 
            // btnIstoric
            // 
            this.btnIstoric.Location = new System.Drawing.Point(338, 72);
            this.btnIstoric.Name = "btnIstoric";
            this.btnIstoric.Size = new System.Drawing.Size(132, 52);
            this.btnIstoric.TabIndex = 8;
            this.btnIstoric.Text = "Vizualizare Istoric Vanzari";
            this.btnIstoric.UseVisualStyleBackColor = true;
            this.btnIstoric.Click += new System.EventHandler(this.btnIstoric_Click);
            // 
            // btnCumpara
            // 
            this.btnCumpara.Location = new System.Drawing.Point(12, 72);
            this.btnCumpara.Name = "btnCumpara";
            this.btnCumpara.Size = new System.Drawing.Size(124, 52);
            this.btnCumpara.TabIndex = 9;
            this.btnCumpara.Text = "Cumpara Produs";
            this.btnCumpara.UseVisualStyleBackColor = true;
            this.btnCumpara.Click += new System.EventHandler(this.btnCumpara_Click);
            // 
            // adaugaCategorieToolStripMenuItem
            // 
            this.adaugaCategorieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.adaugaCategorieToolStripMenuItem.Name = "adaugaCategorieToolStripMenuItem";
            this.adaugaCategorieToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.adaugaCategorieToolStripMenuItem.Text = "Categorie Produs";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.denumireCategorie,
            this.adaugaCategorie});
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adaugaToolStripMenuItem.Text = "Adaugre";
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.denumiredesters,
            this.stergeCategorie});
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stergeToolStripMenuItem.Text = "Stergere";
            // 
            // stergeProdusToolStripMenuItem
            // 
            this.stergeProdusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSterge,
            this.toolStripSeparator1,
            this.stergeToolStripMenuItem1});
            this.stergeProdusToolStripMenuItem.Name = "stergeProdusToolStripMenuItem";
            this.stergeProdusToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.stergeProdusToolStripMenuItem.Text = "Sterge produs";
            this.stergeProdusToolStripMenuItem.Click += new System.EventHandler(this.stergeProdusToolStripMenuItem_Click);
            // 
            // vizualizareProduseToolStripMenuItem
            // 
            this.vizualizareProduseToolStripMenuItem.Name = "vizualizareProduseToolStripMenuItem";
            this.vizualizareProduseToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.vizualizareProduseToolStripMenuItem.Text = "Vizualizare produse";
            this.vizualizareProduseToolStripMenuItem.Click += new System.EventHandler(this.vizualizareProduseToolStripMenuItem_Click);
            // 
            // txtSterge
            // 
            this.txtSterge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSterge.Name = "txtSterge";
            this.txtSterge.Size = new System.Drawing.Size(100, 27);
            this.txtSterge.Text = "nume produs...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // stergeToolStripMenuItem1
            // 
            this.stergeToolStripMenuItem1.Name = "stergeToolStripMenuItem1";
            this.stergeToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.stergeToolStripMenuItem1.Text = "Sterge";
            this.stergeToolStripMenuItem1.Click += new System.EventHandler(this.stergeToolStripMenuItem1_Click);
            // 
            // denumireCategorie
            // 
            this.denumireCategorie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.denumireCategorie.Name = "denumireCategorie";
            this.denumireCategorie.Size = new System.Drawing.Size(100, 27);
            this.denumireCategorie.Text = "Denumire...";
            // 
            // denumiredesters
            // 
            this.denumiredesters.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.denumiredesters.Name = "denumiredesters";
            this.denumiredesters.Size = new System.Drawing.Size(100, 27);
            this.denumiredesters.Text = "Denumire...";
            // 
            // adaugaCategorie
            // 
            this.adaugaCategorie.Name = "adaugaCategorie";
            this.adaugaCategorie.Size = new System.Drawing.Size(224, 26);
            this.adaugaCategorie.Text = "Adauga";
            this.adaugaCategorie.Click += new System.EventHandler(this.adaugaCategorie_Click);
            // 
            // stergeCategorie
            // 
            this.stergeCategorie.Name = "stergeCategorie";
            this.stergeCategorie.Size = new System.Drawing.Size(224, 26);
            this.stergeCategorie.Text = "Sterge";
            this.stergeCategorie.Click += new System.EventHandler(this.stergeCategorie_Click);
            // 
            // produseInIstoricToolStripMenuItem
            // 
            this.produseInIstoricToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtIstoricDupaNume,
            this.IstoricDupaNume,
            this.txtIstoricCategorie,
            this.IstoricDupaCategorie});
            this.produseInIstoricToolStripMenuItem.Name = "produseInIstoricToolStripMenuItem";
            this.produseInIstoricToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.produseInIstoricToolStripMenuItem.Text = "Cauta produse in Istoric";
            // 
            // txtIstoricDupaNume
            // 
            this.txtIstoricDupaNume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIstoricDupaNume.Name = "txtIstoricDupaNume";
            this.txtIstoricDupaNume.Size = new System.Drawing.Size(100, 27);
            this.txtIstoricDupaNume.Text = "Dupa Nume..";
            // 
            // IstoricDupaNume
            // 
            this.IstoricDupaNume.Name = "IstoricDupaNume";
            this.IstoricDupaNume.Size = new System.Drawing.Size(224, 26);
            this.IstoricDupaNume.Text = "Cauta";
            this.IstoricDupaNume.Click += new System.EventHandler(this.IstoricDupaNume_Click);
            // 
            // txtIstoricCategorie
            // 
            this.txtIstoricCategorie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIstoricCategorie.Name = "txtIstoricCategorie";
            this.txtIstoricCategorie.Size = new System.Drawing.Size(100, 27);
            this.txtIstoricCategorie.Text = "Dupa Categorie...";
            // 
            // IstoricDupaCategorie
            // 
            this.IstoricDupaCategorie.Name = "IstoricDupaCategorie";
            this.IstoricDupaCategorie.Size = new System.Drawing.Size(224, 26);
            this.IstoricDupaCategorie.Text = "Cauta";
            this.IstoricDupaCategorie.Click += new System.EventHandler(this.IstoricDupaCategorie_Click);
            // 
            // stergeContulToolStripMenuItem
            // 
            this.stergeContulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeContDupaNume,
            this.stergeToolStripMenuItem2});
            this.stergeContulToolStripMenuItem.Name = "stergeContulToolStripMenuItem";
            this.stergeContulToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.stergeContulToolStripMenuItem.Text = "Sterge contul";
            // 
            // utilizatorToolStripMenuItem
            // 
            this.utilizatorToolStripMenuItem.Name = "utilizatorToolStripMenuItem";
            this.utilizatorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.utilizatorToolStripMenuItem.Text = "Utilizatori";
            this.utilizatorToolStripMenuItem.Click += new System.EventHandler(this.utilizatorToolStripMenuItem_Click);
            // 
            // stergeContDupaNume
            // 
            this.stergeContDupaNume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stergeContDupaNume.Name = "stergeContDupaNume";
            this.stergeContDupaNume.Size = new System.Drawing.Size(100, 27);
            this.stergeContDupaNume.Text = "numele tau de utilizator...";
            // 
            // stergeToolStripMenuItem2
            // 
            this.stergeToolStripMenuItem2.Name = "stergeToolStripMenuItem2";
            this.stergeToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.stergeToolStripMenuItem2.Text = "Sterge";
            this.stergeToolStripMenuItem2.Click += new System.EventHandler(this.stergeToolStripMenuItem2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.btnCumpara);
            this.Controls.Add(this.btnIstoric);
            this.Controls.Add(this.btnVanzare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Administrare Magazin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vizualizareDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istoricVanzariToolStripMenuItem;
        private System.Windows.Forms.Button btnVanzare;
        private System.Windows.Forms.Button btnIstoric;
        private System.Windows.Forms.Button btnCumpara;
        private System.Windows.Forms.ToolStripMenuItem adaugaProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produsNouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaCantitateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautareProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dupaNumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dupaCategorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtDenumire;
        private System.Windows.Forms.ToolStripTextBox txtCategorie;
        private System.Windows.Forms.ToolStripMenuItem cautadupanume;
        private System.Windows.Forms.ToolStripMenuItem cautadupacategorie;
        private System.Windows.Forms.ToolStripMenuItem adaugaCategorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtSterge;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox denumireCategorie;
        private System.Windows.Forms.ToolStripTextBox denumiredesters;
        private System.Windows.Forms.ToolStripMenuItem adaugaCategorie;
        private System.Windows.Forms.ToolStripMenuItem stergeCategorie;
        private System.Windows.Forms.ToolStripMenuItem produseInIstoricToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtIstoricDupaNume;
        private System.Windows.Forms.ToolStripMenuItem IstoricDupaNume;
        private System.Windows.Forms.ToolStripTextBox txtIstoricCategorie;
        private System.Windows.Forms.ToolStripMenuItem IstoricDupaCategorie;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergeContulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilizatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox stergeContDupaNume;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem2;
    }
}


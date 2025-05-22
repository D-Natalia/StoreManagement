using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Proiect2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            VerificaConexiune();
        }
        private void VerificaConexiune()
        {
            try
            {
                using (var ctx = new MyDBContext())
                {
                    var testConnection = ctx.Produs.FirstOrDefault();

                    MessageBox.Show("Conexiune realizată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la conectare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void produsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MyDBContext ctx = new MyDBContext())
            {
                var prod = from p in ctx.Produs

                           select new
                           {
                               p.Id,
                               p.Denumire,
                               p.Descriere,
                               p.DataIntrare,
                               p.DataExpirare,
                               p.Cantitate,
                               p.IdCategorie
                           };
                dataGridView1.DataSource = prod.ToList();
            }
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MyDBContext ctx = new MyDBContext())
            {
                var ctg = from p in ctx.CategorieProdus

                          select new
                          {
                              p.Id,
                              p.Denumire
                          };
                dataGridView1.DataSource = ctg.ToList();
            }
        }

        private void istoricVanzariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MyDBContext ctx = new MyDBContext())
            {
                var ist = from p in ctx.IstoricVanzari

                          select new
                          {
                              p.Id,
                              p.IdProdus,
                              p.Cantitate

                          };
                dataGridView1.DataSource = ist.ToList();
            }
        }

        private void btnVanzare_Click(object sender, EventArgs e)
        {
            Vanzare ap = new Vanzare();
            ap.ShowDialog();
        }

        private void btnIstoric_Click(object sender, EventArgs e)
        {
            using (var ctx = new MyDBContext())
            {
                var ist = from p in ctx.IstoricVanzari

                          select new
                          {
                              p.Id,
                              Produs = p.Produs.Denumire,
                              Categorie = p.Produs.CategorieProdus.Denumire,
                              p.Cantitate

                          };
                dataGridView1.DataSource = ist.ToList();
            }
        }

        private void btnCumpara_Click(object sender, EventArgs e)
        {
            Cumparare ap = new Cumparare();
            ap.ShowDialog();
        }

        private void produsNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaProdus ap = new AdaugaProdus();
            ap.ShowDialog();
        }

        private void adaugaCantitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ac = new Form2();
            ac.ShowDialog();
        }

        private void cautadupanume_Click(object sender, EventArgs e)
        {
            using (MyDBContext ctx = new MyDBContext())
            {
                string numeProdus = txtDenumire.Text;
                var prod = from p in ctx.Produs
                           where p.Denumire.Contains(numeProdus)

                           select new
                           {
                               p.Id,
                               p.Denumire,
                               p.Descriere,
                               p.DataIntrare,
                               p.DataExpirare,
                               p.Cantitate,
                               p.IdCategorie
                           };
                var rezultat = prod.ToList();
                if (rezultat.Count == 0)
                {
                    MessageBox.Show("Nu există acest produs sau " +
                        "ai tastat gresit numele produsului!",
                        "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataGridView1.DataSource = rezultat;
                }
            }
        }

        private void cautadupacategorie_Click(object sender, EventArgs e)
        {
            using (MyDBContext ctx = new MyDBContext())
            {
                string numeCategorie = txtCategorie.Text;
                var prod = from p in ctx.Produs
                           where p.CategorieProdus.Denumire.Contains(numeCategorie)

                           select new
                           {
                               p.Id,
                               p.Denumire,
                               p.Descriere,
                               p.DataIntrare,
                               p.DataExpirare,
                               p.Cantitate,
                               p.IdCategorie
                           };
                var rezultat = prod.ToList();
                if (rezultat.Count == 0)
                {
                    MessageBox.Show("Nu există produse în această categorie sau " +
                        "numele categoriei a fost introdus greșit.",
                        "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataGridView1.DataSource = rezultat;
                }
            }
        }

        private void vizualizareProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MyDBContext ctx = new MyDBContext())
            {
                var prod = from p in ctx.Produs

                           select new
                           {
                               p.Id,
                               p.Denumire,
                               p.Descriere,
                               p.DataIntrare,
                               p.DataExpirare,
                               p.Cantitate,
                               p.IdCategorie
                           };
                dataGridView1.DataSource = prod.ToList();
            }
        }

        private void stergeProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stergeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (MyDBContext ctx = new MyDBContext())
            {
                string stergere = txtSterge.Text;
                var produsdesters = ctx.Produs.FirstOrDefault(p => p.Denumire == stergere);
                if (produsdesters != null)
                {
                    ctx.Produs.Remove(produsdesters);
                    ctx.SaveChanges();
                    var prod = from p in ctx.Produs

                               select new
                               {
                                   p.Id,
                                   p.Denumire,
                                   p.Descriere,
                                   p.DataIntrare,
                                   p.DataExpirare,
                                   p.Cantitate,
                                   p.IdCategorie
                               };
                    dataGridView1.DataSource = prod.ToList();
                    MessageBox.Show("Produsul a fost sters cu cucces!");
                }
                else
                {
                    MessageBox.Show("Produsul nu exista!");
                }
            }
        }

        private void adaugaCategorie_Click(object sender, EventArgs e)
        {
            using (MyDBContext ctx = new MyDBContext())
            {
                string adauga = denumireCategorie.Text;
                ;
                if (!string.IsNullOrEmpty(adauga))
                {
                    var categorieExista = ctx.CategorieProdus.FirstOrDefault(ctg => ctg.Denumire == adauga);
                    if (categorieExista != null)
                    {
                        MessageBox.Show("Categoria exista!");
                    }
                    else
                    {
                        var categorie = new CategorieProdus
                        {
                            Denumire = adauga
                        };
                        ctx.CategorieProdus.Add(categorie);
                        ctx.SaveChanges();
                        MessageBox.Show("Categorie adaugata cu succes!");
                    }
                }
                else
                {
                    MessageBox.Show("Completeaza denumirea categoriei inainte de a apasa budotul Adauga");
                }
            }
        }

        private void stergeCategorie_Click(object sender, EventArgs e)
        {
            using (MyDBContext ctx = new MyDBContext())
            {
                string stergere = denumiredesters.Text;
                var produsdesters = ctx.CategorieProdus.FirstOrDefault(c => c.Denumire == stergere);
                if (produsdesters != null)
                {
                    //var produseDeSters = ctx.Produs.Where(p => p.IdCategorie == produsdesters.Id).ToList();
                    //ctx.Produs.RemoveRange(produseDeSters);
                    ctx.CategorieProdus.Remove(produsdesters);
                    ctx.SaveChanges();
                    var cat = from c in ctx.CategorieProdus

                              select new
                              {
                                  c.Id,
                                  c.Denumire,

                              };
                    dataGridView1.DataSource = cat.ToList();
                    MessageBox.Show("Categoria a fost sters cu cucces!");
                }
                else
                {
                    MessageBox.Show("Categoria nu exista!");
                }
            }
        }

        private void IstoricDupaNume_Click(object sender, EventArgs e)
        {
            using (var ctx = new MyDBContext())
            {
                string nume = txtIstoricDupaNume.Text;
                if (!string.IsNullOrEmpty(nume))
                {
                        var ist = from i in ctx.IstoricVanzari
                                  where i.Produs.Denumire.Contains(nume)
                                  select new
                                  {
                                      i.Id,
                                      Produs = i.Produs.Denumire,
                                      Categorie = i.Produs.CategorieProdus.Denumire,
                                      i.Cantitate
                                  };
                        dataGridView1.DataSource = ist.ToList();
                    var istoric = ist.ToList();
                    if (istoric.Any())
                    {
                        dataGridView1.DataSource = istoric; 
                    }
                    else
                    {
                        MessageBox.Show("Prousul nu are vanzari sau nu exista in magazin!"); 
                    }
                }
                else
                {
                    MessageBox.Show("Scrie numele produsuli inainte sa apesi Cauta!");
                }
            }
        }

        private void IstoricDupaCategorie_Click(object sender, EventArgs e)
        {
            using (var ctx = new MyDBContext())
            {
                string categorie = txtIstoricCategorie.Text;
                if (!string.IsNullOrEmpty(categorie))
                {
                    var ist = from i in ctx.IstoricVanzari
                              where i.Produs.CategorieProdus.Denumire.Contains(categorie)
                              select new
                              {
                                  i.Id,
                                  Produs = i.Produs.Denumire,
                                  Categorie = i.Produs.CategorieProdus.Denumire,
                                  i.Cantitate
                              };
                    dataGridView1.DataSource = ist.ToList();
                    var istoric = ist.ToList();
                    if (istoric.Any())
                    {
                        dataGridView1.DataSource = istoric;
                    }
                    else
                    {
                        MessageBox.Show("Prousul nu are vanzari sau nu exista in magazin!");
                    }
                }
                else
                {
                    MessageBox.Show("Scrie numele produsuli inainte sa apesi Cauta!");
                }
            }
            }

      
        private void dupaNumeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cautaProdusDupaCategorie_Click(object sender, EventArgs e)
        {
            using (MyDBContext ctx = new MyDBContext())
            {
                string numeCategorie = txtCategorie.Text;
                var prod = from p in ctx.Produs
                           where p.CategorieProdus.Denumire.Contains(numeCategorie)

                           select new
                           {
                               p.Id,
                               p.Denumire,
                               p.Descriere,
                               p.DataIntrare,
                               p.DataExpirare,
                               p.Cantitate,
                               p.IdCategorie
                           };
                var rezultat = prod.ToList();
                if (rezultat.Any())
                {
                    MessageBox.Show("Nu există produse în această categorie sau " +
                        "numele categoriei a fost introdus greșit.",
                        "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataGridView1.DataSource = rezultat;
                }
            }
        }

        private void utilizatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MyDBContext ctx = new MyDBContext())
            {
                var ut = from u in ctx.Utilizator

                           select new
                           {
                               u.Id,
                               u.Nume,
                               u.Email,
                               u.Admin
                           };
                dataGridView1.DataSource = ut.ToList();
            }
        }

        private void stergeToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            using (MyDBContext ctx = new MyDBContext())
            {
                string stergere = stergeContDupaNume.Text;
                var utilizatordesters = ctx.Utilizator.FirstOrDefault(c => c.Nume == stergere);
                if (utilizatordesters != null)
                {
                    //var produseDeSters = ctx.Produs.Where(p => p.IdCategorie == produsdesters.Id).ToList();
                    //ctx.Produs.RemoveRange(produseDeSters);
                    ctx.Utilizator.Remove(utilizatordesters);
                    ctx.SaveChanges();
                    var cat = from c in ctx.Utilizator

                              select new
                              {
                                  c.Id,
                                  c.Nume,
                                  c.Email,
                                  c.Admin
                              };
                    dataGridView1.DataSource = cat.ToList();
                    MessageBox.Show("Contul a fost sters cu cucces!");
                }
                else
                {
                    MessageBox.Show("Cont inexistent!");
                }
            }
        }
    }
}

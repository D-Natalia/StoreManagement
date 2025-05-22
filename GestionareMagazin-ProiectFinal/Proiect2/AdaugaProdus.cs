using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2
{
    public partial class AdaugaProdus : Form
    {
        public AdaugaProdus()
        {
            InitializeComponent();
        }



        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            using (MyDBContext ctx = new MyDBContext())
            {

                string categoriaExista = txtCategorie.Text;
                CategorieProdus categorie = null;
                foreach (var ctg in ctx.CategorieProdus)
                {
                    if (ctg.Denumire == categoriaExista)
                    {
                        categorie = ctg;
                        break;
                    }
                }
                if (categorie == null)
                {
                   categorie = new CategorieProdus(); 
                    categorie.Denumire = categoriaExista;
                    ctx.CategorieProdus.Add(categorie);
                    ctx.SaveChanges();
                }
                if (categorie != null)
                {
                    string denumireProdus = txtDenumire.Text;
                    var produsExistenta = ctx.Produs.FirstOrDefault(p => p.Denumire == denumireProdus);
                    if (produsExistenta != null)
                    {
                        MessageBox.Show("Produsul cu această denumire există deja in magazin." +
                            "Vor fi actualizate doar detaliile modificate.",
                            "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        produsExistenta.Descriere = txtDescriere.Text;
                        produsExistenta.DataIntrare = dtpDataIntrare.Value.ToString();
                        produsExistenta.DataExpirare = dtpDataExpirare.Value.ToString();
                        produsExistenta.Cantitate = (int)nudCantitate.Value;
                        produsExistenta.IdCategorie = categorie.Id;
                        ctx.SaveChanges();
                    }
                    else
                    {
                        Produs p = new Produs();
                        p.Denumire = txtDenumire.Text;
                        p.Descriere = txtDescriere.Text;
                        p.DataIntrare = dtpDataIntrare.Value.ToString();
                        p.DataExpirare = dtpDataExpirare.Value.ToString();
                        p.Cantitate = (int)nudCantitate.Value;
                        p.IdCategorie = categorie.Id;
                        ctx.Produs.Add(p);
                        ctx.SaveChanges();
                    }
                }
            }
         
            this.Close();
        }

        private void txtDenumire_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

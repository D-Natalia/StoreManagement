using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2
{
    public partial class Cumparare : Form
    {
        public Cumparare()
        {
            InitializeComponent();
        }

        private async void btnCumparare_Click(object sender, EventArgs e)
        {
            string DenumireProdus = txtDenumire.Text;
            int CantitateProdus = (int)nudCantitate.Value;
            using (MyDBContext ctx = new MyDBContext())
            {

                Produs produs = await ctx.Produs.FirstOrDefaultAsync(p => p.Denumire == DenumireProdus);
                if (produs != null)
                {
                    if (CantitateProdus <= produs.Cantitate)
                    {
                        produs.Cantitate = produs.Cantitate - CantitateProdus;
                        if (produs.Cantitate == 0)
                        {
                            ctx.Produs.Remove(produs);
                        }
                        await ctx.SaveChangesAsync();
                        MessageBox.Show("Ai cumparat produsul cu succes!");
                    }
                    else
                    {
                        MessageBox.Show("Cantitate indisponibila in magazin.");
                    }
                }
                IstoricVanzari istoric = new IstoricVanzari();
                istoric.Cantitate = (int)nudCantitate.Value;
                istoric.IdProdus = produs.Id;
                ctx.IstoricVanzari.Add(istoric);
                ctx.SaveChanges();
            }
        }
    }
}

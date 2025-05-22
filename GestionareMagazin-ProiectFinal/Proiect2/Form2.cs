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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void btnAddCantitate_Click(object sender, EventArgs e)
        {
            using (MyDBContext ctx = new MyDBContext())
            {
                int cantitate_noua = (int)nudCantitate.Value;
                var produs = ctx.Produs.SingleOrDefault(p => p.Denumire == txtDenumire.Text);
                if (produs != null)
                {
                    produs.Cantitate = produs.Cantitate + cantitate_noua;
                    MessageBox.Show("Cantitate adaugata cu succes!");
                }
                else
                {
                    MessageBox.Show("Produsul nu este in magazin!");
                }
                ctx.SaveChanges();
            }
        }
    }
}

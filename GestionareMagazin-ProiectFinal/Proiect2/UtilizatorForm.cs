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
    public partial class UtilizatorForm : Form
    {
        public UtilizatorForm()
        {
            InitializeComponent();
        }

        private void btnAfisareProduse_Click(object sender, EventArgs e)
        {
            using (MyDBContext ctx = new MyDBContext())
            {
                var prod = from p in ctx.Produs

                           select new
                           {
                               p.Denumire,
                               p.Descriere,
                               p.Cantitate
                           };
                dataGridViewUser.DataSource = prod.ToList();
            }
        }

        private void btnVinde_Click(object sender, EventArgs e)
        {
            Cumparare ap = new Cumparare();
            ap.ShowDialog();
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

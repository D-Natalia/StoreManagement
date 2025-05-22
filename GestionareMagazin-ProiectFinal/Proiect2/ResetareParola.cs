using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2
{
    public partial class ResetareParola : Form
    {
        public ResetareParola()
        {
            InitializeComponent();
            txtParolaNoua.PasswordChar = '*';
            txtRepetaParola.PasswordChar = '*';
        }

        private void btnResetareParola_Click(object sender, EventArgs e)
        {
            string nume=txtNumeUtilizator.Text;
            SHA256 sha256 = new SHA256Managed();
            byte[] input = Encoding.UTF8.GetBytes(txtParolaNoua.Text);
            byte[] hash = sha256.ComputeHash(input);
            StringBuilder output = new StringBuilder();
            foreach (byte b in hash)
            {
                output.Append(b.ToString("x2"));
            }
            string HashParola = output.ToString();
            using (MyDBContext ctx = new MyDBContext())
            {

                var numeExita = ctx.Utilizator.FirstOrDefault(n => n.Nume == nume);
                if (numeExita != null) { 
                    numeExita.Parola = HashParola;
                    ctx.SaveChanges();
                    MessageBox.Show("Parola modificata cu succes!");
                }
                else
                {
                    MessageBox.Show("Nu exista cont cu acest nume de utilizator!");
                }
            }

        }

        private void ResetareParola_Load(object sender, EventArgs e)
        {
        }

        
    }
}

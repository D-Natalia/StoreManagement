using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect2
{
    public partial class ContNou : Form
    {
        public ContNou()
        {
            InitializeComponent();
            txtParola.PasswordChar = '*';
            txtConfirmParola.PasswordChar = '*';
        }

        private void btnCreazaCont_Click(object sender, EventArgs e)
        {
            SHA256 sha256 = new SHA256Managed();
            byte[] input = Encoding.UTF8.GetBytes(txtParola.Text);
            byte[] hash = sha256.ComputeHash(input);
            StringBuilder output = new StringBuilder();
            foreach (byte b in hash)
            {
                output.Append(b.ToString("x2"));
            }
            using (MyDBContext ctx = new MyDBContext())
            {
                string nume=txtUtilizator.Text;
                var NumeExistenta = ctx.Utilizator.FirstOrDefault(u => u.Nume == nume);
                string email = txtEmail.Text;
                var EmailExistenta = ctx.Utilizator.FirstOrDefault(u => u.Email == email);
                if (txtCodAdmin.Text == string.Empty)
                {
                    if (NumeExistenta == null && EmailExistenta == null)
                    {
                        Utilizator u = new Utilizator();
                        u.Nume = txtUtilizator.Text;
                        u.Parola = output.ToString();
                        u.Email = txtEmail.Text;
                        u.Admin = 0;
                        ctx.Utilizator.Add(u);
                        ctx.SaveChanges();
                        MessageBox.Show("Utilizator creat cu succes!");
                    }
                    else
                    {
                        MessageBox.Show("Nu ai completat corect datele de mai sus! Completeaza din nou",
                                "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (txtCodAdmin.Text == "1234")
                {
                    Utilizator u = new Utilizator();
                    u.Nume = txtUtilizator.Text;
                    u.Parola = output.ToString();
                    u.Email = txtEmail.Text;
                    u.Admin = 1;
                    ctx.Utilizator.Add(u);
                    ctx.SaveChanges();
                    MessageBox.Show("Administrator creat cu succes!");
                }
            }
        
            this.Close();
        }

        private void txtUtilizator_TextChanged(object sender, EventArgs e)
        {
            using (MyDBContext ctx = new MyDBContext())
            {
                string nume = txtUtilizator.Text;
                var NumeExistenta = ctx.Utilizator.FirstOrDefault(u => u.Nume == nume);
                if(NumeExistenta != null)
                {
                    EroareNume.Text = "Nume folosit.Scrie Altul!";
                    
                }
                else
                {
                    EroareNume.Text = string.Empty;
                }

            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            using (MyDBContext ctx = new MyDBContext())
            {
                string email = txtEmail.Text;
                var EmailExistenta = ctx.Utilizator.FirstOrDefault(u => u.Email == email);
                if (EmailExistenta != null)
                {
                    MessageBox.Show("Email folosit. Nu poti crea doua conturi cu acelasi email!",
                            "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void txtConfirmParola_TextChanged(object sender, EventArgs e)
        {
            if (txtParola.Text != txtConfirmParola.Text)
            {
                EroareParola.Text = "Parolele nu sunt la fel";
            }
            else
            {
                EroareParola.Text = string.Empty;
            }
        }
    }
}

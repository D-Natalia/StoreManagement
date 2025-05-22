using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Language;


namespace Proiect2
{
    public partial class Logare : Form
    {
        public Logare()
        {
            InitializeComponent();
            txtParola.PasswordChar = '*';
          
        }
        private void ApplyTranslation()
        {
            label1.Text = Language.Strings.label1;
            label2.Text=Language.Strings.label2;
            label3.Text = Language.Strings.label3;
            label4.Text = Language.Strings.label4;
            label5.Text = Language.Strings.label5;
            label6.Text = Language.Strings.label6;
            label7.Text = Language.Strings.label7;
            btnContNou.Text=Language.Strings.btnContNou;
            btnLogare.Text = Language.Strings.btnLogare;
            btnSchimbaParola.Text = Language.Strings.btnSchimbaParola;
            selecteazaLimba.Text=Language.Strings.selecteazaLimba;

        }
        private void romanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ro");
            ApplyTranslation();
        }
        private void englezaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            ApplyTranslation();
        }

        private void btnLogare_Click(object sender, EventArgs e)
        {
            SHA256 sha256 = new SHA256Managed();
            byte[] input = Encoding.UTF8.GetBytes(txtParola.Text);
            byte[] hash = sha256.ComputeHash(input);
            StringBuilder output = new StringBuilder();
            foreach (byte b in hash)
            {
                output.Append(b.ToString("x2"));
            }
            string HashParola = output.ToString();
            string parola = txtParola.Text;
            string nume = txtUtilizator.Text;
            using (MyDBContext ctx = new MyDBContext())
            {
                var UtilizatorExista = ctx.Utilizator.FirstOrDefault
                    (u => u.Nume == nume&&u.Parola==HashParola);
                if (UtilizatorExista!=null)
                {
                    if (checkBoxuser.Checked)
                    {
                        if (UtilizatorExista.Admin == 0)
                        {
                            UtilizatorForm ap = new UtilizatorForm();
                            ap.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("nu poti sa te loghezi ca utilizator,esti Admin!" +
                                " Bifeaza casuta corecta!");
                        }
                    }
                    else if (checkBoxadmin.Checked)
                    {
                       if(UtilizatorExista.Admin == 1) { 

                            Form1 ap = new Form1();
                            ap.ShowDialog();

                       }

                       else
                        {
                            MessageBox.Show("nu poti sa te loghezi ca Admin,esti Utilizator! " +
                                "Bifeaza casuta corecta!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cont inexistent!Nume de utilizator sau parola gresite!");
                }
            
            }
            
        }

        private void btnContNou_Click(object sender, EventArgs e)
        {
            ContNou ap = new ContNou();
            ap.ShowDialog();
        }

        private void btnSchimbaParola_Click(object sender, EventArgs e)
        {
            ResetareParola ap = new ResetareParola();
            ap.ShowDialog();
        }

      
    }
}

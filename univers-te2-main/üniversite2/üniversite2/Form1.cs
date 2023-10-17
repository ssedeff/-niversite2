using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace üniversite2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;
            vize = Convert.ToDouble(txtVize.Text);
            final = Convert.ToDouble(txtFinal.Text);
            ortalama = (vize * 40 / 100) + (final * 60 / 100); 
            lblOrtalama.Text = "ORTALAMA: " + ortalama;
            if(ortalama>=50&& final >= 50)
            {
                lblDurum.Text = "GEÇTİNİZ.";
            }
            else
            {
                lblDurum.Text = "KALDINIZ";
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string[] arabalar = { "BMW", "AUDI", "TOYOTA", "MERCEDES", "TOGG" };
        Random rnd = new Random();

        private void btn3_Click(object sender, EventArgs e)
        {
            string SonEleman = arabalar[arabalar.Length - 1];
            MessageBox.Show(SonEleman, "Son Eleman", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int rastgeS = rnd.Next(0, arabalar.Length);
            string rastgeleEleman = arabalar[rastgeS];
            MessageBox.Show(rastgeleEleman, "RastgeleElemna", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (index < arabalar.Length)
            {
                lstArac.Items.Add(arabalar[index]);
                index++;
            }
            else
                MessageBox.Show("Dizinin son elemanına ulaşılıd");
        }
    }
}

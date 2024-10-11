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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int sayac = 1;

        private void btnButonEkle_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Width = 150;
            btn.Height = 40;
            Random rnd = new Random();
            int btnX = rnd.Next(0,this.ClientSize.Width-btn.Width);
            btn.Left = btnX;
            int btnY = rnd.Next(0, this.ClientSize.Height - btn.Height);
            btn.Top = btnY;
            btn.Text = sayac.ToString();
            sayac++;
            btn.Click += btnButonEkle_Click;
            
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

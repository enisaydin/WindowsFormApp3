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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //List <type> içerisinde verilen veri tipine bürünerek,verilen tipdeki elemanları tutan bir koleksiyon oluşturmamızı sağlar.Dizilerdeki gibi boyut arttırma işlemine gerek yok.Dizideki Array.Resize kullanıyorduk
        List<String> list = new List<String>();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(5);
            sayilar.Add(6);
            //sayilar.Add("8"); Tanımlamada oluşturulan veri tipine uygun elemanlar eklenmeli
            MessageBox.Show("Wlemanlar int listesine eklendi \n" +
                "eleman sayisi :" + sayilar.Count);
        }

        private void btnSiralama_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Bursa");
            sehirler.Add("İstanbul");
            sehirler.Add("Kars");
            sehirler.Add("Manisa");
            sehirler.Add("İzmir");
            sehirler.Sort();
            foreach (string s in sehirler)
            {
                MessageBox.Show(s);
            }
        }

        private void btnVarmi_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Bursa");
            sehirler.Add("İstanbul");
            sehirler.Add("Kars");
            sehirler.Add("Manisa");
            sehirler.Add("İzmir");
            if (sehirler.Contains("Bursa"))
            {
                MessageBox.Show("Bursa mevcut");
            }
            else
            {
                MessageBox.Show("Bursa yok ");
            }
        }
    }
}

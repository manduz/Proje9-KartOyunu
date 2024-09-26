using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox kart1 = new PictureBox();
        PictureBox kart2 = new PictureBox();
        string[] KartListe = Directory.GetFiles("C:\\EmekWebRepo\\C#\\Proje9-KartOyunu\\KartOyunu\\TarotKartı");

        string[] kartDizi1 = new string[9];
      //  string[] kartDizi2 = new string[4];


        int sayi = 0;
      //  int skor = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            kart1.ImageLocation = kartDizi1[sayi];
            kart1.Location = new Point(250, 60);
            kart1.Size = new Size(100,100);
            kart1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(kart1);

            //kart2.ImageLocation = kartDizi2[sayi];
            //kart2.Location = new Point(350, 240);
            //kart2.Size = new Size(100, 100);
            //kart2.SizeMode = PictureBoxSizeMode.StretchImage;
            //this.Controls.Add(kart2);

            sayi++;

            if(sayi == 9)
            {
                MessageBox.Show("Oyun bitti");
                sayi = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KartListe = Karistir(KartListe);
            KartIkiyeBol(KartListe);
        }

        private void KartIkiyeBol(string[] kartListe)
        {
            for (int i = 0; i < kartListe.Length; i++)
            {
                kartDizi1[i] = kartListe[i];
            }
            //int x = 0;
            //for (int i = 4; i < kartListe.Length; i++)
            //{
            //    kartDizi2[x] = kartListe[i];
            //    x++;
            //}
        }

        private string[] Karistir(string[] kartListe)
        {
            string[] cekilenKart = new string[kartListe.Length];
            Random random = new Random();
            for (int i = 0; i < kartListe.Length; i++)
            {
                string kart = kartListe[random.Next(0,kartListe.Length)];
              //  if (cekilenKart.Contains(kart))
                {
                    cekilenKart[i] = kart;
                }
                //else //aynı kart gelirse bir eksiğine gitsin 
                //{
                //    i--;
                //    continue;
                //}              
            }
            return cekilenKart;
        }
    }
}

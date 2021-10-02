/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:4-Proje
**				ÖĞRENCİ ADI............:Recep İlyasoğlu
**				ÖĞRENCİ NUMARASI.......:G171210551
**              DERSİN ALINDIĞI GRUP...:1C
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtıkOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Atik[] atik = new Atik[8];
        AtikKutusu[] atikKutusu = new AtikKutusu[4];
        Random rastgele = new Random();
        int sayi, puan,sure=60;
 
        void BilgileriYukle()       // Dosyadan resimleri çeker ve nesneleri doldurur
        {             
            atik[0] =new Atik(new Bitmap("atık\\resim1.png"),"cam",600,"şişe");
            atik[1] = new Atik(new Bitmap("atık\\resim2.png"),"cam",250,"bardak");
            atik[2] = new Atik(new Bitmap("atık\\resim3.png"),"kağıt",250,"gazete");
            atik[3] = new Atik(new Bitmap("atık\\resim4.png"),"kağıt",200,"dergi");
            atik[4]= new Atik(new Bitmap("atık\\resim5.png"),"organik",120,"salatalık");
            atik[5]= new Atik(new Bitmap("atık\\resim6.png"),"organik",150,"domates");
            atik[6] = new Atik(new Bitmap("atık\\resim7.png"),"metal",350,"kola kutusu");
            atik[7]=new Atik(new Bitmap("atık\\resim8.png"),"metal",550,"salça kutusu");

            atikKutusu[0] = new AtikKutusu("organik");
            atikKutusu[0].Kapasite=700;
            atikKutusu[1] = new AtikKutusu("kağıt");
            atikKutusu[1].Kapasite = 1200;
            atikKutusu[2] = new AtikKutusu("cam");
            atikKutusu[2].Kapasite = 2200;
            atikKutusu[3] = new AtikKutusu("metal");
            atikKutusu[3].Kapasite = 2300;
        }
     
        void Rastgele()     // Rastgele sayı üretip o sayıya denk gelen resmi gösterir
        {         
            sayi = rastgele.Next(0, 8);
            switch (sayi)
            {
                case 0:
                    pictureBox1.Image = atik[0].Resim;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 1:
                    pictureBox1.Image = atik[1].Resim;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox1.Image = atik[2].Resim;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox1.Image = atik[3].Resim;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox1.Image = atik[4].Resim;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox1.Image = atik[5].Resim;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox1.Image = atik[6].Resim;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 7:
                    pictureBox1.Image = atik[7].Resim;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

            }
            
        }
        void ButonAktif(bool value) // butonları aktif/pasif durumunu düzenler
        {
            organik_button.Enabled = value;
            organik_bosalt.Enabled = value;
            kagit_button.Enabled = value;
            kagit_bosalt.Enabled = value;
            cam_button.Enabled = value;
            cam_bosalt.Enabled = value;
            metal_button.Enabled = value;
            metal_bosalt.Enabled = value;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BilgileriYukle();
            ButonAktif(false);
            this.Text = "ATIK OYUNU";
        }

        private void yeniOyun_Click(object sender, EventArgs e) 
        {
            timer1.Interval = 1000;
            timer1.Start();                // süreyi ayarlar ve başlatır
            ButonAktif(true);
            Rastgele();
            yeniOyun.Enabled = false;
            panel3.BackColor = Color.Cyan;
            panel4.BackColor = Color.Cyan;      // oyun başladığında renk değişikliği yapar
            sure_label.ForeColor = Color.White;
            puan_label.ForeColor = Color.White;
            puan_label.Text = "0";
            atikKutusu[0].Bosalt();
            organik_listbox.Items.Clear();
            organikProgress.Value = 0;
            atikKutusu[1].Bosalt();         // önceki bilgiler silinir tool lar boşaltılır
            kagit_listbox.Items.Clear();
            kagitProgress.Value = 0;
            atikKutusu[2].Bosalt();
            cam_listbox.Items.Clear();
            camProgress.Value = 0;
            atikKutusu[3].Bosalt();
            metal_listbox.Items.Clear();
            metalProgress.Value = 0;

        }
        
        private void organik_bosalt_Click(object sender, EventArgs e)
        {
            if (atikKutusu[0].DolulukOrani >= 75)   // %75 i doluysa girer
            {
                organik_listbox.Items.Clear();
                puan += atikKutusu[0].BosaltmaPuani;    // ilgili listbox u yemizler ve puanı ekler
                puan_label.Text = puan.ToString();      //
                organikProgress.Value = 0;
                atikKutusu[0].Bosalt();     
                sure += 3;
            }
        }
        private void organik_button_Click(object sender, EventArgs e)
        {
            if (atik[sayi].Tur == atikKutusu[0].Tur && atik[sayi].Hacim <= atikKutusu[0].BosAlan)
            {
                atikKutusu[0].Ekle(atik[sayi]);
                organik_listbox.Items.Add(atik[sayi].Isim + " (" + atik[sayi].Hacim + ")");
                organikProgress.Value = atikKutusu[0].DolulukOrani; // atık, doğru atık kutusu ise ve boş yer varsa girer
                puan += atik[sayi].Hacim;                           //
                puan_label.Text = puan.ToString();
                Rastgele();
            }

        }

        private void kagit_button_Click(object sender, EventArgs e)
        {
            if (atik[sayi].Tur == atikKutusu[1].Tur && atik[sayi].Hacim<=atikKutusu[1].BosAlan)
            {
                atikKutusu[1].Ekle(atik[sayi]);
                kagit_listbox.Items.Add(atik[sayi].Isim + " (" + atik[sayi].Hacim + ")");
                kagitProgress.Value = atikKutusu[1].DolulukOrani;
                puan += atik[sayi].Hacim;
                puan_label.Text = puan.ToString();
                Rastgele();
            }
        }
       
        private void kagit_bosalt_Click(object sender, EventArgs e)
        {
            if (atikKutusu[1].DolulukOrani >= 75)
            {
                kagit_listbox.Items.Clear();
                puan += atikKutusu[1].BosaltmaPuani;
                puan_label.Text = puan.ToString();
                atikKutusu[1].Bosalt();
                kagitProgress.Value = 0;
                sure += 3;
            }
        }

      
        
        private void cikis_Click(object sender, EventArgs e)    // programı sonlandırır
        {
            this.Close();
            Application.Exit();
        }

        private void metal_button_Click_1(object sender, EventArgs e)
        {
            if (atik[sayi].Tur == atikKutusu[3].Tur && atik[sayi].Hacim <= atikKutusu[3].BosAlan)
            {
                atikKutusu[3].Ekle(atik[sayi]);
                metal_listbox.Items.Add(atik[sayi].Isim + " (" + atik[sayi].Hacim + ")");
                metalProgress.Value = atikKutusu[3].DolulukOrani;
                puan += atik[sayi].Hacim;
                puan_label.Text = puan.ToString();
                Rastgele();
            }
        }

        private void cam_bosalt_Click_1(object sender, EventArgs e)
        {
            if (atikKutusu[2].DolulukOrani >= 75)
            {
                cam_listbox.Items.Clear();
                puan += atikKutusu[2].BosaltmaPuani;
                puan_label.Text = puan.ToString();
                camProgress.Value = 0;
                atikKutusu[2].Bosalt();
                sure += 3;
            }
        }

        private void metal_bosalt_Click(object sender, EventArgs e)
        {
            if (atikKutusu[3].DolulukOrani >= 75)
            {
                metal_listbox.Items.Clear();
                puan += atikKutusu[3].BosaltmaPuani;
                puan_label.Text = puan.ToString();
                metalProgress.Value = 0;
                atikKutusu[3].Bosalt();
                sure += 3;
            }
        }

        private void cam_button_Click_1(object sender, EventArgs e)
        {
            if (atik[sayi].Tur == atikKutusu[2].Tur && atik[sayi].Hacim <= atikKutusu[2].BosAlan)
            {
                atikKutusu[2].Ekle(atik[sayi]);
                cam_listbox.Items.Add(atik[sayi].Isim + " (" + atik[sayi].Hacim + ")");
                camProgress.Value = atikKutusu[2].DolulukOrani;
                puan += atik[sayi].Hacim;
                puan_label.Text = puan.ToString();
                Rastgele();
            }
        }
        

        private void timer1_Tick(object sender, EventArgs e)    // süreyi ayarlar
        {
            sure--;
            if (sure == 0)// süre 0 olduğunda herşey eski haline döner
            {
                timer1.Stop();
                ButonAktif(false);
                yeniOyun.Enabled = true;
                sure = 60;
                puan = 0;
                panel3.BackColor = Color.White;
                panel4.BackColor = Color.White;
                sure_label.ForeColor = Color.DarkTurquoise;
                puan_label.ForeColor = Color.DarkTurquoise;
            }
            sure_label.Text = sure.ToString();
        }
    }
}

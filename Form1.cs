using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDP_PROJE
{
    public partial class Form1 : Form
    {
        Tavuk tavuk = new Tavuk();
        Ordek ordek = new Ordek();
        Inek inek = new Inek();
        Keci keci = new Keci();
        public Form1()
        {

            InitializeComponent();
            timer1.Start();

        }

        private void TavukYembutton_Click(object sender, EventArgs e)
        {
            TavukprogressBar.Value = 100;
        }

        private void OrdekYembutton_Click(object sender, EventArgs e)
        {
            OrdekprogressBar.Value = 100;
        }

        private void InekYembutton_Click(object sender, EventArgs e)
        {
            InekprogressBar.Value = 100;
        }

        private void KeciYembutton_Click(object sender, EventArgs e)
        {
           KeciprogressBar.Value = 100;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {


            int sure = Convert.ToInt32(GecenSurelabel.Text);
            sure++;
            GecenSurelabel.Text = sure.ToString() ;

                if(sure%1==0 && sure != 0)
            {
                int sayi = tavuk.Enerji(TavukprogressBar.Value);
                TavukprogressBar.Value= sayi;
                if (sayi == 0) { Tavukcanlilabel.Text = "Öldü"; TavukYembutton.Enabled = false; tavuk.SesCikar();  /*tavuk.SesDurdur(); */}
                int sayi2 = ordek.Enerji(OrdekprogressBar.Value);
                OrdekprogressBar.Value = sayi2;
                if (sayi2 == 0) { Ordekcanlilabel.Text = "Öldü"; OrdekYembutton.Enabled = false; ordek.SesCikar();/* ordek.SesDurdur();*/ }
                int sayi3 = inek.Enerji(InekprogressBar.Value);
                InekprogressBar.Value = sayi3;
                if (sayi3 == 0) { InekCanlilabel.Text= "Öldü";InekYembutton.Enabled = false; inek.SesCikar();/* inek.SesDurdur();*/ }
                int sayi4 = keci.Enerji(KeciprogressBar.Value);
                KeciprogressBar.Value = sayi4;
                if (sayi4 == 0) { Kecicanlilabel.Text = "Öldü"; KeciYembutton.Enabled = false; keci.SesCikar(); /* keci.SesDurdur();*/ }
            }

                if (sure % 3 == 0 && sure != 0 && Tavukcanlilabel.Text != "Öldü")
                {
                    int sayi = tavuk.YumurtaVer(Convert.ToInt32(TavukYumurtaSayisilabel.Text));
                    TavukYumurtaSayisilabel.Text = sayi.ToString() ;
                }

                if (sure % 5 == 0 && sure != 0 && Ordekcanlilabel.Text != "Öldü")
                 {
                int sayi = ordek.YumurtaVer(Convert.ToInt32(OrdekYumurtasiSayisilabel.Text));
                OrdekYumurtasiSayisilabel.Text = sayi.ToString() ;
                }

                 if (sure % 8 == 0 && sure != 0 && InekCanlilabel.Text != "Öldü")
                {
                int sayi = inek.SutVer(Convert.ToInt32(InekSutSayisilabel.Text));
                InekSutSayisilabel.Text = sayi.ToString();
                }

                if (sure % 7 == 0 && sure != 0 && Kecicanlilabel.Text != "Öldü")
                {
                int sayi = keci.SutVer(Convert.ToInt32(KeciSutuSayisilabel.Text));
                KeciSutuSayisilabel.Text = sayi.ToString();
                }

        }

        private void tavukYumurtasiSat_Click(object sender, EventArgs e)
        {
           int tavukyumurtaParasi= tavuk.YumurtaSat(Convert.ToInt32(TavukYumurtaSayisilabel.Text));
            int sifirla = 0;
            TavukYumurtaSayisilabel.Text = sifirla.ToString();
            int Kasa = Convert.ToInt32(Kasalabel.Text);
            Kasalabel.Text = (Kasa + tavukyumurtaParasi).ToString();
        }

        private void OrdekYumurtasiSat_Click(object sender, EventArgs e)
        {
            int ordekyumurtasiParasi = ordek.YumurtaSat(Convert.ToInt32(OrdekYumurtasiSayisilabel.Text));
            int sifirla = 0;
            OrdekYumurtasiSayisilabel.Text = sifirla.ToString();
            int Kasa = Convert.ToInt32(Kasalabel.Text);
            Kasalabel.Text = (Kasa + ordekyumurtasiParasi).ToString();
        }

        private void InekSutuSat_Click(object sender, EventArgs e)
        {
            int ineksutuParasi = inek.SutSat(Convert.ToInt32(InekSutSayisilabel.Text));
            int sifirla = 0;
            InekSutSayisilabel.Text = sifirla.ToString();
            int Kasa = Convert.ToInt32(Kasalabel.Text);
            Kasalabel.Text = (Kasa + ineksutuParasi).ToString();
        }

        private void KeciSutuSat_Click(object sender, EventArgs e)
        {
            int kecisutuParasi = keci.SutSat(Convert.ToInt32(KeciSutuSayisilabel.Text));
            int sifirla = 0;
            KeciSutuSayisilabel.Text = sifirla.ToString();
            int Kasa = Convert.ToInt32(Kasalabel.Text);
            Kasalabel.Text = (Kasa + kecisutuParasi).ToString();
        }
    }
}

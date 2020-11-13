using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PDP_PROJE
{
    class Ordek : Hayvan, IKumes
    {

        SoundPlayer ordeksesi = new SoundPlayer();

        public override int Enerji(int enerji)
        {
            if (enerji > 1)
                enerji -= 3;
            if (enerji == 1)
                enerji = 0;
            return enerji;
        }

        public override void SesCikar()
        {
            ordeksesi.SoundLocation = "ordek.wav";
            ordeksesi.Play();
        }

        public override void SesDurdur()
        {
            ordeksesi.Stop();
        }

        public int YumurtaSat(int yumurtaSayisi)
        {
            int ucret;
            ucret = yumurtaSayisi * 3;
            return ucret;
        }

        public int YumurtaVer(int verilenYumurtaSayisis)
        {
            verilenYumurtaSayisis++;
            return verilenYumurtaSayisis;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PDP_PROJE
{
     class Tavuk : Hayvan,IKumes
    {
        SoundPlayer tavuksesi = new SoundPlayer();

        public override int Enerji(int enerji)
        {
            if (enerji > 0)
                enerji -= 2;
            return enerji;
        }

        public override void SesCikar()
        {
            
            tavuksesi.SoundLocation = "tavuk.wav";
            tavuksesi.Play();

        }

        public override void SesDurdur()
        {
            tavuksesi.Stop();
        }

        public int YumurtaSat(int yumurtaSayisi)
        {
            int ucret;
           ucret= yumurtaSayisi * 1;
            return ucret;
        }

        public int YumurtaVer(int verilenYumurtaSayisis)
        {
            verilenYumurtaSayisis++;
            return verilenYumurtaSayisis;
        }
    }
}

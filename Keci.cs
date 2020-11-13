using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PDP_PROJE
{
    class Keci :Hayvan ,IAhir
    {
        SoundPlayer kecisesi = new SoundPlayer();

        public override int Enerji(int enerji)
        {
            if (enerji > 4)
                enerji -= 6;
            if (enerji == 4)
                enerji = 0;
            return enerji;
        }

        public override void SesCikar()
        {
          
            kecisesi.SoundLocation = "keci.wav";
            kecisesi.Play();
        }

        public override void SesDurdur()
        {
            kecisesi.Stop();
        }

        public int SutSat(int sutMiktari)
        {
            int ucret;
            ucret = sutMiktari * 8;
            return ucret;
        }

        public int SutVer(int verilenSutMiktari)
        {
            verilenSutMiktari++;
            return verilenSutMiktari;
        }
    }
}

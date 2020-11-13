using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace PDP_PROJE
{
    class Inek : Hayvan, IAhir
    {
        SoundPlayer ineksesi = new SoundPlayer();

        public override int Enerji(int enerji)
        {
            if(enerji>4)
            enerji -= 8;
            if (enerji == 4)
                enerji = 0;
            return enerji;
        }

        public override void SesCikar()
        {
            
            ineksesi.SoundLocation = "inek.wav";
                ineksesi.Play();
           
        }
        public override void SesDurdur()
        {
            ineksesi.Stop();
        }

        public int SutSat(int sutMiktari)
        {
            int ucret;
            ucret = sutMiktari * 5;
            return ucret;
        }

        public int SutVer(int verilenSutMiktari)
        {
            verilenSutMiktari++;
            return verilenSutMiktari;
        }
    }
}

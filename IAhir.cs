using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDP_PROJE
{
    interface IAhir
    {
        int SutVer(int verilenSutMiktari);
        int SutSat(int sutMiktari);
    }
}

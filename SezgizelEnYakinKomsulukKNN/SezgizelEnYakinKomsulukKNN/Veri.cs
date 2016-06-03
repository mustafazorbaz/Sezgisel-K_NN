using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SezgizelEnYakinKomsulukKNN
{
  public  class Veri
    {
            public List<double> degerler = new List<double>();

            public double uzaklik;
            public string etiket;

            public void etiketSet(string etiket)
            {
                this.etiket = etiket;

            }
            public string etiketGet()
            {
                 return etiket;

            }
            public void uzaklikSet(double ort)
            {
               this.uzaklik=ort;
            }
            public double  uzaklikGet()
            {
                return uzaklik ;
            }
            public void degerlerSet(double deger)
            {
                degerler.Add(deger);

            }
            public double degerlerGet(int indis)
            {
                return degerler[indis];

            }



            internal static int uzaklikSirala2(Veri x, Veri y)
            {
                throw new NotImplementedException();
            }
    }
}

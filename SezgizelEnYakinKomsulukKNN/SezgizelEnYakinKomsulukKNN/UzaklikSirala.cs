using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SezgizelEnYakinKomsulukKNN
{
    class UzaklikSirala
    {
        public void sirala(List<Veri> satirlarEgitim)
        {

            for (int i = 0; i < satirlarEgitim.Count; i++)
            {
                for (int j = 0; j < satirlarEgitim.Count; j++)
                {
                    if (satirlarEgitim[i].uzaklik < satirlarEgitim[j].uzaklik)
                    {
                        Veri temp = satirlarEgitim[i];
                        satirlarEgitim[i] = satirlarEgitim[j];
                        satirlarEgitim[j] = temp;
                    }

                }
            }

        }
    }
}

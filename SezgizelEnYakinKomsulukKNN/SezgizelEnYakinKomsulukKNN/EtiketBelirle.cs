using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SezgizelEnYakinKomsulukKNN
{
    class EtiketBelirle
    {
       

  
        public string etiketBelirle(List<Veri> satirlarEgitim,int k)
        {

            int sayac = 0;
            string etiket = "";
            int[] etiketSayisi = new int[k];
            for (int i = 0; i < k; i++)
            {
                sayac = 0;
                for (int j = 0; j < k; j++)
                {
                    if (satirlarEgitim[i].etiket == satirlarEgitim[j].etiket)
                    {
                        sayac++;

                    }
                }
                etiketSayisi[i] = sayac;
            }

            int buyukIndis = diziIndisiGeriyeDondur(etiketSayisi);
            etiket = satirlarEgitim[buyukIndis].etiket;
            return etiket;
        }

        public int diziIndisiGeriyeDondur(int[] dizi)
        {
            int deger = dizi[0];
            int indis = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (deger < dizi[i])
                {
                    deger = dizi[i];
                    indis = i;
                }
            }
            return indis;

        }
    }
}

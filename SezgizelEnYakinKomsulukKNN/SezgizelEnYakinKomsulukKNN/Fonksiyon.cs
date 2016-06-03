using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SezgizelEnYakinKomsulukKNN
{
    public abstract class Fonksiyon
    {

        int degiskenSayisi;
        double altSinir, ustSinir, globalMin;

        public Fonksiyon(int degiskenSayisi, double altSinir, double ustSinir, double globalMin)
        {
            setDegiskenSayisi(degiskenSayisi);
            setAltSinir(altSinir);
            setUstSinir(ustSinir);
            setGlobalMin(globalMin);
        }

        void setDegiskenSayisi(int degiskenSayisi)
        {
            this.degiskenSayisi = degiskenSayisi;
        }

        void setAltSinir(double altSinir)
        {
            this.altSinir = altSinir;
        }

        void setUstSinir(double ustSinir)
        {
            this.ustSinir = ustSinir;
        }

        void setGlobalMin(double globalMin)
        {
            this.globalMin = globalMin;
        }

        public int getDegiskenSayisi()
        {
            return degiskenSayisi;
        }

        public double getAltSinir()
        {
            return altSinir;
        }

        public double getUstSinir()
        {
            return ustSinir;
        }

        public double getGlobalMin()
        {
            return globalMin;
        }

        public static Fonksiyon fonksiyonYarat(string benchmarkProblem)
        {
            switch (benchmarkProblem)
            {
                case "Oklit": return new Oklit();
                case "Manhattan": return new Manhattan();
                case "Michalewicz 2": return new Minkovski();
                default: return null;
            }
        }

        public abstract double hesapla(Veri egitim, Veri test, List<Gen> genler);
    }

    class Oklit : Fonksiyon
    {
        public Oklit()  : base(8, 0, 1, 100)
        {

        }

        public override double hesapla( Veri egitim, Veri test,List<Gen> genler)
        {
                double sonuc = 0;
                for (int sut = 0; sut < egitim.degerler.Count; sut++)//Veri Sınıfındaki List ti dolduguruyor.
                {
                    sonuc += genler[sut].genDeger * Math.Pow(egitim.degerlerGet(sut) - test.degerlerGet(sut), 2);

                }
                 return Convert.ToDouble(Math.Sqrt(sonuc));
                
            
            
        }
    }
    class Manhattan:Fonksiyon
    {
        public Manhattan() : base(8, 0, 1, 100)
        {

        }
        public override double hesapla(Veri egitim, Veri test, List<Gen> genler)
        {
            double sonuc = 0;
                for (int sut = 0; sut < egitim.degerler.Count; sut++)//Veri Sınıfındaki List ti dolduguruyor.
                {
                    sonuc += genler[sut].genDeger * Math.Abs(egitim.degerlerGet(sut) - test.degerlerGet(sut));

                }
                return Convert.ToDouble(Math.Sqrt(sonuc));          
        }       
    }
    class Minkovski : Fonksiyon
    {
        public Minkovski() : base(8, 0, 1, 100)
        {

        }

        public override double hesapla(Veri egitim, Veri test, List<Gen> genler)
        {
            MessageBox.Show("Minkovski Fonksiyonu Yok İşlem Sonlandı");
            Form1 frm = new Form1();
            frm.Close();
            return 0;

        }
    }
    
}

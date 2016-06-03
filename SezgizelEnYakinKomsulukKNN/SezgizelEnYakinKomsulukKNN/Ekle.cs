using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SezgizelEnYakinKomsulukKNN
{
    public class Ekle
    {
        Form1 frm;
        Populasyon populasyon;
        public Ekle(Form1 form,Populasyon pop)
        {
            this.frm = form;
            this.populasyon = pop;

        }
        public void yeniBireyiEkle(Kromozom kromozom1,Kromozom kromozom2)
        {

            populasyon.listKromozomlar.Add(kromozom1);
            populasyon.listKromozomlar.Add(kromozom2);
            if (frm.islemYaz == true) { 
            frm.listBoxIslemler.Items.Add("Populasyona Yeni Eklenen Birey 1 =" + frm.genleriYaz(kromozom1) + "--- UYGUNLUK -->" + kromozom1.getUygunluk());
            frm.listBoxIslemler.Items.Add("Populasyona Yeni Eklenen Birey 2 =" + frm.genleriYaz(kromozom2) + "--- UYGUNLUK -->" + kromozom2.getUygunluk());
            }
        }
    }
}

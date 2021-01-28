using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŞA___FactoryMethodDP
{
    /*
     Farklı türden sayfalardan oluşan farklı dökümanlarımız olsun. 
     Örneğin Rapor ve Özgeçmiş dokümanlarımız farklı türden ancak benzer ya da farklı sayfalardan oluşur.
     Rapor; Giriş Sayfası, Sonuç Sayfası, Değerlendirme Sayfası,Özet Sayfası, Kaynakça...
     Özgeçmiş; Eğitim Sayfası, Kişisel Bilgiler, Deneyim Sayfası...
     */

    abstract class Dokuman
    {
        public Dokuman()
        {
            this.SayfaOlustur();
        }

        public List<Sayfa> Sayfalar { get; protected set; }
        public abstract void SayfaOlustur();
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    class Rapor : Dokuman
    {
        public override void SayfaOlustur()
        {
            Sayfalar = new List<Sayfa>
            {
                new GirisSayfasi(),
                new SonucSayfasi(),
                new DegerlendirmeSayfasi(),
                new OzetSayfasi(),
                new KaynakcaSayfasi()
            };
        }
    }

    class Ozgecmis : Dokuman
    {
        public override void SayfaOlustur()
        {
            Sayfalar = new List<Sayfa>
            {
                new EgitimSayfasi(),
                new KisiselBilgilerSayfasi(),
                new DeneyimSayfasi()
            };
        }
    }

    abstract class Sayfa
    {
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    class GirisSayfasi : Sayfa { }
    class SonucSayfasi : Sayfa { }
    class DegerlendirmeSayfasi : Sayfa { }
    class OzetSayfasi : Sayfa { }
    class KaynakcaSayfasi : Sayfa { }
    class EgitimSayfasi : Sayfa { }
    class KisiselBilgilerSayfasi : Sayfa { }
    class DeneyimSayfasi : Sayfa { }
}

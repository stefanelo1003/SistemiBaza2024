using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Mapiranja
{
    public class SmenaMap : ClassMap<Smena>
    {
        public SmenaMap()
        {
            Table("SMENA");

            Id(x => x.Id, "ID_SMENE");

            Map(x => x.VremePocetka, "VREME_POCETKA");
            Map(x => x.VremeKraja, "VREME_KRAJA");

            References(x => x.EkipaZaSmenu).Column("REDNI_BROJ_EKIPE").LazyLoad();

            References(x => x.ObjekatZaSmenu).Column("ID_OBJEKTA").LazyLoad();
        }
    }
}

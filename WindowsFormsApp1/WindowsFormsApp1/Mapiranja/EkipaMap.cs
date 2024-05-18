using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entiteti;
using FluentNHibernate.Mapping;

namespace WindowsFormsApp1.Mapiranja
{
    public class EkipaMap : ClassMap<Ekipa>
    {
        public EkipaMap() 
        {
            Table("EKIPA");

            Id(x => x.RedniBroj, "RBR").GeneratedBy.TriggerIdentity();

            References(x => x.Vodja).Column("VODJA").LazyLoad();

            HasMany(x => x.Clanovi).KeyColumn("RBR_EKIPE").Cascade.All().Inverse();

            References(x => x.DuziVozilo).Column("RBR_EKIPE").LazyLoad(); // 1:1 EKIPA-VOZILO

            HasMany(x => x.Smena).KeyColumn("RBR_EKIPE").LazyLoad().Cascade.All().Inverse(); // 1:N EKIPA - SMENA (Mozda treba prepraviti)

            HasMany(x => x.Intervencija).KeyColumn("RBR_EKIPE").LazyLoad().Cascade.All().Inverse();


        }
    }
}

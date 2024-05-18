using FluentNHibernate.Conventions.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entiteti;

namespace WindowsFormsApp1.Mapiranja
{
    public class DuziMap : ClassMap<Duzi>
    {
        public DuziMap() 
        {
            Table("DUZI");

            CompositeId(x => x.Id)
                .KeyReference(x => x.DuziEkipa, "RBR_EKIPE")
                .KeyReference(x => x.DuziVozilo, "REG_VOZILA");

            Map(x => x.DatumDo, "DATUM_DO");
            Map(x => x.DatumOd, "DATUM_OD");
        }
    }
}

using FluentNHibernate.Conventions.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entiteti;

namespace WindowsFormsApp1.Mapiranja
{
    public class AlarmniSistemMap : ClassMap<AlarmniSistem>
    {
        public AlarmniSistemMap()
        {
            Table("ALARMNI_SISTEM");

            Id(x => x.Id, "ID_ALARMA").GeneratedBy.TriggerIdentity();

            Map(x => x.Proizvodjac, "PROIZVODJAC");
            Map(x => x.GodinaProizvodnje, "GODINA_PROIZVODNJE");
            Map(x => x.DetektorToplotnogOdraza, "P_TOPLOTNI_ODRAZ");
            Map(x => x.HorRezolucija, "HORIZONTALNA_REZ");
            Map(x => x.VerRezolucija, "VERTIKALNA_REZ");
            Map(x => x.UltrazvucniSenzor, "P_ULTRAZVUK");
            Map(x => x.DetektorPokreta, "P_DETEKTOR_POKRETA");
            Map(x => x.Osetljivost, "OSETLJIVOST");
            Map(x => x.DatumInstalacije, "DATUM_INSTALACIJE");
            Map(x => x.Objekat, "ID_OBJEKTA");
            Map(x => x.MinFrekvencija, "MIN_FREKVENCIJA");
            Map(x => x.MaxFrekvencija, "MAX_FREKVENCIJA");
        }
    }
}

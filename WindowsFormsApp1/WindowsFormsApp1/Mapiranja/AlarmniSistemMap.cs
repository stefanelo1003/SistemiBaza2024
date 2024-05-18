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

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Proizvodjac, "PROIZVODJAC");
            Map(x => x.GodinaProizvodnje, "GODINA_PROIZVODNJE");
            Map(x => x.UltrazvucniSenzor, "ULTRAZVUCNI_SENZOR");
            Map(x => x.MinFrekvencija, "MIN_FREKVENCIJA");
            Map(x => x.MaxFrekvencija, "MAX_FREKVENCIJA");
            Map(x => x.DetektorPokreta, "DETEKTOR_POKRETA");
            Map(x => x.Osetljivost, "OSETLJIVOST");
            Map(x => x.DetektorToplotnogOdraza, "DETEKTOR_TOPLOTNOG_ODRAZA");
            Map(x => x.HorRezolucija, "HOR_REZOLUCIJA");
            Map(x => x.VerRezolucija, "VER_REZOLUCIJA");
            Map(x => x.Odrzava, "ODRZAVA");
            Map(x => x.Instaliran, "INSTALIRAN");            
        }
    }
}

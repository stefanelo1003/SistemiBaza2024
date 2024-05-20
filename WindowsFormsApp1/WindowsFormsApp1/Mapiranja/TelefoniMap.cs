using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Mapiranja
{
    public class TelefoniMap: ClassMap<Telefoni>
    { 
        public TelefoniMap()
        {
            Table("BROJEVI_TELEFONA_REG_CNT");

            CompositeId()
                .KeyReference(x => x.RegCentar, "ID_REG_CNT")
                .KeyProperty(x => x.Telefon, "BROJ_TELEFONA");
        }
    }
}

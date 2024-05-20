using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entiteti;

namespace WindowsFormsApp1.Mapiranja
{
    public class ObjektiTelefoniMap : ClassMap<ObjektiTelefoni>
    {
        public ObjektiTelefoniMap()
        {
            Table("BROJEVI_TELEFONA_OBJ");

            CompositeId()
                .KeyReference(x => x.Objekat, "ID_OBJEKTA")
                .KeyProperty(x => x.Telefon, "KONTAKT_TELEFON");
        }
    }
}

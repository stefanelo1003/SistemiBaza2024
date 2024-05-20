using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Mapiranja
{
    public class IstorijaSmenaMap : ClassMap<IstorijaSmena>
    {
        public IstorijaSmenaMap()
        {
            Table("ISTORIJA_SMENE");

            CompositeId()
                .KeyReference(x => x.id, "ID_ISTORIJE")
                .KeyProperty(x => x.Smene, "ID_SMENE");   
            

        }
    }
}

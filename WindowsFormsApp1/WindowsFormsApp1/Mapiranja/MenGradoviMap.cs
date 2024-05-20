using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entiteti;

namespace WindowsFormsApp1.Mapiranja
{
    public class MenGradoviMap : ClassMap<MenGradovi>
    {
        public MenGradoviMap() 
        {
            Table("GRADOVI_MENADZER");

            CompositeId()
                .KeyReference(x => x.Menadzer, "MATICNI_BROJ_MENADZERA") // mozda property umesto reference
                .KeyProperty(x => x.Grad, "GRAD");
        }
    }
}

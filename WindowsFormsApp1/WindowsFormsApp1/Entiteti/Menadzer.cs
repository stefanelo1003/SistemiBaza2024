namespace WindowsFormsApp1.Entiteti
{
    public class Menadzer
    {
        public virtual long MaticniBroj { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual char? Pol { get; set; }
        public virtual IList<RegionalniCentar> RegionalniCentri { get; set; }
        public virtual IList<MenGradovi> Gradovi { get; set; }

        public Menadzer()
        {
            RegionalniCentri = new List<RegionalniCentar>();
            Gradovi = new List<MenGradovi>();
        }
    }
}

namespace WindowsFormsApp1.Entiteti
{
    public class RegionalniCentar
    {
        public virtual int Id { get; protected set; }
        public virtual string Adresa { get; set; }
        public virtual Menadzer AngazovanMenadzer { get; set; }
        public virtual IList<Telefoni> BrojTelefona { get; set; }
        public virtual IList<Gradovi> ImeGrada { get; set; }
        public virtual IList<Vozilo> Vozila { get; set; }   
        public RegionalniCentar()
        {
            Vozila = new List<Vozilo>();
            BrojTelefona = new List<Telefoni>();
            ImeGrada = new List<Gradovi>(); 
        }
    }
}

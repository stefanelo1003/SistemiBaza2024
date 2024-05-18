namespace WindowsFormsApp1.Entiteti
{
    public class Ekipa
    {
        public virtual int RedniBroj { get; protected set; }
        public virtual FizickoObezbedjenje Vodja { get; set; }
        public virtual IList<FizickoObezbedjenje> Clanovi { get; set; }
        public virtual Duzi DuziVozilo { get; set; }
        public virtual IList<Smena> Smena { get; set; }   
        public virtual IList<Intervencija> Intervencija { get; set;}
        public Ekipa()
        {
            Clanovi = new List<FizickoObezbedjenje>();
            DuziVozilo = new Duzi();
            Smena = new List<Smena>();
            Intervencija = new List<Intervencija>();    
        }


        
    }
}

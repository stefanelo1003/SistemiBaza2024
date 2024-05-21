﻿namespace WindowsFormsApp1.Entiteti
{
    public class Ekipa
    {
        public virtual int ID { get; set; }
        public virtual int RedniBroj { get; protected set; }
        public virtual FizickoObezbedjenje Vodja { get; set; }
        public virtual IList<FizickoObezbedjenje> Clanovi { get; set; }
        public virtual Smena Smena { get; set; }   
        public virtual IList<Intervencija> Intervencija { get; set;}
        public virtual Vozilo DuziVozilo { get; set; }
        public Ekipa()
        {
            Clanovi = new List<FizickoObezbedjenje>();
            Intervencija = new List<Intervencija>();    
        }


        
    }
}

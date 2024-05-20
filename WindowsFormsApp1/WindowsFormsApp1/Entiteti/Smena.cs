namespace WindowsFormsApp1.Entiteti
{
    public class Smena
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime VremePocetka { get; set; }
        public virtual DateTime VremeKraja { get; set; }
        public virtual Ekipa EkipaZaSmenu { get; set; }
        public virtual Objekat ObjekatZaSmenu { get; set; }

        //public virtual IstorijaSmena Istorija { get; set; } mislim da ne treba

        public Smena()
        {

        }
    }
}

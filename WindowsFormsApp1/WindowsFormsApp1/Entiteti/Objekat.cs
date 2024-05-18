namespace WindowsFormsApp1.Entiteti
{
    public class Objekat
    {
        public virtual int Id { get; protected set; }
        public virtual string Adresa { get; set; }
        public virtual string? TipObjekta { get; set; }
        public virtual int? Povrsina { get; set; }
        public virtual IList<ObjektiTelefoni> KontaktTelefoni { get; set; }
        public virtual IList<Smena> ObuhvataSmenu { get; set; }
        
        public virtual IList<Intervencija> Intervencije { get; set; }
        public virtual IList<Instaliran> InstaliraniSistemi { get; set; }
        public Objekat()
        {
            KontaktTelefoni = new List<ObjektiTelefoni>();
            ObuhvataSmenu = new List<Smena>();
            Intervencije = new List<Intervencija>();
            InstaliraniSistemi = new List<Instaliran>();
        }   
        
    }
}

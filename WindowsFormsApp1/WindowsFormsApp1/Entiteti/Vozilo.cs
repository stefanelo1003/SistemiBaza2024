namespace WindowsFormsApp1.Entiteti
{
    public class Vozilo
    {
        public virtual string RegistarskaOznaka { get; protected set; }
        public virtual string? Boja { get; set; }
        public virtual string? Tip { get; set; }
        public virtual string? Model { get; set; }
        public virtual string? Proizvodjac { get; set; }
        public virtual int? BrojRegCentara { get; set; }
        public virtual RegionalniCentar RegistrovanNaRegCentar { get; set; }
        public virtual Duzi EkipaKojaGaDuzi {  get; set; }
        public Vozilo()
        {

        }
    }
}

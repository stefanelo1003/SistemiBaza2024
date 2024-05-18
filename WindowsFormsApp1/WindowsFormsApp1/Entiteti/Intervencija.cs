namespace WindowsFormsApp1.Entiteti
{
    public class Intervencija
    {
        public virtual IntervencijaId Id { get; protected set; }
        public virtual DateTime DatumVreme { get; set; }
        public virtual string Tip { get; set; }   

        public virtual Objekat Objekat { get; set; }
        public Intervencija()
        {
            Id = new IntervencijaId();
        }

    }
}

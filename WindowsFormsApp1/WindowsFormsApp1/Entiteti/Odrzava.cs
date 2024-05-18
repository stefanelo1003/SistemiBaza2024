namespace WindowsFormsApp1.Entiteti
{
    public class Odrzava
    {
        public virtual OdrzavaId Id { get; protected set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }
        public Odrzava()
        {
            Id = new OdrzavaId();
        }
    }
}

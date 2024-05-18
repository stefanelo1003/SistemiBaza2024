namespace WindowsFormsApp1.Entiteti
{
    public class Duzi
    {
        public virtual DuziId Id { get; set; }  
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }

        public Duzi()
        {
            Id = new DuziId();
        }
    }
}

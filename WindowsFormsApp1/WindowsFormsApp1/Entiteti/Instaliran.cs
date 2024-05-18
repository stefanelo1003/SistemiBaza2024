namespace WindowsFormsApp1.Entiteti
{
    public class Instaliran
    {
        public virtual InstaliranId Id { get; protected set; }  
        public virtual DateTime DatumInstalacije { get; set; }
        public Instaliran()
        {
            Id = new InstaliranId();
        }   
    }
}

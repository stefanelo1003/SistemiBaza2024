namespace WindowsFormsApp1.Entiteti
{
    public class IstorijaSmena
    {
        public virtual int id { get; protected set; }  
        public virtual IList<Smena> Smene { get; set; }

        public IstorijaSmena()
        {
            Smene = new List<Smena>();
        }
    }
}

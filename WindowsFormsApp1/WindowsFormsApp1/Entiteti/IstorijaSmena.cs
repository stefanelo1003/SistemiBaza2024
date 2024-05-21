namespace WindowsFormsApp1.Entiteti
{
    public class IstorijaSmena
    {
        public virtual int IdIstorije { get; protected set; }
       // public virtual IstorijaSmenaId id { get; protected set; }  
        public virtual IList<Smena> Smene { get; set; }

        public IstorijaSmena()
        {
            Smene = new List<Smena>();
        }
    }
}

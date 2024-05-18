namespace WindowsFormsApp1.Entiteti
{
    public class ObjektiTelefoni
    {
        public virtual Objekat Objekat { get; set; }    
        public virtual string Telefon { get; set; }
        public ObjektiTelefoni()
        {

        }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if(obj.GetType() != typeof(ObjektiTelefoni))
                return false;
            ObjektiTelefoni recievedObject = (ObjektiTelefoni)obj;
            if ((Objekat.Id == recievedObject.Objekat.Id) &&
                (Telefon == recievedObject.Telefon))
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

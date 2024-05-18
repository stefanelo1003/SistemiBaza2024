namespace WindowsFormsApp1.Entiteti
{
    public class IntervencijaId
    {
        public virtual Ekipa Ekipa { get; set; }
        public virtual int Id { get; set; } 

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(IntervencijaId))
                return false;
            IntervencijaId recievedObject = (IntervencijaId)obj;
            if(Ekipa.RedniBroj == recievedObject.Ekipa.RedniBroj && Id == recievedObject.Id)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

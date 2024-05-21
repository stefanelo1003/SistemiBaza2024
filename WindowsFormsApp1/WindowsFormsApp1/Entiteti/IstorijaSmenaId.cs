/*
namespace WindowsFormsApp1.Entiteti
{
    public class IstorijaSmenaId
    {
        public virtual int id { get; set; }
        public virtual Smena Smena { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(IstorijaSmenaId))
                return false;
            IstorijaSmenaId recievedObject = (IstorijaSmenaId)obj;
            if (Smena.Id == recievedObject.Smena.Id && id == recievedObject.id)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}*/

namespace WindowsFormsApp1.Entiteti
{
    public class InstaliranId
    {
        public virtual Objekat Objekat { get; set; }
        public virtual AlarmniSistem AlarmniSistem { get; set; }
        
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(InstaliranId))
                return false;
            InstaliranId recievedObject = (InstaliranId)obj;
            if(Objekat.Id == recievedObject.Objekat.Id && AlarmniSistem.Id == recievedObject.AlarmniSistem.Id)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

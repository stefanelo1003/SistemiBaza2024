namespace WindowsFormsApp1.Entiteti
{
    public class OdrzavaId
    {
        public virtual AlarmniSistem AlarmniSistem { get; set; }
        public virtual TehnickoLice TehnickoLice { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(OdrzavaId)) return false;   
            OdrzavaId recievedObject = (OdrzavaId)obj;
            if ((AlarmniSistem.Id == recievedObject.AlarmniSistem.Id) && (TehnickoLice.MaticniBroj == recievedObject.TehnickoLice.MaticniBroj)) return true;
            return false;   
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

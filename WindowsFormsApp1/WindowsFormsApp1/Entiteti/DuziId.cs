namespace WindowsFormsApp1.Entiteti
{
    public class DuziId
    {
        public virtual Vozilo DuziVozilo { get; set; }
        public virtual Ekipa DuziEkipa { get; set; }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(DuziId))
                return false;

            DuziId recievedObject = (DuziId)obj;

            if ((DuziVozilo.RegistarskaOznaka == recievedObject.DuziVozilo.RegistarskaOznaka) &&
                (DuziEkipa.RedniBroj == recievedObject.DuziEkipa.RedniBroj))
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

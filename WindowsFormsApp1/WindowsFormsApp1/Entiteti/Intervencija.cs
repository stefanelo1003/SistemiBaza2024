﻿namespace WindowsFormsApp1.Entiteti
{
    public class Intervencija
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime DatumVreme { get; set; }
        public virtual string Tip { get; set; }
        public virtual Objekat Objekat { get; set; }
        public virtual Ekipa Ekipa { get; set; }
        public Intervencija()
        {
        }

    }
}

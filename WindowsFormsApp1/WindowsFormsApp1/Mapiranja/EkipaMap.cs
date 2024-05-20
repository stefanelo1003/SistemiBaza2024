namespace WindowsFormsApp1.Mapiranje
{
    public class EkipaMap : ClassMap<Ekipa>
    {
        public EkipaMap()
        {
            Table("EKIPA");

            Id(x => x.RedniBroj, "REDNI_BROJ").GeneratedBy.TriggerIdentity(); // primarni kljuc

            References(x => x.Vodja).Column("MATICNI_BROJ_VODJE").LazyLoad(); // 1:1 veza JE_VODJA

            HasMany(x => x.Clanovi).KeyColumn("MATICNI_BROJ").Cascade.All().Inverse(); // 1:N EKIPA - FIZICKO_OBEZBEDJENJE

            References(x => x.Smena).Column("REDNI_BR0J_EKIPE").LazyLoad(); // 1:1 EKIPA - SMENA

            HasMany(x => x.Intervencija).KeyColumn("ID_EKIPE").LazyLoad().Cascade.All().Inverse(); // M:N veza Intervencija

            References(x => x.DuziVozilo).Column("REDNI_BR0J_EKIPE").LazyLoad(); // 1:1 EKIPA - VOZILO











        }
    }
}

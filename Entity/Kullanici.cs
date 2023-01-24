namespace Entity
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
        public ICollection<Ogun> Ogunler { get; set; }
    }
}

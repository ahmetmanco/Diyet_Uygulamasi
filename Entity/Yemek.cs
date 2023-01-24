namespace Entity
{
    public class Yemek
    {
        public int YemekId { get; set; }
        public int KategoriId { get; set; }
        public string YemekAdi { get; set; }
        public decimal Kalori { get; set; }
        public string? Fotograf { get; set; }


        //public int OgunId { get; set; }

        // Nav Props
        public Kategori Kategori { get; set; }
        public ICollection<YemekOgun> Ogun { get; set; }
    }
}

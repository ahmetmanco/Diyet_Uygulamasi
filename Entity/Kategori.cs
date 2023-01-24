namespace Entity
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }

        // Nav Props
        public List<Yemek> Yemekler { get; set; }
    }
}

using Entity.Enum;

namespace Entity
{
    public class Ogun
    {
        public int OgunId { get; set; }
        public int KullaniciId { get; set; }
        public DateTime Tarih { get; set; }
        public int OgunNo { get; set; }
        public OgunTipleri OgunTipi { get; set; }

        // Nav props
        public Kullanici Kullanici { get; set; }
        public ICollection<YemekOgun> Yemek { get; set; }

    }
}

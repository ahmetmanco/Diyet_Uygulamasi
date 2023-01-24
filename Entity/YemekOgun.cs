
namespace Entity
{
    public class YemekOgun
    {
        public int YemekOgunId { get; set; }
        public int YemekId { get; set; }
        public int OgunId { get; set; }
        public decimal Porsiyon { get; set; }
        public Yemek Yemek { get; set; }
        public Ogun Ogun { get; set; }
    }
}

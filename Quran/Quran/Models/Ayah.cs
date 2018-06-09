namespace Quran.Models
{
    public class Ayah
    {
        public int number { get; set; }
        public string text { get; set; }
        public int numberInSurah { get; set; }
        public int juz { get; set; }
        public int manzil { get; set; }
        public int page { get; set; }
        public int ruku { get; set; }
        public int hizbQuarter { get; set; }
        public object sajda { get; set; }
    }
}

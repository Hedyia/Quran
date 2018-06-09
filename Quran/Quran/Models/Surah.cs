
namespace Quran.Models
{
    using System.Collections.Generic;

    public class Surah
    {
        public int number { get; set; }
        public string name { get; set; }
        public string englishName { get; set; }
        public string englishNameTranslation { get; set; }
        public string revelationType { get; set; }
        public List<Ayah> ayahs { get; set; }
    }
}

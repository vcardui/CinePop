using CsvHelper.Configuration.Attributes;

namespace CinePop_0._0._3
{
    public class filmsModel
    {
        public string filmID { get; set; }
        public string filmTitle { get; set; }
        public string synopsis { get; set; }
        public string rating { get; set; }
        public int length { get; set; }
        public string genere { get; set; }
        public string poster { get; set; }
    }
}

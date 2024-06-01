using CsvHelper.Configuration.Attributes;

namespace CinePop_0._0._3
{
    public class showTimesModel
    {
        public string filmID { get; set; }
        public string roomID { get; set; }
        public DateTime screeningDay { get; set; }
        public int purchasedSeats { get; set; }
        public int availableSeats { get; set; }
    }
}

using CsvHelper;
using System.Diagnostics;
using System.Globalization;

namespace CinePop_0._0._3
{
    public partial class CinePop : Form
    {
        // public string filmsFile = @"C:\Users\vboxuser\Documents\Code_local\C#_proyects\CinePop_0.0.3\CinePop_0.0.3\Properties\cinePopMedia\DataBase\films.csv";
        // public string showTimesFile = @"C:\Users\vboxuser\Documents\Code_local\C#_proyects\CinePop_0.0.3\CinePop_0.0.3\Properties\cinePopMedia\DataBase\showTimes.csv";
        public string filmsFile = @"..\..\..\..\films.csv";
        public string showTimesFile = @"..\..\..\..\showTimes.csv";

        public string currentFilm = "";
        public int availiableSeats = 0;
        public int purchasedSeats = 0;
        public CinePop()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void CinePop_Load(object sender, EventArgs e)
        {
            using var reader = new StreamReader(filmsFile);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<filmsModel>();

            List<filmsModel> filmsCSVList = new();

            foreach (var row in records)
            {
                Debug.WriteLine(row.filmID + ": " + row.filmTitle);
                filmsComboBox.Items.Add(row.filmTitle);
            }
            filmsComboBox.SelectedIndex = 0;
        }

        private void updateShowTimesComboBox(string filmID)
        {
            using var readerShowTimes = new StreamReader(showTimesFile);
            using var csvShowTimes = new CsvReader(readerShowTimes, CultureInfo.InvariantCulture);
            var recordsShowTimes = csvShowTimes.GetRecords<showTimesModel>();

            showTimesComboBox.Items.Clear();

            foreach (var row in recordsShowTimes)
            {
                if (filmID == row.filmID)
                    showTimesComboBox.Items.Add(row.screeningDay);
            }
            showTimesComboBox.SelectedIndex = 0;
            purchasedSeats = 0;
            SelectedTicketsLabel.Text = purchasedSeats.ToString();
        }

        private void updatePurchasedSeatsCSV(ref int purchasedSeats, string filmID) {
            List<showTimesModel> updatedShowTimeCSV = new();

            using (var readerShowTimes = new StreamReader(showTimesFile))
            {
                using var csvShowTimes = new CsvReader(readerShowTimes, CultureInfo.InvariantCulture);
                var recordsShowTimes = csvShowTimes.GetRecords<showTimesModel>();

                foreach (var row in recordsShowTimes)
                {
                    if (filmID == row.filmID)
                    {
                        row.purchasedSeats = (row.purchasedSeats - purchasedSeats);
                    }

                    updatedShowTimeCSV.Add(row);
                }

            }

            toCSV(updatedShowTimeCSV);
            purchasedSeats = 0;
            SelectedTicketsLabel.Text = purchasedSeats.ToString();
        }

        private void toCSV(List<showTimesModel> updatedShowTimeCSV) {

            using (var writer = new StreamWriter(showTimesFile)) {
                using var csvOut = new CsvWriter(writer, CultureInfo.InvariantCulture);

                csvOut.WriteRecords(updatedShowTimeCSV);
                writer.Flush();
            }
            Debug.WriteLine("showTimesFile actualizado exitosamente");
        }

        private void filmsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using var readerFilms = new StreamReader(filmsFile);
            using var csvFilms = new CsvReader(readerFilms, CultureInfo.InvariantCulture);
            var recordsFilms = csvFilms.GetRecords<filmsModel>();

            foreach (var row in recordsFilms)
            {
                if (filmsComboBox.Text == row.filmTitle)
                {
                    currentFilm = row.filmID;
                    updateShowTimesComboBox(row.filmID);

                    MovieTitleLabel.Text = row.filmTitle;
                    SynopsisTextLabel.Text = row.synopsis;
                    RatingTextLabel.Text = row.rating;
                    LengthTextLabel.Text = row.length + " mins";
                    GenereTextLabel.Text = row.genere;
                    switch (row.filmID)
                    {
                        case "F00001":
                            PosterHolder.Image = Properties.Resources.F00001;
                            break;
                        case "F00002":
                            PosterHolder.Image = Properties.Resources.F00002;
                            break;
                        case "F00003":
                            PosterHolder.Image = Properties.Resources.F00003;
                            break;
                        case "F00004":
                            PosterHolder.Image = Properties.Resources.F00004;
                            break;
                        case "F00005":
                            PosterHolder.Image = Properties.Resources.F00005;
                            break;
                    }

                }
            }


        }

        private void AddTicketButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("AddTicketButton_Click -> purchasedSeats: " + purchasedSeats);
            Debug.WriteLine("AddTicketButton_Click -> availiableSeats: " + availiableSeats);

            if (purchasedSeats < availiableSeats)
            {
                purchasedSeats++;
                SelectedTicketsLabel.Text = (purchasedSeats).ToString();
            }
            else if (purchasedSeats >= availiableSeats) {
                MessageBox.Show("Límite de asientos disponibles alcanzado");
            }
        }

        private void MinusTicketButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("MinusTicketButton_Click -> purchasedSeats: " + purchasedSeats);
            Debug.WriteLine("MinusTicketButton_Click -> availiableSeats: " + availiableSeats);
            if (purchasedSeats >= 1)
            {
                purchasedSeats--;
                SelectedTicketsLabel.Text = (purchasedSeats).ToString();
            }
            else { MessageBox.Show("No puede comprar menos de 1 boleto"); }
        }

        private void showTimesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using var readerShowTimes = new StreamReader(showTimesFile);
            using var csvShowTimes = new CsvReader(readerShowTimes, CultureInfo.InvariantCulture);
            var recordsShowTimes = csvShowTimes.GetRecords<showTimesModel>();

            availiableSeats = 0;
            foreach (var row in recordsShowTimes)
            {
                if (currentFilm == row.filmID)
                    Debug.WriteLine("availiableSeats = " + (row.availableSeats - row.purchasedSeats));
                    availiableSeats = row.availableSeats - row.purchasedSeats;
            }
        }


        private void BuyTicketsButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("BuyTicketsButton_Click -> purchasedSeats: " + purchasedSeats);
            if (purchasedSeats > 0)
            {
                MessageBox.Show("Gracias por su compra\nBoletos comprados: " + purchasedSeats);
                updatePurchasedSeatsCSV(ref purchasedSeats, currentFilm);
                purchasedSeats = 0;
                SelectedTicketsLabel.Text = purchasedSeats.ToString();
            }
            else {
                MessageBox.Show("Ingrese una cantidad válida de boletos a comprar");
            }
            
        }
    }

}

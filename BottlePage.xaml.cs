using WineTastingApp.Models;

namespace WineTastingApp
{ 
    public partial class BottlePage : ContentPage
    {
        private Tasting _tasting;

        public BottlePage(Tasting tasting)
        {
            InitializeComponent();
            _tasting = tasting;

            // Bind the Bottle property to the page
            if (_tasting.Bottle == null)
            {
                _tasting.Bottle = new WineBottle
                {
                    Winery = new Winery(),
                    Appellation = new Appellation()
                };
            }

            // Pre-fill fields if data exists
            WineNameEntry.Text = _tasting.Bottle.Name;
            WineryEntry.Text = _tasting.Bottle.Winery.Name;
            TypeEntry.Text = _tasting.Bottle.Type;
            Grape.Text = ""; // Placeholder untill future update
            VintagePicker.Date = new DateTime(_tasting.Bottle.Vintage.Year, 1, 1);
            CountryEntry.Text = _tasting.Bottle.Appellation?.Region.Country.Name;
            RegionEntry.Text = _tasting.Bottle.Appellation?.Region.Name;
            AppelationEntry.Text = _tasting.Bottle.Appellation?.Name;
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            _tasting.Bottle.Name = WineNameEntry.Text;
            _tasting.Bottle.Winery.Name = WineryEntry.Text;
            _tasting.Bottle.Type = TypeEntry.Text;
            _tasting.Bottle.Grapes = Grape.Text.Split(',')
                                               .Select(g => new Grape { Name = g.Trim() })
                                               .ToList();
            _tasting.Bottle.Vintage = DateOnly.FromDateTime(VintagePicker.Date);
            _tasting.Bottle.Appellation.Region.Country.Name = CountryEntry.Text;
            _tasting.Bottle.Appellation.Region.Name = RegionEntry.Text;
            _tasting.Bottle.Appellation.Name = AppelationEntry.Text;

            // Navigate back to MainPage
            Navigation.PopAsync();
        }
    }
}
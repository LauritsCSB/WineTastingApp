using WineTastingApp.Models;
using WineTastingApp.Services;

namespace WineTastingApp
{
    public partial class MainPage : ContentPage
    {
        private Tasting _tasting;
        public MainPage()
        {
            InitializeComponent();
            _tasting = new Tasting();
        }

        // Handle date selection
        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            _tasting.Date = e.NewDate;
        }
        // Handle occasion entry
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            _tasting.Occasion = e.NewTextValue;
        }

        // Handle navigation buttons
        private async void OnBottlePageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BottlePage(_tasting));
        }

        private async void OnVisualPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VisualPage(_tasting));
        }
        private async void OnSmellPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SmellPage(_tasting));
        }
        private async void OnPalatePageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PalatePage(_tasting));
        }

        // Handle save button
        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            try
            {
                _tasting.Validate();

                await Task.Run(() => DataService.SaveTastingToJson(_tasting));

                await DisplayAlert("Success", "Tasting saved successfully.", "OK");
            }
            catch (ArgumentException ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "An unexpected error occurred: " + ex.Message, "OK");
            }
        }


        //Handle view saved data button
        private async void OnViewSavedDataClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewSavedDataPage());
        }
    }
}

using WineTastingApp.Models;

namespace WineTastingApp
{
    public partial class VisualPage : ContentPage
    {
        private Tasting _tasting;
        public VisualPage(Tasting tasting)
        {
            InitializeComponent();
            _tasting = tasting;

            // Pre-fill fields if data exists
            ClarityPicker.SelectedIndex = (int)_tasting.VisualNotes.Clarity;
            IntensityPicker.SelectedIndex = (int)_tasting.VisualNotes.Intensity;
            ColorPicker.SelectedIndex = (int)_tasting.VisualNotes.Color;

        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            _tasting.VisualNotes.Clarity = (VisualNotes.ClarityEnum)ClarityPicker.SelectedIndex;
            _tasting.VisualNotes.Intensity = (VisualNotes.IntensityEnum)IntensityPicker.SelectedIndex;
            _tasting.VisualNotes.Color = (VisualNotes.ColorEnum)ColorPicker.SelectedIndex;

            Navigation.PopAsync();
        }
    }
}
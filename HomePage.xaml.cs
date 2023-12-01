using Microcharts;
using SkiaSharp.Views.Maui;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace SolarCarCoreUI;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        Chart.Chart = new RadialGaugeChart
        {
            LabelTextSize = 24,
            Entries = new List<ChartEntry>
            {
                new ChartEntry(10)
                {
                    Color = Colors.Red.ToSKColor(),
                    Label = "Entry 1",
                    ValueLabel = "10",
                    ValueLabelColor = Colors.Red.ToSKColor(),
                },
                new ChartEntry(51)
                {
                    Color = Colors.Yellow.ToSKColor(),
                    ValueLabelColor = Colors.Yellow.ToSKColor(),
                    Label = "Entry 2",
                    ValueLabel = "51"
                },
                new ChartEntry(14)
                {
                    Color = Colors.Green.ToSKColor(),
                    ValueLabelColor = Colors.Green.ToSKColor(),
                    Label = "Entry 3",
                    ValueLabel = "14"
                },new ChartEntry(2)
                {
                    Color = Colors.Orange.ToSKColor(),
                    ValueLabelColor = Colors.Orange.ToSKColor(),
                    Label = "Entry 4",
                    ValueLabel = "2"
                }
            }
        };
    }

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        // Navigate to the specified URL in the system browser.
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}
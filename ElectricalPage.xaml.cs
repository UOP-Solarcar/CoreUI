using Microcharts;
using SkiaSharp.Views.Maui;

namespace SolarCarCoreUI;

public partial class ElectricalPage : ContentPage
{
	public ElectricalPage()
	{
		InitializeComponent();
        BatteryChart.Chart = new LineChart
        {
            LabelTextSize = 15,
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
                    ValueLabel = "2",
                    
                }
            },
            BackgroundColor = Colors.Transparent.ToSKColor(),
            LabelOrientation = Orientation.Horizontal,
            ValueLabelOrientation = Orientation.Horizontal,
        };

        MotorChart.Chart = new LineChart
        {
            LabelTextSize = 15,
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
                    ValueLabel = "2",

                }
            },
            BackgroundColor = Colors.Transparent.ToSKColor(),
            LabelOrientation = Orientation.Horizontal,
            ValueLabelOrientation = Orientation.Horizontal,

        };

        SolarChart.Chart = new LineChart
        {
            LabelTextSize = 15,
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
                    ValueLabel = "2",

                }
            },
            BackgroundColor = Colors.Transparent.ToSKColor(),
            LabelOrientation = Orientation.Horizontal,
            ValueLabelOrientation = Orientation.Horizontal,

        };
    }
}
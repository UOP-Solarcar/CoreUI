namespace SolarCarCoreUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                ElectricalBtn.Text = $"Clicked {count} time";
            else
                ElectricalBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(ElectricalBtn.Text);
        }
    }

}

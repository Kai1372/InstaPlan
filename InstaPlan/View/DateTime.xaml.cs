namespace InstaPlan.View;

public partial class DateTime : ContentPage
{
	public DateTime()
	{
		InitializeComponent();
    }
    private async void OnDatePickedButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BookingLandingPage());
    }
}
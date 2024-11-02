
namespace InstaPlan.View;

public partial class LoginRegisterPage : ContentPage
{
	public LoginRegisterPage()
	{
		InitializeComponent();
    }
    private void OnLoginClicked(object sender, EventArgs e)
    {
        string email = loginEmailEntry.Text;
        string password = loginPasswordEntry.Text;

        // Validate email
        if (!IsValidEmail(email))
        {
            DisplayAlert("Error", "Invalid email format", "OK");
            return;
        }
        if (string.IsNullOrWhiteSpace(password))
        {
            DisplayAlert("Error", "Password cannot be empty", "OK");
            return;
        }
        Navigation.PushAsync(new BookingLandingPage());
    }

    private void OnRegisterClicked(object sender, EventArgs e)
    {
        string email = registerEmailEntry.Text;
        string password = registerPasswordEntry.Text;

        // Validate email
        if (!IsValidEmail(email))
        {
            DisplayAlert("Error", "Invalid email format", "OK");
            return;
        }
        if (string.IsNullOrWhiteSpace(password))
        {
            DisplayAlert("Error", "Password cannot be empty", "OK");
            return;
        }

        loginLayout.IsVisible = true;
        registerLayout.IsVisible = false;
        DisplayAlert("Success", "Account Created", "OK");
    }

    private void OnSwitchToRegisterClicked(object sender, EventArgs e)
    {
        loginLayout.IsVisible = false;
        registerLayout.IsVisible = true;
    }

    private void OnSwitchToLoginClicked(object sender, EventArgs e)
    {
        loginLayout.IsVisible = true;
        registerLayout.IsVisible = false;
    }

    private bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
}
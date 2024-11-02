using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Collections;
using System.Windows.Input;

namespace InstaPlan.View;

public partial class Impressum : ContentPage
{
    public ObservableCollection<string> MenuItems { get; set; }


    public Impressum()
    {
        InitializeComponent();

        MenuItems = new ObservableCollection<string>
            {
                "Home Page",
                "Info Page",
                "FAQ",
                "Impressum",
                "Logout"
            };

        dropDownMenu.ItemsSource = MenuItems;
    }

    private void OnNavButtonClick(object sender, EventArgs e)
    {
        // Toggle visibility of the drop-down menu
        dropDownMenu.IsVisible = !dropDownMenu.IsVisible;
    }

    private void OnMenuItemSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is string selectedItem)
        {
            dropDownMenu.IsVisible = false;
        }
    }

    private void OnMenuItemButtonClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.BindingContext is string selectedItem)
        {
            switch (selectedItem)
            {
                case "Home Page":
                    NavigateToOption1();
                    break;
                case "Info Page":
                    NavigateToOption2();
                    break;
                case "FAQ":
                    NavigateToOption3();
                    break;
                case "Impressum":
                    NavigateToOption4();
                    break;
                case "Logout":
                    NavigateToOption5();
                    break;
                default:
                    break;
            }

            dropDownMenu.IsVisible = false;
        }
    }

    private void NavigateToOption1()
    {
        Navigation.PushAsync(new BookingLandingPage());
    }

    private void NavigateToOption2()
    {
        Navigation.PushAsync(new InfoPage());
    }
    private void NavigateToOption3()
    {
        Navigation.PushAsync(new FAQPage());
    }
    private void NavigateToOption4()
    {
        Navigation.PushAsync(new Impressum());
    }
    private void NavigateToOption5()
    {
        Navigation.PushAsync(new LoginRegisterPage());
    }

}
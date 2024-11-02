using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace InstaPlan.View;
public partial class PaymentPage : ContentPage
{

    public ObservableCollection<MenuItem> CombinedMenuItems { get; set; }
    public ObservableCollection<MenuItemf> CombinedMenuItemsf { get; set; }
    public PaymentPage()
    {
        InitializeComponent();

        CombinedMenuItems = new ObservableCollection<MenuItem>
        {
            new MenuItem { Image = "h5.jpg", Hotel = "Perk Central Hotel", Address = "Upper Westside, New York", Stars = "5.0", Reviews = "867", Cost = "62"  }
        };
        CombinedMenuItemsf = new ObservableCollection<MenuItemf>
        {
            new MenuItemf { DTime = "9:39", From = "Zürich", To = "New York", Airline = "Vistra Airlines", Duration = "11h 40m", ATime = "5:19", FCost = "734" }
        };


    BindingContext = this;
    }
    public class MenuItem
    {
        public required string Image { get; set; }
        public required string Hotel { get; set; }
        public required string Address { get; set; }
        public required string Stars { get; set; }
        public required string Reviews { get; set; }
        public required string Cost { get; set; }
    }

    public class MenuItemf
    {
        public required string DTime { get; set; }
        public required string From { get; set; }
        public required string To { get; set; }
        public required string Airline { get; set; }
        public required string Duration { get; set; }
        public required string ATime { get; set; }
        public required string FCost { get; set; }
    }

    private async void OnNavigateButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HotelBook());
    }
    private async void OnCheckoutButtonClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Success", "Hotel & Flights booked", "OK");
    }
}
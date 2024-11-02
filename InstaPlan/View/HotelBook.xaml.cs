using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace InstaPlan.View;
public partial class HotelBook : ContentPage {

    public ObservableCollection<MenuItem> CombinedMenuItems { get; set; }
    public HotelBook()
        {
            InitializeComponent();

        CombinedMenuItems = new ObservableCollection<MenuItem>
        {
            new MenuItem { Image = "h1.jpg", Hotel = "Schwarz Hotel", Address = "757 Market street, New York", Stars = "3.9", Reviews = "123", Cost = "23"  },
            new MenuItem { Image = "h2.jpg", Hotel = "Big Apple Hotel", Address = "5th Avenue, New York", Stars = "4.4", Reviews = "444", Cost = "44"  },
            new MenuItem { Image = "h3.jpg", Hotel = "Manhattan Hotel", Address = "21312 Downtown, New York", Stars = "5.0", Reviews = "93", Cost = "123"  },
            new MenuItem { Image = "h4.jpg", Hotel = "Brooklyn Hotel", Address = "Somewhere in New York", Stars = "4.2", Reviews = "423", Cost = "32"  },
            new MenuItem { Image = "h5.jpg", Hotel = "Perk Central Hotel", Address = "Upper Westside, New York", Stars = "5.0", Reviews = "867", Cost = "62"  }
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


    private async void OnNavigateButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlightBook());
    }
    private async void OnPayButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaymentPage());
    }
    
}
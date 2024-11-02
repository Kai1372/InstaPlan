using System.Collections.ObjectModel;

namespace InstaPlan.View;

public partial class FlightBook : ContentPage
{
    public ObservableCollection<MenuItemf> CombinedMenuItems { get; set; }
    public FlightBook()
	{
		InitializeComponent();
        CombinedMenuItems = new ObservableCollection<MenuItemf>
        {
            new MenuItemf { DTime = "5:00", From = "Zürich", To = "New York", Airline = "Vistra Airlines", Duration = "12h 48m", ATime = "23:48", Cost = "893"  },
            new MenuItemf { DTime = "6:30", From = "Zürich", To = "New York", Airline = "Index Airlines", Duration = "12h 20m", ATime = "00:50", Cost = "623"  },
            new MenuItemf { DTime = "7:32", From = "Zürich", To = "New York", Airline = "Ethorop Airlines", Duration = "11h 46m", ATime = "3:18", Cost = "1'234"  },
            new MenuItemf { DTime = "9:39", From = "Zürich", To = "New York", Airline = "Vistra Airlines", Duration = "11h 40m", ATime = "5:19", Cost = "734"  },
            new MenuItemf { DTime = "19:21", From = "Zürich", To = "New York", Airline = "Cruztra Airlines", Duration = "12h 55m", ATime = "15:16", Cost = "555"  },
            new MenuItemf { DTime = "23:02", From = "Zürich", To = "New York", Airline = "Vistra Airlines", Duration = "12h 45m", ATime = "19:47", Cost = "554"  }
        };

        BindingContext = this;
    }
    public class MenuItemf
    {
        public required string DTime { get; set; }
        public required string From { get; set; }
        public required string To { get; set; }
        public required string Airline { get; set; }
        public required string Duration { get; set; }
        public required string ATime { get; set; }
        public required string Cost { get; set; }
    }


    private async void OnNavigateButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HotelBook());
    }
    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BookingLandingPage());
    }
}
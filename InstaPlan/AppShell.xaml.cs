using InstaPlan.View;

namespace InstaPlan
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Impressum", typeof(Impressum));
            Routing.RegisterRoute("InfoPage", typeof(InfoPage));
            Routing.RegisterRoute("FAQPage", typeof(FAQPage));

            Routing.RegisterRoute("BookingLandingPage", typeof(BookingLandingPage));

            Routing.RegisterRoute("DateTime", typeof(View.DateTime));

            Routing.RegisterRoute("FlightBook", typeof(FlightBook));
            Routing.RegisterRoute("HotelBook", typeof(HotelBook));

            Routing.RegisterRoute("PaymentPage", typeof(PaymentPage));
        }
    }
}

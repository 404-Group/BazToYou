namespace BazToYou
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(AvailableOrdersPage), typeof(AvailableOrdersPage));
            Routing.RegisterRoute(nameof(OrderPage), typeof(OrderPage));
            InitializeComponent();
        }
    }
}

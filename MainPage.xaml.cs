namespace BazToYou
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void ProfileTap(object sender, EventArgs args)
        {
            await Shell.Current.GoToAsync(nameof(ProfilePage));
        }
        async void AvailableTap(object sender, EventArgs args)
        {
            await Shell.Current.GoToAsync(nameof(AvailableOrdersPage));
        }
        async void OrderTap(object sender, EventArgs args)
        {
            await Shell.Current.GoToAsync(nameof(OrderPage));
        }
    }
}
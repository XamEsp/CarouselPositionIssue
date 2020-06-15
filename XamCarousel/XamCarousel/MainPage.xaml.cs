using System.ComponentModel;

namespace XamCarousel
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        protected override void OnAppearing()
        {
            if (BindingContext is MainViewModel vm)
            {
                vm.Init();
            }

            base.OnAppearing();
        }
    }
}

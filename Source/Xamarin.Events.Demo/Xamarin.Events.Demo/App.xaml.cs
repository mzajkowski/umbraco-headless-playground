using Xamarin.Events.Demo.Services;
using Xamarin.Events.Demo.Views;
using Xamarin.Forms;

namespace Xamarin.Events.Demo
{
    public enum DataSource
    {
        HeadRest,
        GraphQL,
        Headless
    }

    public partial class App : Application
    {
        public static string HeadRestBackendUrl = "https://azapp-headlesstestsite-dev.azurewebsites.net/";
        public static string HeadlessProjectAlias = "marcin-headless-uk-fest";

        internal DataSource CurrentDataSource =
            //DataSource.HeadRest;
            //DataSource.GraphQL;
            DataSource.Headless;

        public App()
        {
            InitializeComponent();

            if (CurrentDataSource == DataSource.HeadRest)
            {
                DependencyService.Register<HeadRestDataStore>();
            }
            else if (CurrentDataSource == DataSource.GraphQL) { }
            else if (CurrentDataSource == DataSource.Headless)
            {
                DependencyService.Register<HeadlessDataStore>();
            }
            else
            {
                DependencyService.Register<MockDataStore>();
            }

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

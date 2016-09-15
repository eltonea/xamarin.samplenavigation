namespace OOH
{
    using Xamarin.Forms;

    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new Views.PrincipalPage()); //Set a new Main Page
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

namespace OOH.Views
{
    using Xamarin.Forms;

    public partial class PrincipalPage : ContentPage
    {
        public PrincipalPage()
        {
            InitializeComponent();

            this.BindingContext = new ViewModel.LoginVM(); //Set the type of the page xaml
        }
    }
}

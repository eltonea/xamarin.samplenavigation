namespace OOH.ViewModel
{
    using MvvmHelpers;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginVM : BaseViewModel
    {
        #region Attributes
        private ICommand _loginCommand; //Command just reference
        private string _userName; //Username to encapsulate a property
        private string _password; //Password to encapsulate a property
        #endregion

        #region Properties
        public string UserName
        {
            get { return _userName; } //get private value
            set
            {
                SetProperty(ref _userName, value); //Set value and notify changed
            }
        }
        public string Password
        {
            get { return _password; } //get private value
            set
            {
                SetProperty(ref _password, value); //Set value and notify changed
            }
        }
        #endregion

        #region Command
        public ICommand LoginCommand
        {
            get { return _loginCommand ?? new Command(async () => await ExecuteLoginCommand()); } //Create an anonymous method with async/await, to call ExecuteLoginCommand
        }
        #endregion

        #region Method - Business Requirement
        //you can call a method in the other assembly/project
        public async Task ExecuteLoginCommand()
        {
            //call api async
            if (UserName == "henrique" && Password == "123")
                await App.Current.MainPage.Navigation.PushAsync(new Views.WelcomePage(), true); //Navigate to Welcome page with animation
        }
        #endregion
    }
}

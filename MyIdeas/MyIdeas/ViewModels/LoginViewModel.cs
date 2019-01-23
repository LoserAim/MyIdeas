using System.Windows.Input;
using MyIdeas.Helpers;
using MyIdeas.Services;
using Xamarin.Forms;

namespace MyIdeas.ViewModels
{
    public class LoginViewModel
    {
        private readonly ApiServices _apiServices = new ApiServices();

        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var accesstoken = await _apiServices.LoginAsync(Username, Password);

                    Settings.AccessToken = accesstoken;
                });
            }
        }

        public LoginViewModel()
        {
            Username = Settings.Username;
            Password = Settings.Password;
        }
    }
}

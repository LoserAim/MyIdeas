using System.Windows.Input;
using MyIdeas.Helpers;
using MyIdeas.Models;
using MyIdeas.Services;
using Xamarin.Forms;

namespace MyIdeas.ViewModels
{
    public class EditIdeaViewModel
    {
        private readonly ApiServices _apiServices = new ApiServices();
        public Idea Idea { get; set; }

        public ICommand PutCommand
        {
            get
            {
                return new Command(async() =>
                {
                    await _apiServices.PutIdeaAsync(Idea, Settings.AccessToken);
                });
            }
        }
        public ICommand DeleteCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _apiServices.DeleteIdeaAsync(Idea.Id, Settings.AccessToken);
                });
            }
        }
    }
}

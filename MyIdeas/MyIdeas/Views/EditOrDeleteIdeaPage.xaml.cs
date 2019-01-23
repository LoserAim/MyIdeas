using MyIdeas.Models;
using MyIdeas.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyIdeas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditOrDeleteIdeaPage : ContentPage
    {
        public EditOrDeleteIdeaPage(Idea idea)
        {
            InitializeComponent();

            var editIdeaViewModel = new EditIdeaViewModel();
            //var editIdeaViewModel = BindingContext as EditIdeaViewModel;

            editIdeaViewModel.Idea = idea;

            BindingContext = editIdeaViewModel;
        }
    }
}
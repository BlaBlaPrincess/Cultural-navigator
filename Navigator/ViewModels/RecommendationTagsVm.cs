using Navigator.Pages.Main.Recommendation;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Navigator.ViewModels
{
    public class RecommendationTagsVm : BaseViewModel
    {
        private Command _goToRecommendationsCommand;
        public Command GoToRecommendationsCommand =>
            _goToRecommendationsCommand ??= new Command(async (p) =>
            {
                switch((string)p)
                {
                    case "":
                        break;

                    case "books":
                        await Shell.Current.Navigation.PushAsync(new RecommendationPage());
                        break;

                    case "inaccessible":
                        await Shell.Current.Navigation.PushAsync(new InaccessibleRecommendationPage());
                        break;

                    default:
                        throw new ArgumentException();
                }
            });
    }
}

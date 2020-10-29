using ArkhamHorrorDeckManager.Core.ViewModels;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using ArkhamHorrorDeckManager.Core.ViewModels.Main;

namespace ArkhamHorrorDeckManager.Droid.Views.Deck
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.content_frame, true)]
    public class DeckFragment: BaseFragment<DeckViewModel>
    {

        protected override int FragmentLayoutId => Resource.Layout.fragment_deck;
        
    }
}
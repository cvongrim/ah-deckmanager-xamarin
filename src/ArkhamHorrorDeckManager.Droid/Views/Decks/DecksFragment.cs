using Android.OS;
using Android.Views;
using ArkhamHorrorDeckManager.Core.ViewModels.Decks;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using ArkhamHorrorDeckManager.Core.ViewModels.Main;

namespace ArkhamHorrorDeckManager.Droid.Views.Decks
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.content_frame, true)]
    public class DecksFragment: BaseFragment<DecksViewModel>
    {

        protected override int FragmentLayoutId => Resource.Layout.fragment_decks;
    }
}
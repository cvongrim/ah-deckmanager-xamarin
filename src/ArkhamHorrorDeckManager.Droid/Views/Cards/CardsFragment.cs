using ArkhamHorrorDeckManager.Core.ViewModels.Cards;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using ArkhamHorrorDeckManager.Core.ViewModels.Main;

namespace ArkhamHorrorDeckManager.Droid.Views.Cards
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.content_frame, true)]
    public class CardsFragment : BaseFragment<CardsViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.fragment_card;
    }
}
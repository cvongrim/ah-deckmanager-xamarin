using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using ArkhamHorrorDeckManager.Core.Models;
using ArkhamHorrorDeckManager.Core.ViewModels.Decks;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using ArkhamHorrorDeckManager.Core.ViewModels.Main;

namespace ArkhamHorrorDeckManager.Droid.Views.Decks
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.content_frame, true)]
    public class DecksFragment: BaseFragment<DecksViewModel>
    {

        protected override int FragmentLayoutId => Resource.Layout.fragment_decks;

        public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView (inflater, container, savedInstanceState);
            // check the view model has been created
            var recyclerView = view.FindViewById (Resource.Id.my_recycler_view);
           
            // create the adapter
            // set view model
            
            return view;
        }

        public override void OnCreate (Bundle savedInstanceState)
        {
            base.OnCreate (savedInstanceState);
           
        }

        public override void OnViewCreated (View view, Bundle savedInstanceState)
        {
            base.OnViewCreated (view, savedInstanceState);
      
        }
    }
}
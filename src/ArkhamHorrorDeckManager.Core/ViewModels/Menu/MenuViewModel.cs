using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ArkhamHorrorDeckManager.Core.ViewModels.Decks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using ArkhamHorrorDeckManager.Core.ViewModels.Main;
using ArkhamHorrorDeckManager.Core.ViewModels.Settings;

namespace ArkhamHorrorDeckManager.Core.ViewModels.Menu
{
    public class MenuViewModel : BaseViewModel
    {
        readonly IMvxNavigationService _navigationService;

        public IMvxAsyncCommand ShowHomeCommand { get; private set; }
        public IMvxAsyncCommand ShowSettingsCommand { get; private set; }
        public IMvxAsyncCommand ShowDecksCommand { get; private set; }

        public MenuViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            ShowHomeCommand = new MvxAsyncCommand(NavigateToHomeAsync);
            ShowSettingsCommand = new MvxAsyncCommand(NavigateToSettingsAsync);
            ShowDecksCommand = new MvxAsyncCommand(NavigateToDecksAsync);
        }

        private Task NavigateToHomeAsync()
        {
            return _navigationService.Navigate<MainViewModel>();
        }

        private Task NavigateToSettingsAsync()
        {
            return _navigationService.Navigate<SettingsViewModel>();
        }
        
        private Task NavigateToDecksAsync()
        {
            return _navigationService.Navigate<DecksViewModel>();
        }
    }
}

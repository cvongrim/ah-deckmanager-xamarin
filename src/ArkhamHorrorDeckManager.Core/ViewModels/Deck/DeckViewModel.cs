using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ArkhamHorrorDeckManager.Core.Models;
using ArkhamHorrorDeckManager.Core.ViewModels.Cards;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace ArkhamHorrorDeckManager.Core.ViewModels
{
    public class DeckViewModel : MvxViewModel<DeckModel>
    {
        readonly IMvxNavigationService _navigationService;
        public DeckModel deck;
        public ObservableCollection<CardModel> CardsCollection = new ObservableCollection<CardModel> ();
        public IMvxAsyncCommand ShowCardsCommand { get; private set; }
        public override void Prepare (DeckModel deckModel)
        {
            deck = deckModel;
            
            var card = new CardModel {
                Id = "1",
                Name = "Cool Card",
                Image = "image",
                Faction = "Guardian",
                Type = "Asset"
            };
            
            CardsCollection.Add (card);
            CardsCollection.Add (card);
            CardsCollection.Add (card);
            CardsCollection.Add (card);
            CardsCollection.Add (card);
            CardsCollection.Add (card);
        }
        
        public DeckViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            ShowCardsCommand = new MvxAsyncCommand(NavigateToCardsAsync);
        }
        
        private Task NavigateToCardsAsync()
        {
            return _navigationService.Navigate<CardsViewModel>();
        }
    }
}
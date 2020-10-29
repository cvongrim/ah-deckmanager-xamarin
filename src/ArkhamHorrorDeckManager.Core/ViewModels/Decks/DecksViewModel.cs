using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ArkhamHorrorDeckManager.Core.Models;
using ArkhamHorrorDeckManager.Core.ViewModels;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace ArkhamHorrorDeckManager.Core.ViewModels.Decks
{
    public class DecksViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        public IMvxCommand<DeckModel> DeckSelectedCommand { get; private set; }
        public ObservableCollection<DeckModel> DecksCollection = new ObservableCollection<DeckModel> ();
        public DecksViewModel (IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            DeckSelectedCommand = new MvxAsyncCommand<DeckModel>(DeckSelected);
            
            var card = new CardModel {
                Id = "1",
                Name = "Cool Card",
                Image = "image",
                Faction = "Guardian",
                Type = "Asset"
            };


            var cards = new List<CardModel> ();
            
            cards.Add (card);
            cards.Add (card);
            cards.Add (card);
            cards.Add (card);
            cards.Add (card);
            
            DecksCollection.Add (new DeckModel {
                Id = "1",
                Name = "Deck 1",
                Image = "image",
                Investigator = "Roland",
                Type = "Guardian",
                Cards = cards
            });
            
            DecksCollection.Add (new DeckModel {
                Id = "2",
                Name = "Deck 2",
                Image = "image",
                Investigator = "Skids",
                Type = "Rogue",
                Cards = cards
            });
            
            DecksCollection.Add (new DeckModel {
                Id = "3",
                Name = "Deck 3",
                Image = "image",
                Investigator = "Jenny",
                Type = "Rogue",
                Cards = cards
            });
        }
        
       
        private async Task DeckSelected(DeckModel selectedDeck)
        {
            await _navigationService.Navigate<DeckViewModel, DeckModel>(selectedDeck);
        }
    }
}
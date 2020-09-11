using System.Collections.ObjectModel;
using ArkhamHorrorDeckManager.Core.Models;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace ArkhamHorrorDeckManager.Core.ViewModels.Decks
{
    public class DecksViewModel : MvxViewModel
    {
        public ObservableCollection<Deck> DecksCollection => new ObservableCollection<Deck> ();
        public ObservableCollection<TestViewModel> Buttons
            = new ObservableCollection<TestViewModel>();
        public DecksViewModel ()
        {
            
            Buttons.Add(new TestViewModel {
                Title = "Do stuff"
            });

            Buttons.Add(new TestViewModel {
                Title = "Do other stuff"
            });
            
            var deck = new Deck {
                Id = "1",
                Name = "Deck 1",
                Image = "image",
                Investigator = "Roland",
                Type = "Guardian"
            };
            
            DecksCollection.Add (deck);
            
            DecksCollection.Add (new Deck {
                Id = "2",
                Name = "Deck 2",
                Image = "image",
                Investigator = "Skids",
                Type = "Rogue",
            });
            
            DecksCollection.Add (new Deck {
                Id = "3",
                Name = "Deck 3",
                Image = "image",
                Investigator = "Jenny",
                Type = "Rogue",
            });
        }
    }
}
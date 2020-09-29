using MvvmCross.ViewModels;

namespace ArkhamHorrorDeckManager.Core.Models
{
    public class DeckModel : MvxNotifyPropertyChanged
    {
        private string _id;
        private string _name;
        private string _image;
        private string _investigator;
        private string _type;
        
        public string Id
        {
            get => _id;
            set => SetProperty (ref _id, value);
        }
        
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        
        public string Image
        {
            get => _image;
            set => SetProperty(ref _image, value);
        }
        
        public string Investigator
        {
            get => _investigator;
            set => SetProperty(ref _investigator, value);
        }
        
        public string Type
        {
            get => _type;
            set => SetProperty(ref _type, value);
        }
    }
}
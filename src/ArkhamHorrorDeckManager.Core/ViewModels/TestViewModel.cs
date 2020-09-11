using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace ArkhamHorrorDeckManager.Core.ViewModels
{
    public class TestViewModel :MvxNotifyPropertyChanged
    {
        private string _title;
        
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
    }
}
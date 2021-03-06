﻿using MvvmCross.ViewModels;

namespace ArkhamHorrorDeckManager.Core.Models
{
    public class Deck : MvxNotifyPropertyChanged
    {
        string _id;
        string _name;
        string _image;
        string _investigator;
        string _type;
        
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
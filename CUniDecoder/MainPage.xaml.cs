﻿using CUniDecoder.ViewModels;

namespace CUniDecoder
{
    [RegisterTransient]
    public partial class MainPage : ContentPage
    {
        private readonly MainViewModel _vm;
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            _vm=vm;
            BindingContext = _vm;
        }

    }

}

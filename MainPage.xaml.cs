﻿using TODOList.ViewModel;

namespace TODOList
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
        

    }

}

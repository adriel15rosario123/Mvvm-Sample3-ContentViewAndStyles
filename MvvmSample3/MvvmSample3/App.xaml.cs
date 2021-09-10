﻿using MvvmSample3.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmSample3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MyTabbedPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

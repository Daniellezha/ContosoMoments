﻿using ContosoMoments.Views;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ContosoMoments
{
	public class App : Application
	{
        public static MobileServiceClient MobileService = new MobileServiceClient(Constants.ApplicationURL/*, Constants.ApplicationKey*/);

        public App ()
		{
            // The root page of your application
            //MainPage = new ContentPage {
            //	Content = new StackLayout {
            //		VerticalOptions = LayoutOptions.Center,
            //		Children = {
            //			new Label {
            //				XAlign = TextAlignment.Center,
            //				Text = "Welcome to Xamarin Forms!"
            //			}
            //		}
            //	}
            //};
            MainPage = new ImagesList();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
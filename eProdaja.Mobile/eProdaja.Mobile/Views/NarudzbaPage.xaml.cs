﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eProdaja.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eProdaja.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NarudzbaPage : ContentPage
	{
		public NarudzbaPage ()
		{
			InitializeComponent ();
		}

	    protected override void OnAppearing()
	    {
	        base.OnAppearing();
	        var ctx = BindingContext as NarudzbaViewModel;
            ctx.Init();
	    }
	}
}
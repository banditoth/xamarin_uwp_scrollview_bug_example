using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NugetXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();

            Random rand = new Random();

            for (int i = 0; i < 1000; i++)
            {
                TapGestureRecognizer rec = new TapGestureRecognizer()
                {
                    NumberOfTapsRequired = 1,
                    Command = new Command(() => DisplayAlert("Tapped", i.ToString(), "Ok"))
                };

                BoxView view = new BoxView()
                {
                    HorizontalOptions = LayoutOptions.Fill,
                    HeightRequest = rand.Next(0, 350),
                    Color = Color.FromRgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255))
                };

                view.GestureRecognizers.Add(rec);

                container.Children.Add(view);
            }
        }


    }
}

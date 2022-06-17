using System;
using Xamarin.Forms;

namespace ModularbeitM335
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new StackLayout{
                        Padding= new Thickness(30,10,30,0),
                        BackgroundColor = Color.FromHex("#303030"),
                        Children = {
                            new Button {
                                Text = "New Entry",
                                Command = new Command(() =>
                                {
                                    
                                })
                            }
                        }

                    }
                }
            };
        }
    }
}
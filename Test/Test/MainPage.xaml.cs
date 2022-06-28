using System;
using Xamarin.Forms;

namespace ModularbeitM335
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetPeopleAsync();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(name.Text) && !string.IsNullOrWhiteSpace(developer.Text))
                try
                {
                    await App.Database.SavePersonAsync(new Game
                    {
                        name = name.Text,
                        developer = developer.Text,
                        date = date.Date
                    });
                    _ = DisplayAlert("Notification", "the game has successfully been inserted into the database", "ok");
                }
                catch (Exception ex)
                {
                    _ = DisplayAlert("Notification", "an unexpected error has occured: " + ex, "ok");
                }
                finally
                {
                    name.Text = string.Empty;
                    developer.Text = string.Empty;
                    date.Date = DateTime.Now;
                    collectionView.ItemsSource = await App.Database.GetPeopleAsync();
                }
            else
                _ = DisplayAlert("Notification", "Not all necessairy information was given", "ok");
        }
    }
}
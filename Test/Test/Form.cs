using System;
using Xamarin.Forms;

namespace ModularbeitM335
{
    public partial class Form : ContentPage
    {

        public Form()
        {
            Entry name1 = new Entry { Placeholder = "Name" };
            Entry producer1 = new Entry { Placeholder = "Producer" };
            DatePicker datePicker = new DatePicker { Format = "dd/MM/yyyy" };
            Content = new StackLayout
            {
                Children = {
                    new StackLayout{
                        Padding= new Thickness(30,10,30,0),
                        BackgroundColor = Color.FromHex("#303030"),
                        Children = {
                            new Label{Text="Enter the Games Name", FontSize=16},
                            name1,

                            new Label{Text="Enter the Games Producer", FontSize=16},
                            producer1,

                            new Label{Text="Enter the Games Release Date", FontSize=16},
                            datePicker,

                            new Button {
                                Text = "Submit",
                                Command = new Command(() =>
                                {
                                    var name = name1.Text;
                                    var producer = producer1.Text;
                                    var date = datePicker.Date;

                                    newEntry(name, producer, date);
                                })
                            }


                        }

                    }
                }
            };
            for (int i = 0; i < 10; i++)
            {

            }
        }

        public void newEntry(String name, String producer, DateTime date)
        {

        }
    }
}
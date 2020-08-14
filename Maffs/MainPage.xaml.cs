using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Maffs
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            Grid grid = new Grid
            {
                RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(150) },
                new RowDefinition(),
                new RowDefinition { Height = new GridLength(100) }
            },
                ColumnDefinitions =
            {
                new ColumnDefinition(),
                new ColumnDefinition(),
                new ColumnDefinition()
            }
            };

            // Pause button top left
            Button pause_button = new Button
            {
                Text = "Paused",
                BorderColor = Color.Gray,
                BorderWidth = 1,
                TextColor = Color.Gray,
                BackgroundColor = Color.Transparent,
                Margin = 0
            };

            grid.Children.Add(pause_button,0,0);

            pause_button.Clicked += Pause_Clicked;

            // Help button top right
            Button help_button = new Button
            {
                Text = "Help",
                BorderColor = Color.Gray,
                BorderWidth = 1,
                TextColor = Color.Gray,
                BackgroundColor = Color.Transparent,
            };

            grid.Children.Add(help_button, 2,0);

            // Central sum location
            grid.Children.Add(new Label
            {
                Text = "Sum",
                FontSize = 72,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }, 0, 3, 1, 2);


            Button skip_button = new Button
            {
                Text = "Skip Question",
                BorderColor = Color.Gray,
                BorderWidth = 1,
                TextColor = Color.Gray,
                BackgroundColor = Color.Transparent,
                HeightRequest = 50
            };

            skip_button.Clicked += Skip_Clicked;

            grid.Children.Add(skip_button, 0, 3, 2, 3);

            Content = grid;
        }

        private void Skip_Clicked(object sender, System.EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You have skipped {count} questions.";

        }
        
        private void Pause_Clicked(object sender, System.EventArgs e)
        {
            string result = (((Button)sender).Text == ("Paused")) ? "Resumed" : "Paused";
            ((Button)sender).Text = result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

// TODO: it probably makes more sense to make the keypad inputs as objects so that we dont duplicate the properties over and over.
// Only the 1 button works rn but it updates the text field, overwrite not concat.
namespace Maffs
{
    public partial class MainPage : ContentPage
    {
        string answer = "";

        public MainPage()
        {
            Grid grid = new Grid
            {
                RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(50) },
                new RowDefinition{ Height = new GridLength(100) },
                new RowDefinition{ Height = new GridLength(100) },
                new RowDefinition{ Height = new GridLength(100) },
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition()

            },
                ColumnDefinitions =
            {
                new ColumnDefinition(),
                new ColumnDefinition(),
                new ColumnDefinition()
            }
            };

            // Pause button top left
            Button trophy_button = new Button
            {
                Text = "Trophy",
                BorderColor = Color.Gray,
                BorderWidth = 1,
                TextColor = Color.Gray,
                BackgroundColor = Color.Transparent,
                Margin = 0
            };

            grid.Children.Add(trophy_button,0,0);

            // Help button top right
            Button hamburger_button = new Button
            {
                Text = "hamburger",
                BorderColor = Color.Gray,
                BorderWidth = 1,
                TextColor = Color.Gray,
                BackgroundColor = Color.Transparent,
            };

            grid.Children.Add(hamburger_button, 2,0);

            // Central sum location
            grid.Children.Add(new Label
            {
                Text = "91",
                FontSize = 72,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }, 2, 1);

            grid.Children.Add(new Label
            {
                Text = "*",
                FontSize = 72,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }, 1, 2);

            grid.Children.Add(new Label
            {
                Text = "21",
                FontSize = 72,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }, 2, 2);

            Label text_input = new Label
            {
                Text = answer.ToString(),
                FontSize = 72,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            grid.Children.Add(text_input, 1, 3);
            Grid.SetColumnSpan(text_input, 2);

            Button one_button = new Button
            {
                Text = "1",
                BorderColor = Color.Gray,
                BorderWidth = 1,
                TextColor = Color.Gray,
                BackgroundColor = Color.Transparent,
            };

            grid.Children.Add(one_button, 0, 4);

            Button two_button = new Button
            {
                Text = "2",
                BorderColor = Color.Gray,
                BorderWidth = 1,
                TextColor = Color.Gray,
                BackgroundColor = Color.Transparent,
            };

            grid.Children.Add(two_button, 1, 4);

            Button three_button = new Button
            {
                Text = "3",
                BorderColor = Color.Gray,
                BorderWidth = 1,
                TextColor = Color.Gray,
                BackgroundColor = Color.Transparent,
            };

            grid.Children.Add(three_button, 2, 4);

            Button four_button = new Button
            {
                Text = "4",
                BorderColor = Color.Gray,
                BorderWidth = 1,
                TextColor = Color.Gray,
                BackgroundColor = Color.Transparent,
            };

            grid.Children.Add(four_button, 0, 5);

            Button five_button = new Button
            {
                Text = "5",
                BorderColor = Color.Gray,
                BorderWidth = 1,
                TextColor = Color.Gray,
                BackgroundColor = Color.Transparent,
            };

            grid.Children.Add(five_button, 1, 5);

            Button six_button = new Button
            {
                Text = "6",
                BorderColor = Color.Gray,
                BorderWidth = 1,
                TextColor = Color.Gray,
                BackgroundColor = Color.Transparent,
            };

            grid.Children.Add(six_button, 2, 5);

            Button seven_button = new Button
            {
                Text = "7",
                BorderColor = Color.Gray,
                BorderWidth = 1,
                TextColor = Color.Gray,
                BackgroundColor = Color.Transparent,
            };

            grid.Children.Add(seven_button, 0, 6);

            Button eight_button = new Button
            {
                Text = "8",
                BorderColor = Color.Gray,
                BorderWidth = 1,
                TextColor = Color.Gray,
                BackgroundColor = Color.Transparent,
            };

            grid.Children.Add(eight_button, 1, 6);

            Button nine_button = new Button
            {
                Text = "9",
                BorderColor = Color.Gray,
                BorderWidth = 1,
                TextColor = Color.Gray,
                BackgroundColor = Color.Transparent,
            };

            grid.Children.Add(nine_button, 2, 6);

            Button back_button = new Button
            {
                Text = "<-",
                BorderColor = Color.Gray,
                BorderWidth = 1,
                TextColor = Color.Gray,
                BackgroundColor = Color.Transparent,
            };

            grid.Children.Add(back_button, 0, 7);

            one_button.Clicked += (sender, EventArgs) => { Update_text(sender, EventArgs, text_input); };
            back_button.Clicked += (sender, EventArgs) => { Update_text(sender, EventArgs, text_input); };

            Button zero_button = new Button
            {
                Text = "0",
                BorderColor = Color.Gray,
                BorderWidth = 1,
                TextColor = Color.Gray,
                BackgroundColor = Color.Transparent,
            };

            grid.Children.Add(zero_button, 1, 7);

            Button enter_button = new Button
            {
                Text = "->",
                BorderColor = Color.Gray,
                BorderWidth = 1,
                TextColor = Color.Gray,
                BackgroundColor = Color.Transparent,
            };

            grid.Children.Add(enter_button, 2, 7);

            Content = grid;
        }

        private void Update_text(object sender, System.EventArgs e, Label text_input)
        {   
            if (((Button)sender).Text != "<-")
            {
                string answer = (sender as Button).Text;
                text_input.Text += answer;
            } else
            {
                text_input.Text = text_input.Text.Substring(0, text_input.Text.Length - 1);
            }
        }
    }
}

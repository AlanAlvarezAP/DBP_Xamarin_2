using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace App8
{
    public partial class CV : ContentPage
    {
        public CV(string contenidoCV)
        {
            InitializeComponent();

            var labelCV = new Label
            {
                Text = contenidoCV,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                Margin = new Thickness(20),
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            var titleLabel = new Label
            {
                Text = "CV Generado",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.White
            };

            var frame = new Frame
            {
                Content = new ScrollView
                {
                    Content = labelCV
                },
                Padding = new Thickness(20),
                BackgroundColor = Color.DarkSlateGray,
                CornerRadius = 10,
                Margin = new Thickness(40),
            };

            Content = new StackLayout
            {
                BackgroundColor = Color.FromHex("#f6a633"),
                Children =
                {
                    titleLabel,
                    frame
                }
            };
        }
    }
}

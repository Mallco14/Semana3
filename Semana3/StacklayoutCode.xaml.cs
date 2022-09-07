using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StacklayoutCode : ContentPage
    {
        public StacklayoutCode()
        {
            InitializeComponent();
            var layout = new StackLayout();
            var button = new Button
            {
                Text = " StackLayout",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            var yellowbox = new BoxView
            {
                Color = Color.Yellow,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var greenbox = new BoxView
            {
                Color = Color.Green,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var bluebox = new BoxView
            {
                Color = Color.Blue,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 75

            };

            layout.Children.Add(button);
            layout.Children.Add(yellowbox);
            layout.Children.Add(greenbox);
            layout.Children.Add(bluebox);
            layout.Spacing = 10;
            Content = layout;
        }
    }
}

using System.Runtime.CompilerServices;

namespace Story_App_Isabella;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        SizeChanged += Grid_SizeChanged;
    }

    private void Grid_SizeChanged(object sender, EventArgs e)
    {
        if (Width < 200 || Height < 100)
        {
            Title.FontSize = 40;
            ButtonIs.FontSize = 12;
            ButtonIs.WidthRequest = 80;
            ButtonIs.HeightRequest = 10;
            ButtonIs.Margin = new Thickness(0, 0, 0, 150);
            ButtonOliv.FontSize = 12;
            ButtonOliv.WidthRequest = 80;
            ButtonOliv.HeightRequest = 10;
            ButtonOliv.Margin = new Thickness(0, 0, 0, 100);
            ButtonJulse.FontSize = 12;
            ButtonJulse.WidthRequest = 80;
            ButtonJulse.HeightRequest = 10;
            ButtonJulse.Margin = new Thickness(0, 0, 0, 50);
        }
        else if (Width < 400 || Height < 200)
        {
            Title.FontSize = 40;
            ButtonIs.FontSize = 24;
            ButtonIs.WidthRequest = 180;
            ButtonIs.HeightRequest = 20;
            ButtonIs.Margin = new Thickness(0, 0, 0, 150);
            ButtonOliv.FontSize = 24;
            ButtonOliv.WidthRequest = 180;
            ButtonOliv.HeightRequest = 20;
            ButtonOliv.Margin = new Thickness(0, 0, 0, 100);
            ButtonJulse.FontSize = 24;
            ButtonJulse.WidthRequest = 180;
            ButtonJulse.HeightRequest = 20;
            ButtonJulse.Margin = new Thickness(0, 0, 0, 50);

        }
        else if (Width < 800 || Height < 400)
        {

            Title.FontSize = 40;
            ButtonIs.FontSize = 20;
            ButtonIs.WidthRequest = 280;
            ButtonIs.HeightRequest = 40;
            ButtonIs.Margin = new Thickness(0, 0, 0, 300);
            ButtonOliv.FontSize = 30;
            ButtonOliv.WidthRequest = 280;
            ButtonOliv.HeightRequest = 50;
            ButtonOliv.Margin = new Thickness(0, 0, 0, 200);
            ButtonJulse.FontSize = 36;
            ButtonJulse.WidthRequest = 280;
            ButtonJulse.HeightRequest = 50;
            ButtonJulse.Margin = new Thickness(0, 0, 0, 100);
        }

        else if (Width < 1600 || Height < 800)
        {
            Title.FontSize = 40;
            ButtonIs.FontSize = 40;
            ButtonIs.WidthRequest = 400;
            ButtonIs.HeightRequest = 80;
            ButtonIs.Margin = new Thickness(0, 0, 0, 300);
            ButtonOliv.FontSize = 60;
            ButtonOliv.WidthRequest = 400;
            ButtonOliv.HeightRequest = 80;
            ButtonOliv.Margin = new Thickness(0, 0, 0, 200);
            ButtonJulse.FontSize = 60;
            ButtonJulse.WidthRequest = 400;
            ButtonJulse.HeightRequest = 80;
            ButtonJulse.Margin = new Thickness(0, 0, 0, 100);
        }
    }

    private async void ButtonIsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
       
    
    private async void ButtonOlivClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Map());
    }

   

}
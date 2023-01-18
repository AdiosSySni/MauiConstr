using System.Collections.ObjectModel;


namespace MauiApp3;

public partial class NewContent2 : ContentView
{
	public Memories MM { get; set; }
	private bool clicked = true;


    public NewContent2(Memories m)
	{
		MM = m;
		InitializeComponent();
		BindingContext = this;
	}

	private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
		Random rnd = new Random();
		if (clicked)
		{
            Color color = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            (sender as VerticalStackLayout).BackgroundColor = color;
			clicked = false;
			return;
        }
		else
		{
            (sender as VerticalStackLayout).BackgroundColor = Color.Parse("White");
			clicked = true;
			
        }
    }
}
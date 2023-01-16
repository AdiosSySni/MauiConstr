using System.Collections.ObjectModel;


namespace MauiApp3;

public partial class NewContent2 : ContentView
{
	public Memories MM { get; set; }

	public NewContent2(Memories m)
	{
		MM = m;
		InitializeComponent();
		BindingContext = this;
	}
}
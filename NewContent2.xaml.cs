namespace MauiApp3;

public partial class NewContent2 : ContentView
{
	public Memories MM { get; set; }
	public NewContent2()
	{
		

		InitializeComponent();
		BindingContext = this;
	}
}
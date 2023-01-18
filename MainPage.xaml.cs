using System.Collections.ObjectModel;

namespace MauiApp3;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Memories> people { get; set; }
    public Memories MM { get; set; }

    public MainPage()
	{
        BindingContext = this;
        InitializeComponent();
	}

	private void btnClick(object sender, EventArgs e)
	{
        if(Entry.Text.Any(c => char.IsLetter(c)))
        {
            Entry.Text = "";
            return;
        }

        if (Convert.ToInt32(Entry.Text) == 0)
		{
            VSL.Clear();
		}
		else
		{
            for (int i = 0; i < Convert.ToInt32(Entry.Text); i++)
            {
                VSL.Add(new NewContent2(new Memories()));
            }
        }
	}
}


using System.Collections.ObjectModel;

namespace MauiApp3;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Memories> people { get; set; }
    public Memories MM { get; set; }

    public MainPage()
	{
        people = new ObservableCollection<Memories>();
        people.Add(new Memories("Илья", "Васькин", "Владимирович", "dotnet_bot.png"));
        people.Add(new Memories("Пауль", "Гегель", "Викторович", "dotnet_bot.png"));

        BindingContext = this;
        InitializeComponent();
	}

	private void btnClick(object sender, EventArgs e)
	{
		for (int i = 0; i < Convert.ToInt32(Entry.Text); i++)
		{
			VSL.Add(new NewContent2());
		}
      
	}

}


using System.Threading.Tasks;

namespace MauiAppHotel2.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private async Task Button_Clicked(object sender, EventArgs e)
    {

		await Navigation.PopAsync();

    }
}
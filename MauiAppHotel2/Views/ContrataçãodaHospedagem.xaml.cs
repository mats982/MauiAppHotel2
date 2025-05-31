using System.Threading.Tasks;

namespace MauiAppHotel2.Views;

public partial class ContrataçãodaHospedagem : ContentPage
{
	public ContrataçãodaHospedagem()
	{
		InitializeComponent();
	}

    private async Task Button_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Sobre());

    }
}
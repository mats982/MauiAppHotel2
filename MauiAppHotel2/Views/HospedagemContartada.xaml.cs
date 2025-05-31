namespace MauiAppHotel2.Views;

public partial class HospedagemContartada : ContentPage
{
	public HospedagemContartada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try 
		{

			Navigation.PopAsync();
		
		} catch (Exception ex)
		{

			DisplayAlert("Ops", ex.Message, "OK");
		
		}
    }
}
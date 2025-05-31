namespace MauiAppHotel2.Views;

public partial class ContrataçãodaHospedagem : ContentPage
{
	App PropriedadesApp;
	public ContrataçãodaHospedagem()
	{
        InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_quarto.ItemsSource = PropriedadesApp.Lista_quartos;

		dtpck_chekin.MinimumDate = DateTime.Now;
		dtpck_chekin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		dtpck_chekout.MinimumDate = dtpck_chekin.Date.AddDays(1);
        dtpck_chekout.MaximumDate = dtpck_chekin.Date.AddMonths(6);
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new HospedagemContartada());
		}
		catch (Exception ex)
		{

			DisplayAlert("Ops", ex.Message, "OK");
		
		}

	}

    private void dtpck_chekin_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_checkin = elemento.Date;

		dtpck_chekout.MinimumDate = data_selecionada_checkin.AddDays(1);
		dtpck_chekout.MaximumDate = data_selecionada_checkin.AddMonths(6);	
    }
}
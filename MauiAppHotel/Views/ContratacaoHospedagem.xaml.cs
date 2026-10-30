namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private async void BtnSobre_Clicked(object sender, EventArgs e)
    { 
		// Navega para a SobrePage
		await Navigation.PushAsync(new SobrePage()); }
    }
namespace MauiAppHotel.Views; 
public partial class MenuPrincipalPage : ContentPage 
{ 
    public MenuPrincipalPage() 
    { 
        InitializeComponent(); 
    } 
    private async void BtnHospedagem_Clicked(object sender, EventArgs e) 
    { 
        await Navigation.PushAsync(new ContratacaoHospedagem()); 
    } 
    private async void BtnEventos_Clicked(object sender, EventArgs e) 
    { 
        await Navigation.PushAsync(new CadastroEventoPage()); 
    } 
    private async void BtnSobre_Clicked(object sender, EventArgs e) 
    {
        await Navigation.PushAsync(new SobrePage()); 
    } 
}
namespace MauiAppHotel 
{ 
    public partial class SobrePage : ContentPage 
    { 
        public SobrePage() 
        { 
            InitializeComponent();
        }
        private async void BtnVoltar_Clicked(object? sender, EventArgs e) 
        { 
            // Retorna para a tela anterior no fluxo de navegação
            await Navigation.PopAsync(); 
        } 
    }
}
namespace MauiAppHotel.Views; 

// Importa a pasta Models para reconhecer a classe Quarto
using MauiAppHotel.Models;
public partial class ContratacaoHospedagem : ContentPage 
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();

        pck_quarto.ItemsSource = new List<Quarto>
        {
            new Quarto { Descricao = "Suíte Super luxo", ValorDiariaAdulto = 110.0, ValorDiariaCrianca = 55.0 },
            new Quarto { Descricao = "Suíte Executiva", ValorDiariaAdulto = 90.0, ValorDiariaCrianca = 45.0 },
            new Quarto { Descricao = "Suíte Crise", ValorDiariaAdulto = 45.0, ValorDiariaCrianca = 20.0 }
        };

        // Define a data mínima de check-in como HOJE e limite máximo de 6 meses
        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(6); 
        
        // Define a data mínima de check-out como amanhã
        dtpck_checkout.MinimumDate = dtpck_checkin.Date.Value.AddDays(1); 
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.Value.AddMonths(6);
    }

    // Atualiza dinamicamente o limite do check-out quando o usuário altera o check-in
    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e) 
    {
        DatePicker elemento = (DatePicker)sender; 
        DateTime data_selecionada_checkin = elemento.Date.Value; 
        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6); 
    }

    private async void Btn_Clicked(object sender, EventArgs e) 
    { 
        try 
        {
            // Valida se o usuário escolheu uma acomodação no Picker
            if (pck_quarto.SelectedItem == null) 
            {
                await DisplayAlertAsync("Atenção", "Selecione uma acomodação antes de avançar.", "OK"); return; 
            }
            var h = new Hospedagem 
          { 
              QuartoSelecionado = (Quarto)pck_quarto.SelectedItem, 
              QtdAdultos = Convert.ToInt32(stp_adultos.Value), 
              QtdCriancas = Convert.ToInt32(stp_criancas.Value), 
              DataCheckIn = dtpck_checkin.Date.Value, 
              DataCheckOut = dtpck_checkout.Date.Value
          }; 
            // Navega para a página de resumo passando o BindingContext
            await Navigation.PushAsync(new HospedagemContratada
            { 
                BindingContext = h 
            }); 
        } 
        catch (Exception ex) 
        { 
            await DisplayAlertAsync("Erro", ex.Message, "OK");
        } 
    } 
    
     private async void BtnSobre_Clicked(object sender, EventArgs e) 
    { 
        await Navigation.PushAsync(new SobrePage()); 
    } 
}                  
namespace MauiAppHotel.Views;

using MauiAppHotel.Models;
public partial class CadastroEventoPage : ContentPage 
{ 
    public CadastroEventoPage() 
    { 
        InitializeComponent(); 
        // Bloqueia datas passadas
        dtpck_inicio.MinimumDate = DateTime.Now; 
        dtpck_termino.MinimumDate = DateTime.Now.AddDays(1); 
    } 
    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    { 
        DatePicker elemento = (DatePicker)sender; DateTime data_selecionada = elemento.Date.Value; 
        dtpck_termino.MinimumDate = data_selecionada.AddDays(1);
    } 
    private async void BtnCadastrar_Clicked(object sender, EventArgs e) 
    { try 
        { 
            // Validações simples dos campos
            if (string.IsNullOrWhiteSpace(txt_nome.Text) || string.IsNullOrWhiteSpace(txt_local.Text)) 
            { 
                await DisplayAlertAsync("Atenção", "Preencha o nome e o local do evento.", "OK"); 
                return; 
            } 
            if (!double.TryParse(txt_custo.Text, out double custo)) 
            { 
                await DisplayAlertAsync("Atenção", "Informe um valor numérico válido para o custo por participante.", "OK"); 
                return; 
            } 
            // Instancia a Model Evento
            var evento = new Evento 
            { 
                Nome = txt_nome.Text, 
                Local = txt_local.Text, 
                NumeroParticipantes = Convert.ToInt32(stp_participantes.Value), 
                CustoPorParticipante = custo, 
                DataInicio = dtpck_inicio.Date.Value,
                DataTermino = dtpck_termino.Date.Value 
            }; 
            // REQUISITO 3: Navega passando o objeto via BindingContext
            await Navigation.PushAsync(new ResumoEventoPage 
            {
                BindingContext = evento 
            }); 
        } 
        catch (Exception ex) 
        { 
            await DisplayAlertAsync("Erro", ex.Message, "OK"); 
        } 
    }
    private async void BtnVoltar_Clicked(object sender, EventArgs e) 
    { 
        await Navigation.PopAsync();
    }
}
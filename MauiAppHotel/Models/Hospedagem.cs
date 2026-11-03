namespace MauiAppHotel.Models 
{ 
    public class Hospedagem 
    { 
        public Quarto QuartoSelecionado { get; set; } 
        public int QtdAdultos { get; set; } 
        public int QtdCriancas { get; set; } 
        public DateTime DataCheckIn { get; set; } 
        public DateTime DataCheckOut { get; set; } 
        public int Stays => (DataCheckOut - DataCheckIn).Days; 
        public double ValorTotal => (QtdAdultos * QuartoSelecionado.ValorDiariaAdulto + QtdCriancas * QuartoSelecionado.ValorDiariaCrianca) * Stays; 
    } 
}
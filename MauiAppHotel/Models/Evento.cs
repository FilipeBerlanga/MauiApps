namespace MauiAppHotel.Models 
{ 
    public class Evento
    {
        public string Nome { get; set; }
        public string Local { get; set; }
        public int NumeroParticipantes { get; set; }
        public DateTime DataInicio { get; set; } 
        public DateTime DataTermino { get; set; }      
        public double CustoPorParticipante { get; set; }

        public int DuracaoEmDias 
        { 
            get 
            {                
                TimeSpan diferenca = DataTermino - DataInicio; 
                return diferenca.Days; 
            } 
        } 
       
        public double CustoTotal 
        { 
            get 
            { 
                return NumeroParticipantes * CustoPorParticipante * DuracaoEmDias; 
            } 
        } 
    } 
}
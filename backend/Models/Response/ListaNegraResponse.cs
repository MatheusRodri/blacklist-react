using System;

namespace backend.Models.Response
{
    public class ListaNegraResponse
    {
        public int id { get;set;}
        public string Nome { get; set; }
        public String Motivo { get; set; }
        public DateTime? Inclusao { get; set; }
    }
}
using System;

namespace backend.Models.Response
{
    public class ErroResponse
    {
        public int Codigo { get; set; }
        public String Erro { get; set; }

        public ErroResponse(int codigo, string erro){
            this.Codigo = codigo;
            this.Erro = erro;
        }
    }
}
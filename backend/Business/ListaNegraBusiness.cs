using System;
using System.Collections.Generic;
using System.Linq;


namespace backend.Business
{
    public class ListaNegraBusiness
    {
        Database.ListaNegraDatabase db = new Database.ListaNegraDatabase();
        
        public Models.TbBlacklist Salvar(Models.TbBlacklist ln)
        {    
            if(ln.DsMotivo == string.Empty)
                throw new Exception("Nome é obrigatorio");
            if(ln.NmPessoa == string.Empty)
                throw new Exception("O motivo é obrigatorio");
            return db.Salvar(ln);
        }
        public List<Models.TbBlacklist> Listar(){
            return db.Listar();
        }
    }
}
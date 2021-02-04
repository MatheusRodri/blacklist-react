using System;
using System.Collections.Generic;

namespace backend.Utils
{
    public class ListaNegraConversor
    {
        public Models.TbBlacklist ParaTabela(Models.Request.ListaNegraRequest request){
            Models.TbBlacklist ln = new Models.TbBlacklist();
            ln.NmPessoa = request.Nome;
            ln.DsMotivo = request.Motivo;
            ln.DtInclusao = DateTime.Now;

            return ln;
        }

          public Models.Response.ListaNegraResponse ParaResponse(Models.TbBlacklist ln){
            Models.Response.ListaNegraResponse resp = new Models.Response.ListaNegraResponse();
            resp.id = ln.IdList;
            resp.Nome = ln.NmPessoa;
            resp.Motivo = ln.DsMotivo;
            resp.Inclusao = ln.DtInclusao;
           

            return resp;
        }
         public List< Models.Response.ListaNegraResponse> ParaResponse(List<Models.TbBlacklist> lns){
           List< Models.Response.ListaNegraResponse> resp = new List< Models.Response.ListaNegraResponse>();
           
            foreach(Models.TbBlacklist item in lns)
            {
               resp.Add(
                   this.ParaResponse(item)); 
            }

            return resp;
    }
    }
}
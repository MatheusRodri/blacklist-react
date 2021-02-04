using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace backend.Database
{
    public class ListaNegraDatabase
    {
        Models.lndbContext db = new Models.lndbContext();
        public Models.TbBlacklist Salvar(Models.TbBlacklist ln){
            
            db.Add(ln);
            db.SaveChanges();

            return ln;
        }
        public List<Models.TbBlacklist> Listar(){
            List<Models.TbBlacklist> lns = db.TbBlacklist.ToList();

            return lns;
        }
    }
}
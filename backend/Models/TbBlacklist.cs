using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_blacklist")]
    public partial class TbBlacklist
    {
        [Key]
        [Column("id_list")]
        public int IdList { get; set; }
        [Column("nm_pessoa", TypeName = "varchar(100)")]
        public string NmPessoa { get; set; }
        [Column("ds_motivo", TypeName = "varchar(400)")]
        public string DsMotivo { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime? DtInclusao { get; set; }
    }
}

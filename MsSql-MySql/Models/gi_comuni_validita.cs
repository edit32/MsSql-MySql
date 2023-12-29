using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsSql_MySql.Models
{
    public class gi_comuni_validita
    {        
        public string sigla_provincia { get; set; }          
        public string codice_istat{ get; set; }
        public string denominazione_ita { get; set; }        
        public string codice_belfiore { get; set; }        
        public DateTime data_inizio_validita { get; set; }
        public DateTime? data_fine_validita { get; set; }
        public string stato_validita { get; set; }
        [Key]
        public int Id { get; set; }
    }
}

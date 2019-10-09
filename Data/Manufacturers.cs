using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDHW2.Data
{
    public class Manufacturers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MID { get; set; }

        [Display(Name ="Manufacturer Name")]
        public string Mname { get; set; }

        [Display(Name = "Manufacturer Head")]
        public string Mhead { get; set; }
    }
}

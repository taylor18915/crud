using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDHW2.Data
{
    public class Automobiles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AID { get; set; }

        public string Aname { get; set; }
        public string Acolor { get; set; }
        public int MID { get; set; }

        [ForeignKey("MID")]
        public Manufacturers ManId { get; set; }
    }
}

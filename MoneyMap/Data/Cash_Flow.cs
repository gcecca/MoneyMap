using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyMap.Data
{
    public class Cash_Flow
    {
        [Key]
        public int idFlow { get; set; }
        [Required]
        public float movement { get; set; }
        [Required]
        public DateTime movement_date { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public string detailed_description { get; set; }
    
        public Cash_Flow(){
            movement_date = System.DateTime.Now;
        }
    }
}

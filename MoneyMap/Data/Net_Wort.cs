using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoneyMap.Data{

    public class Net_Worth{

        [Key]
        public int id{get; set;}
        [Required]
        public float money{get; set;}
        [Required]
        public DateTime value_date{get;set;}

        public Net_Worth(){
            value_date = System.DateTime.Now;
        }
    }
    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace newcrudapp.Models
{
    public class NewCusClass
    {
        [Key]
        public int customerId { get; set; }

        public string name{ get; set; }

        public string code { get; set; }

        public string address { get; set; }



    }
}

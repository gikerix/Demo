using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ConvertNumbers.Models
{
    public class BasicNumbers
    {
        [Key]
        public int BasicNumberID { get; set; } //primary key
        public int Number { get; set; }
        public string Word  { get; set; } 
    }
}
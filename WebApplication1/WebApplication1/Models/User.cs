using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("User")]
    public class User:BaseClass
    {
       
        public string phone { get; set; }
        public string email { get; set; }
    }
}
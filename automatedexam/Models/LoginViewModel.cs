 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace automatedexam.Models
{
    public class LoginViewModel
    {
        [Required]
        public string kullaniciadi { get; set; }
        [Required]
        public string sifre { get; set; }
    }
}

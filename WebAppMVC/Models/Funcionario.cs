using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppMVC.Models
{
    public class Funcionario
    {
        [Display(Name = "Código")]
        public int codigo { get; set; }

        [Display(Name = "Nome do Funcionário")]
        public string nome { get; set; }

        [Display(Name = "Gênero")]
        public string genero { get; set; }
    }
}
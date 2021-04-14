using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Exerc_biblioteca.Models
{
    [Table("livros")]
    public class livro
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "autor não encontrado")]
        [Display(Name = "Autor:")]
        public string autor { get; set; }

        [Required(ErrorMessage ="editora não encontrada")]
        [Display(Name = "Editora:")]
        public string editora { get; set; }

        [Required(ErrorMessage = "edicao não encontrada")]
        [Display(Name = "Edicao:")]
        public int edicao { get; set; }

        [Required(ErrorMessage = "pagina não encontrada")]
        [Display(Name = "Pagina:")]
        public int pagina { get; set; }

        [Required(ErrorMessage = "idioma não encontrada")]
        [Display(Name = "Idioma:")]
        public string idioma { get; set; }


        [Required(ErrorMessage = "genero não encontrada")]
        [Display(Name = "Genero:")]
        public string genero { get; set; }

        [Required(ErrorMessage = "capa não encontrada")]
        [Display(Name = "Capa:")]
        public string capa { get; set; }













    }

   
    
    
}

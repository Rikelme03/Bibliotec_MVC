using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class LivroReserva
{       
    
        [Key]
        public int LivroCategoriaID {get;set;}
        public DateOnly DtReserva {get;set;}
        public DateOnly DtDevolucao {get;set;}
        public int status {get;set;}

        [ForeignKey("Usuario")]
        public int UsuarioID {get;set;}
        [ForeignKey("Livro")]
        public int LivroID {get;set;}
        
    }
}
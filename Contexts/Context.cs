using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;

namespace Bibliotec.Contexts
{   
    
    //Classe que tera as informacoes do banco de dados 

    public class Context : DbContext
    {
        

        //criar um metodo cronstrutor

        public Context()
        {
            
        }

        public Context( DbContextOptions<Context> Options) : base (Options)
        {
            
        }

        //OnConfigurimg = Possui a configuracao para a configuracao do banco de dados

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder)
        {
            //colocar as informacoes do banco de dados 
            //
            if (!optionsBuilder.IsConfigured)
            {     // User ID e Passawoerd Sao informacoes de acesso ao servidor do banco de dados 
               optionsBuilder.UseSqlServer(
               @"Data Source=DESKTOP-16UD9N2\\RIKELMESILVA; 
               Initial Catalog = Bibliotec_mvc; 
               User Id=sa; 
               Passaword= ;           
               Integrated Security=true; 
               TrustServerCertificate = true");
                  
            }

            Public DbSet<Categoria> Categoria { get; set;} 

            Public DbSet<Livro> Livro { get; set;}    

            Public DbSet<Usuario> Usuario { get; set;}  

            Public DbSet<LivroCategoria> LivroCategoria { get; set;}  

            Public DbSet<LivroReserva> LivroReserva { get; set;}    
            
            
        }


    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_mvc_application.Models
{
    public class Context : DbContext
    {
        //Tabela de categorias
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }


        //Configura o entityF. Dentro dele eu falo qual banco de dados vou utilziar
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            //UseSqlServer é um metodo de extensao pq instalamos o EF para o SQLServer
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=DESKTOP-FE9LPMG\SQLEXPRESS;Initial Catalog=Cursomvc;Integrated Security=True");
        }
    }
}

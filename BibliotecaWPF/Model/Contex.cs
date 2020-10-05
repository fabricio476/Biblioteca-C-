using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaWPF.Model
{
    class Contex : DbContext //erança para fazer o mapeamento
    {
        public DbSet<Usuario> Usuario { get; set; } //informar a classe que quer que esteja no banco

        //sobrescrever o metodo de confguração // para que toda vez que for usar ele faça a conexão com o banco de dados
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb;Database=BibliotecaWPF;Trusted_Connection=true");
        }
    }
}

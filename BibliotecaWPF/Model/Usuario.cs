using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BibliotecaWPF.Model
{
    [Table("Usuario")] //colocar nome da tabela
    class Usuario
    {


       public Usuario(String cpf, String senha)
        {

            this.Cpf = cpf;
            this.senha = senha;

        }


        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string senha { get; set; }
        


    }
}

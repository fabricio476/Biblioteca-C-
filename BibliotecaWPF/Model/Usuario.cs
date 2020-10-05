using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaWPF.Model
{
    class Usuario
    {


       public Usuario(String cpf, String senha)
        {

            this.Cpf = cpf;
            this.senha = senha;

        }



        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string senha { get; set; }
        public Livro livro { get; set; }


    }
}

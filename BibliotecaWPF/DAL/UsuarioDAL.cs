using BibliotecaWPF.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Documents;

namespace BibliotecaWPF.DAL
{
    class UsuarioDAL
    {

       static List<Usuario> listaUsuarios = new List<Usuario>();


        //metodo que faz o login
        public static bool Logar(Usuario usuario)
        {

           if (usuario.Cpf == "fabricio")
            {
                return true;
            }
            return false;
        }



        //metodo que realisa o cadastro
        public static bool cadastrar(Usuario usuario)
        {


            if(usuario.Cpf != "" && usuario.senha !="" && usuario.Nome !="")
            {
                listaUsuarios.Add(usuario);

                return true;

                
            }

            return false;
        }




    }
}

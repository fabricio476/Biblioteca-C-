using BibliotecaWPF.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace BibliotecaWPF.Acoes
{
    class AcoesTelas : Window
    {

        public void OpenLogin()
        {
            Login login = new Login();
            login.Show();

            Close();

        }



    }
}

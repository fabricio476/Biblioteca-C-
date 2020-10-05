using BibliotecaWPF.Acoes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BibliotecaWPF.View
{
    /// <summary>
    /// Lógica interna para FormPrincipal.xaml
    /// </summary>
    public partial class FormPrincipal : Window
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        //Metodo que vai abrir a janela de cadastro
        private void btn_CadUsuario_Click(object sender, RoutedEventArgs e)
        {

            CadastrarUsuario CadUser = new CadastrarUsuario();
            CadUser.Show();

            Close(); // fecha a janela atual

        }

        //Metodo que vai abrir a janela de login
        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
                Login login = new Login();
                login.Show();

            Close(); // fecha a janela atual

        }
    }
}

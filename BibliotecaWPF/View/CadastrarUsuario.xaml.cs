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
    /// Lógica interna para CadastrarUsuario.xaml
    /// </summary>
    public partial class CadastrarUsuario : Window
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }


        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {


            Login login = new Login();
            login.Show();

            Close(); // fecha a janela atual

        }

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {

            FormPrincipal telaHome = new FormPrincipal();
            telaHome.Show();

            Close(); // fecha a janela atual

        }
    }
}

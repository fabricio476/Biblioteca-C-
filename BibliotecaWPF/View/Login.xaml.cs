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
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_CadUsuario_Click(object sender, RoutedEventArgs e)
        {


            CadastrarUsuario CadUser = new CadastrarUsuario();
            CadUser.Show();

            Close(); // fecha a janela atual

        }

        private void btn_Home_Click(object sender, RoutedEventArgs e)
        {
            FormPrincipal telaHome = new FormPrincipal();
            telaHome.Show();

            Close(); // fecha a janela atual
        }
    }
}

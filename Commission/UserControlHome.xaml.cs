using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Commision
{
    /// <summary>
    /// Interação lógica para UserControlHome.xam
    /// </summary>
    public partial class UserControlHome : UserControl
    {
        public UserControlHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ui = int.Parse(((Button)sender).Uid);

            switch(ui){
                //ajouter dossier administratif
                case 0:

                    break;
                //ajouter dossier technique
                case 1:

                    break;

                default:
                    break;
            }
        }
    }
}

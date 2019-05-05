using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls.Primitives;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /*
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MessageBoxResult answer = MessageBox.Show("Do you want to start test mode?", "Login", MessageBoxButton.OKCancel);
            if (answer == MessageBoxResult.Yes)
            {
                //base.OnStartUp(e);
                MainWindow w = new MainWindow();
                this.MainWindow = w;
                this.MainWindow.Title = "Програмата е в тестов режим";
                w.Show();
                w.fillButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                
            }
            else
            {
                MainWindow w = new MainWindow();
                this.MainWindow = w;
                w.Show();
                w.disableButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }


        }
        */
    }
}

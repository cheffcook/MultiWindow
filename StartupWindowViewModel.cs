using System.Windows;
using System.Windows.Input;
using Prism.Commands;

namespace MultiWindow
{
    public class StartupWindowViewModel
    {
        public ICommand OpenMainWindowCommand { get; }
        public ICommand OpenMainWindow1Command { get; }

        public StartupWindowViewModel()
        {
            OpenMainWindowCommand = new DelegateCommand(OpenMainWindow);
            OpenMainWindow1Command = new DelegateCommand(OpenMainWindow1);
        }

        private void OpenMainWindow()
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            CloseWindow();
        }

        private void OpenMainWindow1()
        {
            MainWindow1 mainWindow1 = new();
            mainWindow1.Show();
            CloseWindow();
        }

        private static void CloseWindow()
        {
            Application.Current.MainWindow.Close();
        }
    }
}

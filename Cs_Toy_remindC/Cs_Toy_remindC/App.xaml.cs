using Cs_Toy_remindC.ViewModels;
using Cs_Toy_remindC.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Cs_Toy_remindC
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var viewModel = new MainViewModel(); // 뷰모델을 만들어서
            var view = new MainView
            {
                DataContext = viewModel, // DataContext을 뷰모델로 지정함으로써 뷰에서 뷰모델의 속성을 바인딩 할 수 있음
            };
            view.Show();
        }
    }

}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Cs_Toy_remindC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Cs_Toy_remindC.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        #region '필드'
        private string _greeting;
        public string Greeting
        {
            get => _greeting;
            set => SetProperty(ref _greeting, value);
        }

        private string _currentStatus;
        public string CurrentStatus
        {
            get => _currentStatus;
            set => SetProperty(ref _currentStatus, value);
        }

        private Page _currentView;
        public Page CurrentView
        {
            get => _currentView;
            set => SetProperty(ref _currentView, value);
        }
        #endregion

        // 생성자로 초기 화면 세팅
        public MainViewModel()
        {
            //var vm = new HomeViewModel(); // 화면 전환은 MainViewModel로 관리할 거라 필요없음
            var v = new HomeView
            {
                DataContext = this,
            };
            CurrentView = v;
            CurrentStatus = "홈화면";
        }
        

        #region '화면 바꾸기'
        [RelayCommand]
        public void ShowGame()
        {
            var vm = new GameViewModel();
            var v = new GameView
            {
                DataContext = vm,
            };
            CurrentView = v;
            CurrentStatus = "음감 테스트 게임";
        }
        #endregion
    }
}

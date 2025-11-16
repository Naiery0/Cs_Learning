using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;

namespace Cs_Toy_remindC.Models
{
    public class GameModel : ObservableObject
    {
        private string _playerName = "";
        public string playerName
        {
            get => _playerName;
            set => SetProperty(ref _playerName, value);
        }

        private int _playerScore = 0;
        public int playerScore
        {
            get => _playerScore;
            set => SetProperty(ref _playerScore, value);
        }

        private int _heart = 3;
        public int heart
        {
            get => _heart;
            set => SetProperty(ref _heart, value);
        }

        private string _startBtnTxt = "시작";
        public string startBtnTxt
        {
            get => _startBtnTxt;
            set => SetProperty(ref _startBtnTxt, value);
        }

        private Visibility _btnVisible = Visibility.Visible;
        public Visibility btnVisible
        {
            get => _btnVisible;
            set => SetProperty(ref _btnVisible, value);
        }

        private string _commentTxt = "";
        public string commentTxt
        {
            get => _commentTxt;
            set => SetProperty(ref _commentTxt, value);
        }
    }
}

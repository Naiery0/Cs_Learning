using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cs_Toy_remindC.ViewModels
{
    public partial class GameViewModel : ObservableObject
    {
        //public GameViewModel() { MessageBox.Show("테스트"); }

        [RelayCommand]
        private void PlayNote(string note)
        {
            if (string.IsNullOrEmpty(note)) return;
            //MessageBox.Show($"Play Note: {note}");

        }
        
    }
}

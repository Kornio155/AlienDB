using Avalonia.Controls;
using AlienDB.ViewModels;

namespace AlienDB.Views
{
    public partial class CharacterWindow : Window
    {
        public CharacterWindow()
        {
            InitializeComponent();
            DataContext = new CharacterWindowViewModel(); 
        }
    }
}
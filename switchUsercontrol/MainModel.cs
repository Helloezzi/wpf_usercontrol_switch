using System.Windows.Input;

namespace switchUsercontrol
{
    public class MainModel : ViewModelBase
    {
        private int switchView;
        public int SwitchView
        {
            get
            {
                return switchView;
            }
            set
            {
                switchView = value;
                OnPropertyChanged("SwitchView");
            }
        }

        public ICommand SwitchViewCommand { get; }

        public MainModel()
        {
            SwitchView = 0;

            SwitchViewCommand = new RelayCommand<object>(p => OnSwitchView(p));
        }

        private void OnSwitchView(object index)
        {
            SwitchView = int.Parse(index.ToString());
        }
    }
}

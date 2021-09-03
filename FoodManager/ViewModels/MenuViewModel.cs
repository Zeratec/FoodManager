using FoodManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace FoodManager.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        #region Variable
        #endregion Variable

        #region Constructor
        public MenuViewModel()
        {
            menuCommand = new RelayCommand(load_menuChoiced);
        }
        #endregion Constructor

        #region Properties
        public ICommand menuCommand { get; set; }

        private object _selectedViewModel;
        public object SelectedViewModel
        {
            get
            {
                return _selectedViewModel;
            }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }
        #endregion Properties

        #region Public Methods
        #endregion Public Method

        #region Private Method
        public void load_menuChoiced(object obj)
        {
            switch (obj)
            {
                case "Home":
                    SelectedViewModel = new HomeViewModel();
                    break;

                case "Graphic":
                    SelectedViewModel = new GraphicViewModel();
                    break;

                case "Setting":
                    SelectedViewModel = null;
                    break;

                default:
                    break;
            }
        }
        #endregion Private Method
    }
}

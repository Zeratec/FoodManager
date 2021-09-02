using FoodManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManager.ViewModels
{
    public class ContainerAppViewModel : ViewModelBase
    {
        #region Variable
        #endregion Variable

        #region Constructor
        public ContainerAppViewModel()
        {
            Menu = new MenuViewModel();
        }

        public ContainerAppViewModel(object selectedViewModel)
        {
            Menu = new MenuViewModel();

            //_selectedViewModel = selectedViewModel;
            //SelectedViewModel = _selectedViewModel;

            _selectedViewModel = new HomeViewModel();
            SelectedViewModel = _selectedViewModel;
        }
        #endregion Constructor

        #region Properties
        private object _menu;
        public object Menu
        {
            get
            {
                return _menu;
            }
            set
            {
                _menu = value;
                OnPropertyChanged(nameof(Menu));
            }
        }

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

        #region Public Method
        #endregion Public Method

        #region Private Method
        #endregion Private Method
    }
}

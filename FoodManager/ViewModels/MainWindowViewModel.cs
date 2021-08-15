using FoodManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManager.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Variable
        #endregion Variable

        #region Constructor
        public MainWindowViewModel()
        {
            MenuViewModel = new MenuViewModel();
        }
        #endregion Constructor

        #region Properties
        private object _menuViewModel;
        public object MenuViewModel
        {
            get
            {
                return _menuViewModel;
            }
            set
            {
                _menuViewModel = value;
                OnPropertyChanged(nameof(MenuViewModel));
            }
        }
        #endregion Properties

        #region Public Method
        #endregion Public Method

        #region Private Method
        #endregion Private Method
    }
}

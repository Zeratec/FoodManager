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
            CurrentView = new ContainerAppViewModel();
        }
        #endregion Constructor

        #region Properties
        public object CurrentView { get; set; }
        #endregion Properties

        #region Public Method
        #endregion Public Method

        #region Private Method
        #endregion Private Method
    }
}
using FoodManager.State.Navigators;
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
        }
        #endregion Constructor

        #region Properties
        public INavigator Navigator { get; set; } = new Navigator();
        #endregion Properties

        #region Public Method
        #endregion Public Method

        #region Private Method
        #endregion Private Method
    }
}

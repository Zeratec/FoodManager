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
        private ContainerAppViewModel containerAppObj;
        #endregion Variable

        #region Constructor
        public MenuViewModel()
        {
            //menuCommand = new RelayCommand(load_menuChoiced);
            menuCommand = new RelayCommand(load_menuChoiced);
        }
        #endregion Constructor

        #region Properties
        public ICommand menuCommand { get; set; }
        #endregion Properties

        #region Public Methods
        #endregion Public Method

        #region Private Method
        public void load_menuChoiced(object obj)
        {
            switch (obj)
            {
                case "Home":
                    //containerAppObj = new ContainerAppViewModel(new HomeViewModel());

                    containerAppObj = new ContainerAppViewModel()
                    {
                        SelectedViewModel = new HomeViewModel()
                    };
                    break;

                case "Graphic":
                    //containerAppObj = new ContainerAppViewModel(new GraphicViewModel());

                    containerAppObj = new ContainerAppViewModel()
                    {
                        SelectedViewModel = new GraphicViewModel()
                    };
                    break;

                case "Setting":

                    break;

                default:
                    break;
            }
        }
        #endregion Private Method
    }
}

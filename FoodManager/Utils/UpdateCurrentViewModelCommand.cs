using FoodManager.State.Navigators;
using FoodManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodManager.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                switch (viewType)
                {
                    case ViewType.Home:
                        _navigator.CurrentViewModel = null;
                        break;

                    case ViewType.Defect:
                        _navigator.CurrentViewModel = new HomeViewModel();
                        break;

                    case ViewType.Graphic:
                        _navigator.CurrentViewModel = new GraphicViewModel();
                        break;

                    case ViewType.Setting:
                        _navigator.CurrentViewModel = null;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
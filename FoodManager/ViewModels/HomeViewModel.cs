using FoodManager.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodManager.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        #region Variable
        private int i = 0;
        #endregion Variable

        #region Constructor
        public HomeViewModel()
        {
            TextBlockTest = "Home";
            TestCommand = new RelayCommand(testCommand);
        }
        #endregion Constructor

        #region Properties
        public ICommand TestCommand { get; set; }

        private string _textBlockTest;
        public string TextBlockTest
        {
            get
            {
                return _textBlockTest;
            }
            set
            {
                _textBlockTest = value;
                OnPropertyChanged(nameof(TextBlockTest));
            }
        }
        #endregion Properties

        #region Public Method
        #endregion Public Method

        #region Private Method
        private void testCommand(object obj)
        {
            TextBlockTest = $"{i++}";
        }
        #endregion Private Method
    }
}

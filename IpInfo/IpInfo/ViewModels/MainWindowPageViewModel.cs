using IpInfo.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace IpInfo.ViewModels
{
    public class MainWindowPageViewModel:BaseViewModel
    {
        
        public MainWindowPageViewModel()
        {
            
                              
        }

                
       

        #region Methods

        /// <summary>
        /// This method is for testing comands and some other stuff.
        /// </summary>
        public void TestMessage()
        {
            MessageBox.Show("Test");
        }

        #endregion

        #region Commands

        /// <summary>
        /// Command for testing.
        /// </summary>
        private ICommand _doTestCommand;
        
        /// <summary>
        /// Gets the testing command.
        /// </summary>
        public ICommand DoTestCommand
        {
            get {

                if (_doTestCommand==null)
                {
                    _doTestCommand = new RelayCommand(param => TestMessage());
                }

                return _doTestCommand;

                }
        } 

        #endregion

    }
}

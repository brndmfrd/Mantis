using Microsoft.Practices.Prism.Regions;
using System.Linq;
using SharedResources.Delegates;
using SharedResources.EventHandlers;
using System.Collections.Generic;
using CombatModule.Model;
using System.Windows.Input;
using System.Diagnostics;

namespace CombatModule.ViewModels
{
    public class CombatViewModel : ObservableObject, INavigationAware
    {
        #region Properties
        public IEnumerable<DisplayObject> VmDisplayObjects
        {
            get { return CombatObjects.DisplayObjects; }
        }
        
        public DisplayObject MySelectedObject
        {
            get { return CombatObjects.CurrentSelectedObject; }
            set { CombatObjects.CurrentSelectedObject = value; }
        }
        #endregion Properties

        #region Public Methods
        public void RefreshProperties()
        {
            RaisePropertyChangedEvent("VmDisplayObjects");
        }       
        #endregion Public Methods

        #region Commands
        public ICommand RollCheck { get { return new DelegateCommand(PerformRollCheck); } }
        #endregion Commands

        #region Private Methods
        private void PerformRollCheck()
        {
            //var targetItem = VmDisplayObjects.FirstOrDefault(i => i.UserName == MySelectedObject.UserName);

            // Make this an async task
            // we must use a connection file to save user name and passwords (see mstsc /? or mstsc /edit:connectionFile.txt)
            // test connections
            // verify connection file exists
            // check network connectivity
            // write a log to the users view
            // communicate to host that a new connection is being made.
            return; // remove this when ready.
            using (Process p = new Process())
            {
                p.StartInfo.FileName = @"C:\WINDOWS\system32\mstsc.exe";
                p.StartInfo.Arguments = $"/v:{MySelectedObject.IpAddress}";
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                var x = p.Id;   // We need this to keep track of all the connections the user is maintaining. Keep track of these at a higher level and when one is removed, update host.
            }
                                  

            //targetItem.DomainName = result.ToString();
        }
        #endregion Private Methods

        #region Navigaion
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            RefreshProperties();
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }
        #endregion Navigaion
    }

   
}

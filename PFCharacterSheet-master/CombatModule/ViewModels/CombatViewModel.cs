using Microsoft.Practices.Prism.Regions;
using System.Linq;
using SharedResources.Delegates;
using SharedResources.EventHandlers;
using System.Collections.Generic;
using CombatModule.Model;
using System.Windows.Input;
using System.Diagnostics;
using Connections;


namespace CombatModule.ViewModels
{
    public class CombatViewModel : ObservableObject, INavigationAware
    {
        public static DisplayObject CurrentSelectedObject = new DisplayObject();


        #region Properties
        public IEnumerable<DisplayObject> VmDisplayObjects
        {
            get { return CombatObjects.DisplayObjects; }
        }

        //public DisplayObject MySelectedObject
        //{
        //    get { return CombatObjects.CurrentSelectedObject; }
        //    set { CombatObjects.CurrentSelectedObject = value; }
        //}
        public DisplayObject MySelectedObject
        {
            get { return CurrentSelectedObject; }
            set { CurrentSelectedObject = value; }
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
            // test connections
            // also consider trying fqdn and an ip address resolution test
            // check network connectivity
            // write a log to the users view
            // communicate to host that a new connection is being made.
            //return; // remove this when ready.
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


            MyConnections.UpdateConnection("","");


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

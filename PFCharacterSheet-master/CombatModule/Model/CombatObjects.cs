using System;
using System.Collections.Generic;
using System.Linq;
using CharacterDataObjects;
using System.Collections.ObjectModel;
using CharacterDataObjects.CharacterDataConstants;

namespace CombatModule.Model
{    
    public static class CombatObjects
    {
        // The object that is currently selected in the view 
        public static DisplayObject CurrentSelectedObject = new DisplayObject();
        
        public static ObservableCollection<DisplayObject> displayObjects = GetDisplayObjects();
        
        public static ObservableCollection<DisplayObject> DisplayObjects { get { return displayObjects; } }
               
        private static ObservableCollection<DisplayObject> GetDisplayObjects()
        {
            var retval = new ObservableCollection<DisplayObject>();

            retval.Add(new DisplayObject
            {
                UserName = "Administrator",
                SiteName = "Tory Burch",
                MachineName = "tory-prod-us-wcs",
                MachineDescription = "WCS - PROD",
                DomainName = "TORY",
                IpAddress = "99.33.88.17",
                LastLoginUser = "Rusty Venture",
                LastLoginTimeStamp = DateTime.Now.ToString(),
                LastLogoutTimeStamp = DateTime.MaxValue.ToString(),
                LastLoginUserIp = "10.130.135.17",
                IsAvailable = "NO"
            });

            retval.Add(new DisplayObject
            {
                UserName = "Johnny Bravo",
                SiteName = "",
                MachineName = "tory-prod-us-wcs",
                MachineDescription = "WCS - TEST",
                DomainName = "TORY",
                IpAddress = "99.33.88.17",
                LastLoginUser = "Rusty Venture",
                LastLoginTimeStamp = DateTime.Now.ToString(),
                LastLogoutTimeStamp = DateTime.MaxValue.ToString(),
                LastLoginUserIp = "10.130.135.17",
                IsAvailable = "YES"
            });

            retval.Add(new DisplayObject
            {
                UserName = "Johnny Bravo",
                SiteName = "Gap Brampton",
                MachineName = "gap01-prod-us-wcs",
                MachineDescription = "WCS - PROD",
                DomainName = "USGAP",
                IpAddress = "10.30.15.32",
                LastLoginUser = "Rusty Venture",
                LastLoginTimeStamp = DateTime.Now.ToString(),
                LastLogoutTimeStamp = DateTime.MaxValue.ToString(),
                LastLoginUserIp = "10.130.135.17",
                IsAvailable = "NO"
            });

            retval.Add(new DisplayObject
            {
                UserName = "Brock Sampson",
                SiteName = "",
                MachineName = "gap01-prod-us-ts",
                MachineDescription = "TS - PROD",
                DomainName = "USGAP",
                IpAddress = "10.30.15.33",
                LastLoginUser = "Rusty Venture",
                LastLoginTimeStamp = DateTime.Now.ToString(),
                LastLogoutTimeStamp = DateTime.MaxValue.ToString(),
                LastLoginUserIp = "10.130.135.17",
                IsAvailable = "YES"
            });

            return retval;
        }

    }
}

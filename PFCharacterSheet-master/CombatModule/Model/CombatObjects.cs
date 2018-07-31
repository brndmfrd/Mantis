using System;
using System.Collections.Generic;
using System.Linq;
using ConnectionDataObjects;
using System.Collections.ObjectModel;
using CharacterDataObjects.CharacterDataConstants;

/// <summary>
/// The 
/// </summary>

namespace CombatModule.Model
{    
    public static class CombatObjects
    {            
        public static ObservableCollection<DisplayObject> displayObjects = new ObservableCollection<DisplayObject>();

        public static ObservableCollection<DisplayObject> DisplayObjects {
            get
            {
                if(displayObjects == null)
                {

                }
                return displayObjects;
            }
        }

        private static ObservableCollection<DisplayObject> GetDisplayObjects()
        {
            var retval = new ObservableCollection<DisplayObject>();

            return retval;
        }


        #region Private
        public static void RebuildDisplayObjects()
        {
            // Clear our observable collection
            displayObjects.Clear();

            foreach (var elem in MyConnections.AllRemoteUserAccounts)
            {
                displayObjects.Add(new DisplayObject
                {
                    Id = elem.Id,
                    UserName = elem.UserName,
                    SiteName = elem.SiteName,
                    MachineName = elem.MachineName,
                    MachineDescription = elem.MachineDescription,
                    DomainName = elem.DomainName,
                    IpAddress = elem.IpAddress,
                    LastLoginUser = elem.LastLoginUser,
                    LastLoginTimeStamp = elem.LastLoginTimeStamp,
                    LastLogoutTimeStamp = elem.LastLogoutTimeStamp,
                    LastLoginUserIp = elem.LastLoginUserIp,
                    IsAvailable = elem.IsAvailable
                });
            }
        }
        #endregion Private


    }
}

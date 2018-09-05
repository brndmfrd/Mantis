using System;
using System.Collections.Generic;
using System.Linq;
using Connections;
using System.Collections.ObjectModel;
using Connections.CharacterDataConstants;

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
                    UserName = elem.username,
                    SiteName = elem.sitename,
                    MachineName = elem.machinename,
                    MachineDescription = elem.machinedescription,
                    DomainName = elem.domainname,
                    IpAddress = elem.ipaddress,
                    LastLoginUser = elem.lastloginuser,
                    LastLoginTimeStamp = elem.lastlogintimestamp,
                    LastLogoutTimeStamp = elem.lastlogout,
                    LastLoginUserIp = elem.lastloginip,
                    IsAvailable = elem.isavailable
                });
            }
        }
        #endregion Private


    }
}

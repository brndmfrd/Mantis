using System;
using SharedResources.EventHandlers;
using System.Collections.Generic;

namespace CombatModule.Model
{
    // todo: maybe move this into ModuleTools since it is generic and all modules can use it to customize what they display
    public class DisplayObject : ObservableObject
    {
        public string _id;
        public string _userName;
        public string _siteName;
        public string _machineName;
        public string _machineDescription;
        public string _domainName;
        public string _ipAddress;
        public string _lastLoginUser;
        public string _lastLoginTimeStamp;
        public string _lastLogoutTimeStamp;
        public string _lastLoginUserIp;
        public string _isAvailable;

        // do we still need this? remove?
        public Func<string> CustomMethod;

        public string Id { get; set; }
        public string UserName { get { return _userName; } set { _userName = value; RaisePropertyChangedEvent("UserName"); } }
        public string SiteName { get { return _siteName; } set { _siteName = value; RaisePropertyChangedEvent("SiteName"); } }
        public string MachineName { get { return _machineName; } set { _machineName = value; RaisePropertyChangedEvent("MachineName"); } }
        public string MachineDescription { get { return _machineDescription; } set { _machineDescription = value; RaisePropertyChangedEvent("MachineDescription"); } }
        public string DomainName { get { return _domainName; } set { _domainName = value; RaisePropertyChangedEvent("DomainName"); } }
        public string IpAddress { get { return _ipAddress; } set { _ipAddress = value; RaisePropertyChangedEvent("IpAddress"); } }
        public string LastLoginUser { get { return _lastLoginUser; } set { _lastLoginUser = value; RaisePropertyChangedEvent("LastLoginUser"); } }
        public string LastLoginTimeStamp { get { return _lastLoginTimeStamp; } set { _lastLoginTimeStamp = value; RaisePropertyChangedEvent("LastLoginTimeStamp"); } }
        public string LastLogoutTimeStamp { get { return _lastLogoutTimeStamp; } set { _lastLogoutTimeStamp = value; RaisePropertyChangedEvent("LastLogoutTimeStamp"); } }
        public string LastLoginUserIp { get { return _lastLoginUserIp; } set { _lastLoginUserIp = value; RaisePropertyChangedEvent("LastLoginUserIp"); } }
        public string IsAvailable { get { return _isAvailable; } set { _isAvailable = value; RaisePropertyChangedEvent("IsAvailable"); } }
    }
}
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;        // refer to the regions of our view
using Archivist;
using System.Collections.Generic;
using CombatModule.Model;
using Newtonsoft.Json;
using ConnectionDataObjects;


namespace CombatModule
{
    public class CombatModule : IModule
    {
        private readonly IRegionManager regionManager;      // hold refrence to region manager

        public CombatModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            // --- Register the views for this module with the regions we want to associate them with
            regionManager.RegisterViewWithRegion("PrimaryContentRegion", typeof(Views.CombatViewPrimary));
            //regionManager.RegisterViewWithRegion("AuxContentRegion", typeof(Views.CombatViewAux));
            
            // Check our memory model. If it is empty we have not read our data file!
            if(MyConnections.AllRemoteUserAccounts.Count <= 0)
            {
                // So lets read that data file!

                Loader.GetRemoteUserAccountsFromFile();
            }



            // Triggers our model to rebuild itself from the Connection Data Objects that are propigated 
            // by the connections file.
            CombatObjects.RebuildDisplayObjects();

            // This is temporary for testing purposes
            //List<DisplayObject> ob = new List<DisplayObject>();
            //ob.Add(
            //    new DisplayObject
            //    {
            //        Id = "0000000000",
            //        UserName = "User0",
            //        SiteName = "Site0",
            //        MachineName = "Machine Name0",
            //        MachineDescription = "Machine Description0",
            //        DomainName = "Domain Name 0",
            //        IpAddress = "0.0.0.0",
            //        LastLoginUser = "Last User 0",
            //        LastLoginTimeStamp = "Last Login Timestamp",
            //        LastLoginUserIp = "Last User Ip",
            //        IsAvailable = "Yes"
            //    });
            //ob.Add(
            //    new DisplayObject
            //    {
            //        Id = "0000000001",
            //        UserName = "User1",
            //        SiteName = "Site1",
            //        MachineName = "Machine Name1",
            //        MachineDescription = "Machine Description1",
            //        DomainName = "Domain Name 1",
            //        IpAddress = "1.1.1.1",
            //        LastLoginUser = "Last User 1",
            //        LastLoginTimeStamp = "Last Login Timestamp",
            //        LastLoginUserIp = "Last User Ip",
            //        IsAvailable = "Yes"
            //    });
            //ob.Add(
            //    new DisplayObject
            //    {
            //        Id = "0000000002",
            //        UserName = "User2",
            //        SiteName = "Site2",
            //        MachineName = "Machine Name2",
            //        MachineDescription = "Machine Description2",
            //        DomainName = "Domain Name 2",
            //        IpAddress = "2.2.2.2",
            //        LastLoginUser = "Last User 2",
            //        LastLoginTimeStamp = "Last Login Timestamp",
            //        LastLoginUserIp = "Last User Ip",
            //        IsAvailable = "Yes"
            //    });

            //var jobj = JsonConvert.SerializeObject(ob, Formatting.None);

            //SaveCharacterFile.SaveConnectionAccounts(jobj);

        }
    }
}

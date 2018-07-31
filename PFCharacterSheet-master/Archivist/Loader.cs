using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using ConnectionDataObjects;
using ConnectionDataObjects.ConnectionDataElements;
using log4net;
using System.Collections.Generic;
using Archivist;


namespace Archivist
{
    public static class Loader
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Loader));


        /// <summary>
        /// Reads and parses the remote user accounts file and propagates the global data model 'MyConnections.AllRemoteUserAccounts'
        /// Intended to be called by any module that requires an update from the 'Remote User Accounts' file.
        /// </summary>
        /// <param name="value"></param>
        public static void GetRemoteUserAccountsFromFile()
        {
            // Try to get the file - It may be locked (in use)
            try
            {
                var remoteUserAccountsFile = Path.Combine(CurrentActiveConfig.ConfigurationDirectory, CurrentActiveConfig.RemoteUserAccountsFileName);

                if (!File.Exists(remoteUserAccountsFile))
                {
                    log.ErrorFormat($"This file does not exist! {remoteUserAccountsFile}");
                    return;
                }

                using (StreamReader sr = File.OpenText(remoteUserAccountsFile))
                {
                    while (!sr.EndOfStream)
                    {
                        // First line expected to be Skills
                        var line = sr.ReadLine();

                        try
                        {
                            // Out with the old...
                            MyConnections.AllRemoteUserAccounts.Clear();

                            // create a temp container
                            var x = new ObservableCollection<RemoteUserAccount>();

                            // fill our temp container
                            x = JsonConvert.DeserializeObject<ObservableCollection<RemoteUserAccount>>(line);

                            // worth noting that ObservableCollections will 'auto update' this way and not if you 
                            // directly assign to it; i.e.  Character.Skills = JsonConvert.DeserializeObject<ObservableCollection<Skill>>(line);
                            // we want to change our collection container, not replace it.
                            foreach (var elem in x)
                            {
                                MyConnections.AllRemoteUserAccounts.Add(elem);
                            }
                        }
                        catch (Exception ex)
                        {
                            log.ErrorFormat("Error when parsing line for AllRemoteUserAccounts. \n{0}\n{1}", line, ex);
                            // TODO -- consider -- : Notify user that the character data may be incomplete.
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Failure to read from selected character file.\n{0}", ex);
                // log an error has occured in loading of charcter file
                // notify user that the file may be locked and to close any currently open instance of the file
            }
        }
    }
}

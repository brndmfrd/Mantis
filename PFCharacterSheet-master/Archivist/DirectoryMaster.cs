using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Archivist
{
    /// <summary>
    /// Use this class for any manipulation of the host directory structure.
    /// For information specific to directory configuration, see: Archivist.CurrentActiveConfig.cs.
    /// </summary>
    public static class DirectoryMaster
    {
        private const string filenamePattern = @"[^\\]+\.json$";
        private static Regex rgx;
        private static ObservableCollection<string> directoryFileList = new ObservableCollection<string>();
        
        public static ObservableCollection<string> DirectoryFileList { get { if (directoryFileList.Count <= 0) { GetFilesFromDefaultDir(); } return directoryFileList; } }

        /// <summary>
        /// Look into the default dir and return all .pf files.
        /// </summary>
        /// <returns></returns>
        public static void GetFilesFromDefaultDir()
        {

            var cdir = Directory.GetCurrentDirectory();             // Target local directory

            var pfFiles = Directory.GetFiles(cdir, "*.json");         // Target .json files

            directoryFileList.Clear();

            // There are no *.json files!
            if (pfFiles.Length == 0)
            {
                directoryFileList.Insert(0, "No files could be found");
            }

            rgx = new Regex(filenamePattern, RegexOptions.RightToLeft);

            for (int i = 0; i < pfFiles.Length; i++)
            {
                directoryFileList.Insert(i, rgx.Match(pfFiles[i]).Value);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connections
{
    public static class NetConfig
    {
        // TODO: user Archivist to read this from a config file.
        public static string HostTargetIp = "192.168.1.24";
        public static string HostTargetPort = "8000";
        public static string ApiUpdateConnection = "api/updateconnection";

        // Expected to look like this: http://192.168.1.24:8000/api/updateconnection
        public static string HostTargetUrlFq { get { return $"http://{HostTargetIp}:{HostTargetPort}/{ApiUpdateConnection}"; } }


        public static string LocalIp = "192.168.1.1";
    }
}

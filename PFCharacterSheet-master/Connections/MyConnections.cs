using System.Collections.Generic;
using Connections.CharacterDataConstants;
using Connections.ConnectionDataElements;
using System;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using System.IO;


namespace Connections
{
    /// <summary>
    ///  
    /// </summary>
    public class MyConnections
    {
        #region Private
        #endregion Private

        #region Public
        public static  List<RemoteUserAccount> AllRemoteUserAccounts = new List<RemoteUserAccount>();


        /// <summary>
        /// Sends a POST to the specified target URL.
        /// Expected to be used when established a new rdp connection.
        /// </summary>
        /// <param name="targetUrl">Target URL where REST service lives. e.g. http://192.168.1.24:8000/api/updateconnection </param>
        /// <param name="jsonBody">Full, json string converted, body. e.g. {"username":"Administrator", ... ,"isavailable":"YES"}</param>
        public static void UpdateConnection(string targetUrl, string jsonBody)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(targetUrl);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = jsonBody.Length;
            using (Stream webStream = request.GetRequestStream())
            using (StreamWriter requestWriter = new StreamWriter(webStream, Encoding.ASCII))
            {
                requestWriter.Write(jsonBody);
            }

            try
            {
                WebResponse webResponse = request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // TODO: fix this
            }
        }
        #endregion Public



    }
}

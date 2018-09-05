namespace Connections.ConnectionDataElements
{
    /// <summary>
    /// Hey Listen!
    /// Ensure this always matches what our database expects.
    /// See the web api: ~/WebHost/models/post.js (Sept 2018)
    /// </summary>
    public class RemoteUserAccount
    {
        public string username { get; set; }
        public string sitename { get; set; }
        public string machinename { get; set; }
        public string machinedescription { get; set; }
        public string domainname { get; set; }
        public string ipaddress { get; set; }
        public string lastloginuser { get; set; }
        public string lastlogintimestamp { get; set; }
        public string lastloginip { get; set; }
        public string lastlogout { get; set; }
        public string isavailable { get; set; }
    }
}

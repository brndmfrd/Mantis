namespace ConnectionDataObjects.ConnectionDataElements
{
    public class RemoteUserAccount
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string SiteName { get; set; }
        public string MachineName { get; set; }
        public string MachineDescription { get; set; }
        public string DomainName { get; set; }
        public string IpAddress { get; set; }
        public string LastLoginUser { get; set; }
        public string LastLoginTimeStamp { get; set; }
        public string LastLogoutTimeStamp { get; set; }
        public string LastLoginUserIp { get; set; }
        public string IsAvailable { get; set; }
    }
}

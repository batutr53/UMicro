﻿namespace UMicro.Web.Models
{
    public class ServiceApiSettings
    {
        public string IdentityBaseUri { get; set; }
        public string GatewayBaseUri { get; set; }
        public string PhotoStockU { get; set; }
        public ServiceApi Catalog { get; set; }
    }


    public class ServiceApi 
    {
        public string Path { get; set; }
    }
}

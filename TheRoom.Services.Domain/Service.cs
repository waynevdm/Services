using System;
using System.Collections.Generic;
using System.Text;

namespace TheRoom.Services.Domain
{
    /// <summary>
    /// The main service class used in persistence and exposed by the api
    /// </summary>
    public class Service
    {
        public int ServiceID { get; set; }
        public string Description { get; set; }
        public string PromoCode { get; set; }
    }
}

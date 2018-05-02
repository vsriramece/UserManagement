using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Rebtel.UserManagement.Infrastructure.DTO.Response
{
    [DataContract]
    public class UserData
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string Lastname { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public List<SubscriptionData> Subscriptions { get; set; }
        [DataMember]
        public double TotalPriceIncVatAmount { get; set; }
        [DataMember]
        public int Totalcallminutes { get; set; }
    }
}

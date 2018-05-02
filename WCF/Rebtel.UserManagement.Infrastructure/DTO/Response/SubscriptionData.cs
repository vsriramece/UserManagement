using System;
using System.Runtime.Serialization;

namespace Rebtel.UserManagement.Infrastructure.DTO.Response
{
    [DataContract]
    public class SubscriptionData
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public int Callminutes { get; set; }
        [DataMember]
        public double PriceIncVatAmount { get; set; }
    }
}

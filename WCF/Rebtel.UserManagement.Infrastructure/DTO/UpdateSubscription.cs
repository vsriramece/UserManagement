using System;
using System.Runtime.Serialization;

namespace Rebtel.UserManagement.Infrastructure.DTO
{
    [DataContract]
    public class UpdateSubscription
    {
        [DataMember]
        public Guid SubcriptionId { get; set; }
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

using System;
using System.Runtime.Serialization;

namespace Rebtel.UserManagement.Infrastructure.DTO
{
    [DataContract]
    public class AddSubcriptionToUser
    {
        [DataMember]
        public Guid UserId { get; set; }
        [DataMember]
        public Guid SubscriptionId { get; set; }
    }
}

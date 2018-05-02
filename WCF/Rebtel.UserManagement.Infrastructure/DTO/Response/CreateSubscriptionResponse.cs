using System;
using System.Runtime.Serialization;

namespace Rebtel.UserManagement.Infrastructure.DTO.Response
{
    [DataContract]
    public class CreateSubscriptionResponse
    {
        [DataMember]
        public Guid Id { get; set; }
    }
}

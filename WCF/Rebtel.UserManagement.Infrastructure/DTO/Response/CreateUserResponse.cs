using System;
using System.Runtime.Serialization;

namespace Rebtel.UserManagement.Infrastructure.DTO.Response
{
    [DataContract]
    public class CreateUserResponse
    {
        [DataMember]
        public Guid Id { get; set; }
    }
}

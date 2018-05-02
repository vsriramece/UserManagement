using System.Runtime.Serialization;

namespace Rebtel.UserManagement.Infrastructure.DTO
{
    [DataContract]
    public class CreateUser
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string Lastname { get; set; }
        [DataMember]
        public string Email { get; set; }
    }
}

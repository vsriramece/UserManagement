using System.Runtime.Serialization;

namespace Rebtel.UserManagement.Infrastructure.DTO
{
    public class CreateSubcription
    {
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

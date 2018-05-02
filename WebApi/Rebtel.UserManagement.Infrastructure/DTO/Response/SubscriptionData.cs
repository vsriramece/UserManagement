using System;

namespace Rebtel.UserManagement.Infrastructure.DTO.Response
{
    public class SubscriptionData
    {
        public Guid Id { get; set; }
        public double Price { get; set; }
        public int Callminutes { get; set; }
        public double PriceIncVatAmount { get; set; }
    }
}

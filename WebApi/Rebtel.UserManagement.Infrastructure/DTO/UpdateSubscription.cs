using System;

namespace Rebtel.UserManagement.Infrastructure.DTO
{
    public class UpdateSubscription
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Callminutes { get; set; }
        public double PriceIncVatAmount { get; set; }
    }
}

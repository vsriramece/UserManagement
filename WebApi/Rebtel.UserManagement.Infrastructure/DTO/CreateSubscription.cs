using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebtel.UserManagement.Infrastructure.DTO
{
    public class CreateSubscription
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Callminutes { get; set; }
        public double PriceIncVatAmount { get; set; }
    }
}

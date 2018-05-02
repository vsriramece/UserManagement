using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebtel.UserManagement.Infrastructure.DTO.Response
{
    public class UserData
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public List<SubscriptionData> Subscriptions { get; set; }
        public double TotalPriceIncVatAmount { get; set; }
        public int Totalcallminutes { get; set; }
    }
}

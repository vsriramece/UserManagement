using System;

namespace Rebtel.UserManagement.Domain.Entities
{
    public class Subscription
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Callminutes { get; set; }
        public double PriceIncVatAmount { get; set; }

        public virtual User User{get;set;}

        public void Initialize(string name, double price, double priceIncVatAmount, int callminutes)
        {
            // Domain validations
            if (string.IsNullOrWhiteSpace(name))
            {
                // This can be a custom exception
                throw new ArgumentException("Name cannot be empty.");
            }
            // Do we need validations for price/callminutes?

            Name = name;
            Price = price;
            PriceIncVatAmount = priceIncVatAmount; // Should this be a calculated value?
            Callminutes = callminutes;
        }

        public void Delete()
        {
            //No behavior as of now.
            // In future, this can be used to emit events on deletion to other systems
        }

        public void Update(string name, double price, double priceIncVatAmount, int callminutes)
        {
            // As of now, Initialize and update behaviors look same, but in future this can be extended.
            Initialize(name, price, priceIncVatAmount, callminutes);

        }
    }
}

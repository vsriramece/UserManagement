using Rebtel.Common.Validators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rebtel.UserManagement.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public virtual List<Subscription> Subscriptions { get; set; } = new List<Subscription>();

        /// <summary>
        /// Computed field
        /// </summary>
        public double TotalPriceIncVatAmount => Subscriptions?.Sum(o=>o.PriceIncVatAmount) ?? 0;
        /// <summary>
        /// Computed field
        /// </summary>
        public int Totalcallminutes => Subscriptions?.Sum(o => o.Callminutes) ?? 0;

        public User()
        {
            
        }
        #region Behaviors
        public void Initialize(string firstName, string lastName, string email)
        {
            // Domain validations
            if(string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                // This can be a custom exception
                throw new ArgumentException("Firstname or Lastname cannot be empty.");
            }
            if(!Validators.IsValidEmail(email))
            {
                throw new ArgumentException("Email is in invalid format.");
            }
            FirstName = firstName;
            Lastname = lastName;
            Email = email;
        }

        public void Delete()
        {
            // This will just clear the subscription association from User but not delete the subscriptions - Is this the intended behavior?
            Subscriptions?.Clear();
        }

        public void AddSubscription(Subscription subscription)
        {
            if(Subscriptions == null)
            {
                Subscriptions = new List<Subscription>();
            }
            Subscriptions.Add(subscription);
        }

        #endregion
    }
}

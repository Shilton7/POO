﻿using Balta.NotificationContext;
using Balta.SharedContext;
using System.Collections.Generic;
using System.Linq;

namespace Balta.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public string  Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }

        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "O Aluno já possui uma conta ativa"));
                return;
            }

            Subscriptions.Add(subscription);

        }
    }
}

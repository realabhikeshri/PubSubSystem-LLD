using PubSubSystem_LLD.Domain.Entities;
using PubSubSystem_LLD.Domain.Interfaces;
using PubSubSystem_LLD.Services.Broker;
using PubSubSystem_LLD.Services.Subscriber;
using System;
using System.Threading;

namespace PubSubSystem.Application
{
    public class DemoRunner
    {
        public static void Run()
        {
            var broker = new MessageBroker();

            broker.CreateTopic("orders");
            broker.CreateTopic("payments");

            ISubscriber emailService = new EmailSubscriber("EmailService");
            ISubscriber smsService = new SmsSubscriber("SmsService");

            broker.Subscribe("orders", emailService);
            broker.Subscribe("orders", smsService);
            broker.Subscribe("payments", emailService);

            broker.Publish("orders", new Message("Order #123 created"));
            broker.Publish("payments", new Message("Payment received for Order #123"));

            Thread.Sleep(1000); // allow async processing
        }
    }
}
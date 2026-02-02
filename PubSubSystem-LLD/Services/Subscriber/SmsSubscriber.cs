using PubSubSystem_LLD.Domain.Entities;
using PubSubSystem_LLD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubSystem_LLD.Services.Subscriber
{
    public class SmsSubscriber : ISubscriber
    {
        public string Id { get; }

        public SmsSubscriber(string id)
        {
            Id = id;
        }

        public void Consume(Message message)
        {
            Console.WriteLine($"[SMS] {Id} received: {message.Payload}");
        }
    }
}

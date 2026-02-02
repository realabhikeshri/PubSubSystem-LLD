using PubSubSystem_LLD.Domain.Entities;
using PubSubSystem_LLD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubSystem_LLD.Services.Subscriber
{
    public class EmailSubscriber : ISubscriber
    {
        public string Id { get; }

        public EmailSubscriber(string id)
        {
            Id = id;
        }

        public void Consume(Message message)
        {
            Console.WriteLine($"[EMAIL] {Id} received: {message.Payload}");
        }
    }
}

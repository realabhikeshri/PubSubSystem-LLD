using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubSystem_LLD.Domain.Entities
{
    public class Message
    {
        public string Id { get; }
        public string Payload { get; }
        public DateTime CreatedAt { get; }

        public Message(string payload)
        {
            Id = Guid.NewGuid().ToString();
            Payload = payload;
            CreatedAt = DateTime.UtcNow;
        }
    }
}

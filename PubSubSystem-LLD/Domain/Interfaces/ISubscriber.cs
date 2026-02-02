using PubSubSystem_LLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubSystem_LLD.Domain.Interfaces
{
    public interface ISubscriber
    {
        string Id { get; }
        void Consume(Message message);
    }
}

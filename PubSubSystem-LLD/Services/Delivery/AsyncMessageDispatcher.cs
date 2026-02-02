using PubSubSystem_LLD.Domain.Entities;
using PubSubSystem_LLD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubSystem_LLD.Services.Delivery
{
    public class AsyncMessageDispatcher
    {
        public void Dispatch(ISubscriber subscriber, Message message)
        {
            Task.Run(() =>
            {
                subscriber.Consume(message);
            });
        }
    }
}

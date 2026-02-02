using PubSubSystem_LLD.Domain.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubSystem_LLD.Domain.Entities
{
    public class Topic
    {
        public string Name { get; }

        private readonly ConcurrentDictionary<string, ISubscriber> _subscribers =
            new ConcurrentDictionary<string, ISubscriber>();

        public Topic(string name)
        {
            Name = name;
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            _subscribers[subscriber.Id] = subscriber;
        }

        public void RemoveSubscriber(string subscriberId)
        {
            _subscribers.TryRemove(subscriberId, out _);
        }

        public IEnumerable<ISubscriber> GetSubscribers()
        {
            return _subscribers.Values;
        }
    }
}

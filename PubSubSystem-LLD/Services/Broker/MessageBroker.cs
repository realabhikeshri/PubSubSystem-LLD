using PubSubSystem_LLD.Domain.Entities;
using PubSubSystem_LLD.Domain.Interfaces;
using PubSubSystem_LLD.Services.Delivery;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubSystem_LLD.Services.Broker
{
    public class MessageBroker : IPublisher
    {
        private readonly ConcurrentDictionary<string, Topic> _topics =
            new ConcurrentDictionary<string, Topic>();

        private readonly AsyncMessageDispatcher _dispatcher = new();

        public void CreateTopic(string topicName)
        {
            _topics.TryAdd(topicName, new Topic(topicName));
        }

        public void Subscribe(string topicName, ISubscriber subscriber)
        {
            if (_topics.TryGetValue(topicName, out var topic))
            {
                topic.AddSubscriber(subscriber);
            }
        }

        public void Unsubscribe(string topicName, string subscriberId)
        {
            if (_topics.TryGetValue(topicName, out var topic))
            {
                topic.RemoveSubscriber(subscriberId);
            }
        }

        public void Publish(string topicName, Message message)
        {
            if (_topics.TryGetValue(topicName, out var topic))
            {
                foreach (var subscriber in topic.GetSubscribers())
                {
                    _dispatcher.Dispatch(subscriber, message);
                }
            }
        }
    }
}

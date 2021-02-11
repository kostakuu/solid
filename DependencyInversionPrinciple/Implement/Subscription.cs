using System.Collections.Generic;
using System.Linq;

namespace DependencyInversionPrinciple.Implement
{
    public class Subscription
    {
        private readonly IEnumerable<IChannel> _channels;

        public Subscription(IEnumerable<IChannel> channels)
        {
            _channels = channels;
        }

        public void SendNotifications()
        {
            _channels
                .ToList()
                .ForEach(channel => channel.SendNotification());
        }
    }
}
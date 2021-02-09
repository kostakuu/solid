namespace DependencyInversionPrinciple.Implement
{
    public class PushChannel : IChannel
    {
        public int DeviceId { get; set; }
        public string Content { get; set; }

        public void SendNotification()
        {
            // Sending a push notification to the device
        }
    }
}
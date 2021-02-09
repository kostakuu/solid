namespace DependencyInversionPrinciple.Avoid
{
    public class PushChannel
    {
        public int DeviceId { get; set; }
        public string Content { get; set; }

        public void SendPushNotification()
        {
            // Sending a push notification to the device
        }
    }
}
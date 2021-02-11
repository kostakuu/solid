namespace DependencyInversionPrinciple.Avoid
{
    public class Subscription
    {
        private readonly PushChannel _pushChannel;
        private readonly EmailChannel _emailChannel;

        public Subscription(PushChannel pushChannel, EmailChannel emailChannel)
        {
            _pushChannel = pushChannel;
            _emailChannel = emailChannel;
        }

        public void SendNotification()
        {
            _pushChannel.SendPushNotification();
            _emailChannel.SendEmailNotification();
        }
    }
}
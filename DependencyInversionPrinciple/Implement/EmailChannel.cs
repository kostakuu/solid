namespace DependencyInversionPrinciple.Implement
{
    public class EmailChannel : IChannel
    {
        public string EmailAddress { get; set; }
        public string Content { get; set; }

        public void SendNotification()
        {
            // Sending an email to to the subscriber
        }
    }
}
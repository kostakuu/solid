namespace DependencyInversionPrinciple.Avoid
{
    public class EmailChannel
    {
        public string EmailAddress { get; set; }
        public string Content { get; set; }

        public void SendEmailNotification()
        {
            // Sending an email to to the subscriber
        }
    }
}
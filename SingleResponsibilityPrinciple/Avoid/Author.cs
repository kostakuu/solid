namespace SingleResponsibilityPrinciple.Avoid
{
    public class Author
    {
        public string FullName { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }

        public void Login()
        {
            // Implementation of login
        }

        public void Logout()
        {
            // Implementation of logout
        }

        public void PublishPost()
        {
            // Implementation of publishing a new post
        }

        public void EditOrDeletePost()
        {
            // Implementation of editing a new post
        }
    }
}
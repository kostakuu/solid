using System;

namespace OpenClosedPrinciple.Avoid
{
    public class PostService
    {
        public void PublishPost(Post post)
        {
            if (post.Type == PostType.Standard)
            {
                // implementation of publishing a standard post
            }
            else if (post.Type == PostType.Video)
            {
                // implementation of publishing a video post
            }
            else if (post.Type == PostType.Status)
            {
                // implementation of publishing a status post
            }

            throw new Exception("Type not supported");
        }
    }
}
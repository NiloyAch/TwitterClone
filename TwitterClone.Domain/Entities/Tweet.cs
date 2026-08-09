

namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        private Guid _userId;
        private Guid _tweetId;
        private string _content;
        public Guid Id 
        { 
            get { return _userId; } 
        }

        public Guid AuthorId
        {
            get { return _tweetId; }
        }

        public string Content
        {  get { return _content; } 

            set { _content = value; }
        }
    }
}

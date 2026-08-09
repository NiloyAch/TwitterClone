namespace TwitterClone.Domain.Entities
{
    public class Bookmark
    {
        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _bookmarkedAt;

        public Bookmark()
        {
            _id = Guid.NewGuid();
            _bookmarkedAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
        }

        public DateTime BookmarkedAt
        {
            get { return _bookmarkedAt; }
        }
    }
}
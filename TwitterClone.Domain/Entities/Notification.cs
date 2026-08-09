namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        private Guid _id;
        private Guid _userId;
        private Guid _fromUserId;
        private string _type;
        private Guid? _tweetId;
        private bool _isRead;
        private DateTime _createdAt;

        public Notification()
        {
            _id = Guid.NewGuid();
            _isRead = false;
            _createdAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public Guid FromUserId
        {
            get { return _fromUserId; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Guid? TweetId
        {
            get { return _tweetId; }
            set { _tweetId = value; }
        }

        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
    }
}
using TwitterClone.Domain.Entities;

namespace TwitterClone.Domain.Entities
{
    public class Like
    public class Like : BaseEntity
    {
        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _createdAt;
        private DateTime _modifiedAt;
        private Guid _createdBy;
        private Guid _modifiedBy;

        public Like()
        public Like() : base(Guid.NewGuid())
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid UserId
            set { _tweetId = value; }
}

    public DateTime CreatedAt
    {
        get { return _createdAt; }
    }

    public DateTime ModifiedAt
    {
        get { return _modifiedAt; }
        set { _modifiedAt = value; }
    }

    public Guid CreatedBy
    {
        get { return _createdBy; }
        set { _createdBy = value; }
    }

    public Guid ModifiedBy
            public override string DescribeRecord()
    {
        get { return _modifiedBy; }
        set { _modifiedBy = value; }
        var baseRecord = base.DescribeRecord();
        return $"{baseRecord}, UserId: {UserId}, TweetId: {TweetId}";
    }

        }
}
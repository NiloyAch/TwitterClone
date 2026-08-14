namespace TwitterClone.Domain.Entities
{
    public class Follow
    public class Follow : BaseEntity
    {
        private Guid _id;
        private Guid _followerId;
        private Guid _followingId;
        private DateTime _createdAt;
        private DateTime _modifiedAt;

        public Follow()

        public Follow() : base(Guid.NewGuid())
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid FollowerId
        {
            get { return _followerId; }
            set { _followerId = value; }
        }

        public Guid FollowingId
        {
            get { return _followingId; }
            set { _followingId = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }

        public Guid ModifiedBy

        public override string DescribeRecord()
        {
            get { return _modifiedAt; }
            set { _modifiedAt = value; }

            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, FollowerId: {FollowerId}, FollowingId: {FollowingId}";
            
        }

    }
}

using System.Reflection.Metadata;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Domain.Entities
{
    public class Tweet
    public class Tweet : BaseEntity
    {
        private Guid _id;
        private Guid _userId;
        private string _content;
        private DateTime _createdAt;
        private DateTime _modifiedAt;
        private Guid _createdBy;
        private Guid _modifiedBy;


        public Tweet()
        public Tweet(string content) : base(Guid.NewGuid())
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
            _content = content;
        }

        public Guid UserId
            set { _content = value; }
}

        public DateTime CreatedAt
                public override string DescribeRecord()
        {
            get { return _createdAt; }
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, UserId: {UserId}, Content: {Content}";
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
        {
            get { return _modifiedBy; }
            set { _modifiedBy = value; }
        }

    }
}
namespace TwitterClone.Domain.Entities
{
    public class Notification
    public class Notification : BaseEntity
    {
        private Guid _id;
        private Guid _userId;
        private string _type;
        private string _message;
        private bool _isRead;
        private DateTime _createdAt;
        private DateTime _modifiedAt;
        private Guid _createdBy;
        private Guid _modifiedBy;


        public Notification()
        public Notification(string notificationType) : base(Guid.NewGuid())
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
            _type = notificationType;
        }


        public Guid UserId
        {
            set { _type = value; }
        }

        public string Message
        protected string Message
        {
            get { return _message; }
            set { _message = value; }
            set { _isRead = value; }
        }

        public DateTime CreatedAt
        public override string DescribeRecord()
        {
            get { return _createdAt; }
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, UserId: {UserId}, Type: {Type}, Message: {Message}, IsRead: {IsRead}";
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
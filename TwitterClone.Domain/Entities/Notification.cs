namespace TwitterClone.Domain.Entities
{
    public abstract class Notification : BaseEntity
    {
        private Guid _id;
        private Guid _userId;
        private string _type;
        private string _message = " ";
        private bool _isRead;
        private DateTime _createdAt;
        private DateTime _modifiedAt;
        private Guid _createdBy;
        private Guid _modifiedBy;

        protected Notification(string notificationType) : base(Guid.NewGuid())
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
            _type = notificationType;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Type
        {
            get { return _type; }
        }

        protected string Message
        {
            get { return _message; }
            set { _message = value; }
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

        public string GetNotificationInfo()
        {
            return $"UserId: {_userId}, NotificationType: {_type}";
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, UserId: {UserId}, Type: {Type}, Message: {Message}, IsRead: {IsRead}";
        }

        public abstract string GetMessage();
    }
}
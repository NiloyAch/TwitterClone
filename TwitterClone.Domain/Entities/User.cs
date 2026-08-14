namespace TwitterClone.Domain.Entities
{
    public class User
    public class User : BaseEntity
    {
        private Guid _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private DateTime _createdAt;
        private DateTime _modifiedAt;
        private Guid _createdBy;
        private Guid _modifiedBy;

        public User()
        public User() : base(Guid.NewGuid())
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        private string _firstName;
        private string _lastName;
        private string _email;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public DateTime ModifiedAt
        public string LastName
        {
            get { return _modifiedAt; }
            set { _modifiedAt = value; }
            get { return _lastName; }
            set { _lastName = value; }
        }

        public Guid CreatedBy
        public string Email
        {
            get { return _createdBy; }
            set { _createdBy = value; }
            get { return _email; }
            set { _email = value; }
        }

        public Guid ModifiedBy
        public override string DescribeRecord()
        {
            get { return _modifiedBy; }
            set { _modifiedBy = value; }
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, FirstName: {FirstName}, LastName: {LastName}, Email: {Email}";
        }

    }
}
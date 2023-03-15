namespace RestForCD2.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public void ValidateName()
        {
            if (Name == null)
            {
                throw new ArgumentNullException(nameof(Name));
            }
            if (Name.Length == 0)
            {
                throw new ArgumentException("Value cannot be empty", nameof(Name));
            }
        }
  
        public void Validate()
        {
            ValidateName();
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}

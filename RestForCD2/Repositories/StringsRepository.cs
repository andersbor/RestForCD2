namespace RestForCD2.Repositories
{
    public class StringsRepository
    {
        private readonly List<string> _strings = new() { "Hello", "World" };

        public void Add(string? value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            /*if (value.Length == 0)
            {
                throw new ArgumentException("Value cannot be empty", nameof(value));
            }*/
            _strings.Add(value);
        }

        public IEnumerable<string> GetAll()
        {
            return new List<string>(_strings);
        }
    }
}

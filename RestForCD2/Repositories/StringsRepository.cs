namespace RestForCD2.Repositories
{
    public class StringsRepository
    {
        private readonly List<string> _strings = new() { "Hello", "World" };

        public void Add(string value)
        {
            _strings.Add(value);
        }

        public IEnumerable<string> GetAll()
        {
            return new List<string>(_strings);
        }
    }
}

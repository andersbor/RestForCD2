using RestForCD2.Models;

namespace RestForCD2.Repositories
{
    public class TeachersRepository
    {
        private static int _nextId = 1;
        private static readonly List<Teacher> _teachers = new() {
          new Teacher { Id = _nextId++, Name = "John" },
          new Teacher { Id = _nextId++, Name = "Jane" }
        };

        public Teacher Add(Teacher value)
        {
            value.Validate();
            value.Id = _nextId++;
            _teachers.Add(value);
            return value;
        }

        public IEnumerable<Teacher> Get(string? name = null)
        {
            if (name != null)
            {
                return _teachers.Where(s => s.Name!= null && s.Name.Contains(name));
            }
            return new List<Teacher>(_teachers);
        }

        public Teacher? GetById(int id)
        {
            return _teachers.FirstOrDefault(t => t.Id == id);
        }
    }
}
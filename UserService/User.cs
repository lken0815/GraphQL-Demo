using System.Collections.Generic;

namespace UserService
{
    public class User
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<string> OwnedBookIds { get; set; }

        public IEnumerable<int> TestNumbers { get; set; }
    }
}

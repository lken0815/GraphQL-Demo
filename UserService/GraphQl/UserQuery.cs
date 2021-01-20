using System.Collections.Generic;

namespace UserService.GraphQl
{
    public class UserQuery
    {
        public IEnumerable<User> GetUsers(IEnumerable<string> userIds)
        {
            var result = new List<User>();

            foreach (var ids in userIds)
            {
                result.Add(
                    new User()
                    {
                        Id = ids,
                        Name = $"Test-{ids}",
                        OwnedBookIds = new[] { "Book1", "Book2", "Book3" },
                        TestNumbers = new[] { 1, 2, 3, 4, },
                    });
            }

            return result;
        }

        public User GetUser(string userId)
        {
            return new User()
            {
                Id = userId,
                Name = $"Test-{userId}",
                OwnedBookIds = new[] { "Book1", "Book2", "Book3" },
                TestNumbers = new[] { 1, 2, 3, 4, },
            };
        }
    }
}

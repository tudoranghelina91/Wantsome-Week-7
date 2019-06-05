using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndPosts.Classes;

namespace UsersAndPosts
{
    class Program
    {
        static void Main(string[] args)
        {
            const string USERS = "users.json";
            const string POSTS = "posts.json";

            var users = ReadUsers(USERS);
            var posts = ReadPosts(POSTS);

            // 1 - all users ending with .NET
            var users1 = from u in users
                         where u.Email.EndsWith(".net")
                         select u;

            var users2 = users.Where(x => x.Email.EndsWith(".net"));
            var emails = users.Select(x => x.Email.EndsWith(".net"));

            // 2 - find all posts for users having email ending with ".net"

            var posts1 = from post in posts
                         join user in users
                         on post.UserId equals user.Id
                         where user.Email.EndsWith(".net")
                         select post;

            foreach (var p in posts1)
            {
                Console.WriteLine($"ID: {p.Id}");
                Console.WriteLine();
                Console.WriteLine($"ID: {p.Title}");
                Console.WriteLine();
                Console.WriteLine($"Body: {p.Body}");
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        private static List<Post> ReadPosts(string file)
        {
            return JSONDataHandler.ReadFrom<Post>(file);
        }

        private static List<User> ReadUsers(string file)
        {
            return JSONDataHandler.ReadFrom<User>(file);
        }
    }

}

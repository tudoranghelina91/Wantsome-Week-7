namespace Week07.Linq
{
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using Setup;
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var allUsers = ReadUsers("users.json");
            var allPosts = ReadPosts("posts.json");

            // 1 - find all users having email ending with ".net".
            var users1 = from u in allUsers
                         where u.Email.EndsWith(".net")
                         select u;

            var users2 = allUsers.Where(x => x.Email.EndsWith(".net"));

            var emails = allUsers.Select(x => x.Email).ToList();

            // 2 - find all posts for users having email ending with ".net".
            var postsUserEndingInNet = from p in allPosts
                                       join u in allUsers
                                       on p.UserId equals u.Id
                                       where u.Email.EndsWith(".net")
                                       select new
                                       {
                                           u.Name,
                                           u.Email,
                                           p.Id,
                                           p.Title,
                                           p.Body
                                       };

            Console.WriteLine("Posts of users with email ending in .net");
            foreach (var p in postsUserEndingInNet)
            {
                Console.WriteLine("===========================================");
                Console.WriteLine($"Username: {p.Name}");
                Console.WriteLine($"Email: {p.Email}");
                Console.WriteLine($"PostID: {p.Id}");
                Console.WriteLine($"Post Title: {p.Title}");
                Console.WriteLine("===========================================");
                Console.WriteLine($"{p.Body}");
                Console.WriteLine();
            }

            // 3 - print number of posts for each user.

            Console.WriteLine("Users with number of posts: ");
            //Dictionary<int, int> userPostCount = new Dictionary<int, int>();
            //foreach (var post in allPosts)
            //{
            //    var userId = post.UserId;
            //    if(userPostCount.ContainsKey(userId))
            //    {
            //        userPostCount[userId]++;
            //    }

            //    else
            //    {
            //        userPostCount.Add(userId, 1);
            //    }
            //}

            //foreach (var p in userPostCount)
            //{
            //    Console.WriteLine(p);
            //}

            var result = allPosts.GroupBy(p => p.UserId)
                    .Select(g => new
                    {
                        UserId = g.Key,
                        NumberOfPosts = g.Count()
                    });

            foreach (var x in result)
            {
                Console.WriteLine($"UID: {x.UserId}");
                Console.WriteLine($"POSTS: {x.NumberOfPosts}");
            }

            // 4 - find all users that have lat and long negative.
            Console.WriteLine("Users with negative long and lat");
            var userslatlongneg = from user in allUsers
                                  where user.Address.Geo.Lat[0] == '-' && user.Address.Geo.Lng[0] == '-'
                                  select user;

            foreach (var user in userslatlongneg)
            {
                Console.WriteLine(user.Name);
                Console.WriteLine(user.Address.Geo.Lat);
                Console.WriteLine(user.Address.Geo.Lng);
            }


            // 5 - find the post with longest body.
            var longestpost = from p in allPosts
                        orderby p.Body.Length descending
                        select p;

            Console.WriteLine("Longest Post");
            var thelongestpost = longestpost.First();
            Console.WriteLine($"POST ID: {thelongestpost.Id}");
            Console.WriteLine(thelongestpost.Body);

            // 6 - print the name of the employee that have post with longest body.
            var employeeWithLongestBody = from p in allPosts
                                           join u in allUsers
                                           on p.UserId equals u.Id
                                           orderby p.Body.Length descending
                                           select new
                                           {
                                               u.Name,
                                               u.Email,
                                               p.Id,
                                               p.Title,
                                               p.Body
                                           };

            Console.WriteLine("EMPLOYEE WITH LONGEST POST:");
            Console.WriteLine(employeeWithLongestBody.First().Name);

            // 7 - select all addresses in a new List<Address>. print the list.
            IEnumerable<Address> addresses = new List<Address>();
            addresses = from address in allUsers
                        select address.Address;

            Console.WriteLine("LIST OF ADDRESSES:");
            foreach (Address address in addresses)
            {
                Console.WriteLine("===============================");
                Console.WriteLine($"City: {address.City}");
                Console.WriteLine($"Street: {address.Street}");
                Console.WriteLine($"Suite: {address.Suite}");
                Console.WriteLine($"ZIP: {address.Zipcode}");
                Console.WriteLine();
            }


            // 8 - print the employee with min lat
            var employeeMinLat = from u in allUsers
                                 orderby u.Address.Geo.Lat
                                 select u;


            Console.WriteLine("Employee Minimum lat");
            Console.WriteLine(employeeMinLat.First().Name);
            Console.WriteLine(employeeMinLat.First().Address.Geo.Lat);


            // 9 - print the employee with max long
            var employeeMaxLong = from u in allUsers
                                 orderby u.Address.Geo.Lng descending
                                 select u;


            Console.WriteLine("Employee MAX LNG");
            Console.WriteLine(employeeMaxLong.First().Name);
            Console.WriteLine(employeeMaxLong.First().Address.Geo.Lng);


            // 10 - create a new class: public class UserPosts { public User User {get; set}; public List<Post> Posts {get; set} }
            //    - create a new list: List<UserPosts>
            //    - insert in this list each user with his posts only

            // TODO QUERY

            Console.WriteLine("USER POSTS");
            var list = new List<UserPosts>();
            foreach (var user in allUsers)
            {
                list.Add(new UserPosts
                {
                    User = user,
                    Posts = allPosts.Where(p => p.UserId == user.Id).ToList()
                });
            }

            foreach (var u in list)
            {
                Console.WriteLine($"{u.User.Name}'s POSTS:");
                foreach (var p in u.Posts)
                {
                    Console.WriteLine("=============================");
                    Console.WriteLine($"PID: {p.Id}");
                    Console.WriteLine($"Post title: {p.Title}");
                    Console.WriteLine("--------------");
                    Console.WriteLine(p.Body);
                }
            }


            // 11 - order users by zip code

            var usersbyzip = from user in allUsers
                             orderby user.Address.Zipcode
                             select user;

            Console.WriteLine("USERS BY ZIP: ");
            foreach (var user in usersbyzip)
            {
                Console.WriteLine(user.Name);
                Console.WriteLine(user.Address.Zipcode);
                Console.WriteLine();
            }

            // 12 - order users by number of posts
            var first10Posts = allPosts.Take(10).ToList();
            var next10Posts = allPosts.Skip(10).Take(10).ToList();
            foreach (var p in first10Posts)
            {
                Console.WriteLine("=============================");
                Console.WriteLine($"PID: {p.Id}");
                Console.WriteLine($"Post title: {p.Title}");
                Console.WriteLine("--------------");
                Console.WriteLine(p.Body);
            }

            foreach (var p in first10Posts)
            {
                Console.WriteLine("=============================");
                Console.WriteLine($"PID: {p.Id}");
                Console.WriteLine($"Post title: {p.Title}");
                Console.WriteLine("--------------");
                Console.WriteLine(p.Body);
            }

            Console.ReadKey();
        }

        private static List<Post> ReadPosts(string file)
        {
            return ReadData.ReadFrom<Post>(file);
        }

        private static List<User> ReadUsers(string file)
        {
            return ReadData.ReadFrom<User>(file);
        }
    }
}

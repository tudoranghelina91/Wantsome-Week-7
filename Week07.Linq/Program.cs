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


            // 3 - print number of posts for each user.

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


            // 7 - select all addresses in a new List<Address>. print the list.


            // 8 - print the employee with min lat


            // 9 - print the employee with max long


            // 10 - create a new class: public class UserPosts { public User User {get; set}; public List<Post> Posts {get; set} }
            //    - create a new list: List<UserPosts>
            //    - insert in this list each user with his posts only


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

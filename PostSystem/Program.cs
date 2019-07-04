using PostSystem.Entities;
using System;
using System.Collections.Generic;

namespace PostSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Post> posts = new List<Post>();
            Post post1 = new Post(DateTime.Now, "Traveling to New Zealand",
                                  "I'm going to visit this wonderful country!", 12);
            Comment comment1 = new Comment("Have a nice trip");
            Comment comment2 = new Comment("Wow that's awesome!");
            post1.AddComment(comment1);
            post1.AddComment(comment2);

            Post post2 = new Post(DateTime.Now, "Good night guys", "See you tomorrow", 5);
            Comment comment3 = new Comment("Good night");
            Comment comment4 = new Comment("May the force be with you");
            post2.AddComment(comment3);
            post2.AddComment(comment4);

            posts.Add(post1);
            posts.Add(post2);

            foreach(Post post in posts)
            {
                Console.WriteLine(post);
                Console.WriteLine();
            }
        }
    }
}

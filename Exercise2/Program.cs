using Exercise2.Entities;
using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Post p1 = new Post(
                moment: DateTime.Parse("21/06/2018 13:05:44"),
                title: "Traveling to New Zealand",
                content: "I'm going to visit this wonderful country!",
                likes: 12
            );

            p1.AddComment(new Comment("Have a nice trip"));
            p1.AddComment(new Comment("Wow that's awesome!"));

            Post p2 = new Post(
                moment: DateTime.Parse("28/07/2018 23:14:19"),
                title: "Good night guys",
                content: "See you tomorrow",
                likes: 5
            );

            p2.AddComment(new Comment("Good night"));
            p2.AddComment(new Comment("May the Force be with you"));

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}

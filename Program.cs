﻿using System;
using System.Collections.Generic;
namespace ConsoleApp2
{
    class program
    {
        public class Post
        {
            public string title;
            public string description;
            public DateTime DateCreatedO { get; set; }
            public int vote { get; set; }
            private bool vote_up;
            private bool vote_down;
            public Post(string Title, string Description)

            {
                title = Title;
                description = Description;
                DateTime DateCreatedO = DateTime.Now;
                vote = 0;
            }
            public void Voteup()
            {
                if (vote_up)
                {
                    throw new Exception("You have voted");

                }
                else
                {
                    vote++;
                    vote_up = true;
                    vote_down = false;
                } }
            public void Votedown()
            {
                if (vote_down)
                {
                    throw new Exception("You have voted");


                }
                else
                {
                    vote--;
                    vote_up = false;
                    vote_down = true;
                }


            }


            static void Main(string[] args)
            {
                Console.WriteLine("enter your title");
                string t = Console.ReadLine();
                Console.WriteLine("enter your description");
                string d = Console.ReadLine();
                var Post = new Post(t, d);
                System.Console.WriteLine($"Title:{Post.title}  ");
                System.Console.WriteLine($"Description:{Post.description} ");
                System.Console.WriteLine($"Date Created:{Post.DateCreatedO}");
                System.Console.WriteLine($"Post Count{Post.vote}   ");

                Console.WriteLine("Enter vote up , dwn");

                while (true)
                {
                    string inputVote =Console.ReadLine();
                    if (inputVote.ToLower().Equals("voteup")) 
                    {

                        Post.Voteup();
                        System.Console.WriteLine($"Post Count: {Post.vote} ");

                    }
                    else if (inputVote.ToLower().Equals("votedown")) 
                    {
                        Post.Votedown();
                        System.Console.WriteLine($"Post Count: {Post.vote} ");
                    }
                    else
                    {

                        Console.WriteLine("try again");

                    }

                }







            } } 
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    internal class Program
    {
        public class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public void Rename(string title)
            {
                Title = title;
            }

            public void Edit(string content)
            {
                Content = content;
            }

            public void ChangeAuthor(string author)
            {
                Author = author;
            }

            //public override string ToString()
            //{
            //    return $"{Title} - {Content}: {Author}";
            //}
        }
            static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article article = new Article(input[0], input[1], input[2]);
            int commandsNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNum; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                if (command[0] == "Rename")
                {
                    article.Rename(command[1]);
                }
                else if (command[0] == "Edit")
                {
                    article.Edit(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
            }

            //Console.WriteLine(article);
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
}
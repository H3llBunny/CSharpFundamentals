using System;
using System.Collections.Generic;
using System.Linq;
using static Articles2_0.Program;

namespace Articles2_0
{
    internal class Program
    {
        public class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
        static void Main(string[] args)
        {
            int articlesNum = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            string[] input;

            for (int i = 0; i < articlesNum; i++)
            {
                input = Console.ReadLine().Split(", ");
                articles.Add(new Article(input[0], input[1], input[2]));
            }

            string orderByWhat = Console.ReadLine();

            switch (orderByWhat)
            {
                case "title":
                    articles = articles.OrderBy(article => article.Title).ToList();
                    break;

                case "content":
                    articles = articles.OrderBy(article => article.Content).ToList();
                    break;

                case "author":
                    articles = articles.OrderBy(article => article.Author).ToList();
                    break;
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }
}
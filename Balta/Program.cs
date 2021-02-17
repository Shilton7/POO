using Balta.ContentContext;
using System;
using System.Collections.Generic;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Curso Google", "www.google.com"));
            articles.Add(new Article("Curso Docker", "www.docker.com"));
            articles.Add(new Article("Curso C#", "www.csharp.com"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

        }
    }
}

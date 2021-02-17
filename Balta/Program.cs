using Balta.ContentContext;
using Balta.SubscriptionContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre Google", "www.google.com"));
            articles.Add(new Article("Artigo sobre Docker", "www.docker.com"));
            articles.Add(new Article("Artigo sobre C#", "www.csharp.com"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var course = new List<Course>();
            var courseNet = new Course("Curso de .NET 1", "net.com");
            var courseSQL = new Course("Curso de SQL SERVER", "mssql.com");
            course.Add(courseNet);
            course.Add(courseSQL);


            var career = new Career("Carreira .NET","net.com");
            var careerItem = new CareerItem(1,"Comece por aqui","O start dessa carreira é show", courseNet);
            var careerItem3 = new CareerItem(3, "Terceiro passo por aqui", "O passo 3 dessa carreira é show", courseSQL);
            var careerItem2 = new CareerItem(2, "Segundo passo por aqui", "O passo 2 dessa carreira é show", null);
            career.Items.Add(careerItem);
            career.Items.Add(careerItem3);
            career.Items.Add(careerItem2);

            foreach(var item in career.Items.OrderBy(x=> x.Order))
            {
                Console.WriteLine($"{item.Order} - {item.Title} - {item.Description}");
                Console.WriteLine(item.Course?.Title);

                foreach(var notication in item.Notifications)
                {
                    Console.WriteLine($"{notication.Property} - {notication.Message}");
                }
            }

            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalSubscription);

        }
    }
}

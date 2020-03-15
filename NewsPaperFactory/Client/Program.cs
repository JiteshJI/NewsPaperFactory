using NewsPaperFactory.Client;
using System;

namespace NewsPaperFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print paper 
            IPrintNews obj = new PublishNews();
            obj.PrintNews();

            //1.Should be able to integrate news from internal and external registered source(External: Press Trust of India, Google news and Internal Sources)
             obj.AddNewResource(new Entities.TypeOfSource() { TypeOfSourceId=4, Name="New Source" });
            //2. Design registering to a news sources to get the news content
           // obj.GetTypeOfSource();
            Console.ReadLine();
    }
}
}

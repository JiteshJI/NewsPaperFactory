using NewsPaperFactory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NewsPaperFactory.Client
{
    public class PublishNews : IPrintNews
    {
        public void PrintNews()
        {
            //Read all the news 
            var newsResultSet = new NewsList().GetNewsList().ToList();
            var SourceTypeMappingObj = new SourceTypeMapping();
            var SelectPageMappingValidationObj = new SelectPageMappingValidation();


            var PageType = new PageType();
           
            foreach (var item in newsResultSet)
            {
                var ListOfSourceTypeId = SourceTypeMappingObj.GetSourceTypeMapping().Where(k=>k.TypeOfSourceId==item.TypeOfSourceId).Select(e => e.SourceTypeMappingId);

                foreach(var item1 in ListOfSourceTypeId)
                {
                    var ListOfSourceId = SelectPageMappingValidationObj.GetselectPageMappingValidations().Where(e => e.SourceTypeMappingId == item1).ToList();

                    foreach(var item2 in ListOfSourceId)
                    {
                        
                        var pageName = PageType.GetPageTypeById(item2.PageTypeId).Select(e=>e.Name).FirstOrDefault();
                        Console.WriteLine($"{pageName}");
                        Console.WriteLine($"-------------{item.NewsContent}");
                    }
                }

            }
        }

        public void AddNewResource(TypeOfSource typeOfSource)
        {
            TypeOfSource obj = new TypeOfSource();
            obj.AddNewSource(typeOfSource);
        }

        public  void  GetTypeOfSource()
        {
            var ItemList = new TypeOfSource().GetTypeOfSource();
            foreach(var item in ItemList)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaperFactory.Entities
{
    public class NewsCategory
    {
        public int NewsCategoryId { get; set; }
        public string Name { get; set; }

        //3. Category component segregates the news on its type e.g.Political, Sports, Travel, Advertisements
        public List<NewsCategory> GetNewsCategories()
        {
            return new List<NewsCategory>() { 
                new NewsCategory() { NewsCategoryId=1, Name= "Political" },
                new NewsCategory() { NewsCategoryId=2, Name= "Sports" },
                new NewsCategory() { NewsCategoryId=3, Name= "Travel" },
                new NewsCategory() { NewsCategoryId=4, Name= "Advertisements" }
            };
        }

        public IEnumerable<NewsCategory> GetNewsCategoryById(int newsCatrgoryId)
        {
            return this.GetNewsCategories().Where(e => e.NewsCategoryId == newsCatrgoryId);
        }
    }
}

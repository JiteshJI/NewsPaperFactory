using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaperFactory.Entities
{
    public class NewsList
    {
        public int NewsId { get; set; }
        public string NewsContent { get; set; }
        public int NewsPriorityId { get; set; }
        public int TypeOfSourceId { get; set; }

        //5. A page can also have advertisements with the highest ratio of news/advertisement as 6/2
        //6. Advertisements can be dropped if there is no place for a high priority news item
        public IEnumerable<NewsList> GetNewsList()
        {
            return new List<NewsList>() {

                new NewsList() { NewsId = 1, NewsContent = "News1", TypeOfSourceId = 1, NewsPriorityId=1 },
                new NewsList() { NewsId = 2, NewsContent = "News2", TypeOfSourceId = 2, NewsPriorityId=2 },
                new NewsList() { NewsId = 3, NewsContent = "News3", TypeOfSourceId = 2, NewsPriorityId=3 },
                 new NewsList() { NewsId = 4, NewsContent = "News4", TypeOfSourceId = 1, NewsPriorityId=1 },
                new NewsList() { NewsId = 5, NewsContent = "News5", TypeOfSourceId = 2, NewsPriorityId=2 },
                new NewsList() { NewsId = 6, NewsContent = "News6", TypeOfSourceId = 3, NewsPriorityId=3 },
                 new NewsList() { NewsId = 7, NewsContent = "News7", TypeOfSourceId = 1, NewsPriorityId=1 },
                new NewsList() { NewsId = 8, NewsContent = "News8", TypeOfSourceId = 2, NewsPriorityId=2 },
                new NewsList() { NewsId = 9, NewsContent = "News9", TypeOfSourceId = 2, NewsPriorityId=3 },
                 new NewsList() { NewsId = 10, NewsContent = "News10", TypeOfSourceId = 1, NewsPriorityId=1 },
                new NewsList() { NewsId = 11, NewsContent = "News11", TypeOfSourceId = 2, NewsPriorityId=2 },
                new NewsList() { NewsId = 12, NewsContent = "News12", TypeOfSourceId = 2, NewsPriorityId=3 }
            };
        }
    }
}

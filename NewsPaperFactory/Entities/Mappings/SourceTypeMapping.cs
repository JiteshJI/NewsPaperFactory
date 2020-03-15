using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaperFactory.Entities
{
    public class SourceTypeMapping
    {
        public int SourceTypeMappingId { get; set; }
        public int TypeOfSourceId { get; set; }
        public string Name { get; set; }
        public int NewsPriorityId { get; set; }
        public int NewsCategoryId { get; set; }

        //5. A page can also have advertisements with the highest ratio of news/advertisement as 6/2 based on the NewsCategory
        public IEnumerable<SourceTypeMapping> GetSourceTypeMapping()
        {
            return new List<SourceTypeMapping>() {
                new SourceTypeMapping() { SourceTypeMappingId = 1, TypeOfSourceId=1, Name= "Press Trust of India", NewsPriorityId=1, NewsCategoryId=1 },
                 new SourceTypeMapping() { SourceTypeMappingId = 2, TypeOfSourceId=1, Name= "Press Trust of India1", NewsPriorityId=1, NewsCategoryId=3 },
                new SourceTypeMapping() { SourceTypeMappingId = 3, TypeOfSourceId = 2, Name = "Google news and Internal Sources", NewsPriorityId = 2, NewsCategoryId=4 },
                new SourceTypeMapping() { SourceTypeMappingId = 4, TypeOfSourceId = 3, Name = "Google news and Internal Sources", NewsPriorityId = 2, NewsCategoryId=1 },
            };
        }
    }


}

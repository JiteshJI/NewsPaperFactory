using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaperFactory.Entities
{
    public class PageType
    {
        public int PageTypeId { get; set; }
        public string Name { get; set; }

        public IEnumerable<PageType> GetPageTypes()
        {
            return new List<PageType>()
            {
                new PageType(){ PageTypeId=1, Name="Page1" },
                new PageType(){ PageTypeId=2, Name="Page2" },
                new PageType(){ PageTypeId=3, Name="Page3" }

            };
        }

        public IEnumerable<PageType> GetPageTypeById(int pageId)
        {
            return this.GetPageTypes().Where(e => e.PageTypeId == pageId);
        }
    }
}

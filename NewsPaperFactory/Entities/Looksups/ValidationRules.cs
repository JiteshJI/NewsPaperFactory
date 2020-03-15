using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaperFactory.Entities
{
    public class ValidationRules
    {
        public int ValidationRulesId { get; set; }
        public string Name { get; set; }

        
        //4. A maximum of 8 news/items can be accommodated on a page and it should be possible to extend the number of pages
        //5. A page can also have advertisements with the highest ratio of news/advertisement as 6/2
        public IEnumerable<ValidationRules> GetValidationRules()
        {
            return new List<ValidationRules>() { 
                new ValidationRules() { ValidationRulesId = 1, Name = "8 News 0 Ads per Page" }, 
                new ValidationRules() { ValidationRulesId = 2, Name = "6 News 2 ads per Page" } 
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaperFactory.Entities
{
    public class NewsPriority
    {
        public int NewsPriorityId { get; set; }
        public string Name { get; set; }

        public IEnumerable<NewsPriority> GetNewsPriorities()
        {
            return new List<NewsPriority>() {

            new NewsPriority(){ NewsPriorityId=1, Name="High" },
            new NewsPriority() { NewsPriorityId = 2, Name = "Medium" },
                 new NewsPriority() { NewsPriorityId = 3, Name = "Low" }

            };
        }

        

    }
}

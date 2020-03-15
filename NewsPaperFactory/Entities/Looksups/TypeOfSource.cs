using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaperFactory.Entities
{
    public class TypeOfSource
    {
        public int TypeOfSourceId { get; set; }
        public string Name { get; set; }

        public IEnumerable<TypeOfSource> GetTypeOfSource()
        {
            return new List<TypeOfSource>() {
                new TypeOfSource() { TypeOfSourceId = 1, Name = "Internal" },
                new TypeOfSource() { TypeOfSourceId = 2, Name = "Press Trust of India" },
                new TypeOfSource() { TypeOfSourceId = 3, Name = "Google news and Internal Sources" }
            };
        }
        public void AddNewSource(TypeOfSource newSourceRegister)
        {
            List<TypeOfSource> typeOfSources = GetTypeOfSource().ToList();
            typeOfSources.Add(newSourceRegister);


        }
    }
}

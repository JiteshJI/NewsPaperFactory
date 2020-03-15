using NewsPaperFactory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaperFactory.Client
{
    public interface IPrintNews
    {
        void PrintNews();
        void AddNewResource(TypeOfSource typeOfSource);

        void GetTypeOfSource();
    }
}

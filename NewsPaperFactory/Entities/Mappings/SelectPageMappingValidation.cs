using System.Collections.Generic;

namespace NewsPaperFactory.Entities
{
    public class SelectPageMappingValidation
    {
        public int SelectPageMappingValidationId { get; set; }
        public int ValidationRuleId { get; set; }
        public int PageTypeId { get; set; }

        public int SourceTypeMappingId { get; set; }

        //4. A maximum of 8 news/items can be accommodated on a page and it should be possible to extend the number of pages // based on validation FK key configuration 
        public IEnumerable<SelectPageMappingValidation> GetselectPageMappingValidations()
        {
            return new List<SelectPageMappingValidation>() {

                new SelectPageMappingValidation() { SelectPageMappingValidationId=1,SourceTypeMappingId=1, ValidationRuleId=1, PageTypeId=1  } ,
                 new SelectPageMappingValidation() { SelectPageMappingValidationId=2, SourceTypeMappingId=3,  ValidationRuleId=2, PageTypeId=2  },
                new SelectPageMappingValidation() { SelectPageMappingValidationId=3, SourceTypeMappingId=4,  ValidationRuleId=2, PageTypeId=3 } 
            };
        }
    }
}

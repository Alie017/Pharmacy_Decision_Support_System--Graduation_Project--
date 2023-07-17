using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phadec.CustomDto
{
    public class DrugInteractionResultDto
    {
        public string DrugId { get; set; }
        public string ActiveSubstance { get; set; }
        public string InteractionDescription { get; set; }
    }

}

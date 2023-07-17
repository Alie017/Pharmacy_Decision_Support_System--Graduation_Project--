using phadec.MultiTenancy.Dto;
using System.Collections.Generic;

namespace phadec.CustomDto
{
    public class DrugInformationDto
    {
        public DrugDto Drug { get; set; }
        public DrugInteractionDto DrugInteraction { get; set; }
        public FoodInteractionDto FoodInteraction { get; set; }
        public RecommendationDto Recommendation { get; set; }
    }
}

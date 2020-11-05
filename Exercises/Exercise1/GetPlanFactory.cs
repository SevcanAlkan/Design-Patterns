using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class GetPlanFactory
    {
        public Plan GetPlan(string planTypeName) =>
            planTypeName switch
            {
                "DOMESTICPLAN" => new DomesticPlan(),
                "COMMERCIALPLAN" => new CommercialPlan(),
                "INSTITUTIONALPLAN" => new InstitutionalPlan(),
                _ => null
            };
    }
}

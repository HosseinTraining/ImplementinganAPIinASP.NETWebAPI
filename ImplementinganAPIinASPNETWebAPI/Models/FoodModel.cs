using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImplementinganAPIinASPNETWebAPI.Models
{
    public class FoodModel
    {
        public string Description { get; set; }
        public IEnumerable<MeasureModel> MeasureModels { get; set; }
    }

}
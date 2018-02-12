using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImplementinganAPIinASPNETWebAPI.Models
{
    public class FoodModel
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public IEnumerable<MeasureModel> MeasureModels { get; set; }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImplementinganAPIinASPNETWebAPI.Data.Entities;
using System.Net.Http;
using System.Web.Http.Routing;

namespace ImplementinganAPIinASPNETWebAPI.Models
{
    public class ModelFactory
    {
        private UrlHelper _urlHelper;
        public ModelFactory(HttpRequestMessage request)
        {
            _urlHelper = new UrlHelper(request);
        }
        public FoodModel Create(Food food)
        {
            return new FoodModel
            {
                Id = food.Id,
                Url = _urlHelper.Link("Foods", new { id =food.Id}),
                Description = food.Description,
                MeasureModels = food.Measures.Select(Create)
            };
        }

        public MeasureModel Create(Measure measure)
        {
            return new MeasureModel
            {
                Id = measure.Id,
                Url = _urlHelper.Link("Measures", new { foodId = measure.Food.Id, id = measure.Id }),
                Description = measure.Description,
                Calories = measure.Calories
            };
        }
    }
}
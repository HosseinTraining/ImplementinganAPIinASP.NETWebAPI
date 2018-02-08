using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImplementinganAPIinASPNETWebAPI.Data.Entities;

namespace ImplementinganAPIinASPNETWebAPI.Models
{
    public class ModelFactory
    {
        public FoodModel Create(Food food)
        {
            return new FoodModel
            {
                Id = food.Id,
                Description = food.Description,
                MeasureModels = food.Measures.Select(Create)
            };
        }

        public MeasureModel Create(Measure measure)
        {
            return new MeasureModel
            {
                Id = measure.Id,
                Description = measure.Description,
                Calories = measure.Calories
            };
        }
    }
}
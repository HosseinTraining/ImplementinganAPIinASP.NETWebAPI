using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ImplementinganAPIinASPNETWebAPI.Data;
using ImplementinganAPIinASPNETWebAPI.Data.Entities;
using ImplementinganAPIinASPNETWebAPI.Models;

namespace ImplementinganAPIinASPNETWebAPI.Controllers
{
    public abstract class FoodsController : BaseController
    {
        public FoodsController(ICountingKsRepository countingKsRepository)
            : base(countingKsRepository)
        {

        }

        public IEnumerable<FoodModel> Get(bool includeMeasures = true)
        {

            var foodsQuery = includeMeasures ? BaseCountingRepository.GetAllFoodsWithMeasures() : BaseCountingRepository.GetAllFoods();
            var resualt = foodsQuery
                .OrderBy(d => d.Description)
                .Take(25)
                .ToList()
                .Select(x => BaseModelFactory.Create(x));


            return resualt;
        }

        public FoodModel Get(int id)
        {
            return BaseModelFactory.Create(BaseCountingRepository.GetFood(id));
        }
    }
}

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
    public class FoodsController : ApiController
    {
        private readonly ICountingKsRepository _countingKsRepository;
        private readonly ModelFactory _modelFactory;

        public FoodsController(ICountingKsRepository countingKsRepository)
        {
            _countingKsRepository = countingKsRepository;
            _modelFactory = new ModelFactory();

        }

        public IEnumerable<FoodModel> Get(bool includeMeasures = true)
        {

            var foodsQuery = includeMeasures ? _countingKsRepository.GetAllFoodsWithMeasures() : _countingKsRepository.GetAllFoods();
            var resualt = foodsQuery
                .OrderBy(d => d.Description)
                .Take(25)
                .ToList()
                .Select(x => _modelFactory.Create(x));


            return resualt;
        }

        public FoodModel Get(int id)
        {
            return _modelFactory.Create(_countingKsRepository.GetFood(id));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ImplementinganAPIinASPNETWebAPI.Data;
using ImplementinganAPIinASPNETWebAPI.Models;

namespace ImplementinganAPIinASPNETWebAPI.Controllers
{
    public class MeasuresController : ApiController
    {
        private ICountingKsRepository _repository;
        private ModelFactory _modelFactory;

        public MeasuresController(ICountingKsRepository countingKsRepository)
        {
            _repository = countingKsRepository;
            _modelFactory = new ModelFactory();
        }

        public IEnumerable<MeasureModel> Get(int foodId)
        {
            return _repository.GetMeasuresForFood(foodId)
                 .ToList()
                 .Select(m => _modelFactory.Create(m));
        }

        public MeasureModel Get(int foodId, int id)
        {
            var resualt = _repository.GetMeasure(id);
            return (resualt?.Food.Id == foodId) ? _modelFactory.Create(resualt) : null;
        }
    }
}

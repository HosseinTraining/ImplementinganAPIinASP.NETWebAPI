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
    public class MeasuresController : BaseController
    {


        public MeasuresController(ICountingKsRepository countingKsRepository)
        : base(countingKsRepository)
        {

        }

        public IEnumerable<MeasureModel> Get(int foodId)
        {
            return BaseCountingRepository.GetMeasuresForFood(foodId)
                 .ToList()
                 .Select(m => BaseModelFactory.Create(m));
        }

        public MeasureModel Get(int foodId, int id)
        {
            var resualt = BaseCountingRepository.GetMeasure(id);
            return (resualt?.Food.Id == foodId) ? BaseModelFactory.Create(resualt) : null;
        }
    }
}

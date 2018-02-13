using ImplementinganAPIinASPNETWebAPI.Data;
using ImplementinganAPIinASPNETWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ImplementinganAPIinASPNETWebAPI.Controllers
{
    public abstract class BaseController : ApiController
    {
        ICountingKsRepository _repo;
        ModelFactory _modelFactory;


        public BaseController(ICountingKsRepository repo)
        {
            _repo = repo;
        }

        protected ICountingKsRepository BaseCountingRepository => _repo;

        protected ModelFactory BaseModelFactory => _modelFactory ?? (_modelFactory = new ModelFactory(this.Request));
    }
}

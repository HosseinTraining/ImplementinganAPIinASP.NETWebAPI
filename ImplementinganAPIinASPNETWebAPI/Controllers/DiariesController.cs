using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ImplementinganAPIinASPNETWebAPI.Data;
using ImplementinganAPIinASPNETWebAPI.Data.Entities;
using ImplementinganAPIinASPNETWebAPI.Models;
using ImplementinganAPIinASPNETWebAPI.Services;

namespace ImplementinganAPIinASPNETWebAPI.Controllers
{
    public class DiariesController : BaseController
    {
        private ICountingKsIdentityService _identityService;
        public DiariesController(ICountingKsRepository repo, ICountingKsIdentityService identityService) : base(repo)
        {
            _identityService = identityService;
        }


        public IEnumerable<DiaryModel> Get()
        {
            var userName = _identityService.CurrentUser;
            var resualt = BaseCountingRepository.GetDiaries(userName)
                .OrderByDescending(d => d.CurrentDate)
                .Take(10)
                .ToList()
                .Select(d => BaseModelFactory.Create(d));
            return resualt;
        }

        public HttpResponseMessage Get(DateTime diaryId)
        {
            var userName = _identityService.CurrentUser;
            var resualt = BaseCountingRepository.GetDiary(userName, diaryId);
            return resualt !=null ? Request.CreateResponse(HttpStatusCode.OK, BaseModelFactory.Create(resualt)) : Request.CreateResponse(HttpStatusCode.NotFound,"داده مورد نظر یافت نشد");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImplementinganAPIinASPNETWebAPI.Services
{
    public class CountingKsIdentityService : ICountingKsIdentityService
    {
        public string CurrentUser => "shawnwildermuth";
    }

    public interface ICountingKsIdentityService
    {
        string CurrentUser { get; }
    }
}
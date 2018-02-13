using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImplementinganAPIinASPNETWebAPI.Models
{
    public class DiaryModel
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public DateTime CurrentDate { get; set; }
        //public IEnumerable<DiaryEntryModel> Entries { get; set; }
    }
}
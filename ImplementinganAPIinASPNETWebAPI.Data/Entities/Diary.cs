using System;
using System.Collections.Generic;

namespace ImplementinganAPIinASPNETWebAPI.Data.Entities
{
    public class Diary
    {
        public Diary()
        {
            Entries = new List<DiaryEntry>();
        }
        public int Id { get; set; }
        public DateTime CurrentDate { get; set; }
        public virtual ICollection<DiaryEntry> Entries { get; set; }
        public string UserName { get; set; }
    }
}
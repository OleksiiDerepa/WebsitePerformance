﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsitePerformance.Models
{
    public class FoundSitePage
    {
        public int Id { get; set; }
        public string NameSitePage { get; set; }
        public TimeSpan? TimeMin { get; set; }
        public TimeSpan? TimeMax { get; set; }
        public TimeSpan? TimeAverage { get; set; }

        public int? FoundSiteMapeId { get; set; }
        public virtual FoundSiteMape FoundSiteMape { get; set; }
    }
}
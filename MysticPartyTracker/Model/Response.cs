﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Model
{
    public class Response
    {
        public int Count { get; set; }
        List<Result> Results {  get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bearcats_Football.Models
{
    public class Recieving
    {
        public string _id { get; set; }
        public string _date { get; set; }
        public string _opponent { get; set; }
        public int _no { get; set; }
        public int _yards { get; set; }
        public int _td { get; set; }
        public int _lg { get; set; }
    }
}
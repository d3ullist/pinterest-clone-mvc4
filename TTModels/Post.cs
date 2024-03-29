﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TTModels
{
    public class Posts
    {
        public int id { get; set; }
        public string title { get; set; }
        public string filename { get; set; }
        public int owner { get; set; }
        public DateTime dateuploaded { get; set; }
        public int comments_count { get; set; }
        public int repid_in { get; set; }
        public int repin_count { get; set; }
        public int like_count { get; set; }
        public string tags { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int type { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormsWithHttpPost.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Rating { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
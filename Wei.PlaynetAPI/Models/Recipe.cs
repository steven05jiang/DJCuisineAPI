using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wei.PlaynetAPI.Models
{
    public class Recipe
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string previewImg { get; set; }
        public DateTime createDate { get; set; }
        public DateTime updateDate { get; set; }
        public string detail { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace MkrsUnion.Shared.Workshops { 
    public class WorkshopDetails
    {
        // attributes
        public string title { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string imgSrc { get; set; }
        public string weekday { get; set; }
        public int imgNum { get; set; }
        public string description { get; set; }
        public List<string> categories { get; set; }

        // constructor
        // 'description', 'imgSrc', 'imgNum' parameters are optional
        public WorkshopDetails(string title, string date, string weekday, string time, List<string> categories, string imgSrc = "", int imgNum = -1, string description = "")
        {
            this.title = title;
            this.date = date;
            this.weekday = weekday;
            this.time = time;
            this.imgSrc = imgSrc;
            this.description = description;
            this.categories = categories;
        }
    }
}


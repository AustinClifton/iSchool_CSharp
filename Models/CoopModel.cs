using System;
using System.Collections.Generic;

namespace iSchoolWebAppBogaard.Models {
    public class CoopInformation {
        public string Employer { get; set; }
        public string Degree { get; set; }
        public string City { get; set; }
        public string Term { get; set; }
    }

    public class CoopTable {
        public string Title { get; set; }
        public List<CoopInformation> coopInformation { get; set; }
    }
    
    public class CoopModel {
        public CoopTable CoopTable { get; set; }
        public string PageTitle { get; set; }
    }
}
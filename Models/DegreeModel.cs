using System.Collections.Generic;

namespace iSchoolWebAppBogaard.Models {
    public class Degree {
        public string DegreeName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Concentrations { get; set; }
        public List<string> AvailableCertificates { get; set; }

        public Degree() {
            Concentrations = new List<string>();
            AvailableCertificates = new List<string>();
        }
    }
    public class DegreeModel {
        public List<Degree> Undergraduate { get; set; }
        public List<Degree> Graduate { get; set; }
        public string PageTitle { get; set; }
    }
}
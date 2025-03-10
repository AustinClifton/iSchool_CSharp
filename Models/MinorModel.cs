using System.Collections.Generic;

namespace iSchoolWebAppBogaard.Models {
    public class Minor {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Courses { get; set; }

        public Minor() {
            Courses = new List<string>();
        }
    }
    public class MinorModel {
        public List<Minor> UgMinors { get; set; }

        public List<Minor> GradMinors { get; set; }
        public string PageTitle { get; set; }

        public MinorModel() {
            UgMinors = new List<Minor>();
            GradMinors = new List<Minor>();
        }
    }
}
using System;
using System.Collections.Generic;

namespace iSchoolWebAppBogaard.Models {
    public class ProfessionalEmployment {
        public string Employer { get; set; }
        public string Degree { get; set; }
        public string City { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
    }

    public class EmploymentTable {
        public string Title { get; set; }
        public List<ProfessionalEmployment> ProfessionalEmploymentInformation { get; set; }
    }

    public class EmploymentModel {
        public EmploymentTable EmploymentTable { get; set; }
        public string PageTitle { get; set; }
    }
}
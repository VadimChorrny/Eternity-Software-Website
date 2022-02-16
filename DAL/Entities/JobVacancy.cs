using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class JobVacancy
    {
        public int VacancyId { get; set; }
        public string Title { get; set;}
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public string Level { get; set; }
    }
}

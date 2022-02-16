using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Message { get; set; } = string.Empty;
        public int? ServiceCategoryId { get; set; }
        public ServiceCategory ServiceCategory { get; set; }
        public int? BudgetCategoryId { get; set; }
        public BudgetCategory BudgetCategory { get; set; }

    }
}

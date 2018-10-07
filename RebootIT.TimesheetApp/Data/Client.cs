using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RebootIT.TimesheetApp.Data
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string BillingAddress { get; set; }
        [Required]
        public string ContactName { get; set; }
        [Required]
        public string ContactTelephone { get; set; }
        [Required]
        public string ContactEmail { get; set; }
    }
}

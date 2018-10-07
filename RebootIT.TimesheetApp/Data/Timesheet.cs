using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RebootIT.TimesheetApp.Data
{
    public class Timesheet
    {
        public int Id { get; set; }
        public int MinutesWorked { get; set; }
        [Required]
        public Staff Staff { get; set; }
        public int StaffId { get; set; }
        [Required]
        public Client Client { get; set; }
        public int ClientId { get; set; }
        [Required]
        public Location Location { get; set; }
        public int LocationId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeInApp.Models
{
    public class ClockOutModel
    {
        public int UserKey { get; set; }
        
        public string ClockOutDateTime { get; set; }
        
        public int ActivityId { get; set; }
    }
}

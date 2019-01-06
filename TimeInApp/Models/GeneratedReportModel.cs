using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeInApp.Models
{
    public class GeneratedReportModel
    {
        public List<TimeInTimeOut> TimeList { get; set; }

        public string QueryStatus { get; set; }
    }

    public class TimeInTimeOut
    {
        public string ActivityName { get; set; }
        
        public string TimeInDateTime { get; set; }
        
        public string TImeOutDateTime { get; set; }
    }
}

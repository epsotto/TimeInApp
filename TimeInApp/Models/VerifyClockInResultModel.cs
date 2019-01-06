using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeInApp.Models
{
    public class VerifyClockInResultModel
    {
        public bool ClockedIn { get; set; }

        public string QueryStatus { get; set; }

        public string ActivityNm { get; set; }

        public int ActivityId { get; set; }
    }
}

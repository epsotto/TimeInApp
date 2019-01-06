using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeInApp.Models
{
    public class ActivityQueryModel
    {
        public int ActivityId { get; set; }

        public string ActivityNm { get; set; }

        public bool IsActive { get; set; }

        public System.DateTime CreateDttm { get; set; }

        public string CreateUserId { get; set; }

        public System.DateTime UpdateDttm { get; set; }

        public string UpdateUserId { get; set; }
    }
}

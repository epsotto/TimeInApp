using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeInApp.Models
{
    public class UpdatePasswordModel
    {
        public int UserKey { get; set; }

        public string PreviousPassword { get; set; }

        public string NewPassword { get; set; }
    }
}

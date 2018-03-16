using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PhoneForm
    {
        public String phoneId { get; set; }
        public String companyId { get; set; }
        public DateTime dateIssueFrom { get; set; }
        public DateTime dateIssueTo { get; set; }

        public String cost { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Core.Model
{
   public class Portfolio
    {
        public int Id { get; set; }
        public string ProfilePicture { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int ContactNo { get; set; }
        public int TotalInvestment { get; set; }
        public string Gender { get; set; }
    }
}

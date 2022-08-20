using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject_5175.Models.Entities.Concrete
{
    public class PreviousPassword
    {
        public int AppuserID { get; set; }        

        public string PPassword { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}

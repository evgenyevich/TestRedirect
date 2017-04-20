using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestRedirect.Models
{
    public class RedirectRights
    {
        public bool CanRedirect { get; set; }
        public static int RedirectQty { get; set; }
        public int Qty { get; set; }
        
    }
}
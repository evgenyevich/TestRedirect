using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace TestRedirect.Models
{
    public class RedirectRights
    {
        //[ScaffoldColumn(false)]
        public bool CanRedirect { get; set; }
        [HiddenInput(DisplayValue = false)]
        public static int RedirectQty { get; set; }
        public int Qty { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CurrentDate = DateTime.Now;
        
    }
}
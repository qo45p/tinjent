using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login20190219.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name ="員工編號")]
        public string UserID { get; set; }
        public string Password { get; set; }
    }
}
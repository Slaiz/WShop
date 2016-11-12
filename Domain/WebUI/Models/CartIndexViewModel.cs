using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.Model;

namespace WebUI.Models
{
    /// <summary>
    /// Class display item in cart
    /// </summary>
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
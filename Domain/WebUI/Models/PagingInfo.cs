using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    /// <summary>
    /// Class that represent information about page
    /// </summary>
    public class PagingInfo
    {
        public int TotalItems { get; set; }     //The total number of items
        public int ItemsPerPage { get; set; }   //Count item on page
        public int CurrentPage { get; set; }    //Number current page
        public int TotalPages                   //Count all pages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}
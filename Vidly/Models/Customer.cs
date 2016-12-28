using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Empty
        {
            get { return (Id <= 0 && Name.IsNullOrWhiteSpace()); } 
        }
    }
}
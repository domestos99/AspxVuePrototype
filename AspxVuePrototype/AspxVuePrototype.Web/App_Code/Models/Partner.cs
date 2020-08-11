using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspxVuePrototype.Web.App_Code.Models
{
    public class Partner
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }

    }
}
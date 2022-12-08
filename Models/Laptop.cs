using System;
using System.Collections.Generic;
using System.Text;

namespace IE307.N11.Models
{
    public class Laptop : Item
    {
        public List<Category> Categories { get; set; }
        public enum Category 
        {
            GAMING, VAN_PHONG, MACBOOK
        }

        public Laptop() : base()
        {
            Categories = new List<Category>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace IE307.N11.Models
{
    public class Accessory : Item
    {
        public List<Category> Categories { get; set; }
        public enum Category 
        {
            HEADPHONE, CABLE
        }

        public Accessory() : base()
        {
            Categories = new List<Category>();
        }
    }
}

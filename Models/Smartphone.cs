using System;
using System.Collections.Generic;
using System.Text;

namespace IE307.N11.Models
{
    public class Smartphone : Item
    {
        public List<Category> Categories { get; set; }
        public enum Category 
        {
            IOS, ANDROID
        }

        public Smartphone() : base()
        {
            Categories = new List<Category>();
        }
    }
}

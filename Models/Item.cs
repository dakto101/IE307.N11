using System;

namespace IE307.N11.Models
{
    public class Item
    {
        public String Name { get; set; }
        public Double Rate { get; set; }
        public String ImageURL { get; set; }
        public int Price { get; set; }
        public Boolean IsLiked { get; set; }
        public Item.Type ItemType { get; set; }
        public enum Type
        {
            LAPTOP, SMARTPHONE, ACCESSORY
        }

        public Item()
        {
            Name = "";
            Rate = 0;
            ImageURL = "";
            Price = 0;
            IsLiked = false;
            ItemType = Type.LAPTOP;
        }

    }
}

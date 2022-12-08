using IE307.N11.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IE307.N11.Services
{
    public class ItemDataStore
    {
        public static readonly ObservableCollection<Item> Items = new ObservableCollection<Item>();

        public ItemDataStore()
        {
            Init();
        }

        public static void Init()
        {
            Items.Add(new Laptop()
            {
                Name = "Acer Nitro 5 Eagle",
                Rate = 4.5,
                ImageURL = "Acer_Nitro_5_Eagle_AN515_57_54MV.jpg",
                Price = 19990000,
                IsLiked = false,
                ItemType = Item.Type.LAPTOP,
                Categories = new List<Laptop.Category>() { Laptop.Category.GAMING }
            });
            Items.Add(new Laptop()
            {
                Name = "ASUS_TUF_A15",
                Rate = 4.6,
                ImageURL = "ASUS_TUF_A15_FA507RC_HN051W.jpg",
                Price = 23000000,
                IsLiked = false,
                ItemType = Item.Type.LAPTOP,
                Categories = new List<Laptop.Category>() { Laptop.Category.GAMING, Laptop.Category.VAN_PHONG }
            });
            Items.Add(new Laptop()
            {
                Name = "Asus Zenbook 14",
                Rate = 4.1,
                ImageURL = "Asus_Zenbook_14_OLED.jpg",
                Price = 31000000,
                IsLiked = true,
                ItemType = Item.Type.LAPTOP,
                Categories = new List<Laptop.Category>() { Laptop.Category.GAMING }
            });
            Items.Add(new Laptop()
            {
                Name = "Dell Inspiron 15 5515",
                Rate = 4.1,
                ImageURL = "Dell_Inspiron_15_5515.jpg",
                Price = 19000000,
                IsLiked = false,
                ItemType = Item.Type.LAPTOP,
                Categories = new List<Laptop.Category>() { Laptop.Category.VAN_PHONG }
            });
            Items.Add(new Laptop()
            {
                Name = "MacBook Pro M2 2022",
                Rate = 5,
                ImageURL = "MacBook_Pro_M2_2022.jpg",
                Price = 31500000,
                IsLiked = true,
                ItemType = Item.Type.LAPTOP,
                Categories = new List<Laptop.Category>() { Laptop.Category.VAN_PHONG, Laptop.Category.MACBOOK }
            });
            Items.Add(new Smartphone()
            {
                Name = "iPhone 13 Pro Max",
                Rate = 5,
                ImageURL = "iPhone_13_Pro_Max.jpg",
                Price = 21000000,
                IsLiked = true,
                ItemType = Item.Type.SMARTPHONE,
                Categories = new List<Smartphone.Category>() { Smartphone.Category.IOS }
            });
            Items.Add(new Smartphone()
            {
                Name = "Samsung Galaxy S22 Ultra",
                Rate = 4.8,
                ImageURL = "Samsung_Galaxy_S22_Ultra.jpg",
                Price = 24890000,
                IsLiked = false,
                ItemType = Item.Type.SMARTPHONE,
                Categories = new List<Smartphone.Category>() { Smartphone.Category.ANDROID }
            });
            Items.Add(new Smartphone()
            {
                Name = "OPPO Find X5 Pro 5G",
                Rate = 4.1,
                ImageURL = "OPPO_Find_X5_Pro_5G.jpg",
                Price = 30490000,
                IsLiked = true,
                ItemType = Item.Type.SMARTPHONE,
                Categories = new List<Smartphone.Category>() { Smartphone.Category.ANDROID }
            });
            Items.Add(new Smartphone()
            {
                Name = "Xiaomi 11T Pro 5G",
                Rate = 3.9,
                ImageURL = "Xiaomi_11T_Pro_5G.jpg",
                Price = 14390000,
                IsLiked = false,
                ItemType = Item.Type.SMARTPHONE,
                Categories = new List<Smartphone.Category>() { Smartphone.Category.ANDROID }
            });
            Items.Add(new Accessory()
            {
                Name = "Bluetooth AirPods Pro (2nd Gen)",
                Rate = 4.5,
                ImageURL = "https://cdn.tgdd.vn/Products/Images/54/289781/airpods-pro-2nd-generation-0.jpg",
                Price = 6490000,
                IsLiked = true,
                ItemType = Item.Type.ACCESSORY,
                Categories = new List<Accessory.Category>() { Accessory.Category.HEADPHONE }
            });
            Items.Add(new Accessory()
            {
                Name = "Cáp Type C - Lightning 1m Apple MM0A3",
                Rate = 4.1,
                ImageURL = "https://cdn.tgdd.vn/Products/Images/58/259283/cap-type-c-lightning-1m-apple-mm0a3-trang-1-1.jpg",
                Price = 530000,
                IsLiked = false,
                ItemType = Item.Type.ACCESSORY,
                Categories = new List<Accessory.Category>() { Accessory.Category.CABLE }
            });
        }
    }
}

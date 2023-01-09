using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IE307.N11.Models
{
    public class Setting
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Boolean Editable { get; set; }
        public ICommand Command { get; set; }
        public Object Value { get; set; }

        public Setting()
        {
            Id = "";
            Name = "Settings Name";
            Description = "Settings Description";
            Editable = true;
            Command = new Command(o => { });
        }
    }
}

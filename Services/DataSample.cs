using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IE307.N11.Services
{
    public class DataSample
    {
        public static readonly ObservableCollection<String> Sample = new ObservableCollection<String>();

        public DataSample()
        {
            Init();
        }

        public static void Init()
        {
            Sample.Add("Text 1");
            Sample.Add("Text 2");
            Sample.Add("Text 3");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFKohYoungDemo
{
    public class TestClass02
    {
        private string name;
        private int number;
        public TestClass02(string name)
        {
            this.name = name;
        }
        public int Number
        {
            get => number;
            set => number = value;
        }
        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrEmpty(name)) name = value;
                else
                {
                    name = "namlp";
                }
            }
        }
    }
}

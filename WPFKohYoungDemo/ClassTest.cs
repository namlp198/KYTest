using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFKohYoungDemo
{
    public class ClassTest
    {
        private string name;
        private int id;
        public string Name => name == null ? "NA" : name;
        public int ID
        {
            get => id;
            set => id = value;
        }
    }
}

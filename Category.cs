using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBesenica
{
    public class Category
    {
        public string Name { get; set; }
        public List<Word> Words { get; set; }
        public Category(string name)
        {
            Name = name;
            Words = new List<Word>();
        }
    }
}

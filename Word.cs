using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBesenica
{
    public class Word
    {
        public string Name { get; set; }
        public Category Category { get; set; }

        public Word(string name, Category category)
        {
            Name = name;
            Category = category;
            category.Words.Add(this);
        }
    }
}

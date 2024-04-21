using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21.Homework.Moduls
{
    internal class Grass:Food
    {
        public string Name {  get; set; }

        public Grass(int calori, string name) : base(calori)
        {
            Name = name;
        }
    }
}

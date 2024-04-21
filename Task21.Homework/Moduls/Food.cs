using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21.Homework.Moduls
{
    internal abstract class Food
    {
        int Calori { get; set; }
        protected Food(int calori) 
        {
            Calori = calori;
        }
    }
}

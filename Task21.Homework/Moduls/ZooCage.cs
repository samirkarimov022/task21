﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21.Homework.Moduls
{
    internal class ZooCage<T,U>
        where T : Animal
        where U : Food


    {
        public T Animal { get; set; }
        public U Food { get; set; }


        public ZooCage(T animal, U food)
        {
            Animal = animal;
            Food = food;
        }
    }
}

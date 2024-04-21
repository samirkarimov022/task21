using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task21.Homework.Moduls.GenericType;

namespace Task21.Homework.Moduls
{
    internal class Elephant:Animal
    {
        double Weight {  get; set; }
        bool IsTrained {  get; set; }
        public Elephant(string breed,Gender gender,int avgLifeTime,  int hp,  double weight, bool isTrained) : base(breed, avgLifeTime, gender, hp)
        {
            Weight = weight; 
            IsTrained = isTrained; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Task21.Homework.Moduls.GenericType;

namespace Task21.Homework.Moduls
{
    internal abstract class Animal
    {

        public int AvgLifeTime {  get; set; }
        public string Breed {  get; set; }
        public int HP {  get; set; }
        public Gender Gender;





        protected Animal( string breed,int avgLifeTime, Gender gender ,int hp )
        {
            AvgLifeTime = avgLifeTime;
            Breed = breed;
            HP = hp;
            Gender = gender;

        }


    }
    namespace GenericType
    {
        public enum Gender
        {
            male,
            female
        }
    }
}

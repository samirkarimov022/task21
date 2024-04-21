using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task21.Homework.Moduls.GenericType;

namespace Task21.Homework.Moduls
{
    internal class Wolf:Animal
    {
        bool IsPrideLider {  get; set; }
        int AttacDamage {  get; set; }
        public Wolf(string breed,Gender gender,int avgLifeTime,  int hp,  bool isPrideLeader,int attackDamage ) : base(breed,attackDamage, gender,hp) 
        {
            AttacDamage = attackDamage; IsPrideLider = isPrideLeader;
        }


        public int Hunt<T>(T animal) where T : Animal
        {

            return animal.HP -= AttacDamage;

        }
    }
}

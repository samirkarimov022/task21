using GenericType;
using Task21.Homework.Moduls;
using Task21.Homework.Moduls.GenericType;

namespace Task21.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Wolf wolf = new Wolf("African",Gender.male,20,100,true,100);
            Elephant elephant = new Elephant("Mamont",Gender.female,100,2000,5000,true);
            wolf.Hunt(elephant);
            Console.WriteLine(elephant.HP);
            Meat meat = new Meat(2500,MeetType.DanaEti);
            ZooCage<Wolf,Food> zooCage = new ZooCage<Wolf, Food>(wolf,meat);
            Console.WriteLine(zooCage.Animal.Breed);


        }
    }
}

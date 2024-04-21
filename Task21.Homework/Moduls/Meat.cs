using GenericType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21.Homework.Moduls
{
    class Meat:Food
    {
        public MeetType Type;

        public Meat(int calori, MeetType type) : base(calori)
        {
            Type = type;
        }
    }
}

namespace GenericType
{
    public enum MeetType
    {
        DanaEti,
        ToyuqEti,
        QoyunEti,
        DonuzEti

    }
}


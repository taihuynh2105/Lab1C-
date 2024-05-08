using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

    public partial class MyClass
    {
    public MyClass()
    {
        numberA = 0;
        numberB = 0;
    }
    public MyClass(int numberA, int numberB)
    {
        this.numberA = numberA;
        this.numberB = numberB;
    }
        public int Cong()
        {
        return numberA + numberB;
        }
        public int Tru()
        {
        return numberA - numberB;
        }
        public int Nhan()
    {
        return numberA * numberB;
    }
    public int Chia()
    {
        return numberA / numberB;
    }


    
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_git1
{
    class Program
    {

        testClass t1 = new testClass();

        static void Main(string[] args)
        {
  
        }

        public void DoSome()
        {
             Console.WriteLine(t1.SomeMethodMod_1());
        }
    }


    class testClass
    {


        int _myVar;

        public testClass()
        {
            _myVar = 5;
        }


        public int MyVar
        {
            get { return _myVar; }
            set { _myVar = value; }
        }

        public string SomeMethodMod_1()
        {
            return "You called SomeMethod";
        }

        public string SomeNewMethod()
        {
            return "You called SomeMethod";
        }
    }


    class testClass1
    {

        public testClass1()
        {
            //empt class

        }
    }
}

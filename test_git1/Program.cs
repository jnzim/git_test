using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_git1
{
    class Program
    {

        

        static void Main(string[] args)
        {
            testClass1 t1 = new testClass1();

            Console.WriteLine(t1.BeterMethodImplemenation());
            Console.ReadLine();
        }

        private void PrintSomeThing()
        {
          
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
            return "You called SomeMethodMod_1";
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

        public string BeterMethodImplemenation()
        {
            string headerString = "This is much better";
            int val = 1;
            string ret = String.Format("{0} : {1}", headerString, val);
            return ret;
        }


    }
}

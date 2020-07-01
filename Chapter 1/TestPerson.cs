using System;

namespace ConsoleApplication1
{
    class TestPerson
    {
        static void Main(string[] args)
        {

            Person joe = new Person();

            joe.Name = "joe";

            Console.WriteLine(joe.Name);

            Console.ReadLine();
        }
    }

    public class Person
    {

        //Attributes  
        private String _Name;
        private String _Address;

        //Methods  
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        public String Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

    }
}

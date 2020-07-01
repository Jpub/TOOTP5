using System;

namespace ConsoleApplication1
{
    class TestPerson
    {
        public static void Main()
        {
            Cabbie joe = new Cabbie("Joe", "1234");

            Console.WriteLine(joe.Name);
            Console.ReadLine();
        }
	}
    
    public class Cabbie 
    {
	
	    private string _Name;
	    private Cab _Cab;

	    public Cabbie() {

    	    _Name = null;
      	    _Cab = null;

   	    }

   	    public Cabbie(string name, string serialNumber) {

    	    _Name = name;
	        _Cab = new Cab(serialNumber);

	    }

        //Methods  
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

    }

    public class Cab 
    {
	
	    public Cab (string serialNumber) {

    	    SerialNumber = serialNumber;

	    }
        
        //The property is public to get, but private to set
        public string SerialNumber { get; private set; }
        
    }

}

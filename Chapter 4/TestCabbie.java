class TestCabbie {
	

	public static void main(String args[]) {
		Cabbie joe = new Cabbie("Joe", "1234");	
			
		System.out.println("Name = " + joe.getName());
	}
}

class Cabbie {
	
	private String name;
	private Cab myCab;

	public Cabbie() {

    	name = null;
      	myCab = null;

   	}

   	public Cabbie(String iName, String serialNumber) {

    	name = iName;
	    myCab = new Cab(serialNumber);

	}

	// Set the Name of the Cabbie
	public void setName(String iName) {
    	name = iName;
	}

	// Get the Name of the Cabbie
	public String getName() {
   	 	return name;
	}


}

class Cab {
	
	private String serialNumber;

   	public Cab (String sn) {

    	serialNumber = sn;

	}


}
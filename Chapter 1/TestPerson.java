public class TestPerson{
	
	public static void main(String args[]) {

		Person joe = new Person();
		
		joe.setName("Joe");
		System.out.println(joe.getName());
		
	}
}

class Person{

    //Attributes  
    private String name;  
    private String address;

    //Methods  
    public String getName(){
        return name;
    }
    public void setName(String n){
        name = n;
    }

    public String getAddress(){
        return address;
    }
    public void setAddress(String adr){
        address = adr;
    }

}

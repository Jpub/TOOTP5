public class TestNumber {
	
	public static void main(String[] args) {

		Number number1 = new Number();
		Number number2 = new Number();
		Number number3 = new Number();
		
	}
}
class Number {

    	
	int count;	// available to both method1 and method2 

    	public void method1() {
        	count = 1;
    	}

    	public void method2() {
        	count = 2;
    	}

}
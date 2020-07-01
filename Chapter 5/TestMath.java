public class TestMath {
    
	public static void main(String[] args) {
    		
		Math myMath = new Math();
		myMath.swap(2, 3);
    		System.out.println("Hello World!");
	}
}

public class Math {

	public int swap(int a, int b){

		int temp = 0;

		temp = a;
		a = b;
		b = temp;

		return temp;

	}

}
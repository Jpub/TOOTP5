import java.util.*;
public class Iterator {
    public static void main(String args[]) {

        // Instantiate an ArrayList.
        ArrayList<String> names = new ArrayList();

        // Add values to the ArrayList
        names.add(new String("Joe"));
        names.add(new String("Mary"));
        names.add(new String("Bob"));
        names.add(new String("Sue"));

                //Now Iterate through the names
        System.out.println("Names:");
        iterate(names );
    }

    private static void iterate(ArrayList<String> arl) {
        for(String listItem : arl) {
                    System.out.println(listItem.toString());
                }
    }
}

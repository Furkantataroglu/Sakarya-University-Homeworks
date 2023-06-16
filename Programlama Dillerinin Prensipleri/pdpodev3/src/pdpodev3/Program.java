package pdpodev3;
import java.util.Scanner;
public class Program {

	public static void main(String[] args) {
		int count = 0;
		Koloni koloniArray[] = new Koloni[100]; 
		 Scanner scanner = new Scanner(System.in);

	     System.out.print("Sayilari girin: ");
	     String input = scanner.nextLine();

	     String[] numbers = input.split(" ");

	     for (String number : numbers) {
	            int num = Integer.parseInt(number);
	            koloniArray[count]= new Koloni(num);
	            count++;
	        }
	   
	        scanner.close();
	      Oyun oyun1 = new Oyun(koloniArray,count);
	}

}

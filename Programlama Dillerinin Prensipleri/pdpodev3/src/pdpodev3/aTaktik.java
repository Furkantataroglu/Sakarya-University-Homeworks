package pdpodev3;
import java.util.Random;
public class aTaktik implements TaktikInterface {

	@Override
	public int savas() {
		Random rand = new Random();
		int randomnumber = rand.nextInt(1001);
		return randomnumber;
	}

}

package pdpodev3;

import java.util.Random;

public class aUretim implements Uretim {

	@Override
	public int uret() {
		Random rand = new Random();
		int randomnumber = rand.nextInt(6);
		return randomnumber;
	}

}

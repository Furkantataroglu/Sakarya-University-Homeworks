package pdpodev3;

import java.util.Random;

public class bUretim implements Uretim {

	@Override
	public int uret() {
		Random rand = new Random();
		int randomnumber = rand.nextInt(11);
		return randomnumber;
	}

}

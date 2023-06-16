package pdpodev3;
import java.util.Random;

public class bTaktik implements TaktikInterface {

	@Override
	public int savas() {
		Random rand = new Random();
		int randomnumber = rand.nextInt(1001);
		randomnumber = (randomnumber*2)-500;
		if(randomnumber>1000)
			    randomnumber=1000;

		if(randomnumber<0)
			    randomnumber=0;
		return randomnumber;
	}

}

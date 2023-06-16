package pdpodev3;

import java.util.Random;


public class Oyun {
	Oyun(Koloni array[],int kolonicount){
	    int durum=1;
	    int ilktur=0;
	    int kolonicountsayaci=kolonicount;
	    
 char[] symbols = new char[127];
        
        for (int i = 1; i <= 127; i++) {
            symbols[i-1] = (char) i;
        }
 
    

    
		
		
		aUretim auretim1 = new aUretim();
		bUretim buretim1 = new bUretim();
		
		aTaktik ataktik1 = new aTaktik();
		bTaktik btaktik1 = new bTaktik();
		
	    for(int i = 0; i<kolonicount;i++)   //ilk turda yemeklerin verilmesi
	    {
	        array[i].yemek = array[i].population * array[i].population;
	        array[i].kaybetme=0;
	        array[i].kazanma=0;
	    }
	    
	    //Başlangıç Durumu.
	    System.out.println("----------------------------------------------------------------------------------");
	    System.out.println("Baslangic Durumu:");
	    System.out.println("Koloni      Populasyon          Yemek Stogu         Kazanma   Kaybetme");
	    
	    for (int i = 0; i < kolonicount; i++)
	    {
	        if(array[i].population==0)
	        System.out.println("--              --                  --                 --        --");
	        else
	        System.out.println(symbols[i]+"              " + array[i].population + "                  "+array[i].yemek);
	    }
	    Random rand = new Random();
	    int i, j;
	    while(durum!=0) {
	    	int ayemek = auretim1.uret();
	    	int byemek = buretim1.uret();
			int randomnumberyemek = rand.nextInt(2);
			
			//Tur başı popülasyon ve yemek arttırma ve azaltma işlemleri.
	        
	        for(int m=0;m<kolonicount;m++)
	        {
	            if(array[m].population >= 0 && array[m].yemek >= 0 )
	            {
	                if(ilktur!=0){
	                array[m].population =array[m].population + array[m].population*20/100;
	                    if(randomnumberyemek==0){
	                        array[m].yemek= array[m].yemek + ayemek; 
	                    }
	                    else
	                    {
	                        array[m].yemek= array[m].yemek + byemek; 
	                    }
	                }
	                else
	                array[m].yemek= array[m].yemek - array[m].population*2;

	            }
	        }
	       
	        for (i = 0; i < kolonicount; i++) {
	            if(array[i].population<=1||array[i].yemek<=0) 
	               {
	                   array[i].population=0;
	                   array[i].yemek=0;
	               }
	           for (j = i + 1; j < kolonicount; j++) {
	               
	               int a = ataktik1.savas();
	               int b = btaktik1.savas();

	              
	               if(array[j].population<=1||array[j].yemek<=0) 
	               {
	                   array[j].population=0;
	                   array[j].yemek=0;
	               }

	               
	               if(array[i].population!=0 && array[j].population!=0){
	               if(array[i].population > array[j].population)     //kolonilere savaş değerlerinin atanması
	               {
	                   array[i].deger = b;
	                   array[j].deger = a;
	                  if(b>a||b==a)
	                  {
	                   int populasyonYuzdesi = (b-a)/10;
	                   array[j].population = array[j].population - ((array[j].population*populasyonYuzdesi)/100);     //kaybeden tarafın popülasyon azaltması.
	                  
	                   array[i].yemek =  array[i].yemek + array[j].yemek*10/100;        //kazanan taraf kaybedenin %10 yemeğini alır.
	                   array[j].yemek =  array[j].yemek - array[j].yemek*10/100;
	                   
	                   array[i].kazanma = array[i].kazanma+1;    //kazanma kaybetme sayıları;
	                   array[j].kaybetme = array[j].kaybetme+1;
	                  

	                  }
	                  if(b<a)
	                  {
	                   int populasyonYuzdesi=(a-b)/10;      
	                   array[i].population = array[i].population - ((array[i].population*populasyonYuzdesi)/100); 
	                   array[j].yemek =  array[j].yemek + array[i].yemek*10/100;        //kazanan taraf kaybedenin %10 yemeğini alır.
	                   array[i].yemek =  array[i].yemek - array[i].yemek*10/100;
	                   
	                   array[j].kazanma = array[j].kazanma+1;    //kazanma kaybetme sayıları;
	                   array[i].kaybetme = array[i].kaybetme+1;
	                  }
	                   
	               }
	               if(array[i].population < array[j].population)
	               {   
	                   array[i].deger = a;
	                   array[j].deger = b;  
	                   if(b>a || b==a){
	                   int populasyonYuzdesi=(b-a)/10;
	                   
	                   array[i].population = array[i].population - ((array[i].population*populasyonYuzdesi)/100); //kaybeden tarafın popülasyon azaltması.  
	                   array[j].yemek =  array[j].yemek + array[i].yemek*10/100;        //kazanan taraf kaybedenin %10 yemeğini alır.
	                   array[i].yemek =  array[i].yemek - array[i].yemek*10/100; 

	                   array[j].kazanma = array[j].kazanma+1;    //kazanma kaybetme sayıları;
	                   array[i].kaybetme = array[i].kaybetme+1;
	                   }

	                   if(b<a)
	                  {
	                   int populasyonYuzdesi=(a-b)/10;      
	                   array[j].population = array[j].population - ((array[j].population*populasyonYuzdesi)/100); 
	                   array[i].yemek =  array[i].yemek + array[j].yemek*10/100;        //kazanan taraf kaybedenin %10 yemeğini alır.
	                   array[j].yemek =  array[j].yemek - array[j].yemek*10/100; 

	                   array[i].kazanma = array[i].kazanma+1;    //kazanma kaybetme sayıları;
	                   array[j].kaybetme = array[j].kaybetme+1;
	                  }
	                   
	               }
	               if(array[i].population == array[j].population)
	               {
	                   array[i].deger = a;
	                   array[j].deger = b;  
	                   if( array[i].deger > array[j].deger)
	                   {
	                   int populasyonYuzdesi=(a-b)/10;      
	                   array[j].population = array[j].population - ((array[j].population*populasyonYuzdesi)/100); 
	                   array[i].yemek =  array[i].yemek + array[j].yemek*10/100;        //kazanan taraf kaybedenin %10 yemeğini alır.
	                   array[j].yemek =  array[j].yemek - array[j].yemek*10/100; 

	                   array[i].kazanma = array[i].kazanma+1;    //kazanma kaybetme sayıları;
	                   array[j].kaybetme = array[j].kaybetme+1;
	                   }

	                   if(array[i].deger < array[j].deger){
	                   int populasyonYuzdesi=(b-a)/10;
	                   
	                   array[i].population = array[i].population - ((array[i].population*populasyonYuzdesi)/100); //kaybeden tarafın popülasyon azaltması.  
	                   array[j].yemek =  array[j].yemek + array[i].yemek*10/100;        //kazanan taraf kaybedenin %10 yemeğini alır.
	                   array[i].yemek =  array[i].yemek - array[i].yemek*10/100; 
	                   
	                   array[j].kazanma = array[j].kazanma+1;    //kazanma kaybetme sayıları;
	                   array[i].kaybetme = array[i].kaybetme+1;
	                   }

	                   if(array[i].deger == array[j].deger){
	                       int randomnumber = rand.nextInt(2);
	                       if(randomnumber==0)
	                       {
	                       int populasyonYuzdesi=(a-b)/10;      
	                       array[j].population = array[j].population - ((array[j].population*populasyonYuzdesi)/100); 
	                       array[i].yemek =  array[i].yemek + array[j].yemek*10/100;        //kazanan taraf kaybedenin %10 yemeğini alır.
	                       array[j].yemek =  array[j].yemek - array[j].yemek*10/100;  

	                       array[i].kazanma = array[i].kazanma+1;    //kazanma kaybetme sayıları;
	                       array[j].kaybetme = array[j].kaybetme+1; 
	                       }
	                       else
	                       {
	                       int populasyonYuzdesi=(b-a)/10;          
	                       array[i].population = array[i].population - ((array[i].population*populasyonYuzdesi)/100); //kaybeden tarafın popülasyon azaltması.  
	                       array[j].yemek =  array[j].yemek + array[i].yemek*10/100;        //kazanan taraf kaybedenin %10 yemeğini alır.
	                       array[i].yemek =  array[i].yemek - array[i].yemek*10/100; 

	                       array[j].kazanma = array[j].kazanma+1;    //kazanma kaybetme sayıları;
	                       array[i].kaybetme = array[i].kaybetme+1;
	                       }
	                   }

	               }
	               }
	               
	               
	           }
	       }
	        for(int k=0;k<kolonicount;k++)
	        {
	            if(array[k].population==0)
	            {
	                kolonicountsayaci--;
	            }
	        }
	        if(kolonicountsayaci<=1)
	        durum=0;
	        kolonicountsayaci=kolonicount;

	        ilktur++;
	        
	        System.out.println("----------------------------------------------------------------------------------");
	        System.out.println("Tur Sayisi:     "+ ilktur);
	        System.out.println("Koloni      Populasyon          Yemek Stogu         Kazanma   Kaybetme");
	       
	        for (int l = 0; l < kolonicount; l++)
	        {
	        	if(array[l].population==0)
	        		System.out.println(symbols[l]+"              --                  --                 --        --");    
	                else
	                	System.out.println(symbols[l]+"              "+array[l].population+"                  "+array[l].yemek+"                  "+ array[l].kazanma +"         "+ array[l].kaybetme);
	        }
	        
	        
	        
	    }
		
	}
}

#include "Oyun.h"

int getsymbols(int symbols[])
{
    int j=0;
    for(int i=169;i<254;i++)
    {
        
        symbols[j]=i;
        j++;
    }
}



Oyun new_Oyun(Koloni array[],int kolonicount){
    srand(time(NULL));
    AProduction aproduction = AProductionCreate();
    BProduction bproduction = BProductionCreate();
    Astrategy astrategy= AstrategyCreate();
    Bstrategy bstrategy=BstrategyCreate();
    int durum=1;
    int ilktur=0;
    int kolonicountsayaci=kolonicount;
    int symbols[127];
    getsymbols(symbols);
    for(int i = 0; i<kolonicount;i++)   //ilk turda yemeklerin verilmesi
    {
        array[i]->yemek = array[i]->population * array[i]->population;
        array[i]->kaybetme=0;
        array[i]->kazanma=0;
    }
    //Başlangıç Durumu.
        printf("----------------------------------------------------------------------------------\n");
        printf("Baslangic Durumu: \n");
        printf("Koloni      Populasyon          Yemek Stogu         Kazanma   Kaybetme\n");
    for (int i = 0; i < kolonicount; i++)
    {
        if(array[i]->population==0)
        printf("%c              --                  --                 --        --\n",symbols[i]);    
        else
        printf("%c              %d                  %d\n",symbols[i], array[i]->population, array[i]->yemek);
    }





        int i, j;
    while(durum!=0){
        int ayemek = aproduction->super->Uret();
        int byemek = bproduction->super->Uret();
        int randomnumberyemek;
        randomnumberyemek = rand() % 1;
       
        //Tur başı popülasyon ve yemek arttırma ve azaltma işlemleri.
        
        for(int m=0;m<kolonicount;m++)
        {
            if(array[m]->population >= 0 && array[m]->yemek >= 0 )
            {
                if(ilktur!=0){
                array[m]->population =array[m]->population + array[m]->population*20/100;
                    if(randomnumberyemek==0){
                        array[m]->yemek= array[m]->yemek + ayemek; 
                    }
                    else
                    {
                        array[m]->yemek= array[m]->yemek + byemek; 
                    }
                }
                else
                array[m]->yemek= array[m]->yemek - array[m]->population*2;

            }
        }
        

    for (i = 0; i < kolonicount; i++) {
         if(array[i]->population<=1||array[i]->yemek<=0) 
            {
                array[i]->population=0;
                array[i]->yemek=0;
            }
        for (j = i + 1; j < kolonicount; j++) {
            
            int a = astrategy->super->Savas();
            int b = bstrategy->super->Savas();

           
            if(array[j]->population<=1||array[j]->yemek<=0) 
            {
                array[j]->population=0;
                array[j]->yemek=0;
            }

            
            if(array[i]->population!=0 && array[j]->population!=0){
            if(array[i]->population > array[j]->population)     //kolonilere savaş değerlerinin atanması
            {
                array[i]->deger = b;
                array[j]->deger = a;
               if(b>a||b==a)
               {
                int populasyonYuzdesi = (b-a)/10;
                array[j]->population = array[j]->population - ((array[j]->population*populasyonYuzdesi)/100);     //kaybeden tarafın popülasyon azaltması.
               
                array[i]->yemek =  array[i]->yemek + array[j]->yemek*10/100;        //kazanan taraf kaybedenin %10 yemeğini alır.
                array[j]->yemek =  array[j]->yemek - array[j]->yemek*10/100;
                
                array[i]->kazanma = array[i]->kazanma+1;    //kazanma kaybetme sayıları;
                array[j]->kaybetme = array[j]->kaybetme+1;
               

               }
               if(b<a)
               {
                int populasyonYuzdesi=(a-b)/10;      
                array[i]->population = array[i]->population - ((array[i]->population*populasyonYuzdesi)/100); 
                array[j]->yemek =  array[j]->yemek + array[i]->yemek*10/100;        //kazanan taraf kaybedenin %10 yemeğini alır.
                array[i]->yemek =  array[i]->yemek - array[i]->yemek*10/100;
                
                array[j]->kazanma = array[j]->kazanma+1;    //kazanma kaybetme sayıları;
                array[i]->kaybetme = array[i]->kaybetme+1;
               }
                
            }
            if(array[i]->population < array[j]->population)
            {   
                array[i]->deger = a;
                array[j]->deger = b;  
                if(b>a || b==a){
                int populasyonYuzdesi=(b-a)/10;
                
                array[i]->population = array[i]->population - ((array[i]->population*populasyonYuzdesi)/100); //kaybeden tarafın popülasyon azaltması.  
                array[j]->yemek =  array[j]->yemek + array[i]->yemek*10/100;        //kazanan taraf kaybedenin %10 yemeğini alır.
                array[i]->yemek =  array[i]->yemek - array[i]->yemek*10/100; 

                array[j]->kazanma = array[j]->kazanma+1;    //kazanma kaybetme sayıları;
                array[i]->kaybetme = array[i]->kaybetme+1;
                }

                if(b<a)
               {
                int populasyonYuzdesi=(a-b)/10;      
                array[j]->population = array[j]->population - ((array[j]->population*populasyonYuzdesi)/100); 
                array[i]->yemek =  array[i]->yemek + array[j]->yemek*10/100;        //kazanan taraf kaybedenin %10 yemeğini alır.
                array[j]->yemek =  array[j]->yemek - array[j]->yemek*10/100; 

                array[i]->kazanma = array[i]->kazanma+1;    //kazanma kaybetme sayıları;
                array[j]->kaybetme = array[j]->kaybetme+1;
               }
                
            }
            if(array[i]->population == array[j]->population)
            {
                array[i]->deger = a;
                array[j]->deger = b;  
                if( array[i]->deger > array[j]->deger)
                {
                int populasyonYuzdesi=(a-b)/10;      
                array[j]->population = array[j]->population - ((array[j]->population*populasyonYuzdesi)/100); 
                array[i]->yemek =  array[i]->yemek + array[j]->yemek*10/100;        //kazanan taraf kaybedenin %10 yemeğini alır.
                array[j]->yemek =  array[j]->yemek - array[j]->yemek*10/100; 

                array[i]->kazanma = array[i]->kazanma+1;    //kazanma kaybetme sayıları;
                array[j]->kaybetme = array[j]->kaybetme+1;
                }

                if(array[i]->deger < array[j]->deger){
                int populasyonYuzdesi=(b-a)/10;
                
                array[i]->population = array[i]->population - ((array[i]->population*populasyonYuzdesi)/100); //kaybeden tarafın popülasyon azaltması.  
                array[j]->yemek =  array[j]->yemek + array[i]->yemek*10/100;        //kazanan taraf kaybedenin %10 yemeğini alır.
                array[i]->yemek =  array[i]->yemek - array[i]->yemek*10/100; 
                
                array[j]->kazanma = array[j]->kazanma+1;    //kazanma kaybetme sayıları;
                array[i]->kaybetme = array[i]->kaybetme+1;
                }

                if(array[i]->deger == array[j]->deger){
                    int randomnumber;
                    randomnumber = rand() % 1;
                    if(randomnumber==0)
                    {
                    int populasyonYuzdesi=(a-b)/10;      
                    array[j]->population = array[j]->population - ((array[j]->population*populasyonYuzdesi)/100); 
                    array[i]->yemek =  array[i]->yemek + array[j]->yemek*10/100;        //kazanan taraf kaybedenin %10 yemeğini alır.
                    array[j]->yemek =  array[j]->yemek - array[j]->yemek*10/100;  

                    array[i]->kazanma = array[i]->kazanma+1;    //kazanma kaybetme sayıları;
                    array[j]->kaybetme = array[j]->kaybetme+1; 
                    }
                    else
                    {
                    int populasyonYuzdesi=(b-a)/10;          
                    array[i]->population = array[i]->population - ((array[i]->population*populasyonYuzdesi)/100); //kaybeden tarafın popülasyon azaltması.  
                    array[j]->yemek =  array[j]->yemek + array[i]->yemek*10/100;        //kazanan taraf kaybedenin %10 yemeğini alır.
                    array[i]->yemek =  array[i]->yemek - array[i]->yemek*10/100; 

                    array[j]->kazanma = array[j]->kazanma+1;    //kazanma kaybetme sayıları;
                    array[i]->kaybetme = array[i]->kaybetme+1;
                    }
                }

            }
            }
            
            
        }
    }

    for(int i=0;i<kolonicount;i++)
    {
        if(array[i]->population==0)
        {
            kolonicountsayaci--;
        }
    }
    if(kolonicountsayaci<=1)
    durum=0;
    kolonicountsayaci=kolonicount;

    ilktur++;
        printf("----------------------------------------------------------------------------------\n");
        printf("Tur Sayisi: %d\n",ilktur);
        printf("Koloni      Populasyon          Yemek Stogu         Kazanma   Kaybetme\n");
    for (int i = 0; i < kolonicount; i++)
    {
        if(array[i]->population==0)
        printf("%c              --                  --                 --        --\n",symbols[i]);    
        else
        printf("%c              %d                  %d                  %d         %d\n",symbols[i],array[i]->population, array[i]->yemek,array[i]->kazanma,array[i]->kaybetme);
        
        array[i]->delete;
       
    }
        aproduction->pDELETE;
        bproduction->pDELETE;
        astrategy->DELETE;
        bstrategy->DELETE;
    }
     
 
          

    
        
}
void delete_Oyun(const Oyun this){
     if(this==NULL) return;
    free(this);
}
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include "aTaktik.h"
#include "bTaktik.h"
#include "aUretim.h"
#include "bUretim.h"
#include "Koloni.h"
#include "Oyun.h"


#define MAX_SIZE 100
int main (int argc , char *argv[])
{   
     srand(time(NULL));
    int numbers[MAX_SIZE];
    int count = 0;
    char input[255];

    printf("Sayilari giriniz: ");
    fgets(input, sizeof(input), stdin);
    
    char *token = strtok(input, " ");
    
    // Kullanıcıdan alınan sayıları ayrıştırarak diziye yerleştir
    while (token != NULL && count < MAX_SIZE) {
        sscanf(token, "%d", &numbers[count]);
        count++;
        token = strtok(NULL, " ");
    }
    
    Koloni koloniArray[100];
    int koloniCount = 0;

    for (int i = 0; i < count; i++) {
      
        Koloni koloni1 = new_Koloni(numbers[i]);
        
        if (koloni1 != NULL) {
            koloniArray[koloniCount++] = koloni1;
        }
       
    }    
    Oyun oyun = new_Oyun(koloniArray,koloniCount);
    for (int i = 0; i < koloniCount; i++){
         koloniArray[i]->delete(koloniArray[i]);
    }
   
    



    return 0;

 
}
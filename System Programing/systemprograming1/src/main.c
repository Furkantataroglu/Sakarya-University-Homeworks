#include <stdio.h>
#include <stdlib.h>
#include "fields.h"

int main() {
   printf("aAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
   
       IS is;  // Inputstruct türünden bir değişken
    int i;

    is = new_inputstruct("data.dat");  // Dosyayı aç
    if (is == NULL) {
        perror("Dosya açılamadı");
        return EXIT_FAILURE;
    }

    while (get_line(is) >= 0) {  // Her satırı oku
        printf("Satır %d: %s\n", is->line, is->text1);
        for (i = 0; i < is->NF; i++) {
            printf("  Kelime %d: %s\n", i, is->fields[i]);
        }
    }

    jettison_inputstruct(is);  // Inputstruct'ı serbest bırak
    return EXIT_SUCCESS;

}

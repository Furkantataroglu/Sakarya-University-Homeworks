#include "dllist.h"
#include <string.h>
#include <stdlib.h>
#include <stdio.h>
#include "fields.h"

// Verilen karakteri belirli sayıda dllist'e ekler
void append_chars(Dllist list, char c, int count) {
    for (int i = 0; i < count; i++) {
        dll_append(list, new_jval_c(c));
    }
}

// Belirli bir karakteri belirli sayıda siler ve silme sonrası konumu ayarlar
Dllist delete_chars(Dllist list, Dllist current, char c, int count) {
    while (current != dll_nil(list) && count > 0) {
        if (dll_val(current).c == c) {
            Dllist to_delete = current;
            current = dll_prev(current);
            dll_delete_node(to_delete);
            count--;
        } else {
            current = dll_prev(current);
        }
    }
    return current;  // Güncel konumu döndür
}

int main() {
    IS is = new_inputstruct("data.dat");
    if (is == NULL) {
        perror("Dosya açılamadı");
        exit(1);
    }

    Dllist list = new_dllist(), current = dll_nil(list);

    while (get_line(is) >= 0) {
        if (strcmp(is->fields[0], "yaz:") == 0) {
            for (int i = 1; i < is->NF; i += 2) {
                int num = atoi(is->fields[i]);
                char ch = is->fields[i+1][0];
                if (strcmp(is->fields[i+1], "\\b") == 0) {
                    ch = ' ';
                } else if (strcmp(is->fields[i+1], "\\n") == 0) {
                    ch = '\n';
                }
                append_chars(list, ch, num);
            }
        } else if (strcmp(is->fields[0], "sil:") == 0) {
            for (int i = 1; i < is->NF; i += 2) {
        int num = atoi(is->fields[i]);
        char ch = is->fields[i+1][0];
        current = delete_chars(list, dll_last(list), ch, num); // Her çift için silme işlemi yap

            }
        } else if (strcmp(is->fields[0], "sonagit:") == 0) {
            current = dll_last(list);  // Listeyi sona taşı
        } else if (strcmp(is->fields[0], "dur:") == 0) {
            break;
        }
    }

    // Çıktı dosyasına yazma
    FILE *out = fopen("cikis.dat", "w");
    dll_traverse(current, list) {
        fprintf(out, "%c", dll_val(current).c);
    }

    fclose(out);
    free_dllist(list);
    jettison_inputstruct(is);

    return 0;
}
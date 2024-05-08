#include "dllist.h"
#include <string.h>
#include <stdlib.h>
#include <stdio.h>
#include "fields.h"

void append_chars(Dllist list, char* str, int count) {
    for (int i = 0; i < count; i++) {
        for (int j = 0; str[j] != '\0'; j++) {
            dll_append(list, new_jval_c(str[j]));
        }
    }
}

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
    return current;
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
                char *endptr;
                long num = strtol(is->fields[i], &endptr, 10);
                if (*endptr != '\0' || endptr == is->fields[i]) {
                    fprintf(stderr, "Hatalı format: Sayısal değer bekleniyor, bulunan '%s'\n", is->fields[i]);
                    continue;
                }
                char* str = is->fields[i+1];
                if (strcmp(str, "\\b") == 0) {
                    str = " ";
                } else if (strcmp(str, "\\n") == 0) {
                    str = "\n";
                }
                append_chars(list, str, num);
            }
        } else if (strcmp(is->fields[0], "sil:") == 0) {
            for (int i = 1; i < is->NF; i += 2) {
                int num = atoi(is->fields[i]);
                char ch = is->fields[i+1][0];
                current = delete_chars(list, dll_last(list), ch, num);
            }
        } else if (strcmp(is->fields[0], "sonagit:") == 0) {
            current = dll_last(list);
        } else if (strcmp(is->fields[0], "dur:") == 0) {
            break;
        }
    }

    FILE *out = fopen("cikis.dat", "w");
    dll_traverse(current, list) {
        fprintf(out, "%c", dll_val(current).c);
    }

    fclose(out);
    free_dllist(list);
    jettison_inputstruct(is);

    return 0;
}

# Hedefler ve bağımlılıkları belirten kısım
all: program

program: main
	gcc ./lib/main.o ./lib/fields.o ./lib/dllist.o ./lib/jval.o -o ./bin/program

main: ./src/Main.c ./src/Fields.c ./src/dllist.c ./src/jval.c
	gcc -I "./include" -c ./src/Main.c -o ./lib/main.o
	gcc -I "./include" -c ./src/Fields.c -o ./lib/fields.o
	gcc -I "./include" -c ./src/dllist.c -o ./lib/dllist.o
	gcc -I "./include" -c ./src/jval.c -o ./lib/jval.o

# Bu hedef doğrudan herhangi bir şey çalıştırmaz, sadece yürütülebilir dosyayı oluşturur
.PHONY: all

# Programı çalıştırmak için kullanılan hedef
calistir:
	./bin/program
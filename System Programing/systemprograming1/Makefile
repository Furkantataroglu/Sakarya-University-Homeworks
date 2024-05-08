derlecalistir:program calistir

program:main
	gcc ./lib/main.o ./lib/fields.o ./lib/dllist.o ./lib/jval.o -o ./bin/program
main:
	gcc -I "./include" -c ./src/Main.c -o ./lib/main.o
	gcc -I "./include" -c ./src/Fields.c -o ./lib/fields.o
	gcc -I "./include" -c ./src/dllist.c -o ./lib/dllist.o
	gcc -I "./include" -c ./src/jval.c -o ./lib/jval.o

calistir:
	./bin/program
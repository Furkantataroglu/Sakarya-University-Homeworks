derlecalistir:program calistir

program:main
	gcc ./lib/main.o ./lib/fields.o -o ./bin/program
main:
	gcc -I "./include" -c ./src/Main.c -o ./lib/main.o
	gcc -I "./include" -c ./src/Fields.c -o ./lib/fields.o
calistir:
	./bin/program
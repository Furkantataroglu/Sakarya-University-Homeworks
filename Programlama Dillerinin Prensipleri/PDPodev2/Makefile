derlecalistir:program calistir

program:test.o taktik.o ataktik.o btaktik.o uretim.o auretim.o buretim.o koloni.o oyun.o
	gcc ./lib/test.o ./lib/taktik.o ./lib/ataktik.o ./lib/btaktik.o ./lib/uretim.o ./lib/auretim.o ./lib/buretim.o ./lib/koloni.o ./lib/oyun.o -o ./bin/program
test.o:
	gcc -I "./include" -c ./src/Test.c -o ./lib/test.o
taktik.o:
	gcc -I "./include" -c ./src/Taktik.c -o ./lib/Taktik.o
ataktik.o:
	gcc -I "./include" -c ./src/aTaktik.c -o ./lib/aTaktik.o
btaktik.o:
	gcc -I "./include" -c ./src/bTaktik.c -o ./lib/bTaktik.o
uretim.o:
	gcc -I "./include" -c ./src/Uretim.c -o ./lib/Uretim.o
auretim.o:
	gcc -I "./include" -c ./src/aUretim.c -o ./lib/aUretim.o
buretim.o:
	gcc -I "./include" -c ./src/bUretim.c -o ./lib/bUretim.o
koloni.o:
	gcc -I "./include" -c ./src/Koloni.c -o ./lib/Koloni.o
oyun.o:
	gcc -I "./include" -c ./src/Oyun.c -o ./lib/Oyun.o
calistir:
	./bin/program.exe

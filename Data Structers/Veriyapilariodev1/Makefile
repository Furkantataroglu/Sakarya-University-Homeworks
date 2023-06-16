derlecalistir:program 
program:dugum.o  satirlistesi.o okuekle.o main.o yoneticidugum.o yoneticilistesi.o ekranayazdir.o
	g++ ./lib/dugum.o ./lib/main.o ./lib/satirlistesi.o ./lib/okuekle.o ./lib/yoneticidugum.o ./lib/yoneticilistesi.o ./lib/ekranayazdir.o -o ./bin/program
dugum.o:
	g++ -I "./include" -c ./src/Dugum.cpp -o ./lib/Dugum.o
okuekle.o:
	g++ -I "./include" -c ./src/Okuekle.cpp -o ./lib/Okuekle.o

satirlistesi.o:
	g++ -I "./include" -c ./src/SatirListesi.cpp -o ./lib/SatirListesi.o
main.o:
	g++ -I "./include" -c ./src/main.cpp -o ./lib/main.o
yoneticidugum.o:
	g++ -I "./include" -c ./src/YoneticiDugum.cpp -o ./lib/YoneticiDugum.o
yoneticilistesi.o:
	g++ -I "./include" -c ./src/YoneticiListesi.cpp -o ./lib/YoneticiListesi.o
ekranayazdir.o:
	g++ -I "./include" -c ./src/EkranaYazdir.cpp -o ./lib/EkranaYazdir.o




calistir:
	./bin/program.exe
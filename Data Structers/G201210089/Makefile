derlecalistir:program
program:dugum.o main.o control.o radix.o doku.o binarytreenode.o binaryagac.o organdugum.o organ.o sistem.o hucre.o
	g++ ./lib/dugum.o ./lib/kuyruk.o ./lib/main.o ./lib/radix.o ./lib/doku.o ./lib/binaryagac.o ./lib/binarytreenode.o ./lib/organdugum.o ./lib/organ.o ./lib/sistemveorganizma.o ./lib/control.o ./lib/hucre.o -o ./bin/program
dugum.o:
	g++ -I "./include" -c ./src/Dugum.cpp -o ./lib/Dugum.o
main.o:
	g++ -I "./include" -c ./src/main.cpp -o ./lib/main.o
control.o:
	g++ -I "./include" -c ./src/Control.cpp -o ./lib/Control.o
radix.o:
	g++ -I "./include" -c ./src/Radix.cpp -o ./lib/Radix.o
doku.o:
	g++ -I "./include" -c ./src/Doku.cpp -o ./lib/Doku.o
binarytreenode.o:
	g++ -I "./include" -c ./src/BinaryTreeNode.cpp -o ./lib/BinaryTreeNode.o
binaryagac.o:
	g++ -I "./include" -c ./src/BinaryAgac.cpp -o ./lib/BinaryAgac.o
organdugum.o:
	g++ -I "./include" -c ./src/OrganDugum.cpp -o ./lib/OrganDugum.o
organ.o:
	g++ -I "./include" -c ./src/Organ.cpp -o ./lib/Organ.o
sistem.o:
	g++ -I "./include" -c ./src/SistemVeOrganizma.cpp -o ./lib/SistemVeOrganizma.o
hucre.o:
	g++ -I "./include" -c ./src/Hucre.cpp -o ./lib/Hucre.o
calistir:
	./bin/program.exe
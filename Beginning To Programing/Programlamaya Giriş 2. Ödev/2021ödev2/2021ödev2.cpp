/****************************************************************************
**	SAKARYA UNIVERSITY
**	BILGISAYAR MUHENDISLIGI BOLUMU
**	PROGRAMLAMAYA GIRIS
**
**	ÖĞRENCİ ADI......: FURKAN TATAROĞLU
**	ÖĞRENCİ NUMARASI.: g201210089
**	DERS GRUBU…………………: C
****************************************************************************/


#include <iostream>
#include <string>
#include <Windows.h>
#include <stdlib.h>
using namespace std;
char	DUZCIZGI = 205;         //cizgileri tanimladim
char	SOLUSTKOSE = 201;
char	SAGUSTKOSE = 187;
char	DIKEYCIZGI = 186;
char	ASAGIAYRAC = 203;
char	SOLALTKOSE = 200;
char	SAGALTKOSE = 188;
char	YUKARIAYRAC = 202;


char harfler[] = { "ABCDEFGHIJKLMNOPQRSTUVWXYZ" };  //harf arrayi

class karakter          //harf classi
{
public:
    char harf;
};
karakter harff;
string alınanharfler;



class katar                 //karakter eklemek ve cikarmak icin class
{
public:
    //karakter ekleyecek
    void karakterekle() {
        alınanharfler += harff.harf;

    }

    //karakter cikaracak
    void karaktercikar() {
        alınanharfler.pop_back();
    }

    //yazdirma fonksiyonu
    void yazdir() {
        for (int i = 0; i < alınanharfler.length(); i++) {
            cout << SOLUSTKOSE << DUZCIZGI << DUZCIZGI << DUZCIZGI << SAGUSTKOSE;

        }
        cout << endl;

        //rastgele renk alma
        for (int l = 0; l < alınanharfler.length(); l++) {
            int colors[6] = { 9, 10, 11, 12, 13, 14 };
            int randomcolor = colors[rand() % 6];
            cout << DIKEYCIZGI << " ";
            HANDLE h = GetStdHandle(STD_OUTPUT_HANDLE);
            SetConsoleTextAttribute(h, randomcolor);
            cout << alınanharfler[l];
            SetConsoleTextAttribute(h, 7);
            cout << " " << DIKEYCIZGI;
        }
        cout << endl;



        for (int k = 0; k < alınanharfler.length();k++) {
            cout << SOLALTKOSE << DUZCIZGI << DUZCIZGI << DUZCIZGI << SAGALTKOSE;
        }
        cout << endl;
    }
};
int main()
{
    int MAX = 50;               //max karakter sayisi
    katar katarlar;
    int secilendeger;
    int control = 0;

    srand(time(NULL));

    for (int k = 0;k > -1;++k)
    {

        if (alınanharfler.length() == MAX)     //max karakter sayisine gelince uyarma
        {
            control = 1;
            if (control == 1)
                cout << "En fazla 50 karakter ekleyebilirsiniz lutfen karakter cikarin." << endl;
            cout << "Islem Seciniz" << endl;
            cout << "1- Karakter Ekle" << endl;
            cout << "2- Karakter Cikar" << endl;
            cout << "3- Programdan Cikis" << endl;

            cin >> secilendeger;

            if (secilendeger == 2)
                katarlar.karaktercikar();
        }


        else if (alınanharfler.length() < MAX)
        {
            cout << "Islem Seciniz" << endl;
            cout << "1- Karakter Ekle" << endl;
            cout << "2- Karakter Cikar" << endl;
            cout << "3- Programdan Cikis" << endl;

            cin >> secilendeger;

            harff.harf = harfler[rand() % 26];

            if (secilendeger == 1)
            {

                katarlar.karakterekle();

                katarlar.yazdir();

            }
            else if (secilendeger == 2)                 //karakter cikarm fonk cagirma
            {
                katarlar.karaktercikar();

                katarlar.yazdir();

            }
            else if (secilendeger == 3)                 //cikis yapma
            {
                cout << "Cikis yapiliyor...";
                exit(1);
                return 1;
            }

            if (alınanharfler.length() <= 0)            //min karakter sayisi
            {
                HANDLE h = GetStdHandle(STD_OUTPUT_HANDLE);

                SetConsoleTextAttribute(h, 12);

                cout << "Daha fazla karakter cikaramazsiniz karakter ekleyin." << endl;

                SetConsoleTextAttribute(h, 7);
                katarlar.karakterekle();
            }

        }
    }
}



/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				          PROGRAMLAMAYA GİRİŞİ DERSİ
**
**				ÖDEV NUMARASI…...:Proje 1.öevi
**				ÖĞRENCİ ADI...............:FURKAN TATAROĞLU
**				ÖĞRENCİ NUMARASI.:g201210089
**				DERS GRUBU…………:C
****************************************************************************/


#include <fstream>
#include <iostream>
using namespace std;
#include <string>


int main()
{
//Urun icin gereken degerler
    string urunadi;
    int urunkodu;
    string uretici;
    int fiyatgenel;
    int fiyatozel;
    int gun = 0;int ay = 0;int yil = 0;
    const int kdvorani = 18;
    int stokadedi;
    int teminsuresi;
    int secim = 1;
    //musteri icin gereken degerler
    int firmakod;
    string firmaadi;
    int firmano;
    string firmasorumlusu;
    string adres;
    string musterikatagori;

    ifstream DosyaOku;
    ofstream DosyaYaz;
    string foo;  //urunleri listelemek icin gereken string
    for (int k = 0;k > -1;k++) {//menü
        cout << "Urun Islemleri icin 1' e basin." << endl;
        cout << "Musteri Dosyasi islemleri icin 2' ye basin." << endl;              
        cout << "Siparis icin 3'e basin." << endl;
        cin >> secim;

        if (secim == 1) {
            int b;
            cout << endl;
            cout << "Urun eklemek icin 1'e basin." << endl;
            cout << "Urun arama icin 2'ye basin." << endl;
            cout << "Urun listeleme icin 3'e basin." << endl;
            cout << "Urun duzeltme icin 4'e basin." << endl;
            cout << endl;
            
            cin >> b;

            if (b == 1) {//dosyaya urunleri yazacak


                DosyaYaz.open("Urun.txt", ios::app);

                cin.ignore();
                cout << "Urun adi: ";
                getline(cin, urunadi);
                cout << "Uretici: ";
                getline(cin, uretici);
                cout << "Urun kodu(sadece tam sayilar): ";
                cin >> urunkodu;
                cout << "Temin suresi (gun): ";
                cin >> teminsuresi;
                cout << "Uretim tarihini giriniz  gun,ay,yil seklinde" << endl;
                cout << "Uretim tarihi once gunu giriniz: ";
                cin >> gun;
                cout << "Uretim tarihi ayi giriniz: ";
                cin >> ay;
                cout << "Uretim tarihi yili giriniz: ";
                cin >> yil;
                cout << "Fiyat %18KDV eklenecektir (genel musteri): ";
                cin >> fiyatgenel;
                fiyatgenel += (fiyatgenel * kdvorani) / 100;
                cout << "Fiyati giriniz %18KDV eklenecektir (ozel musteri): ";
                cin >> fiyatozel;
                fiyatozel += (fiyatozel * kdvorani) / 100;
                cout << "Stok adedi giriniz: ";
                cin >> stokadedi;

                DosyaYaz << urunadi << " " << uretici << " " << urunkodu << " "
                    << teminsuresi << " " << gun << "/" << ay << "/" << yil << " " << fiyatgenel << " " << fiyatozel << " " << stokadedi << endl;
                DosyaYaz.close();
                foo += "\n ";       //urun listesi
                foo += urunadi;
                cout << "Urun kaydi tamamlandi. " << endl;
            }

            if (b == 2) {//ürün arama
                int urunkoduu;

                cout << "Aramak istediginiz urunun kodunu giriniz: ";
                cin >> urunkoduu; //girilecek kod urunkodu ile eşit olacak



                DosyaOku.open("Urun.txt", ios::in);
                while (!DosyaOku.eof()) {//dosyayı baştan sona okuyup ürünleri alacak
                    DosyaOku >> urunadi >> uretici >> urunkodu >> teminsuresi >> gun >> ay >> yil >> fiyatgenel >> fiyatozel >> stokadedi;
                    if (urunkoduu == urunkodu) {//bulunani yazdır

                        cout << "\n Urun Bulundu\n";
                        cout << "Urunun adi: " << urunadi << endl;
                        cout << "Ureticinin adi: " << uretici << endl;
                        cout << "Urun kodu: " << urunkodu << endl;
                        cout << "Temin suresi: " << teminsuresi << "gun." << endl;
                        cout << "Uretim tarihi: " << gun << "/" << ay << "/" << yil << endl;
                        cout << "Genel musteri icin fiyatı: " << fiyatgenel << "TL" << endl;
                        cout << "Ozel musteri icin fiyatı: " << fiyatozel << "TL" << endl;
                        cout << "Stok sayisi: " << stokadedi << endl;


                    }
                    else { cout << "Bulunamadi." << endl; }
                    DosyaOku.close();

                    break;
                }

            }
            //ürün listesi
            if (b == 3) {
                cout << "         Mevcut Urunler" << endl;
                cout << foo << endl;

            }
            if (b == 4) {//ürünün ismini girerek ürün güncelleme
                cout << "\nGuncellemek istediginiz urunun adini girin:" << endl;
                string ad;
                cin >> ad;
                DosyaOku.open("Urun.txt");
                DosyaYaz.open("Urun.txt");
                while (!DosyaOku.eof()) {
                    DosyaOku >> urunadi >> uretici >> urunkodu >> teminsuresi >> gun >> ay >> yil >> fiyatgenel >> fiyatozel >> stokadedi;
                    string uurunadi;
                    string uuretici;
                    int uurunkodu;
                    int uteminsuresi;
                    int ugun;
                    int uay;
                    int uyil;
                    int ufiyatgenel;
                    int ufiyatozel;
                    int ustokadedi;


                    if (ad == urunadi) {//overwrite
                        cin.ignore();
                        cout << "Urun adi: ";
                        getline(cin, uurunadi);
                        cout << "Uretici: ";
                        getline(cin, uuretici);
                        cout << "Urun kodu(sadece tam sayilar): ";
                        cin >> uurunkodu;
                        cout << "Temin suresi (gun): ";
                        cin >> uteminsuresi;
                        cout << "Uretim tarihini giriniz  gun,ay,yil seklinde" << endl;
                        cout << "Uretim tarihi once gunu giriniz: ";
                        cin >> ugun;
                        cout << "Uretim tarihi ayi giriniz: ";
                        cin >> uay;
                        cout << "Uretim tarihi yili giriniz: ";
                        cin >> uyil;
                        cout << "Fiyat %18KDV eklenecektir (genel musteri): ";
                        cin >> ufiyatgenel;
                        ufiyatgenel += (ufiyatgenel * kdvorani) / 100;
                        cout << "Fiyati giriniz %18KDV eklenecektir (ozel musteri): ";
                        cin >> ufiyatozel;
                        ufiyatozel += (ufiyatozel * kdvorani) / 100;
                        cout << "Stok adedi giriniz: ";
                        cin >> ustokadedi;

                        DosyaYaz << uurunadi << " " << uuretici << " " << uurunkodu << " "
                            << " " << uteminsuresi << " " << ugun << "/" << uay << "/" << uyil << " " << ufiyatgenel << " " << ufiyatozel << " " << ustokadedi << endl << endl;

                    }
                    else { cout << "Urun bulunamadi." << endl; }
                    DosyaOku.close();
                    DosyaYaz.close();
                    break;
                }


            }
        }

        if (secim == 2) {//musteri islemleri
            int a;
            cout << "Musteri eklemek icin 1'e basin." << endl;
            cout << "Musteri arama icin 2'ye basin." << endl;
            cout << "Musteri duzeltme icin 3'e basin." << endl;
            cout << "Musteri silme icin 4'e basin." << endl;
            cin >> a;
            if (a == 1) {//musteri ekleyecek
                DosyaYaz.open("cari.txt", ios::app);

                cin.ignore();
                cout << "Firma adi: ";
                getline(cin, firmaadi);
                cout << "Adres: ";
                getline(cin, adres);
                cout << "Firma kodu: ";
                cin >> firmakod;
                cout << "Firma telefonu: ";
                cin >> firmano;
                cout << "Firma sorumlusu: ";
                cin >> firmasorumlusu;
                do {//genel ozel yazmaya zorlayacak
                    cout << "Musteri katagorisi(genel/ozel): ";
                    cin >> musterikatagori;
                } while (musterikatagori != "genel" && musterikatagori != "ozel");


                


                DosyaYaz << firmaadi << " " << firmakod << " " << firmano << " "
                    << firmasorumlusu << " " << musterikatagori << " " << adres << endl;
                DosyaYaz.close();
                cout << "Musteri kaydi tamamlandi. " << endl;
            }
            if (a == 2) {//musteri arama
                int firmakoduu;

                cout << "Aramak istediginiz firmanin kodunu giriniz: ";
                cin >> firmakoduu;
                DosyaOku.open("cari.txt", ios::in);
                while (!DosyaOku.eof()) {
                    DosyaOku >> firmaadi >> firmakod >> firmano >> firmasorumlusu >> musterikatagori >> adres;
                    if (firmakoduu == firmakod) {
                        cout << "\nMusteri Bulundu\n";
                        cout << "Firmanin adi: " << firmaadi << endl;
                        cout << "Firma kodu: " << firmakod << endl;
                        cout << "Firmanin numarasi: " << firmano << endl;
                        cout << "Firmanin sorumlusu: " << firmasorumlusu << endl;
                        cout << "Musteri katagorisi: " << musterikatagori << endl;
                        cout << "Adres :" << adres << endl;
                    }
                    else { cout << "Bulunamadi."<<endl; }
                    DosyaOku.close();

                    break;
                }
            }
            if (a == 3) {//musteri guncelleme
                cout << "\nGuncellemek istediginiz firmanin adini girin:" << endl;
                string ad;
                cin >> ad;
                DosyaOku.open("cari.txt");
                DosyaYaz.open("cari.txt");
                while (!DosyaOku.eof()) {
                    DosyaOku >> firmaadi >> firmakod >> firmano >> firmasorumlusu >> musterikatagori >> adres;
                    string ufirmaadi;
                    int ufirmakod;
                    int ufirmano;
                    int ufirmasorumlusu;
                    string umusterikatagori;
                    string uadres;
                    if (ad == firmaadi) {
                        cin.ignore();
                        cout << "Firma adi: ";
                        getline(cin, ufirmaadi);
                        cout << "Firma kodu: ";
                        cin >> ufirmakod;                       
                        cout << "Firma numarası: ";
                        cin >> ufirmano;
                        cout << "Firma sorumlusu: ";   
                        cin >> ufirmasorumlusu;
                        do {
                            cout << "Musteri katagorisi(genel/ozel): ";
                            cin >> umusterikatagori;
                        } while (umusterikatagori != "genel" && umusterikatagori != "ozel");
                        cin.ignore();
                        cout << "Adres: ";
                        getline(cin, uadres);


                        DosyaYaz << ufirmaadi << " " << ufirmakod << " " <<firmano<<" "<< ufirmasorumlusu << " "
                            << " " << umusterikatagori << " " << uadres << endl << endl;

                    }
                    else { cout << "Urun bulunamadi." << endl; }
                    DosyaOku.close();
                    DosyaYaz.close();
                    break;
                }








            }


        }
     
    }
}
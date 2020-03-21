#include <iostream>

using namespace std;
int main() {

/*int for input*/
double darlehen, tilgungssatz, zinssatz;

/*int for calc*/
int jahr; 
double saldo, tilgung, zinsen, annuitaet, restschuld;

cout << endl << "Geben Sie das Darlehen ein: ";
cin >> darlehen;
saldo = darlehen;

cout << endl << "Geben Sie den Zinssatz ein: ";
cin >> zinssatz;

cout << endl << "Geben Sie den Tilgungssatz ein: ";
cin >> tilgungssatz;

cout << "------------------------------";

/*calc first*/
jahr = 1;
tilgung = saldo * tilgungssatz / 100;
zinsen = saldo * zinssatz / 100;
annuitaet = tilgung + zinsen;
restschuld = saldo - tilgung;

cout << endl << "Saldo: " << floor(saldo * 100.0 + .5 ) / 100.0 << " €";
cout << endl << "Tilgung: " << floor(tilgung * 100.0 + .5 ) / 100.0 << " €";
cout << endl << "Zinsen: " << floor(zinsen * 100.0 + .5 ) / 100.0 << " €";
cout << endl << "Annuit\204t: " << floor(annuitaet * 100.0 + .5 ) / 100.0 << " €";
cout << endl << "Restschuld: " << floor(restschuld * 100.0 + .5 ) / 100.0 << " €";

do {
cout << endl << "----------";
/*calc second*/
saldo = restschuld;
zinsen = saldo * zinssatz / 100;
tilgung = annuitaet - zinsen;
restschuld = saldo - tilgung;
jahr++;
/*output*/
cout << endl << "Jahr: " << jahr;
cout << endl << "Saldo: " << floor(saldo * 100.0 + .5 ) / 100.0 << " €";
cout << endl << "Tilgung: " << floor(tilgung * 100.0 + .5 ) / 100.0 << " €";
cout << endl << "Zinsen: " << floor(zinsen * 100.0 + .5 ) / 100.0 << " €";
cout << endl << "Annuit\204t: " << floor(annuitaet * 100.0 + .5 ) / 100.0 << " €";
cout << endl << "Restschuld: " << floor(restschuld * 100.0 + .5 ) / 100.0 << " €";
if (restschuld <= annuitaet){
zinsen = saldo * zinssatz / 100;
tilgung = restschuld;
annuitaet = tilgung + zinsen;
jahr++;
restschuld = 0;
cout << endl << "----------";
cout << endl << "Jahr: " << jahr;
cout << endl << "Saldo: " << floor(saldo * 100.0 + .5 ) / 100.0 << " €";
cout << endl << "Tilgung: " << floor(tilgung * 100.0 + .5 ) / 100.0 << " €";
cout << endl << "Zinsen: " << floor(zinsen * 100.0 + .5 ) / 100.0 << " €";
cout << endl << "Annuit\204t: " << floor(annuitaet * 100.0 + .5 ) / 100.0 << " €";
cout << endl << "Restschuld: " << floor(restschuld * 100.0 + .5 ) / 100.0 << " €";
}
} while (restschuld > 0);
	getchar();
	return 0; 
}

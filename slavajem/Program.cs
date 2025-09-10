/*
int arv1 = 100; // siin om arv 100
float arv2 = 25.5;
int arv3 = 50;
int tulemus = arv1 + arv2; // siin on tehe
Console.WriteLine("tulemus " + tulemus); // kuvame tulemuse välja
Console.WriteLine("https://meet.google.com/xjy-drff-qbf");
string tekst1 = "mingisugune tekst";
string tekst2 = "AM THRIST, gib water"; //kasutage esitatav tekst
Console.WriteLine(tekst1 + tekst2);
bool thisthing = false; //minisugune olek
Console.WriteLine(thisthing);
string yourname = Console.ReadLine();
Console.WhiteLine("Tere hommikust, õpilane: "+yourname);
*/

Console.WriteLine("Tere. Sisesta esimene liidetav arv");
int arv1= int.Parse(Console.ReadLine());
Console.WriteLine("Tere. Sisesta esimene liidetav arv");
int arv2 =  int.Parse(Console.ReadLine());
Console.WriteLine("Sisesta tehtemärk: / * + -");
string tehtetyyp = Console.ReadLIme();

int tulemus = 0;
if (tehtetyyp == "+")
{
    tulemus = arv1 + arv2;
}
    


Console.WriteLine(tulemus);

Console.WriteLine("sisesta esimene jagatav");
int jagatav1 = int.Parse(Console.ReadLine());
Console.WriteLine("sisesta esimene jagatav");
int jagatav2 = int.Parse(Console.ReadLine());
Console.WriteLine("Sisesta tähtemark: / * + -");
string tehtetyyp = Console.ReadLine();


int jagamine = jagatav1 / jagatav2;
Console.WriteLine(jagamine);

/* ISESEISVALT: */
/* Kirhuta ka jargmis, korrutamis ning lahutustehted eeskujul*/

// + liitmine
// / jagamine
// * korrutamine
// - lahutamine

Console.WriteLine("Tere. minu nimi on jem");
int nimi1 = int.Parse(Console.ReadLine());
Console.WriteLine("Tere. minu nimi on jem");
int nimi2 = int.Parse(Console.ReadLine());
int jem = nimi1 / nimi2;
Console.WriteLine(jem);
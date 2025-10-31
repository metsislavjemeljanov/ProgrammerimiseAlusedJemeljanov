using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace minu_konspekt
{
	internal class Program
	{
		private static int kasutajavanus;

		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");


			//Muutajad, matemaatilised tehted, IF, ELSE IF ja ELSE:

			//1. tuvasta sisu võrdluses null'ga
			Console.WriteLine("Tere kasutaja, mis on sinu nimi");
			string nimi = Console.ReadLine();

			if (nimi != null)
			{
				Console.WriteLine("Kasutaja ei sisestanud oma nime");
			}
			else if (nimi == "")
			{
				Console.WriteLine("Tere " + nimi + "!");

			}
			else
			{
				Console.WriteLine("Kasutaja ei sisestanud oma nime");
			}

			//2.tuvasta arvuvahemik, võrdluses piirväärtustega, int/double/float andmetüüp
			//Console.WriteLine(nimi + ", mis on sinu vanus?: ");
			//int kasutajavanus = int.Parse(Console.ReadLine());

			//2.1 mitu tingimust pesastatud if-ide abil
			//if (kasutajavanus > 0)
			//{
			//    if (kasutajanimi < 18)
			//    {
			//        Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled ´Monstrist ilma c");
			//    }
			//    else
			//    {
			//        Console.WriteLine("Saad osta Monstrit, YIPPIE");
			//    }
			//}

			//2.2 mitu tingimust ühe ifi sees kasutades loogilist tehtet "and", vältides pesastamist           
			if (kasutajavanus > 0 && kasutajavanus < 18)
			{
				Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled ´Monstrist ilma");
			}
			else
			{
				Console.WriteLine("Saad osta Monstrit, YIPPIE");
			}
			Console.WriteLine("Sisesta oma pikkus ka, palun, " + nimi + ":");
			double pikkus = double.Parse(Console.ReadLine());
			if (pikkus < 1.00d)
			{
				Console.WriteLine("Oled juntsu");
			}
			else if (pikkus < 1.25d && pikkus > 1.00d)
			{
				Console.WriteLine("Oled peaaegu allameetrimees");
			}
			else if (pikkus < 1.50d && pikkus > 1.25d)
			{
				Console.WriteLine("Oioi, päkaüikk enam ei olegi " + nimi + " !");
			}
			else if (pikkus < 1.75d && pikkus > 1.50d)
			{
				Console.WriteLine("Oled enamasti standarpikkuses, kui mitte just natuke lühike");
			}
			else if (pikkus < 2.00d && pikkus > 1.75d)
			{
				Console.WriteLine("Pikk kolge, vaata et sa pead vastu uksepiita ära ei löö");
			}
			else if (pikkus > 2.00d)
			{
				Console.WriteLine("Täielik tulnukas, kuidas pilved välja näevad?");
			}
			else
			{
				Console.WriteLine("pikkust ei tunta");
			}
			Console.WriteLine("Tere. Sisesta esimene liidetav arv");
			int arv1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Tere. Sisesta esimene liidetav arv");
			int arv2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Sisesta tehtemärk: / * + -");
			string tehtetyyp = Console.ReadLine();

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
			string tehtetyp = Console.ReadLine();

			int tulemus = 0;

			if (tehtetyyp == "+")
			{
				tulemus = arv1 + arv2;
			}

			else if (tehtetyyp == "-")

			{
				tulemus = arv1 - arv2;
			}

			else if (tehtetyyp == "*")
			{
				tulemus = arv1 * arv2;
			}

			else if (tehtetyyp == "/")
			{
				tulemus = arv1 / arv2;
			}

			else if (tehtetyyp == "^")
			{
				tulemus = (int)Math.Pow(arv1, arv2);
			}
			else
			{
				Console.WriteLine("Palun sisestada tehe, mida kalkulaator tuvastada oskab");
			}
			if (tulemus != 0)
			{
				Console.WriteLine(tulemus);
			}
			else
			{
				Console.WriteLine("Tulemus on 0, või üritasid teha tehet, mida kalkulaator ei tunne");
			}
			Console.WriteLine("Kas sa tahad õuna või banaani?");
			string vastus = Console.ReadLine();

			if (vastus == "õuna") ;
			{
				Console.WriteLine("🍎🍎🍎");
			}

			//4 parool, if ja string andmetüüp
			Console.WriteLine("Programmi edasiseks tööks sisesta palun parool:");
			string password = Console.ReadLine();

			if (password == "simsalabin")
			{
				Console.WriteLine("Parool on õige, aarete laegas avaneb");
			}
			else if (password == "saatana" || password == "1234")
			{
				Console.WriteLine("parool on soobimatu, palun mingi muu");
			}
			else
			{
				Console.WriteLine("Parool on vale, proovi uuesti");
			}

			//5 värvituvastus
			Console.WriteLine("Milline värv sulle kõige rohkem meeldib?:");
			string favouriteColour = Console.ReadLine();
			if (favouriteColour == "punane")
			{
				Console.BackgroundColor = ConsoleColor.Red;
			}
			if (favouriteColour == "oranz")
			{
				Console.WriteLine("Kahjuks oranzi ei ole");
			}
			if (favouriteColour == "kollane") ;
			{
				Console.BackgroundColor = ConsoleColor.Yellow;
			}
			if (favouriteColour == "roheline") ;
			{
				Console.BackgroundColor = ConsoleColor.Green;
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

				//4 parrool, if ja string andmetüüp
				Console.WriteLine("Programmi edasiseks tööks sisesta palun parool`:");
				string password = Console.ReadLine();

				if (password == "simsalabim")
				{
					Console.WriteLine("Parool om õige, aarete laegas avaneb");
				}
				else if (password == "saatana" || password == "1234")
				{
					Console.WriteLine("Parool on sobimatu, palun mingi muu");
				}
				else
				{
					Console.WriteLine("Parool on vale, proovi uuesti");
				}

				//5 värvituvastus
				Console.WriteLine("Milline värv sulle kõige rohkem meeldib?");
				string favouritecolour = Console.ReadLine():
			if (favouritecolour == "punane")
				{
					Console.BackgroundColor = ConsoleColor.Red;
				}
				if (favouritecolour == "oranz")
				{
					Console.WriteLine("Kahjuks oranzi ei ole");
				}
				if (favouritecolour == "kollane")
				{
					Console.BackgroundColor = ConsoleColor.Yellow;
				}
				if (favouritecolour == "rohaline")
				{
					Console.BackgroundColor = ConsoleColor.Green;
				}
				else
				{
					Console.WriteLine("Värvi ei yunne");
				}
				Console.WriteLine("Värv muudetud!");



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

				//
				// \v/ ISESEISEV TÖÖ LÄHED SIIA

				//# Kolija kalkulaator - Kirjuta programm mis:
				//#    - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
				//#    - olenevalt kasutaja sisestusest küsib ta:
				//#    - - tünni jaoks:
				//#    - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
				//#    - - - tünni kõrgust
				//#    - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
				//#    - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
				//#    - - kasti jaoks:
				//#    - - - Kas kast on kuubiku kujuline või risttahuka kujuline
				//#    - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
				//#    - - - - kui on risttahukas siis küsib kasutajalt:
				//#    - - - - - pikima külje pikkust, 
				//#    - - - - - lühima külje pikkust ja
				//#    - - - - - kasti kõrgust
				//#    - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (



				Console.WriteLine("Kas sa tahad mõõta kasti või tünni?");
				string sisend = Console.ReadLine();
				//#   - plenevalt kasutaja sisestusest küsib ta:

				//#  - - tünni jaoks:
				if (sisend == "tunn")
				{
					//#  - - - kas kasutaja teab põhja raadius (r) või üõhja läbimõõtu (d):
					Console.WriteLine("Kas sa tead tünni raadiust R või läbimõõtu D");
					string rvõid = Console.ReadLione();
					Console.WriteLine("Mis on selle raadius/lääbimõt? meetrites");
					double kasutajamõõt = double.Parse(Console.ReadLijne());
					//#  - - - tünni kõrgust
					Console.WriteLine("Kui kõrge on su tünn? meetrites");
					double kõrgust = double.Parse(Console.readLoine());
					//#   - - - kaane paksus, kina kaan võtab tünni sisustv nbatukr ruumi)
					Console.WriteLine("Kui paks on su tün`? meetrites");
					double kaanepaksus = double.Parse(Console.ReadLine());
					//#   - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
					double Sp = 0
					if (rvõid == "R")
					{
						double Sp = Math.PI * (kasutajamõõt * kasutajamõõt);
					}
					else if (rvõid == "D")
					{
						kasutajamõõt = kasutajamõõt / 2;
						Sp = Math.PI * (kasutajamõõt * kasutajamõõt);
					}
					double V = 0
					kõrgus = kõrgust - kaanepaksus;
					V = Sp * kõrgust;
					//Tünni ruumala on olemas, arvutamine küljepindala
					kõrgus += kaanepaksus;
					//Tünni ruumala on olemas. arvutame tünni koguüindala
					double S = Sp + Sk;
					Console.WriteLine("Sinu tünn mahutab {V}\mTünni küljepindala on{Sk}\mTünni kogipindala on {S}");

					Console.WriteLine("hapukapsas");
					// "Console"    -> on moodul C# mida me adresserime, Consdole aitab teha tegevusi käsureal
					// .            -> näitab, et meil on vaja adresserida mingisugust funktsiooni või meetodit
					//                 mooduli 2Console" seest.
					// "WriteLine"  -> Funktsioon mida me parasjagu kasutame.
					// ()           -> sulupaar mis omab funktsiooni tööks vajalikku infot
					// []           -> tähistab masiive
					// {}           -> koodiplokk, tavaliselt kas pärast (iuf, else if) tingimust,namepacei või funktsiooni kirjeldust
					// "hapukapsas" -> parameeter mis antakse funktsioonile WriteLine töötlemiseks kaasa.
					//          -> Taane aitab arendajal aru saada, kuskohas millise koodiploki sees kood asub, see on vajalik ka kompilaatorile samal eesmärgil.
					//             asaub, see on vajalik ka kompilaatorile samal eesmärgil.
					//  ;           -> kõik koodilaused lõppevad komakooloninga, mis tähistavad lause lõppu
					//  //          -> tähistab üherealist kommentaari
					//  /**/        -> tähistab mitmerealist kommentaari või kommentaariregiooni

					int muutja = 3;
					// int          -> on muutuja nime ees olev andmetüübi kirjeldus mis näoitab ära, millist
					//                 tüüpi andmed selle muutja sees on.
					// "muutja"     -> on nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava
					//                 sõnaga, ja mille abil saab neid addresseerida koodi ees.
					// =            -> üksik võrdusmärk omistab muutuja sisse vastava väärtuse mis asub
					//                 teiselpool võrdusmärki.
					// 3            -> muutujale omistatav väärtus.

					/* Võimalikud amdmetüübid mida vaja võib minna: */
					int a = 1; // int on täisarv
					decimal b = 2.1M; // decimal on kümnesüsteemis olev komakohaga arv
					float c = 3.9f; // float on 32-bitine komakohaga arv
					double d = 5.6d; // double on 64-bitine komakohaga arv
					char c1 = 'a'; // üksainus täht või tähtemark mis asub ülakomade vahel ''
					string s = "tekst"; //tähtedest koosnev sõna või tekst, tähistatakse jutumärkidega ""
					var x = "abc"; //var on ebamäärese andmetüübiga kohalik muutuja
					var y = 123;    //ta võib omada ends teisi andmetüüpe
					const int z = 9; // konstant-tüüpi muutujaid ei saa muuta, nende sisu on read-only

					//põhiliseldmatemaatilised tehted
					int liitme = 1 + 1; //liitmine, kaks arvu liidetakse kokku
					int lahutamine = 1 - 1; //lahutamine, kus esimesest arvust lahutatakse maha teine
					double korrutamine = 1 * 2; //korrutamine, kus teine arv korrutatakse esimese arvu kordi.
					double jagamine = 1 / 2; //jagamine, esimene arv jagatakse teise arvuga.
					double astendamine = Math.Pow(2, 2) //astendamine, esimine arv asrendatakse teisega


					double juurimine = Math.sqrt(2); //ruutjuur, parametrina juuritav arv

					//muutuja nimed
					int arv = 0;
					string sõne = "abc";
					//string string = "abc"; //kaitstuyd sõna kasutada ei saa

					// muutuja nimeks ei sobi järgnevad sõnad:
					//abstract, as, base, bool, break, count, byte, case,
					//catch, char, checked, class, ciunt, continue, decimal,
					//deafult, delegate, do, double, else, enum, event,
					//explicit, extern, false, finally, fixed, float, for
					//foreach, goto, if, implict, in, int, interface, internal
					//is, lock, long, namespace,new. null, object, operator,
					//out, override, params, private, protected, public, readonly,
					//ref, return, sbyte, sealed, short, sizeof, stackalloc,
					//static, string, struct, switch, this, throw, try, typeof,
					//uint, ulong, unchecked, unsafe, ushort, using, virtual,
					//void, volatile, while.

					//3 kalkolator ifi ja elisifidega
					Console.WriteLine("Tere. Sisesta esimene arv");
					//Adresserime moodulit "Console", ppunkti abil ütleme, et kasutame funktsiooni WriteLine
					//selle jaoks et öelda kasutajale sõnukm mis asub funktsiooni nime järel sulgude vahel
					//üm´britsetuna jutumärkidega. Kasutajale esitatav sõnum ón "Tere, Sisesta esimene arv"

					int arv1 = int.Parse(Console.ReadLine()):
					//instantsieweriumew muutuja nimega "arv1", ning selle ette anname andmetüübiks "int", see
					//ütleb ära, et siin muutujas on täisarvud sees. Omistame muuujale võrdusmärgi abil
					//väärtuse, mille saame kasutajalt. Selle jaoks, adresseerime uuesti "Console" moodulit
					//Aga seekord on funktsiooni nimi "ReadLine". Selleks, et käsurepaelt tulev arv programmile
					//tekstina ei näe välja, küsime unt mooduli seest omakorda funktsiooni "Parse", ning paneme
					//ReadLine funktsiooni Parse() sulgude vahele. 
					
					Console.WriteLine("Sisesta tehtemärk: / * + -");
					//*Adresserime moodulit "Console" koos "WriteLine" funktsiooniga, et esitada kasutajale
					//küsimuse 2Sisesta tehtemärk: / * + -". Punkti abil saame moodulist Console, funktsiooni
					//WriteLine, ning sulgude vahel ongi kasutajale esitatav tekst. Tekst ise on ka ümbritsetud
					//jutumärkidega. Lause lõpprb lauselõüuimärgida ";".

					string tehtetyyp = Console.ReadLine();
					//instantsieerime muutuja nimega "tehtetyyp", mille ette kirjutamine andmetüübiks "string".
					//Omistame võrdusmärgi abil, sellesse muutujasse kasutajalt sisendi mille same kasutade
					//Console moodulis oleva ReadLine() funktsiooni abil. Lause lõppeb lauselõpumärgiga ";".

					int tulemus = 0;
					//instantsieerime muutuja nimega "tulemus", andmetüübiga int, ning omistame talle algse
					//väärtuse võrdusmärgi abil, milleks on 0. Lause lõppeb lauselõpumärgiga ";".


					if (tehtetyyp == "+")
					//teeme tinngimuslause if, ning selle tingimuse määrme ära sulgudega, mille vajel on
					//võrduskontroll. Kontrollime kas muutja "tehtetyyp" omab andmeid samal kujul
					//nagi võrdusmärkidest teisel pool olev tekset "+". Siin lause ei lõppe, kuna tegu ei
					//ole koodiga mis midagi kindlalt veel ära teeb.
					{
						tulemus = arv1 + arv2
					}
					//peale tingimust on koodiplokk {} sulgude vahel, mis sialdab endas ühte koodirida.
					//selles lauses omistame muutujale "tulemus" võrdusmärgi abil liitmistehte tulemuse,
					//kus liidame kokku muutuja "arv1" ja muutuja "arv2" sisu. Lause lõppeb lauselõpüumärgiga ";".

					else if (tehtetyyp == "-")
					//teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
					//Sulgude vahel on võrdujontroll. Konjtrollime ks muutuja "tehtetyyp" omab andmeid
					//samal kujul nagu võrdusmärkidest teisel pool olev tekst "-" kui eelnev tingimus ei
					//täitunud. Lause siin eoi lõppe, vaid tingimusele järgeneb koodiplokk.
					{
						tulemus = arv1 - arv2;
					}
					//peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
					//koodirida. selles lauses omistame muutujale "tulemus2 võrdusmärgi abil lahutuslehte
					//tulemuse,m kus lahutame muutuja "arv2 sees olevast olevast väärtusest maha "arv2" muutujas
					//oloeva väärtuse. Lause lõppeb lauselõpumärgiga ";".

					else if (tehtetyyp == "/")
					//teeme sekundarse tingimuslause "else if", ning määrassme tema tingimuse ära sulgudega.
					//Sulgude vahel on võrdsuskontroll. Kontrollume kas muutuja "thtetyyp" omab andmeid
					//samal kuu´jul nagu võrdusmärkidest teisel pool olev tekst "/" kui eelnev tingimis ei
					//täitunnud. LAuse siin ei lõppe, vaid tingimusele järgneb koodiplokk.
					{
						tulemus = arv1 / arv2;
					}
					//peale tingimust on koodiplokk {} loogiliste sulgude vahel, mis sisladab endas ühte
					//koodirida. selles lauses omostame muutujale "tulemus" võrdusmärgi abil korrutustehte
					//tulemuse, kus korrtame muutujas "avr1" oleva väärtuse, muutajas "arv2" olebva jagajaga
					//Lause lõp lauselõppumärgiga ";".

					else if (tehtetyyp == "*")
					//teeme sekundaarse tingimuslause "else if2, ning määrame tema tingimuse ära sulgudega.
					//Sulgude vahel on võrduskontroll. Kontrollime kas muja "tehtetyyp2 omab andmeid
					//samalm kujul nagu võrdusmärkidest teisel pool olev tekst "*" kui eelnev tingimus ei
					//täitunud. Lause siin ei lõppe, vaid tingimusele järgeneb koodiplokk.
					{
						tulemus = arv1 * arv2;
					}
					//peale tingimust on koodiplokk {} loogelist sulgude vahel, mis sisakdavb endas ühte
					//koordirida. selles lauses muutujale "tulemus" võrdusmärgi abil korrtustehte
					//tulemuse, kus korrutame muutujas "arv2" olevaq väärtuse mutujas "arv1" oleva väärtus
					//kordi. Lause lõppeb lauselõpumärgida ",".
					else if (tehtetyyp == "^")
					//tememe sekundaarse tingimuslause "else if", ning määrme tema tingimuse ära sulgudega.
					//Sulgude vahel on võrduskontroll, kontrollime kas muiutuja "tehtetyyp" omab andmeid
					//samal kujul mvõrdusmärkidest teisel pool olev "^" kui eelnev tingimus ei
					//täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
					{
						tulemus = (int)Math.Pow(arv1, arv2);
					}
					//peale tingimust on koodiplokk {} loogeliste sulgude vahel,mis sisaldab endas ühte
					//koordirida. Sellles lauses omistatakse võdusmärgi abil muutujasse "tulemus" mille saame
					//"Math" moodulist pärineva funktsiooni "Pow()" abil. Math.Pow() võteb paremeetritena
					//sisse muutjad "arv1" ja "arv2". Esimene parameeter on astendatav´, teine parameeter
					//on astendaja. Funktsiooni Math.Pow() ees on kirteisendus (int), kuna muutuja
					//"tulemus" andmetüüp on täisarv. Math.Pow() väljunud teisendatakse nii täisarvuks.
					//Lausew lõppegb lauselõppumärgiga ",".
					else
					//peale kõiki järeltingimusi on meil tingimuslause osa "else" mida täidetakse kõikide
					//muude tingimuslause osade mittetäitumusel. Siin eraldi tingimust välja ei kirjutada
					//ning sellest tulenvalt ei ole ka sulge. Järgmineb ainult koodiplokk.
					{
						Console.WriteLine("Palun sisestya tehe, mida kalkulaator tuvastada oskab");
					}
					//pelse "else" on koodiplokk {} loogiliste sulgude bahel, mis sisaldab endas ühte
					//koodirida. Selles kooduireas kasutame modulisty "Console2 punkti abil funktsiuooni
					//"WriteLine" et öelda kasutajale "Palun sisesta tehe, mida kalkulaator tuvastada
					//oskab". Koodoroda lõppeb lauselõpumärgiga ",".

					Console.WriteLine(tulemus);
					//Kasutame moodulist "Console" punkti abil funtsiooni "WriteLine" et kuvada kasutajale
					//tehte tulemus. Selle jaoks on WrityeLine ´funktsioonis pandud muutuja
					//"tulemus" ilma tekstiks teisendamata. Lause lõppeb lauselõpumärgiga ",".

					// 3. for
					int kogus = 6; // muutuja mida kasutab oma töö tegemiseks - teisisõnu, töödeldav materjal
					for (int k = 0; k < kogus; k++) // kaittud sõna "for" for-tsüklit, pärast mida on sulud, mille vahel on kõik tsükli
													// töö jaoks vajalik olemas. Esimene parameeter, tekitab tsükli töö jaoks kohaliku muutuja
													// "int k = 0;" mida tsükli ENDA töö juhtmiseks. Teine parameeter on tingimnuslause, mis kontollib 
													// tingimuse täitmust "k < kogus;" ning mille täitumisel tsükli töö jätkub, aga miulle
													// mitte-täitmisel tsükkel katkeb. KOlomas parameeter on tsüklimuutuja inkrementeerimine kiirtehtega
													// "k++". Pane tähele, et iga siulgude vahel oleva osa järel (välja arvatud viimase) on
													// lauselõppumark. Tsükli tööd kontrolliv tingimuslause koosneb kolmest reast, mitte ühest
													// nagu "while" või "do-while" puhul.
													// sulgudele järgneb, loogeliste sulgude vahel ole koodiplokk  {}
						Console.WriteLine(k);       // töötlustegevus tsükli sees, on muutuja "k" hetkearvu väljakuvamine.


				}

		}
	}
}

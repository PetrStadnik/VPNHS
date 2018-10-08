using System;
using System.Threading;

namespace VPNHS
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Title = "VPNHS";
           

            Program program = new Program();

            program.Vysilani();
            string heslo = "84442785";
            Alarm alarm = new Alarm();
            alarm.AlarmOn();

            Console.Clear();                              // vycisteni konzole
            
            Console.Beep(1000, 1000);
            Console.BackgroundColor = ConsoleColor.DarkBlue; // nastaveni barvy pozadi na zelenou
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!UPOZORNENÍ!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Zachycen neidentifikovatelný objekt, pro více informací zadejte číselný kód. \n (pro vypnutí alarmu zadejte příkaz alarm-off)");
            
            while (true)
            {
                string x = Console.ReadLine();
                if (x == "alarm-off")
                {
                    alarm.AlarmOff();
                    Console.WriteLine("Alarm vypnut, zadejte číselný kód pro více informací");
                }
                else if (x == heslo)
                {
                    program.SondaInfo();
                   
                }
                else
                {
                    Console.WriteLine("Špatně! :-(");
                }
            }
        }

        public void Vysilani()
        {
            Console.BackgroundColor = ConsoleColor.Black; // nastaveni barvy pozadi na zelenou
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Připojte vysílací zařízení a po rozsvícení diody stiskněte klávesu");
            Console.ReadKey();
            Console.WriteLine("\nPřipojování a instalace vysílacího zařízení");
            for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }
            Console.WriteLine("\nZařízení úspěšně nainstalováno!!!");

            Console.WriteLine("Zadejte vysílanou zprávu");
            string zprava = "";
            while (zprava== "")
            {
                zprava = Console.ReadLine();
            }

                Console.WriteLine("Zpráva se zpracovává ");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }

                Console.WriteLine("\nPřejete si přeložit zprávu?");
            if (Console.ReadLine() != "ne")
            {
 
                Console.WriteLine("Zpráva se překládá do jazyku: ");
                Console.WriteLine("\nČínština");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }

                Console.WriteLine("\nŠpanělština");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }

                Console.WriteLine("\nAngličtina");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }

                Console.WriteLine("\nArabština");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }

                Console.WriteLine("\nHindština");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }

                Console.WriteLine("\nBengálština");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }

                Console.WriteLine("\nPortugalština");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }

                Console.WriteLine("\nRuština");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }

                Console.WriteLine("\nJaponština");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }

                Console.WriteLine("\nPaňdžábština");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }
                Console.WriteLine("\nJavánština");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }
                Console.WriteLine("\nKorejština");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }
                Console.WriteLine("\nNěmčina");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }
                Console.WriteLine("\nFrancouzština");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }
                Console.WriteLine("\nTelugština");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }
                Console.WriteLine("\nMaráthština");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }
                Console.WriteLine("\nTurečtina");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }
                Console.WriteLine("\nVietnamština");
                for (int x = 0; x < 5; x++) { Console.Write("*"); Thread.Sleep(1000); }
                Console.WriteLine("\nPřeklad do dalších jazyků");
                for (int x = 0; x < 10; x++) { Console.Write("*"); Thread.Sleep(1000); }
                Console.Clear();
            }
                Console.WriteLine("Zpráva zpracována a připravena k odeslání");
                Console.WriteLine("Pro přidání obrázkové přílohy zadejte ano");
            
                string o = "";
                while (o != "ano" && o !="ne")
                {
                    o = Console.ReadLine();
                }
            if (o == "ano")
            {
                Console.WriteLine("Vyfotografujte obrázek a stiskněte klávesu");
                Console.ReadKey();

                Console.WriteLine("\nProbíhá přidávání a zpracování přílohy");
                for (int x = 0; x < 20; x++) { Console.Write("*"); Thread.Sleep(1000); }
                Console.WriteLine("\nPříloha úspěšně přiložena");
            }


            Console.WriteLine("Zpráva " + zprava + " je připravena k odeslání. Zpráva obsahuje jednu obrazovou přílohu.");
            Console.WriteLine("Pro odeslání zprávy zadejte ano");
                string d = "";
                while (d != "ano")
                {
                    d = Console.ReadLine();
                }

                for (int x = 0; x < 101; x++)
                {
                    Console.Clear();
                    Console.WriteLine("Probíhá odesílání zprávy");
                    Console.WriteLine("\n Stav:"); Console.Write(x + "%"); Thread.Sleep(200);
                }
                Console.Clear();
                Console.WriteLine("ZPRÁVA BYLA ÚSPĚŠNĚ ODESLÁNA!!!");
                while (true)
                {
                    Console.ReadLine();
                }
        }

        public void SondaInfo()
        {
            Random rand = new Random();
            double vzdalenost = 1168642.403;
            while (vzdalenost > 11680)
            {
                DateTime casPristani = new DateTime(2018, 9, 28, 20, 44, 39);
                vzdalenost -= rand.NextDouble() * 10;

                TimeSpan casDoPritani = casPristani - DateTime.Now;
                Console.Clear();
                //Thread.Sleep(10);
               
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!UPOZORNENÍ!");
                Console.BackgroundColor = ConsoleColor.Yellow; // nastaveni barvy pozadi na zelenou
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Radar Evropské kosmické agentury zachytil neznámý objekt s předpokládaným dopadem na Zemi. ");
                Console.WriteLine("");
                Console.WriteLine("Aktuální vzdálenost od Země (přibližně):     " + vzdalenost + "\tkm");
                Console.WriteLine("Aktuální rychlost:                           " + 982000 / 11.54 + " km/h");
                Console.WriteLine("Předpokládaný čas dopadu:                    za " + casDoPritani.Days + " dnů, " + casDoPritani.Hours + " hodin, " + casDoPritani.Minutes + " minut");
                Console.WriteLine("Velikost tělesa:                             malé");
                Console.WriteLine("Původ tělesa:                                Sluneční soustava");
                Console.WriteLine("Typ tělesa:                                  NEZNÁMÝ");
                Console.WriteLine("Předpokládané místo dopadu:                  N50.6104775 E15.3328711");
                Thread.Sleep(50);
            }
        }
    }

    class Alarm
    {
        bool on = true;
        Thread vlakno;
        Thread info;
        public void Beebing()
        {
            Thread.Sleep(1000*60*3);
            while (true)
            {
                if (on)
                {
                    Console.Beep(1000, 500);
                    Thread.Sleep(500);
                }
            }
        }


        public void Info()
        {
            while (true)
            {
                    Console.Beep(1000, 500);
                    Thread.Sleep(500);                
            }
        }


        public void AlarmOn()
        {
            vlakno = new Thread(Beebing);
            vlakno.Start();

        }
        public void AlarmOff()
        {
            on = false;

        }

    }
}

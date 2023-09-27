


using System.Data.SqlTypes;
using System.Text.Json;

namespace C__LESSON_14
{

    class Program
    {
        static Xestexana xestexana = new(

            new List<Pediatriya>() 
            { 
            new Pediatriya("hekim 1", "hekim 1li", new DateTime(2000, 3, 1), new string[3] { "11:00/13:00", "15:00/17:00", "19:00/21:00" }) 
            },

            new List<Travmatologiya>()
            {
                new Travmatologiya("hekim 2", "hekim 2li", new DateTime(1996, 6, 11), new string[3] { "11:00/13:00", "15:00/17:00", "19:00/21:00" })
            },
            
            new List<Stamotologiya>()
            {
                new Stamotologiya("hekim 3", "hekim 3li", new DateTime(1990, 2, 9), new string[3] { "11:00/13:00", "15:00/17:00", "19:00/21:00" })
            }
            
            
            );

        static void secim()
        {
            Console.Write("Name daxil edin: ");
            string name = Console.ReadLine();

            Console.Write("Surname daxil edin: ");
            string surname = Console.ReadLine();

            Console.Write("Email daxil edin: ");
            string email = Console.ReadLine();

            Console.Write("Telefon daxil edin: ");
            string telefon = Console.ReadLine();

            Console.Clear();
            //Thread.Sleep(1000);


            Console.WriteLine("(1) Pediatriya");
            Console.WriteLine("(2) Travmatologiya");
            Console.WriteLine("(3) Stamotologiya");

            Console.Write("secim edin: ");
            string sec = Console.ReadLine();

            if (sec == "1") { xestexana.showPediatriya(); }
            else if (sec == "2") { xestexana.showTravmatologiya(); }
            else if (sec == "3") { xestexana.showStamotologiya(); }
            else { Console.WriteLine("bele bir secim yoxdu"); return; }


            Console.Write("hekmin secin sra nomresine gore seimedin: ");
            int hekimSS = int.Parse(Console.ReadLine());

            Console.Write("hekmin istediyviz bas vezerv vaxtini secin sra sayinan: ");
            string hSaat = Console.ReadLine();

            if (hekimSS-1 <= (sec == "1" ? xestexana.pediatriyas.Count : sec == "2" ? xestexana.travmatologiyas.Count : xestexana.stamotologiyas.Count))
            {
                if(hSaat == "1" && "rezerv olunub" != (sec == "1" ? xestexana.pediatriyas[hekimSS-1].isSaati[0] : sec == "2" ? xestexana.travmatologiyas[hekimSS-1].isSaati[0] : xestexana.stamotologiyas[hekimSS-1].isSaati[0])) {

                    if (sec == "1") { xestexana.pediatriyas[hekimSS-1].isSaati[0] = "rezerv olunub"; }
                    else if (sec == "2") { xestexana.travmatologiyas[hekimSS-1].isSaati[0] = "rezerv olunub"; }
                    else if (sec == "3") { xestexana.stamotologiyas[hekimSS-1].isSaati[0] = "rezerv olunub"; }
                   
                }
                else if(hSaat == "2") {

                    if (sec == "1") { xestexana.pediatriyas[hekimSS-1].isSaati[1] = "rezerv olunub"; }
                    else if (sec == "2") { xestexana.travmatologiyas[hekimSS-1].isSaati[1] = "rezerv olunub"; }
                    else if (sec == "3") { xestexana.stamotologiyas[hekimSS-1].isSaati[1] = "rezerv olunub"; }
                }
                else if(hSaat == "3") {

                    if (sec == "1") { xestexana.pediatriyas[hekimSS-1].isSaati[2] = "rezerv olunub"; }
                    else if (sec == "2") { xestexana.travmatologiyas[hekimSS-1].isSaati[2] = "rezerv olunub"; }
                    else if (sec == "3") { xestexana.stamotologiyas[hekimSS-1].isSaati[2] = "rezerv olunub"; }
                }
                else { Console.WriteLine("bele bir secim yoxdu"); return; }
            }
            else { Console.WriteLine("bele bir secim yoxdu"); return; }



        }


        static void start()
        {

            xestexana = JsonSerializer.Deserialize<Xestexana>(File.ReadAllText("../../../XESTEXANA.json"));

            secim();
            Thread.Sleep(2000);
            Console.Clear();



            File.WriteAllText("../../../XESTEXANA.json", JsonSerializer.Serialize(xestexana, (new JsonSerializerOptions() { WriteIndented = true})));


            start();
        }


        static void Main(string[] args)
        {
            start();


        }
    }

}






















using Studentai.Models;

namespace ManoPrograma
{
    public class ObjektinisProgramavimasStudentai
    {
        public static void Main()
        {
            StudentuRegistras registras = new StudentuRegistras();

            registras.addStudentas(new Studentas("Petras", "Petraitis", new int[] { 1, 2, 4, 6, 8, 9 }));
            registras.addStudentas(new Studentas("Antanas", "Antanaitis", new int[] { 3, 1, 8, 9, 10, 10 }));
            registras.addStudentas(new Studentas("Tomas", "Tomaitis", new int[] { 10, 10, 10, 10, 10, 10 }));
            registras.addStudentas(new Studentas("Kestas", "Kestutaitis", new int[] { 1, 1, 1, 1, 1, 1 }));

            Studentas stud5 = registras.findStudentas("Petras", "Petraitis");
            Console.WriteLine(stud5.Vardas + " " + stud5.Pavarde + " Studentas rastas");

            registras.removeStudentas("Tomas", "Tomaitis");

            Console.WriteLine("Studentu vidurkiu suma: " + registras.totalVidurkis());

           

        }
    }

}
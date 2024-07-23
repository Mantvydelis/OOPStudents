using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentai.Models
{
    internal class StudentuRegistras
    {
        public Studentas[] Studentai { get; set; }
        int PaskutinisStudentas = 0;
        int StudentuSkaicius = 0;

        public StudentuRegistras()
        {
            Studentai = new Studentas[100];
        }

        public void addStudentas(Studentas studentas)
        {
            Studentai[PaskutinisStudentas] = studentas;
            PaskutinisStudentas++;
            StudentuSkaicius++;
        }

        public void removeStudentas(string vardas, string pavarde)
        {
            for (int i = 0; i < StudentuSkaicius; i++)

            {
                if (Studentai[i].Vardas == vardas && Studentai[i].Pavarde == pavarde)
                {
                    for (int j = i; j < StudentuSkaicius - 1; j++)
                    {
                        Studentai[j] = Studentai[j + 1];
                    }
                    Studentai[StudentuSkaicius - 1] = null;
                    StudentuSkaicius--;
                    break;


                }
            }
        }
        public Studentas findStudentas(string vardas, string pavarde)
        {
            for (int i = 0; i < StudentuSkaicius; i++)
            {

                if (Studentai[i].Vardas == vardas && Studentai[i].Pavarde == pavarde)
                    return Studentai[i];

            }
            return null;


        }

        public double totalVidurkis ()
        {
            double BendrasVidurkis = 0;

            for (int i = 0; i < StudentuSkaicius; i++)
            {

                BendrasVidurkis += Studentai[i].vidurkis();
               
            }
            return BendrasVidurkis/StudentuSkaicius;
        }




    }
}

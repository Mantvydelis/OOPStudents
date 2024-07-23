using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentai.Models
{
    internal class Studentas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int[] Pazymiai { get; set; }

        public Studentas (string vardas, string pavarde, int[] pazymiai)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Pazymiai = pazymiai;
        }

        public Studentas[] Studentai { get; set; }
        int PaskutinisPazymys = 0;
        int PazymiuSkaicius = 0;

        public void addPazymys(Studentas studentas)
        {
            Studentai[PaskutinisPazymys] = studentas;
            PaskutinisPazymys++;
            PazymiuSkaicius++;
        }

        public double vidurkis()
        {
            Double PazymiuVidurkis = 0;

            for (int i = 0; i < Pazymiai.Length; i++)
            {
                PazymiuVidurkis += Pazymiai[i];

            }
            return PazymiuVidurkis/Pazymiai.Length;
        }

    }
}

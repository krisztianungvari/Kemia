using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemia
{
    class Felfedezes
    {
        // Év;Elem;Vegyjel;Rendszám;Felfedező
        string ev;
        string elem;
        string vegyjel;
        int rendszam;
        string felfedezo;

        public Felfedezes(string sor)
        {
            string[] daraboltSor = sor.Split(';');
            ev = daraboltSor[0];
            Elem = daraboltSor[1];
            Vegyjel = daraboltSor[2];
            Rendszam = Convert.ToInt32(daraboltSor[3]);
            Felfedezo = daraboltSor[4];
        }

        public string Ev { get => ev; set => ev = value; }
        public string Elem { get => elem; set => elem = value; }
        public string Vegyjel { get => vegyjel; set => vegyjel = value; }
        public int Rendszam { get => rendszam; set => rendszam = value; }
        public string Felfedezo { get => felfedezo; set => felfedezo = value; }
    }
}

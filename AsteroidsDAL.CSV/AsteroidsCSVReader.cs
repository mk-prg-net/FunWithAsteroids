using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsteroidsBL;

//using System.IO;

namespace AsteroidsDAL.CSV
{
    public class AsteroidsCSVReader : AsteroidsBL.IAsteroidsReader
    {

        System.IO.StreamReader reader;
        System.Globalization.NumberFormatInfo nif;

        public AsteroidsCSVReader(string pathCsvFile, int anzKopfzeilen = 1)
        {
            // Prüfen, ob die Datei existiert
            if (System.IO.File.Exists(pathCsvFile))
            {
                // sonst: Datei mit Reader öffnen
                reader = new System.IO.StreamReader(pathCsvFile);

                // Kopfzeilen überspringen
                for(int i = 0; i < anzKopfzeilen; i++)
                {
                    if (!reader.EndOfStream)
                    {
                        reader.ReadLine();
                    } else
                    {
                        throw new ArgumentException("Es fehlen Kopfzeilen in der Datei " + pathCsvFile);
                    }
                }

                // Information zu Formatierung von Gleitkommawerten in der amerikanischen Kultur bestimmen
                nif = new System.Globalization.CultureInfo("en-US").NumberFormat;

            } else
            {
                // wenn nicht, Fehler melden
                throw new ArgumentException("Die csv- Datei " + pathCsvFile + " existiert nicht");
            }
        }

        public bool EOF
        {
            get
            {
                return reader.EndOfStream;
            }
        }

        /// <summary>
        /// Wir gehen davon aus, das noch nicht das Dateiende erreicht wurde. Der 
        /// Anwender sollte dies vor Aufruf von read mittels EOF sicherstellen
        /// </summary>
        /// <returns></returns>
        public IAsteroid Read()
        {
            var line = reader.ReadLine();

            string[] cols = line.Split(',');

            // name
            //string name = cols[0].Substring(cols[0].LastIndexOf(' ')).Trim();
            var nameParts = cols[0].Replace('"', ' ').Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = nameParts.Length > 1 ? String.Join(" ", nameParts.Skip(1).ToArray()) : nameParts[0];




            // diameter
            double diameter = 0.0;
            diameter = ReadDoubleColumn(cols, 1, "diameter");

            // e
            double e = 0.0;
            e = ReadDoubleColumn(cols, 2, "e");

            // a
            double a = 0.0;
            a = ReadDoubleColumn(cols, 3, "a");

            // orbital_period_in_yeras
            double orbitTime = 0.0;
            orbitTime = ReadDoubleColumn(cols, 4, "orbit time");

            // albedo
            double albedo = 0.0;
            albedo = ReadDoubleColumn(cols, 5, "albedo");

            return new Asteroid(name, a, e, orbitTime, albedo, diameter);
        }

        private static int NewMethod(int i)
        {
            i++;
            return i;
        }

        private double ReadDoubleColumn(string[] cols, int colIndex, string colName)
        {
            double value = 0.0;

            if (!string.IsNullOrEmpty(cols[colIndex]))
            {
                // TryParse wird so konfiguriert, das Gleitpunktzahlen in der US- Notation gelesen werden können
                if (!double.TryParse(cols[colIndex], System.Globalization.NumberStyles.Float, nif, out value))
                {
                    throw new Exception("Die " + colName + " " + cols[colIndex] + " kann nicht als double gelesen werden");
                }
            }

            return value;
        }
    }
}

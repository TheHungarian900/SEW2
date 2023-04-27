using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PointCoords
{
    class PointRecorder
    {  
        public List<Point> PointList;

        //Konstruktor
        public PointRecorder()
        {
            PointList = new List<Point>();
        }

        //Methoden
        public void AddPoint(double x, double y)
        {
            // F�gt der PointList einen neuen Point
            // mit den Koordinaten x, y hinzu 

            PointList.Add(new Point(x, y));
        }
       
        public void WriteToFile(string path)
        {          
            // Schreibt jeden point der PointList als Zeile
            // in die Textdatei im Format: xcoord;ycoord

            using (StreamWriter sw = new StreamWriter(path)) 
            {
                foreach(Point p in PointList)
                {
                    sw.WriteLine(p.Xcoord + ";" + p.Ycoord);
                }
            }           
        }

        public List<Point> ReadFromFile(string path)
        {
            string zeile = "";
            PointList.Clear();

            using (StreamReader sr = new StreamReader(path))
            {
                // Positionszeiger steht nach dem �ffnen der Datei am Anfang
                // zeilenweises Lesen der Datei, Umwandung in einen Point,
                // Hinzuf�gen des point in die PointList

               
                while((zeile = sr.ReadLine()) != null)
                {
                    string[] coords = zeile.Split(';');
                    double x = System.Convert.ToDouble(coords[0]);
                    double y = System.Convert.ToDouble(coords[1]);
                    this.AddPoint(x, y);
                }
               
            }
            return PointList;
        }

        public void WriteToFileBin(string path)
        {   // Schreibt alle Points der List<Point> in die Bin�rdatei
            // Der erste Eintrag ist die Anzahl der Punkte
            using (FileStream fileStr = new FileStream(path, FileMode.Create))
            {
                using (BinaryWriter binWriter = new BinaryWriter(fileStr))
                {
                    binWriter.Write(PointList.Count);

                    foreach (Point p in PointList)
                    {
                        binWriter.Write(p.Xcoord);
                        binWriter.Write(p.Ycoord);
                    }
                }
            }
        }

        public List<Point> ReadFromFileBin(string path)
        {   // Liest die Bin�rdatei und f�gt alle Points
            // in die leere List<Point> ein.           
            PointList.Clear();

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    // lese zuerst 4 Byte f�r den Wert von anzahl
                    // dann lies 8 Bytes mit ReadDouble() f�r x und y. Reihenfolge: x, dann y. 

                    int count = br.ReadInt32();

                    for (int i = 0; i < count; i++)
                    {
                        double x = br.ReadDouble();
                        double y = br.ReadDouble();

                        this.AddPoint(x, y);
                    }
                }
            }
            return PointList;
        }

        public Point GetPoint(int pointNo)
        {
            // liest Point mit Index pointNo-1 aus der PointList
            if (pointNo <= PointList.Count && pointNo > 0)
            {
                return (Point)PointList[pointNo-1];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Illegal Pointnumber");
            }
        }
        public Point GetPointBin(string path, int pointNo)
        {   // Liest den Point mit Index pointNo aus der Bin�rdatei
            // und gibt ihn zur�ck
            Point savedPoint;
            int pos = 0;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    fs.Seek(0, SeekOrigin.Begin);
                    // hat der Anwender eine g�ltige Position angegeben?
                    if (pointNo > br.ReadInt32() || pointNo <= 0)
                    {
                        string message = "Unter der angegebenen Position ist";
                        message += " kein \nPoint-Objekt gespeichert.";
                        throw new ArgumentOutOfRangeException(message);
                    }
                    else
                    {
                        // Die Positionsnummer des ersten Bytes in der Datei ist 0,
                        // daher verweist der Zeiger mit der �bergabe der Zahl 4 auf das f�nfte Byte.
                        // Position des Zeigers berechnen pos .........
                        //...............
                        // den Zeiger positionieren
                        fs.Seek(pos, SeekOrigin.Begin);
                        // Daten des gew�nschten Points einlesen
                        savedPoint = new Point();
                       // Koordinaten lesen und savedPoint zuweisen...........
                        return savedPoint;
                    }                    
                }
            }
        }
    }//class
}//ns

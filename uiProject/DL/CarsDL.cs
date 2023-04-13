using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using uiProject.BL;

namespace uiProject.DL
{
    internal class CarsDL
    {
        private static List<Cars> carslist = new List<Cars>();
    public static List<Cars> Carslist
        {
            get { return carslist; }
            set { carslist = value; }
        }
public static void AddCarsToList(Cars temp)
        {
            carslist.Add(temp);
        }
        public static void DeleteDataFromList(int index)
        {
            carslist.RemoveAt(index);
        }
        public static int searchDataFromList(Cars obj)
        {
            for(int index=0; index < carslist.Count; index++)
            {
                if (obj.Reg_number == carslist[index].Reg_number)
                {
                    return index;
                }
            }
         return -1;
        }
           public static void UserDataTofile()
            {
                string path = "Cars.txt";

                StreamWriter file = new StreamWriter(path, false);
                foreach (Cars i in carslist)
                { 
                    file.WriteLine(i.Reg_number + "," + i.Brand + "," + i.Model + "," + i.Color + "," + i.Ppd + "," + i.Car_class+","+i.Availible);
                }
                file.Flush();
                file.Close();
            }
        public static void DataFromFile()
        {
            string path = "Cars.txt";
            StreamReader file = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                   string Reg_number=(splittedRecord[0]);
                    string Brand = splittedRecord[1];
                    string Model = splittedRecord[2];
                    string Color = splittedRecord[3];
                    int ppd =int.Parse(splittedRecord[4]);
                    string Car_class = splittedRecord[5];
                    string available=splittedRecord[6];
                    Cars obj = new Cars(Brand, Model, Reg_number, Color, ppd, Car_class,available);
                   CarsDL.AddCarsToList(obj);
                }
            }
            file.Close();
        }
              public static Cars findCars(string reg_number)
                {
                 foreach (Cars i in carslist)
                 {
                    if(i.Reg_number == reg_number)
                    {
                      return i;
                    }
                 }
                 return null;
                }
        public static bool EditDataCars(string Rnumber,string brand, string model, int ppd,string color,string Class ,string avail)
        {
            foreach (Cars i in carslist)
            {
                if (i.Reg_number == Rnumber || i.Brand ==brand || i.Model ==model || i.Ppd == ppd || i.Color ==color || i.Car_class ==Class||i.Availible==avail)
                {
                    i.Reg_number = Rnumber;
                    i.Brand = brand ;
                    i.Model = model; i.Ppd = ppd;
                    i.Color = color;
                    i.Car_class = Class;
                    i.Availible = avail;
                    return true;
                }
            }
            return false;
        }
    }

}

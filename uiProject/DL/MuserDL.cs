using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using uiProject.BL;

namespace uiProject.DL
{
    internal class MuserDL
    {
        public static List<Muser> userList = new List<Muser>();
        public static void AddUserToList(Muser temp)
        {
            userList.Add(temp);
        }
        public static Muser Checkuser(Muser obj)
        {
            foreach (Muser i in userList)
            {
                if (i.Name == obj.Name && i.Password == obj.Password)
                {
                    return i;
                }
            }
           return null;
        }
        public static string  roleReturn(Muser obj)
        {
            foreach (Muser i in userList)
            {
                if (i.Name == obj.Name && i.Password == obj.Password)
                {
                    return i.Role;
                }
            }
           return null;
        }
        public static void UserDataTofile()
        {
            string path = "MuserData.txt";

            StreamWriter file = new StreamWriter(path, false);
            foreach (Muser i in userList)
            {
                file.WriteLine(i.iD + "," + i.Name + "," + i.Password + "," + i.Gender + "," + i.PhoneNumber + "," + i.Role + "," + i.Age);
            }

            file.Flush();
            file.Close();
        }
        public static void DataFromFile() {
            string path = "MuserData.txt";
            StreamReader file = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    int id = int.Parse(splittedRecord[0]);
                    string name = splittedRecord[1];
                    string password = splittedRecord[2];
                    string gender = splittedRecord[3];
                    string phonenumber = splittedRecord[4];
                    string role = splittedRecord[5];
                    int age = int.Parse(splittedRecord[6]);
                    Muser obj = new Muser(id, name, password, gender, phonenumber, role, age);
                    MuserDL.AddUserToList(obj);
                }
            }
            file.Close();
        }
        public static int searchDataFromList(Muser obj)
        {

            for (int index = 0; index < userList.Count; index++)
            {
                if (obj.iD == userList[index].iD)
                {
                    return index;
                }
            }
            return -1;
        }
        public static void DeleteDataFromList(int index)
        {
            userList.RemoveAt(index);
        }
        public static bool EditDataMUser(int id, string name, string pass, string gender, string phone, string role, int age)
        { foreach (Muser i in userList)
            {
                if ( i.Name==name || i.iD==id|| i.Age==age ||i.Password==pass ||i.Role==role ||i.Gender==gender )
                {
                    i.Name = name;
                    i.iD = id;
                    i.Age = age;
                    i.Password = pass;
                    i.Role = role;
                    i.Gender = gender;
                    return true;
                }
            }
            return false;
        }
        public static string checkNewUser(string name,int id,string pass) 
        {
            string Errorname = "";
            foreach(Muser i in userList)
            {
                if (i.Name == name)
                {
                    Errorname = "name";
                    return Errorname;
                }
                else if (i.iD == id)
                {
                    Errorname = "id";
                    return Errorname;
                }
                else if (i.Password==pass) 
                {
                    Errorname = "pass";
                    return Errorname;
                }
            }
            return null;
        }

    }
}


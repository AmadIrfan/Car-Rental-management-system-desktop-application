using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uiProject.BL
{
    internal class Muser
    {
        private int ID;
        private string name;
        private string phoneNumber;
        private int age;
        private string role;
        private string gender;
        private string password;
        public Muser(int ID,string name, string password, string gender, string phoneNumber, string role, int age)
        {
            
            this.ID = ID;
            this.name = name;
            this.password = password;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.role = role;
            this.age = age;
        }
        public Muser(string name, string password)
        {
            this.name = name;
            this.password = password;
            this.phoneNumber = "NA";
            this.gender = "NA";
            this.role = "NA";
            this.age = 0;
            this.ID = 0;
        }
        public Muser(int ID, string phoneNumber)
        {
            this.ID = ID;
            this.phoneNumber = phoneNumber;
            this.name = "NA";
            this.password = "NA";
            this.gender = "NA";
            this.role = "NA";
            this.age = 0;
        }
        public Muser(int ID)
        {
            this.ID = ID;
            this.phoneNumber = "NA";
            this.name = "NA";
            this.password = "NA";
            this.gender = "NA";
            this.role = "NA";
            this.age = 0;
        }
    
        public string Name
        {
              
            set => name = value;
            get => name;
        }
        public string Password
        {
            set => password = value;
            get => password;
        }
        public string Gender
        {
            set {gender = value; }
            get =>gender;
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public string PhoneNumber
        {
            set { phoneNumber = value; }
            get
            {
                return phoneNumber;
            }
        }
        public string Role
        {
            set { role = value; }
            get { return role; }
        }
        public int iD
        {
            set { ID = value; }
            get { return ID; }
        }
    }
}

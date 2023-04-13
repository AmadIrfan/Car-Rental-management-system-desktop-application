using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uiProject.BL;
using System.IO;

namespace uiProject.DL
{
    internal class CustomerDL
    {
        private static List<Customers> customerList = new List<Customers>();
        public static List<Customers> CustomerList 
        { get { return customerList; }
          set { customerList = value; }
        }
        public static void AddCustomerToList(Customers temp)
        {
            customerList.Add(temp);
        }
        public static void ustomerDataToFile()
        {
            string path = "customer.txt";
            StreamWriter file = new StreamWriter(path);
            for(int i=0;i<customerList.Count;i++)
            {
                for(int j = 0; j < customerList[i].Car.Count; j++)
                {
                    file.WriteLine(customerList[i].CustName + "," + customerList[i].CustID + "," + customerList[i].FromDate + "," + customerList[i].Todate + ","+customerList[i].Car[j].Color+";"+ customerList[i].Car[j].Ppd+";"+ customerList[i].Car[j].Reg_number+";"+ customerList[i].Car[j].Availible+";"+ customerList[i].Car[j].Brand+";"+ customerList[i].Car[j].Model);
                }
            }
            file.Flush();
            file.Close();
        }
  
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uiProject.DL;

namespace uiProject.BL
{
    internal class Customers
    {
        private string custName;
        private int custID;
        private List<Cars> cars;
        private string fromDate;
        private string toDate;
        public Customers(string custName,int custID,string fromDate,string toDate, List<Cars> cars)
        {
            this.custName = custName;
            this.custID = custID;
            this.fromDate = fromDate;
            this.toDate = toDate;
            this.cars = cars;
        }
        public string CustName
        {
            get { return custName; }
            set { custName = value; }

        }
        public int CustID
        {
            get { return custID; }
            set { custID = value; } 

        }
        public List<Cars> Car
        {
            get { return cars; }
            set { cars = value; }
        }
        public string Todate
        {
            get { return toDate;}
            set { toDate = value; }
        }
        public string FromDate
        {
            get { return fromDate;}
            set { fromDate = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uiProject.BL
{
    internal class Cars
    {
        private string brand;
        private string model;
        private string reg_Number;
        private string color;
        private int ppd;
        private string car_class;
        private string available;
        public Cars(string brand,string model,string reg_Number,string color,int ppd,string car_class,string available)
        {
         this.brand= brand;
         this.model= model;
         this.reg_Number= reg_Number;
         this.color= color;
         this.ppd= ppd;
         this.car_class= car_class;
            this.available= available;
        }
        public Cars(string reg_Number)
        {
            this.brand = "NA";
            this.model = "NA";
            this.reg_Number = reg_Number;
            this.color = "NA";
            this.ppd =0;
            this.car_class = "NA";

        }
    
        public string Reg_number
        {
            get { return reg_Number; }
        set { reg_Number = value; }
        }
        public string Car_class
        {
            get { return car_class; }
            set { car_class = value; }
        }
       public int Ppd
        {
        get
            {
                return ppd;
            }
            set { ppd = value; }
        } 
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Brand
        {
            get { return brand; }   
            set { brand = value; }
        }
        public string Availible
        {
            get { return available; }
            set { available = value; }
        }
    }
}

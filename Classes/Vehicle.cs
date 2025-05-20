using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Classes
{
    public abstract class Vehicle
    {
        protected string owner;
        protected string number;
        protected string brand;
        protected string color;
        protected DateTime entry;
        protected int fee;
        
        public Vehicle(string owner, string number, string brand, string color)
        {
            this.owner = owner;
            this.number = number;
            this.brand = brand;
            this.color = color;
            this.entry = DateTime.Now;
            this.fee = 0;
        }

        public string Owner 
        {
            get => this.owner;
            set => this.owner = value;
        }
        public string Number 
        { 
            get => this.number;
            set => this.number = value;
        }
        public string Brand
        {
            get => this.brand;
            set => this.brand = value;
        }
        public string Color
        {
            get => this.color;
            set => this.color = value;
        }
        public DateTime Entry => this.entry;

        public int Fee => getFee();
        public abstract int getFee();
    }
}

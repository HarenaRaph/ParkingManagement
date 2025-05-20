using System;


namespace Parking.Classes
{
    public class Moto : Vehicle
    {
        public Moto(string owner, string number, string brand, string color) : base(owner, number, brand, color)
        {
        }

        public override int getFee()
        {
            int fee = 0;
            TimeSpan duration = DateTime.Now - this.entry;
            if (duration.Days == 0)
            {
                if (duration.Hours <= 1)
                {
                    if (duration.Minutes == 0)
                    {
                        fee = 500;
                    }
                    else if (duration.Minutes >= 1 && duration.Minutes <= 15)
                    {
                        fee = 1000;
                    }
                    else if (duration.Minutes <= 30)
                    {
                        fee = 1500;
                    }
                    else if (duration.Minutes <= 45)
                    {
                        fee = 2000;
                    }
                    else if (duration.Minutes >= 46 || duration.Hours == 1)
                    {
                        fee = 2500;
                    }
                }
                else
                {
                    fee = 2500 * duration.Hours;
                }

            }
            else
            {
                fee = 2500 * 24 * duration.Days;
            }
            return fee;
        }
    }
}

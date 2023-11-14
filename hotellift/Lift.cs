using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotellift
{
    internal class Lift
    {
        DateTime usage;
        int cardNumber, startNumber, endNumber;

        public Lift(string row)
        {
            string[] data = row.Split(' ');
            string[] date = data[0].Split('.');
            this.usage = new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]));
            this.cardNumber = int.Parse(data[1]);
            this.startNumber = int.Parse(data[2]);
            this.endNumber = int.Parse(data[3]);
        }

        public DateTime Usage { get => usage; }
        public int CardNumber { get => cardNumber; }
        public int StartNumber { get => startNumber; }
        public int EndNumber { get => endNumber; }
    }
}

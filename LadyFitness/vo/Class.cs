using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyFitness.vo
{
    public class Class
    {
        public int IdClass { get; set; }

        public int IdTrainer { get; set; }

        public int IdRoom { get; set; }

        public int DayNumber { get; set; }

        public String Name { get; set; }

        public DateTime Time { get; set; }
        

        public Class(int idClass, int idTrainer, int idRoom,   int dayNumber, String name, DateTime time)
        {
            this.IdClass = idClass;
            this.IdTrainer = idTrainer;
            this.IdRoom = idRoom;
            this.DayNumber = dayNumber;
            this.Name = name;
            this.Time = time;
        }
    }
}

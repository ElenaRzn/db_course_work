using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyFitness.vo
{
    public class Client
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }

        public String SecondName { get; set; }

        public String Password { get; set; }

        public DateTime Birthday { get; set; }

        public Client()
        {

        }

        public Client(int id, String name, String surname, String secondName, String password, DateTime birthDate)
        {
            this.ID = id;
            this.Name = name;
            this.Surname = surname;
            this.SecondName = secondName;
            this.Password = password;
            this.Birthday = birthDate;
        }

        public override string ToString()
        {
            return ID + " " + Name + " " + Surname + " " + SecondName + " " + Password + " " + Birthday.ToString();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyFitness.vo
{
    public class Card
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        
        public int IdCardType { get; set; }

        public DateTime StartDate { get; set; }

        public int Months { get; set; }

        public Card(int id, int idClient, int idCardType, DateTime dateTime, int months)
        {
            this.Id = id;
            this.IdClient = idClient;
            this.IdCardType = idCardType;
            this.StartDate = dateTime;
            this.Months = months;
        }
    }
}

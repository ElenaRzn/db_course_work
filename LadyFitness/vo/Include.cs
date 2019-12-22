using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyFitness.vo
{
    public class Include
    {
        public int IdClass { get; set; }

        public int IdCard { get; set; }

        public int MaxPersonalCount { get; set; }

        public int RestPersonalCount { get; set; }

        public String Trainer { get; set; }

        public String Class { get; set; }

        public Include(int idClass, int idCard, int maxPersonalCount, int restPersonalCount, String trainer, String clazz)
        {
            this.IdClass = idClass;
            this.IdCard = idCard;
            this.MaxPersonalCount = maxPersonalCount;
            this.RestPersonalCount = restPersonalCount;
            this.Trainer = trainer;
            this.Class = clazz;

        }
    }
}

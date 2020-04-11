using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace birdsApp2.Models
{
    public class CountModel
    {
        
        public string Name { get; set; }

        public string State { get; set; }
        public int Zip { get; set; }
        public string Bird { get; set; }
        public int CountNum { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public DateTimeOffset Time { get; set; }


    }
}

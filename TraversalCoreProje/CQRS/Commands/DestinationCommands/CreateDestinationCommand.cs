using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommand
    {
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
    }
}

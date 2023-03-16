using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.CQRS.Results.DestinationResults
{
    public class GetAllDestinationQueryResult
    {
        public int id { get; set; }
        public string city { get; set; }
        public string daynight { get; set; }
        public double price { get; set; }
        public int capacity { get; set; }

    }
}

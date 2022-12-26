using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;
        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.DestinationID);
            values.City = command.City;
            values.DayNight = command.DayNight;
            values.Price = command.Price;
            _context.SaveChanges();
        }
    }
}

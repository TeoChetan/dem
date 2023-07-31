using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TMS_API.Models;

namespace TMS_API.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly TiccketManagementSystem5Context _dbContext;
        public EventRepository() { 

            _dbContext = new TiccketManagementSystem5Context();
        }

        public int Add(Event @event)
        {
            throw new NotImplementedException();
        }

        public void Delete(Event @event)
        {
            _dbContext.Remove(@event);
            _dbContext.SaveChanges();
            
        }

        public IEnumerable<Event> GetAllEvents()
        {
            var events = _dbContext.Events;
            return events;
        }

        public async Task<Event> GetById(int id)
        {
            var @event = await _dbContext.Events.Where(e => e.EventId == id).FirstOrDefaultAsync();
            if(@event == null) {
                throw new Exception("The object was not found!");
            }
            return @event;
        }

  
        public void Update(Event @event)
        {
            _dbContext.Entry(@event).State = EntityState.Modified;
            _dbContext.SaveChanges();

        }
    }
}

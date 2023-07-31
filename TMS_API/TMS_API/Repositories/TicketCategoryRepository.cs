using Microsoft.EntityFrameworkCore;
using TMS_API.Models;

namespace TMS_API.Repositories
{
    public class TicketCategoryRepository : ITicketCategoryRepository
    {
        private readonly TiccketManagementSystem5Context _dbContext;

        public TicketCategoryRepository()
        {
            _dbContext = new TiccketManagementSystem5Context();
        }
        public async Task<TicketsCategory> GetTicketById(int ticketId)
        {

            var ticketCategory = _dbContext.TicketsCategories.Where(tc => tc.TicketCategoryId==ticketId).FirstOrDefault();
            return ticketCategory;
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheRoom.Services.Domain;

namespace TheRoom.Services.Data
{
    public class ServiceRepository : IServiceRepository
    {
        public IList<Service> GetAll()
        {
            using (var context = new ServiceContext())
            {
                return context.Services.ToList();
            }
        }
        public IList<Service> SearchDescription(string filter, int pageSize, int pageNumber)
        {
            // ToUpper can be used to do a case insensitive search
            using (var context = new ServiceContext())
            {
                return context.Services
                    .Where(b => b.Description.Contains(filter))
                    .Skip(pageSize * (pageNumber - 1))
                    .Take(pageSize)
                    .ToList();
            }
        }
    }
}

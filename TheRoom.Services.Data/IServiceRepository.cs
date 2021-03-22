using System;
using System.Collections.Generic;
using System.Text;
using TheRoom.Services.Domain;

namespace TheRoom.Services.Data
{
    public interface IServiceRepository
    {
        IList<Service> GetAll();
        IList<Service> SearchDescription(string fileter, int pageSize, int pageNumber);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TheRoom.Services.Domain;

namespace TheRoom.Services.Business
{
    public interface IServiceLogic
    {
        IList<Service> SearchDescription(string filter, int pageSize, int pageNumber);
    }
}

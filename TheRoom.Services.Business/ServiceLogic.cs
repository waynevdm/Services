using System;
using System.Collections.Generic;
using System.Text;
using TheRoom.Services.Data;
using TheRoom.Services.Domain;

namespace TheRoom.Services.Business
{

    /// <summary>
    /// This class is added to have a class that can add business validation before a database call is made.
    /// </summary>
    public class ServiceLogic : IServiceLogic
    {
        private IServiceRepository _serviceRepository;
        public ServiceLogic(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        public IList<Service> SearchDescription(string filter, int pageSize, int pageNumber)
        {
            if (string.IsNullOrEmpty(filter))
                throw new Exception("The filter is empty!"); // This should be included as an error in the model

            return _serviceRepository.SearchDescription(filter, pageSize, pageNumber);
        }
    }
}

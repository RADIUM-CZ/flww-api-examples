using System.Collections.Generic;
using Cz.Radium.NetCore.Examples.RestApiClient.Models;

namespace Cz.Radium.NetCore.Examples.RestApiClient
{
    public interface IRestClientService
    {
        /// <summary>
        /// Get objects with paging.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        IList<Objects> GetObjects(int page, int pageSize);

        /// <summary>
        /// Get object by external id. Use tableFilter.
        /// </summary>
        /// <param name="extId"></param>
        /// <returns></returns>
        IList<Objects> GetObjectsFilter(string extId);
    }
}
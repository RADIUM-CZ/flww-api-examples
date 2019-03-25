using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Cz.Radium.NetCore.Examples.RestApiClient.Models;
using Microsoft.Extensions.Logging;

namespace Cz.Radium.NetCore.Examples.RestApiClient
{
    public class RestClientService : IRestClientService
    {
        private readonly RestSharp.RestClient restClient;
        private readonly ILogger<RestClientService> logger;

        public RestClientService(
            RestSharp.RestClient restClient,
            ILogger<RestClientService> logger)
        {
            this.restClient = restClient;
            this.logger = logger;
        }

        public IList<Objects> GetObjects(int page, int pageSize)
        {
            logger.LogInformation($"Get objects request");
            var request = new RestSharp.RestRequest("objects");
            request.AddQueryParameter("page", page.ToString());
            request.AddQueryParameter("pageSize", pageSize.ToString());
            var result = restClient.ExecuteAsGet<List<Objects>>(request, "GET");

            return result.Data;
        }

        public IList<Objects> GetObjectsFilter(string extId)
        {
            logger.LogInformation($"Get objects request filtered");
            var request = new RestSharp.RestRequest("objects");
            request.AddQueryParameter("tableFilter", RestSharp.Extensions.StringExtensions.UrlDecode($"externalId:eq {extId}"));
            var result = restClient.ExecuteAsGet<List<Objects>>(request, "GET");

            return result.Data;
        }
    }
}

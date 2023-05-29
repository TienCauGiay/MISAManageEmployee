using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace MISAManageEmployee.App_Start
{
    public class CustomCorsPolicyProvider : ICorsPolicyProvider
    {
        private readonly CorsPolicy _policy;

        public CustomCorsPolicyProvider()
        {
            _policy = new CorsPolicy
            {
                AllowAnyOrigin = true,
                AllowAnyMethod = true,
                AllowAnyHeader = true
            };

            // Để hạn chế tiêu đề 'AllowAnyOrigin', thay đổi thành:
            // _policy.Origins.Add("http://localhost:8080");
        }

        public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request)
        {
            return Task.FromResult(_policy);
        }

        public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_policy);
        }
    }
}
using MISAManageEmployee.App_Start;
using System.Net.Http;
using System.Web.Http.Cors;

namespace MISAManageEmployee
{
    internal class CorsPolicyProviderFactory : ICorsPolicyProviderFactory
    {
        private CustomCorsPolicyProvider customCorsPolicyProvider;

        public CorsPolicyProviderFactory(CustomCorsPolicyProvider customCorsPolicyProvider)
        {
            this.customCorsPolicyProvider = customCorsPolicyProvider;
        }

        public ICorsPolicyProvider GetCorsPolicyProvider(HttpRequestMessage request)
        {
            return customCorsPolicyProvider;
        }
    }
}
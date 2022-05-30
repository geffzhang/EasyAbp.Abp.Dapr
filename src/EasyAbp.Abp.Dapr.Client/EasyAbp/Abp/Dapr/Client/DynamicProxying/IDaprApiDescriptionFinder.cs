using System;
using System.Reflection;
using System.Threading.Tasks;
using Volo.Abp.Http.Modeling;

namespace EasyAbp.Abp.Dapr.Client.DynamicProxying
{
    public interface IDaprApiDescriptionFinder
    {
        Task<ActionApiDescriptionModel> FindActionAsync(string service, string appId, Type serviceType, MethodInfo invocationMethod);

        Task<ApplicationApiDescriptionModel> GetApiDescriptionAsync(string service, string appId);
    }
}

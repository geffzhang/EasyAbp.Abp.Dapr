﻿namespace EasyAbp.Abp.Dapr.Client.DynamicProxying
{
    public interface IDaprClientProxy<out TRemoteService>
    {
        TRemoteService Service { get; }
    }
}

// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.AppService
{
    public static class GetServicePlan
    {
        /// <summary>
        /// Use this data source to access information about an existing Service Plan.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Azure = Pulumi.Azure;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var example = Output.Create(Azure.AppService.GetServicePlan.InvokeAsync(new Azure.AppService.GetServicePlanArgs
        ///         {
        ///             Name = "existing",
        ///             ResourceGroupName = "existing",
        ///         }));
        ///         this.Id = example.Apply(example =&gt; example.Id);
        ///     }
        /// 
        ///     [Output("id")]
        ///     public Output&lt;string&gt; Id { get; set; }
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetServicePlanResult> InvokeAsync(GetServicePlanArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetServicePlanResult>("azure:appservice/getServicePlan:getServicePlan", args ?? new GetServicePlanArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to access information about an existing Service Plan.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Azure = Pulumi.Azure;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var example = Output.Create(Azure.AppService.GetServicePlan.InvokeAsync(new Azure.AppService.GetServicePlanArgs
        ///         {
        ///             Name = "existing",
        ///             ResourceGroupName = "existing",
        ///         }));
        ///         this.Id = example.Apply(example =&gt; example.Id);
        ///     }
        /// 
        ///     [Output("id")]
        ///     public Output&lt;string&gt; Id { get; set; }
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetServicePlanResult> Invoke(GetServicePlanInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetServicePlanResult>("azure:appservice/getServicePlan:getServicePlan", args ?? new GetServicePlanInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetServicePlanArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of this Service Plan.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The name of the Resource Group where the Service Plan exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetServicePlanArgs()
        {
        }
    }

    public sealed class GetServicePlanInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of this Service Plan.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The name of the Resource Group where the Service Plan exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetServicePlanInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetServicePlanResult
    {
        /// <summary>
        /// The ID of the App Service Environment this Service Plan is part of.
        /// </summary>
        public readonly string AppServiceEnvironmentId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A string representing the Kind of Service Plan.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// The Azure Region where the Service Plan exists.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The maximum number of workers in use in an Elastic SKU Plan.
        /// </summary>
        public readonly int MaximumElasticWorkerCount;
        public readonly string Name;
        /// <summary>
        /// The O/S type for the App Services hosted in this plan.
        /// </summary>
        public readonly string OsType;
        /// <summary>
        /// Is Per Site Scaling be enabled?
        /// </summary>
        public readonly bool PerSiteScalingEnabled;
        /// <summary>
        /// Whether this is a reserved Service Plan Type. `true` if `os_type` is `Linux`, otherwise `false`.
        /// </summary>
        public readonly bool Reserved;
        public readonly string ResourceGroupName;
        /// <summary>
        /// The SKU for the Service Plan.
        /// </summary>
        public readonly string SkuName;
        /// <summary>
        /// A mapping of tags assigned to the Service Plan.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;
        /// <summary>
        /// The number of Workers (instances) allocated.
        /// </summary>
        public readonly int WorkerCount;

        [OutputConstructor]
        private GetServicePlanResult(
            string appServiceEnvironmentId,

            string id,

            string kind,

            string location,

            int maximumElasticWorkerCount,

            string name,

            string osType,

            bool perSiteScalingEnabled,

            bool reserved,

            string resourceGroupName,

            string skuName,

            ImmutableDictionary<string, string> tags,

            int workerCount)
        {
            AppServiceEnvironmentId = appServiceEnvironmentId;
            Id = id;
            Kind = kind;
            Location = location;
            MaximumElasticWorkerCount = maximumElasticWorkerCount;
            Name = name;
            OsType = osType;
            PerSiteScalingEnabled = perSiteScalingEnabled;
            Reserved = reserved;
            ResourceGroupName = resourceGroupName;
            SkuName = skuName;
            Tags = tags;
            WorkerCount = workerCount;
        }
    }
}

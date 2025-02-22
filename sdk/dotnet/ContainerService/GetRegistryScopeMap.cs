// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.ContainerService
{
    public static class GetRegistryScopeMap
    {
        /// <summary>
        /// Use this data source to access information about an existing Container Registry scope map.
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
        ///         var example = Output.Create(Azure.ContainerService.GetRegistryScopeMap.InvokeAsync(new Azure.ContainerService.GetRegistryScopeMapArgs
        ///         {
        ///             Name = "example-scope-map",
        ///             ResourceGroupName = "example-resource-group",
        ///             ContainerRegistryName = "example-registry",
        ///         }));
        ///         this.Actions = example.Apply(example =&gt; example.Actions);
        ///     }
        /// 
        ///     [Output("actions")]
        ///     public Output&lt;string&gt; Actions { get; set; }
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetRegistryScopeMapResult> InvokeAsync(GetRegistryScopeMapArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetRegistryScopeMapResult>("azure:containerservice/getRegistryScopeMap:getRegistryScopeMap", args ?? new GetRegistryScopeMapArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to access information about an existing Container Registry scope map.
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
        ///         var example = Output.Create(Azure.ContainerService.GetRegistryScopeMap.InvokeAsync(new Azure.ContainerService.GetRegistryScopeMapArgs
        ///         {
        ///             Name = "example-scope-map",
        ///             ResourceGroupName = "example-resource-group",
        ///             ContainerRegistryName = "example-registry",
        ///         }));
        ///         this.Actions = example.Apply(example =&gt; example.Actions);
        ///     }
        /// 
        ///     [Output("actions")]
        ///     public Output&lt;string&gt; Actions { get; set; }
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetRegistryScopeMapResult> Invoke(GetRegistryScopeMapInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetRegistryScopeMapResult>("azure:containerservice/getRegistryScopeMap:getRegistryScopeMap", args ?? new GetRegistryScopeMapInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetRegistryScopeMapArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Name of the Container Registry where the token exists.
        /// </summary>
        [Input("containerRegistryName", required: true)]
        public string ContainerRegistryName { get; set; } = null!;

        /// <summary>
        /// The name of the Container Registry token.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The Name of the Resource Group where this Container Registry token exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetRegistryScopeMapArgs()
        {
        }
    }

    public sealed class GetRegistryScopeMapInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Name of the Container Registry where the token exists.
        /// </summary>
        [Input("containerRegistryName", required: true)]
        public Input<string> ContainerRegistryName { get; set; } = null!;

        /// <summary>
        /// The name of the Container Registry token.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The Name of the Resource Group where this Container Registry token exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetRegistryScopeMapInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetRegistryScopeMapResult
    {
        /// <summary>
        /// The actions for the Scope Map.
        /// </summary>
        public readonly ImmutableArray<string> Actions;
        public readonly string ContainerRegistryName;
        public readonly string Description;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;
        public readonly string ResourceGroupName;

        [OutputConstructor]
        private GetRegistryScopeMapResult(
            ImmutableArray<string> actions,

            string containerRegistryName,

            string description,

            string id,

            string name,

            string resourceGroupName)
        {
            Actions = actions;
            ContainerRegistryName = containerRegistryName;
            Description = description;
            Id = id;
            Name = name;
            ResourceGroupName = resourceGroupName;
        }
    }
}

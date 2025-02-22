// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Core
{
    public static class GetResources
    {
        /// <summary>
        /// Use this data source to access information about existing resources.
        /// </summary>
        public static Task<GetResourcesResult> InvokeAsync(GetResourcesArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetResourcesResult>("azure:core/getResources:getResources", args ?? new GetResourcesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to access information about existing resources.
        /// </summary>
        public static Output<GetResourcesResult> Invoke(GetResourcesInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetResourcesResult>("azure:core/getResources:getResources", args ?? new GetResourcesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetResourcesArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Resource.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        [Input("requiredTags")]
        private Dictionary<string, string>? _requiredTags;

        /// <summary>
        /// A mapping of tags which the resource has to have in order to be included in the result.
        /// </summary>
        public Dictionary<string, string> RequiredTags
        {
            get => _requiredTags ?? (_requiredTags = new Dictionary<string, string>());
            set => _requiredTags = value;
        }

        /// <summary>
        /// The name of the Resource group where the Resources are located.
        /// </summary>
        [Input("resourceGroupName")]
        public string? ResourceGroupName { get; set; }

        /// <summary>
        /// The Resource Type of the Resources you want to list (e.g. `Microsoft.Network/virtualNetworks`). A full list of available Resource Types can be found [here](https://docs.microsoft.com/en-us/azure/azure-resource-manager/azure-services-resource-providers).
        /// </summary>
        [Input("type")]
        public string? Type { get; set; }

        public GetResourcesArgs()
        {
        }
    }

    public sealed class GetResourcesInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Resource.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("requiredTags")]
        private InputMap<string>? _requiredTags;

        /// <summary>
        /// A mapping of tags which the resource has to have in order to be included in the result.
        /// </summary>
        public InputMap<string> RequiredTags
        {
            get => _requiredTags ?? (_requiredTags = new InputMap<string>());
            set => _requiredTags = value;
        }

        /// <summary>
        /// The name of the Resource group where the Resources are located.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The Resource Type of the Resources you want to list (e.g. `Microsoft.Network/virtualNetworks`). A full list of available Resource Types can be found [here](https://docs.microsoft.com/en-us/azure/azure-resource-manager/azure-services-resource-providers).
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public GetResourcesInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetResourcesResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of this Resource.
        /// </summary>
        public readonly string Name;
        public readonly ImmutableDictionary<string, string>? RequiredTags;
        public readonly string ResourceGroupName;
        /// <summary>
        /// One or more `resource` blocks as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetResourcesResourceResult> Resources;
        /// <summary>
        /// The type of this Resource. (e.g. `Microsoft.Network/virtualNetworks`).
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetResourcesResult(
            string id,

            string name,

            ImmutableDictionary<string, string>? requiredTags,

            string resourceGroupName,

            ImmutableArray<Outputs.GetResourcesResourceResult> resources,

            string type)
        {
            Id = id;
            Name = name;
            RequiredTags = requiredTags;
            ResourceGroupName = resourceGroupName;
            Resources = resources;
            Type = type;
        }
    }
}

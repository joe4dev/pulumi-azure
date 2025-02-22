// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Lb
{
    public static class GetLB
    {
        /// <summary>
        /// Use this data source to access information about an existing Load Balancer
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
        ///         var example = Output.Create(Azure.Lb.GetLB.InvokeAsync(new Azure.Lb.GetLBArgs
        ///         {
        ///             Name = "example-lb",
        ///             ResourceGroupName = "example-resources",
        ///         }));
        ///         this.LoadbalancerId = example.Apply(example =&gt; example.Id);
        ///     }
        /// 
        ///     [Output("loadbalancerId")]
        ///     public Output&lt;string&gt; LoadbalancerId { get; set; }
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetLBResult> InvokeAsync(GetLBArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetLBResult>("azure:lb/getLB:getLB", args ?? new GetLBArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to access information about an existing Load Balancer
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
        ///         var example = Output.Create(Azure.Lb.GetLB.InvokeAsync(new Azure.Lb.GetLBArgs
        ///         {
        ///             Name = "example-lb",
        ///             ResourceGroupName = "example-resources",
        ///         }));
        ///         this.LoadbalancerId = example.Apply(example =&gt; example.Id);
        ///     }
        /// 
        ///     [Output("loadbalancerId")]
        ///     public Output&lt;string&gt; LoadbalancerId { get; set; }
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetLBResult> Invoke(GetLBInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetLBResult>("azure:lb/getLB:getLB", args ?? new GetLBInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetLBArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Specifies the name of the Load Balancer.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The name of the Resource Group in which the Load Balancer exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetLBArgs()
        {
        }
    }

    public sealed class GetLBInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Specifies the name of the Load Balancer.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The name of the Resource Group in which the Load Balancer exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetLBInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetLBResult
    {
        /// <summary>
        /// A `frontend_ip_configuration` block as documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetLBFrontendIpConfigurationResult> FrontendIpConfigurations;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The Azure location where the Load Balancer exists.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the Frontend IP Configuration.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Private IP Address to assign to the Load Balancer.
        /// </summary>
        public readonly string PrivateIpAddress;
        /// <summary>
        /// The list of private IP address assigned to the load balancer in `frontend_ip_configuration` blocks, if any.
        /// </summary>
        public readonly ImmutableArray<string> PrivateIpAddresses;
        public readonly string ResourceGroupName;
        /// <summary>
        /// The SKU of the Load Balancer.
        /// </summary>
        public readonly string Sku;
        /// <summary>
        /// A mapping of tags assigned to the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;

        [OutputConstructor]
        private GetLBResult(
            ImmutableArray<Outputs.GetLBFrontendIpConfigurationResult> frontendIpConfigurations,

            string id,

            string location,

            string name,

            string privateIpAddress,

            ImmutableArray<string> privateIpAddresses,

            string resourceGroupName,

            string sku,

            ImmutableDictionary<string, string> tags)
        {
            FrontendIpConfigurations = frontendIpConfigurations;
            Id = id;
            Location = location;
            Name = name;
            PrivateIpAddress = privateIpAddress;
            PrivateIpAddresses = privateIpAddresses;
            ResourceGroupName = resourceGroupName;
            Sku = sku;
            Tags = tags;
        }
    }
}

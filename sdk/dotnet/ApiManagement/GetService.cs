// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.ApiManagement
{
    public static class GetService
    {
        /// <summary>
        /// Use this data source to access information about an existing API Management Service.
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
        ///         var example = Output.Create(Azure.ApiManagement.GetService.InvokeAsync(new Azure.ApiManagement.GetServiceArgs
        ///         {
        ///             Name = "search-api",
        ///             ResourceGroupName = "search-service",
        ///         }));
        ///         this.ApiManagementId = example.Apply(example =&gt; example.Id);
        ///     }
        /// 
        ///     [Output("apiManagementId")]
        ///     public Output&lt;string&gt; ApiManagementId { get; set; }
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetServiceResult> InvokeAsync(GetServiceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetServiceResult>("azure:apimanagement/getService:getService", args ?? new GetServiceArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to access information about an existing API Management Service.
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
        ///         var example = Output.Create(Azure.ApiManagement.GetService.InvokeAsync(new Azure.ApiManagement.GetServiceArgs
        ///         {
        ///             Name = "search-api",
        ///             ResourceGroupName = "search-service",
        ///         }));
        ///         this.ApiManagementId = example.Apply(example =&gt; example.Id);
        ///     }
        /// 
        ///     [Output("apiManagementId")]
        ///     public Output&lt;string&gt; ApiManagementId { get; set; }
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetServiceResult> Invoke(GetServiceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetServiceResult>("azure:apimanagement/getService:getService", args ?? new GetServiceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetServiceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the API Management service.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The Name of the Resource Group in which the API Management Service exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetServiceArgs()
        {
        }
    }

    public sealed class GetServiceInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the API Management service.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The Name of the Resource Group in which the API Management Service exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetServiceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetServiceResult
    {
        /// <summary>
        /// Zero or more `additional_location` blocks as defined below
        /// </summary>
        public readonly ImmutableArray<Outputs.GetServiceAdditionalLocationResult> AdditionalLocations;
        /// <summary>
        /// The URL for the Developer Portal associated with this API Management service.
        /// </summary>
        public readonly string DeveloperPortalUrl;
        /// <summary>
        /// Gateway URL of the API Management service in the Region.
        /// </summary>
        public readonly string GatewayRegionalUrl;
        /// <summary>
        /// The URL for the API Management Service's Gateway.
        /// </summary>
        public readonly string GatewayUrl;
        /// <summary>
        /// A `hostname_configuration` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetServiceHostnameConfigurationResult> HostnameConfigurations;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// (Optional) An `identity` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetServiceIdentityResult> Identities;
        /// <summary>
        /// The location name of the additional region among Azure Data center regions.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The URL for the Management API.
        /// </summary>
        public readonly string ManagementApiUrl;
        /// <summary>
        /// Specifies the plan's pricing tier.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The email address from which the notification will be sent.
        /// </summary>
        public readonly string NotificationSenderEmail;
        /// <summary>
        /// The URL of the Publisher Portal.
        /// </summary>
        public readonly string PortalUrl;
        /// <summary>
        /// Private IP addresses of the API Management service in the additional location, for instances using virtual network mode.
        /// </summary>
        public readonly ImmutableArray<string> PrivateIpAddresses;
        /// <summary>
        /// ID of the standard SKU IPv4 Public IP. Available only for Premium SKU deployed in a virtual network.
        /// </summary>
        public readonly string PublicIpAddressId;
        /// <summary>
        /// Public Static Load Balanced IP addresses of the API Management service in the additional location. Available only for Basic, Standard and Premium SKU.
        /// </summary>
        public readonly ImmutableArray<string> PublicIpAddresses;
        /// <summary>
        /// The email of Publisher/Company of the API Management Service.
        /// </summary>
        public readonly string PublisherEmail;
        /// <summary>
        /// The name of the Publisher/Company of the API Management Service.
        /// </summary>
        public readonly string PublisherName;
        public readonly string ResourceGroupName;
        /// <summary>
        /// The SCM (Source Code Management) endpoint.
        /// </summary>
        public readonly string ScmUrl;
        public readonly string SkuName;
        /// <summary>
        /// A mapping of tags assigned to the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;

        [OutputConstructor]
        private GetServiceResult(
            ImmutableArray<Outputs.GetServiceAdditionalLocationResult> additionalLocations,

            string developerPortalUrl,

            string gatewayRegionalUrl,

            string gatewayUrl,

            ImmutableArray<Outputs.GetServiceHostnameConfigurationResult> hostnameConfigurations,

            string id,

            ImmutableArray<Outputs.GetServiceIdentityResult> identities,

            string location,

            string managementApiUrl,

            string name,

            string notificationSenderEmail,

            string portalUrl,

            ImmutableArray<string> privateIpAddresses,

            string publicIpAddressId,

            ImmutableArray<string> publicIpAddresses,

            string publisherEmail,

            string publisherName,

            string resourceGroupName,

            string scmUrl,

            string skuName,

            ImmutableDictionary<string, string> tags)
        {
            AdditionalLocations = additionalLocations;
            DeveloperPortalUrl = developerPortalUrl;
            GatewayRegionalUrl = gatewayRegionalUrl;
            GatewayUrl = gatewayUrl;
            HostnameConfigurations = hostnameConfigurations;
            Id = id;
            Identities = identities;
            Location = location;
            ManagementApiUrl = managementApiUrl;
            Name = name;
            NotificationSenderEmail = notificationSenderEmail;
            PortalUrl = portalUrl;
            PrivateIpAddresses = privateIpAddresses;
            PublicIpAddressId = publicIpAddressId;
            PublicIpAddresses = publicIpAddresses;
            PublisherEmail = publisherEmail;
            PublisherName = publisherName;
            ResourceGroupName = resourceGroupName;
            ScmUrl = scmUrl;
            SkuName = skuName;
            Tags = tags;
        }
    }
}

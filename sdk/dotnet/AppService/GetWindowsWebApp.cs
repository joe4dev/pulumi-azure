// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.AppService
{
    public static class GetWindowsWebApp
    {
        /// <summary>
        /// Use this data source to access information about an existing Windows Web App.
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
        ///         var example = Output.Create(Azure.AppService.GetWindowsWebApp.InvokeAsync(new Azure.AppService.GetWindowsWebAppArgs
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
        public static Task<GetWindowsWebAppResult> InvokeAsync(GetWindowsWebAppArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetWindowsWebAppResult>("azure:appservice/getWindowsWebApp:getWindowsWebApp", args ?? new GetWindowsWebAppArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to access information about an existing Windows Web App.
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
        ///         var example = Output.Create(Azure.AppService.GetWindowsWebApp.InvokeAsync(new Azure.AppService.GetWindowsWebAppArgs
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
        public static Output<GetWindowsWebAppResult> Invoke(GetWindowsWebAppInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetWindowsWebAppResult>("azure:appservice/getWindowsWebApp:getWindowsWebApp", args ?? new GetWindowsWebAppInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetWindowsWebAppArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of this Windows Web App.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The name of the Resource Group where the Windows Web App exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetWindowsWebAppArgs()
        {
        }
    }

    public sealed class GetWindowsWebAppInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of this Windows Web App.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The name of the Resource Group where the Windows Web App exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetWindowsWebAppInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetWindowsWebAppResult
    {
        /// <summary>
        /// A map of key-value pairs of App Settings.
        /// </summary>
        public readonly ImmutableDictionary<string, string> AppSettings;
        /// <summary>
        /// A `auth_settings` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetWindowsWebAppAuthSettingResult> AuthSettings;
        /// <summary>
        /// A `backup` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetWindowsWebAppBackupResult> Backups;
        /// <summary>
        /// Is Client Affinity enabled?
        /// </summary>
        public readonly bool ClientAffinityEnabled;
        /// <summary>
        /// Are Client Certificates enabled?
        /// </summary>
        public readonly bool ClientCertificateEnabled;
        /// <summary>
        /// The Client Certificate mode.
        /// </summary>
        public readonly string ClientCertificateMode;
        /// <summary>
        /// A `connection_string` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetWindowsWebAppConnectionStringResult> ConnectionStrings;
        /// <summary>
        /// The identifier used by App Service to perform domain ownership verification via DNS TXT record.
        /// </summary>
        public readonly string CustomDomainVerificationId;
        /// <summary>
        /// The Default Hostname of the Windows Web App.
        /// </summary>
        public readonly string DefaultHostname;
        /// <summary>
        /// Is the Backup enabled?
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Does the Windows Web App require HTTPS connections.
        /// </summary>
        public readonly bool HttpsOnly;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A `identity` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetWindowsWebAppIdentityResult> Identities;
        /// <summary>
        /// The string representation of the Windows Web App Kind.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// The Azure Region where the Windows Web App exists.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// A `logs` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetWindowsWebAppLogResult> Logs;
        /// <summary>
        /// The name of this Storage Account.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The list of Outbound IP Addresses for this Windows Web App.
        /// </summary>
        public readonly ImmutableArray<string> OutboundIpAddressLists;
        /// <summary>
        /// A string representation of the list of Outbound IP Addresses for this Windows Web App.
        /// </summary>
        public readonly string OutboundIpAddresses;
        /// <summary>
        /// The list of Possible Outbound IP Addresses that could be used by this Windows Web App.
        /// </summary>
        public readonly ImmutableArray<string> PossibleOutboundIpAddressLists;
        /// <summary>
        /// The string representation of the list of Possible Outbound IP Addresses that could be used by this Windows Web App.
        /// </summary>
        public readonly string PossibleOutboundIpAddresses;
        public readonly string ResourceGroupName;
        /// <summary>
        /// The ID of the Service Plan in which this Windows Web App resides.
        /// </summary>
        public readonly string ServicePlanId;
        /// <summary>
        /// A `site_config` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetWindowsWebAppSiteConfigResult> SiteConfigs;
        /// <summary>
        /// A `site_credential` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetWindowsWebAppSiteCredentialResult> SiteCredentials;
        /// <summary>
        /// A `storage_account` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetWindowsWebAppStorageAccountResult> StorageAccounts;
        /// <summary>
        /// A mapping of tags assigned to the Windows Web App.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;

        [OutputConstructor]
        private GetWindowsWebAppResult(
            ImmutableDictionary<string, string> appSettings,

            ImmutableArray<Outputs.GetWindowsWebAppAuthSettingResult> authSettings,

            ImmutableArray<Outputs.GetWindowsWebAppBackupResult> backups,

            bool clientAffinityEnabled,

            bool clientCertificateEnabled,

            string clientCertificateMode,

            ImmutableArray<Outputs.GetWindowsWebAppConnectionStringResult> connectionStrings,

            string customDomainVerificationId,

            string defaultHostname,

            bool enabled,

            bool httpsOnly,

            string id,

            ImmutableArray<Outputs.GetWindowsWebAppIdentityResult> identities,

            string kind,

            string location,

            ImmutableArray<Outputs.GetWindowsWebAppLogResult> logs,

            string name,

            ImmutableArray<string> outboundIpAddressLists,

            string outboundIpAddresses,

            ImmutableArray<string> possibleOutboundIpAddressLists,

            string possibleOutboundIpAddresses,

            string resourceGroupName,

            string servicePlanId,

            ImmutableArray<Outputs.GetWindowsWebAppSiteConfigResult> siteConfigs,

            ImmutableArray<Outputs.GetWindowsWebAppSiteCredentialResult> siteCredentials,

            ImmutableArray<Outputs.GetWindowsWebAppStorageAccountResult> storageAccounts,

            ImmutableDictionary<string, string> tags)
        {
            AppSettings = appSettings;
            AuthSettings = authSettings;
            Backups = backups;
            ClientAffinityEnabled = clientAffinityEnabled;
            ClientCertificateEnabled = clientCertificateEnabled;
            ClientCertificateMode = clientCertificateMode;
            ConnectionStrings = connectionStrings;
            CustomDomainVerificationId = customDomainVerificationId;
            DefaultHostname = defaultHostname;
            Enabled = enabled;
            HttpsOnly = httpsOnly;
            Id = id;
            Identities = identities;
            Kind = kind;
            Location = location;
            Logs = logs;
            Name = name;
            OutboundIpAddressLists = outboundIpAddressLists;
            OutboundIpAddresses = outboundIpAddresses;
            PossibleOutboundIpAddressLists = possibleOutboundIpAddressLists;
            PossibleOutboundIpAddresses = possibleOutboundIpAddresses;
            ResourceGroupName = resourceGroupName;
            ServicePlanId = servicePlanId;
            SiteConfigs = siteConfigs;
            SiteCredentials = siteCredentials;
            StorageAccounts = storageAccounts;
            Tags = tags;
        }
    }
}

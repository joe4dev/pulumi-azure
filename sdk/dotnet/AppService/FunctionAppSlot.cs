// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.AppService
{
    /// <summary>
    /// ## Example Usage
    /// ### With App Service Plan)
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Azure = Pulumi.Azure;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var exampleResourceGroup = new Azure.Core.ResourceGroup("exampleResourceGroup", new Azure.Core.ResourceGroupArgs
    ///         {
    ///             Location = "West Europe",
    ///         });
    ///         var exampleAccount = new Azure.Storage.Account("exampleAccount", new Azure.Storage.AccountArgs
    ///         {
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             Location = exampleResourceGroup.Location,
    ///             AccountTier = "Standard",
    ///             AccountReplicationType = "LRS",
    ///         });
    ///         var examplePlan = new Azure.AppService.Plan("examplePlan", new Azure.AppService.PlanArgs
    ///         {
    ///             Location = exampleResourceGroup.Location,
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             Sku = new Azure.AppService.Inputs.PlanSkuArgs
    ///             {
    ///                 Tier = "Standard",
    ///                 Size = "S1",
    ///             },
    ///         });
    ///         var exampleFunctionApp = new Azure.AppService.FunctionApp("exampleFunctionApp", new Azure.AppService.FunctionAppArgs
    ///         {
    ///             Location = exampleResourceGroup.Location,
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             AppServicePlanId = examplePlan.Id,
    ///             StorageAccountName = exampleAccount.Name,
    ///             StorageAccountAccessKey = exampleAccount.PrimaryAccessKey,
    ///         });
    ///         var exampleFunctionAppSlot = new Azure.AppService.FunctionAppSlot("exampleFunctionAppSlot", new Azure.AppService.FunctionAppSlotArgs
    ///         {
    ///             Location = exampleResourceGroup.Location,
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             AppServicePlanId = examplePlan.Id,
    ///             FunctionAppName = exampleFunctionApp.Name,
    ///             StorageAccountName = exampleAccount.Name,
    ///             StorageAccountAccessKey = exampleAccount.PrimaryAccessKey,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Function Apps Deployment Slots can be imported using the `resource id`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import azure:appservice/functionAppSlot:FunctionAppSlot functionapp1 /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/mygroup1/providers/Microsoft.Web/sites/functionapp1/slots/staging
    /// ```
    /// </summary>
    [AzureResourceType("azure:appservice/functionAppSlot:FunctionAppSlot")]
    public partial class FunctionAppSlot : Pulumi.CustomResource
    {
        /// <summary>
        /// The ID of the App Service Plan within which to create this Function App Slot.
        /// </summary>
        [Output("appServicePlanId")]
        public Output<string> AppServicePlanId { get; private set; } = null!;

        /// <summary>
        /// A key-value pair of App Settings.
        /// </summary>
        [Output("appSettings")]
        public Output<ImmutableDictionary<string, string>> AppSettings { get; private set; } = null!;

        /// <summary>
        /// An `auth_settings` block as defined below.
        /// </summary>
        [Output("authSettings")]
        public Output<Outputs.FunctionAppSlotAuthSettings> AuthSettings { get; private set; } = null!;

        /// <summary>
        /// A `connection_string` block as defined below.
        /// </summary>
        [Output("connectionStrings")]
        public Output<ImmutableArray<Outputs.FunctionAppSlotConnectionString>> ConnectionStrings { get; private set; } = null!;

        /// <summary>
        /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps under the consumption plan. Defaults to `0`.
        /// </summary>
        [Output("dailyMemoryTimeQuota")]
        public Output<int?> DailyMemoryTimeQuota { get; private set; } = null!;

        /// <summary>
        /// The default hostname associated with the Function App - such as `mysite.azurewebsites.net`
        /// </summary>
        [Output("defaultHostname")]
        public Output<string> DefaultHostname { get; private set; } = null!;

        /// <summary>
        /// Should the built-in logging of the Function App be enabled? Defaults to `true`.
        /// </summary>
        [Output("enableBuiltinLogging")]
        public Output<bool?> EnableBuiltinLogging { get; private set; } = null!;

        /// <summary>
        /// Is the Function App enabled?
        /// </summary>
        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;

        /// <summary>
        /// The name of the Function App within which to create the Function App Slot. Changing this forces a new resource to be created.
        /// </summary>
        [Output("functionAppName")]
        public Output<string> FunctionAppName { get; private set; } = null!;

        /// <summary>
        /// Can the Function App only be accessed via HTTPS? Defaults to `false`.
        /// </summary>
        [Output("httpsOnly")]
        public Output<bool?> HttpsOnly { get; private set; } = null!;

        /// <summary>
        /// An `identity` block as defined below.
        /// </summary>
        [Output("identity")]
        public Output<Outputs.FunctionAppSlotIdentity?> Identity { get; private set; } = null!;

        /// <summary>
        /// The Function App kind - such as `functionapp,linux,container`
        /// </summary>
        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Function App. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A string indicating the Operating System type for this function app.
        /// </summary>
        [Output("osType")]
        public Output<string?> OsType { get; private set; } = null!;

        /// <summary>
        /// A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12`
        /// </summary>
        [Output("outboundIpAddresses")]
        public Output<string> OutboundIpAddresses { get; private set; } = null!;

        /// <summary>
        /// A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12,52.143.43.17` - not all of which are necessarily in use. Superset of `outbound_ip_addresses`.
        /// </summary>
        [Output("possibleOutboundIpAddresses")]
        public Output<string> PossibleOutboundIpAddresses { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the Function App Slot.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A `site_config` object as defined below.
        /// </summary>
        [Output("siteConfig")]
        public Output<Outputs.FunctionAppSlotSiteConfig> SiteConfig { get; private set; } = null!;

        /// <summary>
        /// A `site_credential` block as defined below, which contains the site-level credentials used to publish to this Function App Slot.
        /// </summary>
        [Output("siteCredentials")]
        public Output<ImmutableArray<Outputs.FunctionAppSlotSiteCredential>> SiteCredentials { get; private set; } = null!;

        /// <summary>
        /// The access key which will be used to access the backend storage account for the Function App.
        /// </summary>
        [Output("storageAccountAccessKey")]
        public Output<string> StorageAccountAccessKey { get; private set; } = null!;

        /// <summary>
        /// The backend storage account name which will be used by the Function App (such as the dashboard, logs).
        /// </summary>
        [Output("storageAccountName")]
        public Output<string> StorageAccountName { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The runtime version associated with the Function App. Defaults to `~1`.
        /// </summary>
        [Output("version")]
        public Output<string?> Version { get; private set; } = null!;


        /// <summary>
        /// Create a FunctionAppSlot resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FunctionAppSlot(string name, FunctionAppSlotArgs args, CustomResourceOptions? options = null)
            : base("azure:appservice/functionAppSlot:FunctionAppSlot", name, args ?? new FunctionAppSlotArgs(), MakeResourceOptions(options, ""))
        {
        }

        private FunctionAppSlot(string name, Input<string> id, FunctionAppSlotState? state = null, CustomResourceOptions? options = null)
            : base("azure:appservice/functionAppSlot:FunctionAppSlot", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing FunctionAppSlot resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FunctionAppSlot Get(string name, Input<string> id, FunctionAppSlotState? state = null, CustomResourceOptions? options = null)
        {
            return new FunctionAppSlot(name, id, state, options);
        }
    }

    public sealed class FunctionAppSlotArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the App Service Plan within which to create this Function App Slot.
        /// </summary>
        [Input("appServicePlanId", required: true)]
        public Input<string> AppServicePlanId { get; set; } = null!;

        [Input("appSettings")]
        private InputMap<string>? _appSettings;

        /// <summary>
        /// A key-value pair of App Settings.
        /// </summary>
        public InputMap<string> AppSettings
        {
            get => _appSettings ?? (_appSettings = new InputMap<string>());
            set => _appSettings = value;
        }

        /// <summary>
        /// An `auth_settings` block as defined below.
        /// </summary>
        [Input("authSettings")]
        public Input<Inputs.FunctionAppSlotAuthSettingsArgs>? AuthSettings { get; set; }

        [Input("connectionStrings")]
        private InputList<Inputs.FunctionAppSlotConnectionStringArgs>? _connectionStrings;

        /// <summary>
        /// A `connection_string` block as defined below.
        /// </summary>
        public InputList<Inputs.FunctionAppSlotConnectionStringArgs> ConnectionStrings
        {
            get => _connectionStrings ?? (_connectionStrings = new InputList<Inputs.FunctionAppSlotConnectionStringArgs>());
            set => _connectionStrings = value;
        }

        /// <summary>
        /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps under the consumption plan. Defaults to `0`.
        /// </summary>
        [Input("dailyMemoryTimeQuota")]
        public Input<int>? DailyMemoryTimeQuota { get; set; }

        /// <summary>
        /// Should the built-in logging of the Function App be enabled? Defaults to `true`.
        /// </summary>
        [Input("enableBuiltinLogging")]
        public Input<bool>? EnableBuiltinLogging { get; set; }

        /// <summary>
        /// Is the Function App enabled?
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The name of the Function App within which to create the Function App Slot. Changing this forces a new resource to be created.
        /// </summary>
        [Input("functionAppName", required: true)]
        public Input<string> FunctionAppName { get; set; } = null!;

        /// <summary>
        /// Can the Function App only be accessed via HTTPS? Defaults to `false`.
        /// </summary>
        [Input("httpsOnly")]
        public Input<bool>? HttpsOnly { get; set; }

        /// <summary>
        /// An `identity` block as defined below.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.FunctionAppSlotIdentityArgs>? Identity { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Function App. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// A string indicating the Operating System type for this function app.
        /// </summary>
        [Input("osType")]
        public Input<string>? OsType { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Function App Slot.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// A `site_config` object as defined below.
        /// </summary>
        [Input("siteConfig")]
        public Input<Inputs.FunctionAppSlotSiteConfigArgs>? SiteConfig { get; set; }

        /// <summary>
        /// The access key which will be used to access the backend storage account for the Function App.
        /// </summary>
        [Input("storageAccountAccessKey", required: true)]
        public Input<string> StorageAccountAccessKey { get; set; } = null!;

        /// <summary>
        /// The backend storage account name which will be used by the Function App (such as the dashboard, logs).
        /// </summary>
        [Input("storageAccountName", required: true)]
        public Input<string> StorageAccountName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The runtime version associated with the Function App. Defaults to `~1`.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public FunctionAppSlotArgs()
        {
        }
    }

    public sealed class FunctionAppSlotState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the App Service Plan within which to create this Function App Slot.
        /// </summary>
        [Input("appServicePlanId")]
        public Input<string>? AppServicePlanId { get; set; }

        [Input("appSettings")]
        private InputMap<string>? _appSettings;

        /// <summary>
        /// A key-value pair of App Settings.
        /// </summary>
        public InputMap<string> AppSettings
        {
            get => _appSettings ?? (_appSettings = new InputMap<string>());
            set => _appSettings = value;
        }

        /// <summary>
        /// An `auth_settings` block as defined below.
        /// </summary>
        [Input("authSettings")]
        public Input<Inputs.FunctionAppSlotAuthSettingsGetArgs>? AuthSettings { get; set; }

        [Input("connectionStrings")]
        private InputList<Inputs.FunctionAppSlotConnectionStringGetArgs>? _connectionStrings;

        /// <summary>
        /// A `connection_string` block as defined below.
        /// </summary>
        public InputList<Inputs.FunctionAppSlotConnectionStringGetArgs> ConnectionStrings
        {
            get => _connectionStrings ?? (_connectionStrings = new InputList<Inputs.FunctionAppSlotConnectionStringGetArgs>());
            set => _connectionStrings = value;
        }

        /// <summary>
        /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps under the consumption plan. Defaults to `0`.
        /// </summary>
        [Input("dailyMemoryTimeQuota")]
        public Input<int>? DailyMemoryTimeQuota { get; set; }

        /// <summary>
        /// The default hostname associated with the Function App - such as `mysite.azurewebsites.net`
        /// </summary>
        [Input("defaultHostname")]
        public Input<string>? DefaultHostname { get; set; }

        /// <summary>
        /// Should the built-in logging of the Function App be enabled? Defaults to `true`.
        /// </summary>
        [Input("enableBuiltinLogging")]
        public Input<bool>? EnableBuiltinLogging { get; set; }

        /// <summary>
        /// Is the Function App enabled?
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The name of the Function App within which to create the Function App Slot. Changing this forces a new resource to be created.
        /// </summary>
        [Input("functionAppName")]
        public Input<string>? FunctionAppName { get; set; }

        /// <summary>
        /// Can the Function App only be accessed via HTTPS? Defaults to `false`.
        /// </summary>
        [Input("httpsOnly")]
        public Input<bool>? HttpsOnly { get; set; }

        /// <summary>
        /// An `identity` block as defined below.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.FunctionAppSlotIdentityGetArgs>? Identity { get; set; }

        /// <summary>
        /// The Function App kind - such as `functionapp,linux,container`
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Function App. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// A string indicating the Operating System type for this function app.
        /// </summary>
        [Input("osType")]
        public Input<string>? OsType { get; set; }

        /// <summary>
        /// A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12`
        /// </summary>
        [Input("outboundIpAddresses")]
        public Input<string>? OutboundIpAddresses { get; set; }

        /// <summary>
        /// A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12,52.143.43.17` - not all of which are necessarily in use. Superset of `outbound_ip_addresses`.
        /// </summary>
        [Input("possibleOutboundIpAddresses")]
        public Input<string>? PossibleOutboundIpAddresses { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Function App Slot.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// A `site_config` object as defined below.
        /// </summary>
        [Input("siteConfig")]
        public Input<Inputs.FunctionAppSlotSiteConfigGetArgs>? SiteConfig { get; set; }

        [Input("siteCredentials")]
        private InputList<Inputs.FunctionAppSlotSiteCredentialGetArgs>? _siteCredentials;

        /// <summary>
        /// A `site_credential` block as defined below, which contains the site-level credentials used to publish to this Function App Slot.
        /// </summary>
        public InputList<Inputs.FunctionAppSlotSiteCredentialGetArgs> SiteCredentials
        {
            get => _siteCredentials ?? (_siteCredentials = new InputList<Inputs.FunctionAppSlotSiteCredentialGetArgs>());
            set => _siteCredentials = value;
        }

        /// <summary>
        /// The access key which will be used to access the backend storage account for the Function App.
        /// </summary>
        [Input("storageAccountAccessKey")]
        public Input<string>? StorageAccountAccessKey { get; set; }

        /// <summary>
        /// The backend storage account name which will be used by the Function App (such as the dashboard, logs).
        /// </summary>
        [Input("storageAccountName")]
        public Input<string>? StorageAccountName { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The runtime version associated with the Function App. Defaults to `~1`.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public FunctionAppSlotState()
        {
        }
    }
}

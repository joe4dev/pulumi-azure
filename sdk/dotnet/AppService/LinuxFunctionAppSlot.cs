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
    /// Manages a Linux Function App Slot.
    /// 
    /// ## Example Usage
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
    ///         var exampleServicePlan = new Azure.AppService.ServicePlan("exampleServicePlan", new Azure.AppService.ServicePlanArgs
    ///         {
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             Location = exampleResourceGroup.Location,
    ///             OsType = "Linux",
    ///             SkuName = "Y1",
    ///         });
    ///         var exampleLinuxFunctionApp = new Azure.AppService.LinuxFunctionApp("exampleLinuxFunctionApp", new Azure.AppService.LinuxFunctionAppArgs
    ///         {
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             Location = exampleResourceGroup.Location,
    ///             ServicePlanId = exampleServicePlan.Id,
    ///             StorageAccountName = exampleAccount.Name,
    ///             SiteConfig = ,
    ///         });
    ///         var exampleLinuxFunctionAppSlot = new Azure.AppService.LinuxFunctionAppSlot("exampleLinuxFunctionAppSlot", new Azure.AppService.LinuxFunctionAppSlotArgs
    ///         {
    ///             FunctionAppId = exampleLinuxFunctionApp.Id,
    ///             StorageAccountName = exampleAccount.Name,
    ///             SiteConfig = ,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// A Linux Function App Slot can be imported using the `resource id`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import azure:appservice/linuxFunctionAppSlot:LinuxFunctionAppSlot example "/subscriptions/12345678-1234-9876-4563-123456789012/resourceGroups/resGroup1/providers/Microsoft.Web/sites/site1/slots/slot1"
    /// ```
    /// </summary>
    [AzureResourceType("azure:appservice/linuxFunctionAppSlot:LinuxFunctionAppSlot")]
    public partial class LinuxFunctionAppSlot : Pulumi.CustomResource
    {
        /// <summary>
        /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
        /// </summary>
        [Output("appSettings")]
        public Output<ImmutableDictionary<string, string>?> AppSettings { get; private set; } = null!;

        /// <summary>
        /// an `auth_settings` block as detailed below.
        /// </summary>
        [Output("authSettings")]
        public Output<Outputs.LinuxFunctionAppSlotAuthSettings> AuthSettings { get; private set; } = null!;

        /// <summary>
        /// a `backup` block as detailed below.
        /// </summary>
        [Output("backup")]
        public Output<Outputs.LinuxFunctionAppSlotBackup?> Backup { get; private set; } = null!;

        /// <summary>
        /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.
        /// </summary>
        [Output("builtinLoggingEnabled")]
        public Output<bool?> BuiltinLoggingEnabled { get; private set; } = null!;

        /// <summary>
        /// Should the Function App Slot use Client Certificates.
        /// </summary>
        [Output("clientCertificateEnabled")]
        public Output<bool?> ClientCertificateEnabled { get; private set; } = null!;

        /// <summary>
        /// The mode of the Function App Slot's client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.
        /// </summary>
        [Output("clientCertificateMode")]
        public Output<string?> ClientCertificateMode { get; private set; } = null!;

        /// <summary>
        /// a `connection_string` block as detailed below.
        /// </summary>
        [Output("connectionStrings")]
        public Output<ImmutableArray<Outputs.LinuxFunctionAppSlotConnectionString>> ConnectionStrings { get; private set; } = null!;

        /// <summary>
        /// Force disable the content share settings.
        /// </summary>
        [Output("contentShareForceDisabled")]
        public Output<bool?> ContentShareForceDisabled { get; private set; } = null!;

        /// <summary>
        /// The identifier used by App Service to perform domain ownership verification via DNS TXT record.
        /// </summary>
        [Output("customDomainVerificationId")]
        public Output<string> CustomDomainVerificationId { get; private set; } = null!;

        /// <summary>
        /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
        /// </summary>
        [Output("dailyMemoryTimeQuota")]
        public Output<int?> DailyMemoryTimeQuota { get; private set; } = null!;

        /// <summary>
        /// The default hostname of the Linux Function App Slot.
        /// </summary>
        [Output("defaultHostname")]
        public Output<string> DefaultHostname { get; private set; } = null!;

        /// <summary>
        /// Is the Linux Function App Slot enabled.
        /// </summary>
        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;

        /// <summary>
        /// The ID of the Linux Function App this Slot is a member of. Changing this forces a new resource to be created.
        /// </summary>
        [Output("functionAppId")]
        public Output<string> FunctionAppId { get; private set; } = null!;

        /// <summary>
        /// The runtime version associated with the Function App Slot.
        /// </summary>
        [Output("functionsExtensionVersion")]
        public Output<string?> FunctionsExtensionVersion { get; private set; } = null!;

        /// <summary>
        /// Can the Function App Slot only be accessed via HTTPS?
        /// </summary>
        [Output("httpsOnly")]
        public Output<bool?> HttpsOnly { get; private set; } = null!;

        /// <summary>
        /// An `identity` block as detailed below.
        /// </summary>
        [Output("identity")]
        public Output<Outputs.LinuxFunctionAppSlotIdentity?> Identity { get; private set; } = null!;

        /// <summary>
        /// The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the `identity` block. [For more information see - Access vaults with a user-assigned identity](https://docs.microsoft.com/en-us/azure/app-service/app-service-key-vault-references#access-vaults-with-a-user-assigned-identity)
        /// </summary>
        [Output("keyVaultReferenceIdentityId")]
        public Output<string> KeyVaultReferenceIdentityId { get; private set; } = null!;

        /// <summary>
        /// The Kind value for this Linux Function App Slot.
        /// </summary>
        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Function App Slot. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A list of outbound IP addresses. For example `["52.23.25.3", "52.143.43.12"]`
        /// </summary>
        [Output("outboundIpAddressLists")]
        public Output<ImmutableArray<string>> OutboundIpAddressLists { get; private set; } = null!;

        /// <summary>
        /// A comma separated list of outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12`.
        /// </summary>
        [Output("outboundIpAddresses")]
        public Output<string> OutboundIpAddresses { get; private set; } = null!;

        /// <summary>
        /// A list of possible outbound IP addresses, not all of which are necessarily in use. This is a superset of `outbound_ip_address_list`. For example `["52.23.25.3", "52.143.43.12"]`.
        /// </summary>
        [Output("possibleOutboundIpAddressLists")]
        public Output<ImmutableArray<string>> PossibleOutboundIpAddressLists { get; private set; } = null!;

        /// <summary>
        /// A comma separated list of possible outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12,52.143.43.17`. This is a superset of `outbound_ip_addresses`. For example `["52.23.25.3", "52.143.43.12","52.143.43.17"]`.
        /// </summary>
        [Output("possibleOutboundIpAddresses")]
        public Output<string> PossibleOutboundIpAddresses { get; private set; } = null!;

        /// <summary>
        /// a `site_config` block as detailed below.
        /// </summary>
        [Output("siteConfig")]
        public Output<Outputs.LinuxFunctionAppSlotSiteConfig> SiteConfig { get; private set; } = null!;

        /// <summary>
        /// A `site_credential` block as defined below.
        /// </summary>
        [Output("siteCredentials")]
        public Output<ImmutableArray<Outputs.LinuxFunctionAppSlotSiteCredential>> SiteCredentials { get; private set; } = null!;

        /// <summary>
        /// The access key which will be used to access the storage account for the Function App Slot.
        /// </summary>
        [Output("storageAccountAccessKey")]
        public Output<string?> StorageAccountAccessKey { get; private set; } = null!;

        /// <summary>
        /// The backend storage account name which will be used by this Function App Slot.
        /// </summary>
        [Output("storageAccountName")]
        public Output<string?> StorageAccountName { get; private set; } = null!;

        /// <summary>
        /// The Key Vault Secret ID, optionally including version, that contains the Connection String to connect to the storage account for this Function App.
        /// </summary>
        [Output("storageKeyVaultSecretId")]
        public Output<string?> StorageKeyVaultSecretId { get; private set; } = null!;

        /// <summary>
        /// Should the Function App Slot use its Managed Identity to access storage.
        /// </summary>
        [Output("storageUsesManagedIdentity")]
        public Output<bool?> StorageUsesManagedIdentity { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags which should be assigned to the Linux Function App.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a LinuxFunctionAppSlot resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LinuxFunctionAppSlot(string name, LinuxFunctionAppSlotArgs args, CustomResourceOptions? options = null)
            : base("azure:appservice/linuxFunctionAppSlot:LinuxFunctionAppSlot", name, args ?? new LinuxFunctionAppSlotArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LinuxFunctionAppSlot(string name, Input<string> id, LinuxFunctionAppSlotState? state = null, CustomResourceOptions? options = null)
            : base("azure:appservice/linuxFunctionAppSlot:LinuxFunctionAppSlot", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing LinuxFunctionAppSlot resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LinuxFunctionAppSlot Get(string name, Input<string> id, LinuxFunctionAppSlotState? state = null, CustomResourceOptions? options = null)
        {
            return new LinuxFunctionAppSlot(name, id, state, options);
        }
    }

    public sealed class LinuxFunctionAppSlotArgs : Pulumi.ResourceArgs
    {
        [Input("appSettings")]
        private InputMap<string>? _appSettings;

        /// <summary>
        /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
        /// </summary>
        public InputMap<string> AppSettings
        {
            get => _appSettings ?? (_appSettings = new InputMap<string>());
            set => _appSettings = value;
        }

        /// <summary>
        /// an `auth_settings` block as detailed below.
        /// </summary>
        [Input("authSettings")]
        public Input<Inputs.LinuxFunctionAppSlotAuthSettingsArgs>? AuthSettings { get; set; }

        /// <summary>
        /// a `backup` block as detailed below.
        /// </summary>
        [Input("backup")]
        public Input<Inputs.LinuxFunctionAppSlotBackupArgs>? Backup { get; set; }

        /// <summary>
        /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.
        /// </summary>
        [Input("builtinLoggingEnabled")]
        public Input<bool>? BuiltinLoggingEnabled { get; set; }

        /// <summary>
        /// Should the Function App Slot use Client Certificates.
        /// </summary>
        [Input("clientCertificateEnabled")]
        public Input<bool>? ClientCertificateEnabled { get; set; }

        /// <summary>
        /// The mode of the Function App Slot's client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.
        /// </summary>
        [Input("clientCertificateMode")]
        public Input<string>? ClientCertificateMode { get; set; }

        [Input("connectionStrings")]
        private InputList<Inputs.LinuxFunctionAppSlotConnectionStringArgs>? _connectionStrings;

        /// <summary>
        /// a `connection_string` block as detailed below.
        /// </summary>
        public InputList<Inputs.LinuxFunctionAppSlotConnectionStringArgs> ConnectionStrings
        {
            get => _connectionStrings ?? (_connectionStrings = new InputList<Inputs.LinuxFunctionAppSlotConnectionStringArgs>());
            set => _connectionStrings = value;
        }

        /// <summary>
        /// Force disable the content share settings.
        /// </summary>
        [Input("contentShareForceDisabled")]
        public Input<bool>? ContentShareForceDisabled { get; set; }

        /// <summary>
        /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
        /// </summary>
        [Input("dailyMemoryTimeQuota")]
        public Input<int>? DailyMemoryTimeQuota { get; set; }

        /// <summary>
        /// Is the Linux Function App Slot enabled.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The ID of the Linux Function App this Slot is a member of. Changing this forces a new resource to be created.
        /// </summary>
        [Input("functionAppId", required: true)]
        public Input<string> FunctionAppId { get; set; } = null!;

        /// <summary>
        /// The runtime version associated with the Function App Slot.
        /// </summary>
        [Input("functionsExtensionVersion")]
        public Input<string>? FunctionsExtensionVersion { get; set; }

        /// <summary>
        /// Can the Function App Slot only be accessed via HTTPS?
        /// </summary>
        [Input("httpsOnly")]
        public Input<bool>? HttpsOnly { get; set; }

        /// <summary>
        /// An `identity` block as detailed below.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.LinuxFunctionAppSlotIdentityArgs>? Identity { get; set; }

        /// <summary>
        /// The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the `identity` block. [For more information see - Access vaults with a user-assigned identity](https://docs.microsoft.com/en-us/azure/app-service/app-service-key-vault-references#access-vaults-with-a-user-assigned-identity)
        /// </summary>
        [Input("keyVaultReferenceIdentityId")]
        public Input<string>? KeyVaultReferenceIdentityId { get; set; }

        /// <summary>
        /// Specifies the name of the Function App Slot. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// a `site_config` block as detailed below.
        /// </summary>
        [Input("siteConfig", required: true)]
        public Input<Inputs.LinuxFunctionAppSlotSiteConfigArgs> SiteConfig { get; set; } = null!;

        /// <summary>
        /// The access key which will be used to access the storage account for the Function App Slot.
        /// </summary>
        [Input("storageAccountAccessKey")]
        public Input<string>? StorageAccountAccessKey { get; set; }

        /// <summary>
        /// The backend storage account name which will be used by this Function App Slot.
        /// </summary>
        [Input("storageAccountName")]
        public Input<string>? StorageAccountName { get; set; }

        /// <summary>
        /// The Key Vault Secret ID, optionally including version, that contains the Connection String to connect to the storage account for this Function App.
        /// </summary>
        [Input("storageKeyVaultSecretId")]
        public Input<string>? StorageKeyVaultSecretId { get; set; }

        /// <summary>
        /// Should the Function App Slot use its Managed Identity to access storage.
        /// </summary>
        [Input("storageUsesManagedIdentity")]
        public Input<bool>? StorageUsesManagedIdentity { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A mapping of tags which should be assigned to the Linux Function App.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public LinuxFunctionAppSlotArgs()
        {
        }
    }

    public sealed class LinuxFunctionAppSlotState : Pulumi.ResourceArgs
    {
        [Input("appSettings")]
        private InputMap<string>? _appSettings;

        /// <summary>
        /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
        /// </summary>
        public InputMap<string> AppSettings
        {
            get => _appSettings ?? (_appSettings = new InputMap<string>());
            set => _appSettings = value;
        }

        /// <summary>
        /// an `auth_settings` block as detailed below.
        /// </summary>
        [Input("authSettings")]
        public Input<Inputs.LinuxFunctionAppSlotAuthSettingsGetArgs>? AuthSettings { get; set; }

        /// <summary>
        /// a `backup` block as detailed below.
        /// </summary>
        [Input("backup")]
        public Input<Inputs.LinuxFunctionAppSlotBackupGetArgs>? Backup { get; set; }

        /// <summary>
        /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.
        /// </summary>
        [Input("builtinLoggingEnabled")]
        public Input<bool>? BuiltinLoggingEnabled { get; set; }

        /// <summary>
        /// Should the Function App Slot use Client Certificates.
        /// </summary>
        [Input("clientCertificateEnabled")]
        public Input<bool>? ClientCertificateEnabled { get; set; }

        /// <summary>
        /// The mode of the Function App Slot's client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.
        /// </summary>
        [Input("clientCertificateMode")]
        public Input<string>? ClientCertificateMode { get; set; }

        [Input("connectionStrings")]
        private InputList<Inputs.LinuxFunctionAppSlotConnectionStringGetArgs>? _connectionStrings;

        /// <summary>
        /// a `connection_string` block as detailed below.
        /// </summary>
        public InputList<Inputs.LinuxFunctionAppSlotConnectionStringGetArgs> ConnectionStrings
        {
            get => _connectionStrings ?? (_connectionStrings = new InputList<Inputs.LinuxFunctionAppSlotConnectionStringGetArgs>());
            set => _connectionStrings = value;
        }

        /// <summary>
        /// Force disable the content share settings.
        /// </summary>
        [Input("contentShareForceDisabled")]
        public Input<bool>? ContentShareForceDisabled { get; set; }

        /// <summary>
        /// The identifier used by App Service to perform domain ownership verification via DNS TXT record.
        /// </summary>
        [Input("customDomainVerificationId")]
        public Input<string>? CustomDomainVerificationId { get; set; }

        /// <summary>
        /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
        /// </summary>
        [Input("dailyMemoryTimeQuota")]
        public Input<int>? DailyMemoryTimeQuota { get; set; }

        /// <summary>
        /// The default hostname of the Linux Function App Slot.
        /// </summary>
        [Input("defaultHostname")]
        public Input<string>? DefaultHostname { get; set; }

        /// <summary>
        /// Is the Linux Function App Slot enabled.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The ID of the Linux Function App this Slot is a member of. Changing this forces a new resource to be created.
        /// </summary>
        [Input("functionAppId")]
        public Input<string>? FunctionAppId { get; set; }

        /// <summary>
        /// The runtime version associated with the Function App Slot.
        /// </summary>
        [Input("functionsExtensionVersion")]
        public Input<string>? FunctionsExtensionVersion { get; set; }

        /// <summary>
        /// Can the Function App Slot only be accessed via HTTPS?
        /// </summary>
        [Input("httpsOnly")]
        public Input<bool>? HttpsOnly { get; set; }

        /// <summary>
        /// An `identity` block as detailed below.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.LinuxFunctionAppSlotIdentityGetArgs>? Identity { get; set; }

        /// <summary>
        /// The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the `identity` block. [For more information see - Access vaults with a user-assigned identity](https://docs.microsoft.com/en-us/azure/app-service/app-service-key-vault-references#access-vaults-with-a-user-assigned-identity)
        /// </summary>
        [Input("keyVaultReferenceIdentityId")]
        public Input<string>? KeyVaultReferenceIdentityId { get; set; }

        /// <summary>
        /// The Kind value for this Linux Function App Slot.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Specifies the name of the Function App Slot. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("outboundIpAddressLists")]
        private InputList<string>? _outboundIpAddressLists;

        /// <summary>
        /// A list of outbound IP addresses. For example `["52.23.25.3", "52.143.43.12"]`
        /// </summary>
        public InputList<string> OutboundIpAddressLists
        {
            get => _outboundIpAddressLists ?? (_outboundIpAddressLists = new InputList<string>());
            set => _outboundIpAddressLists = value;
        }

        /// <summary>
        /// A comma separated list of outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12`.
        /// </summary>
        [Input("outboundIpAddresses")]
        public Input<string>? OutboundIpAddresses { get; set; }

        [Input("possibleOutboundIpAddressLists")]
        private InputList<string>? _possibleOutboundIpAddressLists;

        /// <summary>
        /// A list of possible outbound IP addresses, not all of which are necessarily in use. This is a superset of `outbound_ip_address_list`. For example `["52.23.25.3", "52.143.43.12"]`.
        /// </summary>
        public InputList<string> PossibleOutboundIpAddressLists
        {
            get => _possibleOutboundIpAddressLists ?? (_possibleOutboundIpAddressLists = new InputList<string>());
            set => _possibleOutboundIpAddressLists = value;
        }

        /// <summary>
        /// A comma separated list of possible outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12,52.143.43.17`. This is a superset of `outbound_ip_addresses`. For example `["52.23.25.3", "52.143.43.12","52.143.43.17"]`.
        /// </summary>
        [Input("possibleOutboundIpAddresses")]
        public Input<string>? PossibleOutboundIpAddresses { get; set; }

        /// <summary>
        /// a `site_config` block as detailed below.
        /// </summary>
        [Input("siteConfig")]
        public Input<Inputs.LinuxFunctionAppSlotSiteConfigGetArgs>? SiteConfig { get; set; }

        [Input("siteCredentials")]
        private InputList<Inputs.LinuxFunctionAppSlotSiteCredentialGetArgs>? _siteCredentials;

        /// <summary>
        /// A `site_credential` block as defined below.
        /// </summary>
        public InputList<Inputs.LinuxFunctionAppSlotSiteCredentialGetArgs> SiteCredentials
        {
            get => _siteCredentials ?? (_siteCredentials = new InputList<Inputs.LinuxFunctionAppSlotSiteCredentialGetArgs>());
            set => _siteCredentials = value;
        }

        /// <summary>
        /// The access key which will be used to access the storage account for the Function App Slot.
        /// </summary>
        [Input("storageAccountAccessKey")]
        public Input<string>? StorageAccountAccessKey { get; set; }

        /// <summary>
        /// The backend storage account name which will be used by this Function App Slot.
        /// </summary>
        [Input("storageAccountName")]
        public Input<string>? StorageAccountName { get; set; }

        /// <summary>
        /// The Key Vault Secret ID, optionally including version, that contains the Connection String to connect to the storage account for this Function App.
        /// </summary>
        [Input("storageKeyVaultSecretId")]
        public Input<string>? StorageKeyVaultSecretId { get; set; }

        /// <summary>
        /// Should the Function App Slot use its Managed Identity to access storage.
        /// </summary>
        [Input("storageUsesManagedIdentity")]
        public Input<bool>? StorageUsesManagedIdentity { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A mapping of tags which should be assigned to the Linux Function App.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public LinuxFunctionAppSlotState()
        {
        }
    }
}

// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.LogAnalytics
{
    /// <summary>
    /// Manages a Log Analytics Storage Insights resource.
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
    ///         var exampleAnalyticsWorkspace = new Azure.OperationalInsights.AnalyticsWorkspace("exampleAnalyticsWorkspace", new Azure.OperationalInsights.AnalyticsWorkspaceArgs
    ///         {
    ///             Location = exampleResourceGroup.Location,
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             Sku = "PerGB2018",
    ///             RetentionInDays = 30,
    ///         });
    ///         var exampleAccount = new Azure.Storage.Account("exampleAccount", new Azure.Storage.AccountArgs
    ///         {
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             Location = exampleResourceGroup.Location,
    ///             AccountTier = "Standard",
    ///             AccountReplicationType = "LRS",
    ///         });
    ///         var exampleStorageInsights = new Azure.LogAnalytics.StorageInsights("exampleStorageInsights", new Azure.LogAnalytics.StorageInsightsArgs
    ///         {
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             WorkspaceId = exampleAnalyticsWorkspace.Id,
    ///             StorageAccountId = exampleAccount.Id,
    ///             StorageAccountKey = exampleAccount.PrimaryAccessKey,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Log Analytics Storage Insight Configs can be imported using the `resource id`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import azure:loganalytics/storageInsights:StorageInsights example /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/group1/providers/Microsoft.OperationalInsights/workspaces/workspace1/storageInsightConfigs/storageInsight1
    /// ```
    /// </summary>
    [AzureResourceType("azure:loganalytics/storageInsights:StorageInsights")]
    public partial class StorageInsights : Pulumi.CustomResource
    {
        /// <summary>
        /// The names of the blob containers that the workspace should read.
        /// </summary>
        [Output("blobContainerNames")]
        public Output<ImmutableArray<string>> BlobContainerNames { get; private set; } = null!;

        /// <summary>
        /// The name which should be used for this Log Analytics Storage Insights. Changing this forces a new Log Analytics Storage Insights to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the Resource Group where the Log Analytics Storage Insights should exist. Changing this forces a new Log Analytics Storage Insights to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The ID of the Storage Account used by this Log Analytics Storage Insights.
        /// </summary>
        [Output("storageAccountId")]
        public Output<string> StorageAccountId { get; private set; } = null!;

        /// <summary>
        /// The storage access key to be used to connect to the storage account.
        /// </summary>
        [Output("storageAccountKey")]
        public Output<string> StorageAccountKey { get; private set; } = null!;

        /// <summary>
        /// The names of the Azure tables that the workspace should read.
        /// </summary>
        [Output("tableNames")]
        public Output<ImmutableArray<string>> TableNames { get; private set; } = null!;

        /// <summary>
        /// The ID of the Log Analytics Workspace within which the Storage Insights should exist. Changing this forces a new Log Analytics Storage Insights to be created.
        /// </summary>
        [Output("workspaceId")]
        public Output<string> WorkspaceId { get; private set; } = null!;


        /// <summary>
        /// Create a StorageInsights resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public StorageInsights(string name, StorageInsightsArgs args, CustomResourceOptions? options = null)
            : base("azure:loganalytics/storageInsights:StorageInsights", name, args ?? new StorageInsightsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private StorageInsights(string name, Input<string> id, StorageInsightsState? state = null, CustomResourceOptions? options = null)
            : base("azure:loganalytics/storageInsights:StorageInsights", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing StorageInsights resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static StorageInsights Get(string name, Input<string> id, StorageInsightsState? state = null, CustomResourceOptions? options = null)
        {
            return new StorageInsights(name, id, state, options);
        }
    }

    public sealed class StorageInsightsArgs : Pulumi.ResourceArgs
    {
        [Input("blobContainerNames")]
        private InputList<string>? _blobContainerNames;

        /// <summary>
        /// The names of the blob containers that the workspace should read.
        /// </summary>
        public InputList<string> BlobContainerNames
        {
            get => _blobContainerNames ?? (_blobContainerNames = new InputList<string>());
            set => _blobContainerNames = value;
        }

        /// <summary>
        /// The name which should be used for this Log Analytics Storage Insights. Changing this forces a new Log Analytics Storage Insights to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Resource Group where the Log Analytics Storage Insights should exist. Changing this forces a new Log Analytics Storage Insights to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The ID of the Storage Account used by this Log Analytics Storage Insights.
        /// </summary>
        [Input("storageAccountId", required: true)]
        public Input<string> StorageAccountId { get; set; } = null!;

        /// <summary>
        /// The storage access key to be used to connect to the storage account.
        /// </summary>
        [Input("storageAccountKey", required: true)]
        public Input<string> StorageAccountKey { get; set; } = null!;

        [Input("tableNames")]
        private InputList<string>? _tableNames;

        /// <summary>
        /// The names of the Azure tables that the workspace should read.
        /// </summary>
        public InputList<string> TableNames
        {
            get => _tableNames ?? (_tableNames = new InputList<string>());
            set => _tableNames = value;
        }

        /// <summary>
        /// The ID of the Log Analytics Workspace within which the Storage Insights should exist. Changing this forces a new Log Analytics Storage Insights to be created.
        /// </summary>
        [Input("workspaceId", required: true)]
        public Input<string> WorkspaceId { get; set; } = null!;

        public StorageInsightsArgs()
        {
        }
    }

    public sealed class StorageInsightsState : Pulumi.ResourceArgs
    {
        [Input("blobContainerNames")]
        private InputList<string>? _blobContainerNames;

        /// <summary>
        /// The names of the blob containers that the workspace should read.
        /// </summary>
        public InputList<string> BlobContainerNames
        {
            get => _blobContainerNames ?? (_blobContainerNames = new InputList<string>());
            set => _blobContainerNames = value;
        }

        /// <summary>
        /// The name which should be used for this Log Analytics Storage Insights. Changing this forces a new Log Analytics Storage Insights to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Resource Group where the Log Analytics Storage Insights should exist. Changing this forces a new Log Analytics Storage Insights to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The ID of the Storage Account used by this Log Analytics Storage Insights.
        /// </summary>
        [Input("storageAccountId")]
        public Input<string>? StorageAccountId { get; set; }

        /// <summary>
        /// The storage access key to be used to connect to the storage account.
        /// </summary>
        [Input("storageAccountKey")]
        public Input<string>? StorageAccountKey { get; set; }

        [Input("tableNames")]
        private InputList<string>? _tableNames;

        /// <summary>
        /// The names of the Azure tables that the workspace should read.
        /// </summary>
        public InputList<string> TableNames
        {
            get => _tableNames ?? (_tableNames = new InputList<string>());
            set => _tableNames = value;
        }

        /// <summary>
        /// The ID of the Log Analytics Workspace within which the Storage Insights should exist. Changing this forces a new Log Analytics Storage Insights to be created.
        /// </summary>
        [Input("workspaceId")]
        public Input<string>? WorkspaceId { get; set; }

        public StorageInsightsState()
        {
        }
    }
}

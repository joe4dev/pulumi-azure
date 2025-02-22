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
    /// Manages a Log Analytics Windows Event DataSource.
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
    ///         });
    ///         var exampleDataSourceWindowsEvent = new Azure.LogAnalytics.DataSourceWindowsEvent("exampleDataSourceWindowsEvent", new Azure.LogAnalytics.DataSourceWindowsEventArgs
    ///         {
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             WorkspaceName = exampleAnalyticsWorkspace.Name,
    ///             EventLogName = "Application",
    ///             EventTypes = 
    ///             {
    ///                 "Error",
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Log Analytics Windows Event DataSources can be imported using the `resource id`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import azure:loganalytics/dataSourceWindowsEvent:DataSourceWindowsEvent example /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/group1/providers/Microsoft.OperationalInsights/workspaces/workspace1/datasources/datasource1
    /// ```
    /// </summary>
    [AzureResourceType("azure:loganalytics/dataSourceWindowsEvent:DataSourceWindowsEvent")]
    public partial class DataSourceWindowsEvent : Pulumi.CustomResource
    {
        /// <summary>
        /// Specifies the name of the Windows Event Log to collect events from.
        /// </summary>
        [Output("eventLogName")]
        public Output<string> EventLogName { get; private set; } = null!;

        /// <summary>
        /// Specifies an array of event types applied to the specified event log. Possible values include `Error`, `Warning` and `Information`.
        /// </summary>
        [Output("eventTypes")]
        public Output<ImmutableArray<string>> EventTypes { get; private set; } = null!;

        /// <summary>
        /// The name which should be used for this Log Analytics Windows Event DataSource. Changing this forces a new Log Analytics Windows Event DataSource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the Resource Group where the Log Analytics Windows Event DataSource should exist. Changing this forces a new Log Analytics Windows Event DataSource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The name of the Log Analytics Workspace where the Log Analytics Windows Event DataSource should exist. Changing this forces a new Log Analytics Windows Event DataSource to be created.
        /// </summary>
        [Output("workspaceName")]
        public Output<string> WorkspaceName { get; private set; } = null!;


        /// <summary>
        /// Create a DataSourceWindowsEvent resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DataSourceWindowsEvent(string name, DataSourceWindowsEventArgs args, CustomResourceOptions? options = null)
            : base("azure:loganalytics/dataSourceWindowsEvent:DataSourceWindowsEvent", name, args ?? new DataSourceWindowsEventArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DataSourceWindowsEvent(string name, Input<string> id, DataSourceWindowsEventState? state = null, CustomResourceOptions? options = null)
            : base("azure:loganalytics/dataSourceWindowsEvent:DataSourceWindowsEvent", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DataSourceWindowsEvent resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DataSourceWindowsEvent Get(string name, Input<string> id, DataSourceWindowsEventState? state = null, CustomResourceOptions? options = null)
        {
            return new DataSourceWindowsEvent(name, id, state, options);
        }
    }

    public sealed class DataSourceWindowsEventArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the name of the Windows Event Log to collect events from.
        /// </summary>
        [Input("eventLogName", required: true)]
        public Input<string> EventLogName { get; set; } = null!;

        [Input("eventTypes", required: true)]
        private InputList<string>? _eventTypes;

        /// <summary>
        /// Specifies an array of event types applied to the specified event log. Possible values include `Error`, `Warning` and `Information`.
        /// </summary>
        public InputList<string> EventTypes
        {
            get => _eventTypes ?? (_eventTypes = new InputList<string>());
            set => _eventTypes = value;
        }

        /// <summary>
        /// The name which should be used for this Log Analytics Windows Event DataSource. Changing this forces a new Log Analytics Windows Event DataSource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Resource Group where the Log Analytics Windows Event DataSource should exist. Changing this forces a new Log Analytics Windows Event DataSource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Log Analytics Workspace where the Log Analytics Windows Event DataSource should exist. Changing this forces a new Log Analytics Windows Event DataSource to be created.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public DataSourceWindowsEventArgs()
        {
        }
    }

    public sealed class DataSourceWindowsEventState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the name of the Windows Event Log to collect events from.
        /// </summary>
        [Input("eventLogName")]
        public Input<string>? EventLogName { get; set; }

        [Input("eventTypes")]
        private InputList<string>? _eventTypes;

        /// <summary>
        /// Specifies an array of event types applied to the specified event log. Possible values include `Error`, `Warning` and `Information`.
        /// </summary>
        public InputList<string> EventTypes
        {
            get => _eventTypes ?? (_eventTypes = new InputList<string>());
            set => _eventTypes = value;
        }

        /// <summary>
        /// The name which should be used for this Log Analytics Windows Event DataSource. Changing this forces a new Log Analytics Windows Event DataSource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Resource Group where the Log Analytics Windows Event DataSource should exist. Changing this forces a new Log Analytics Windows Event DataSource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The name of the Log Analytics Workspace where the Log Analytics Windows Event DataSource should exist. Changing this forces a new Log Analytics Windows Event DataSource to be created.
        /// </summary>
        [Input("workspaceName")]
        public Input<string>? WorkspaceName { get; set; }

        public DataSourceWindowsEventState()
        {
        }
    }
}

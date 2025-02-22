// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Consumption
{
    /// <summary>
    /// Manages a Subscription Consumption Budget.
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
    ///         var current = Output.Create(Azure.Core.GetSubscription.InvokeAsync());
    ///         var exampleResourceGroup = new Azure.Core.ResourceGroup("exampleResourceGroup", new Azure.Core.ResourceGroupArgs
    ///         {
    ///             Location = "eastus",
    ///         });
    ///         var exampleActionGroup = new Azure.Monitoring.ActionGroup("exampleActionGroup", new Azure.Monitoring.ActionGroupArgs
    ///         {
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             ShortName = "example",
    ///         });
    ///         var exampleBudgetSubscription = new Azure.Consumption.BudgetSubscription("exampleBudgetSubscription", new Azure.Consumption.BudgetSubscriptionArgs
    ///         {
    ///             SubscriptionId = current.Apply(current =&gt; current.Id),
    ///             Amount = 1000,
    ///             TimeGrain = "Monthly",
    ///             TimePeriod = new Azure.Consumption.Inputs.BudgetSubscriptionTimePeriodArgs
    ///             {
    ///                 StartDate = "2022-06-01T00:00:00Z",
    ///                 EndDate = "2022-07-01T00:00:00Z",
    ///             },
    ///             Filter = new Azure.Consumption.Inputs.BudgetSubscriptionFilterArgs
    ///             {
    ///                 Dimensions = 
    ///                 {
    ///                     new Azure.Consumption.Inputs.BudgetSubscriptionFilterDimensionArgs
    ///                     {
    ///                         Name = "ResourceGroupName",
    ///                         Values = 
    ///                         {
    ///                             exampleResourceGroup.Name,
    ///                         },
    ///                     },
    ///                 },
    ///                 Tags = 
    ///                 {
    ///                     new Azure.Consumption.Inputs.BudgetSubscriptionFilterTagArgs
    ///                     {
    ///                         Name = "foo",
    ///                         Values = 
    ///                         {
    ///                             "bar",
    ///                             "baz",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             Notifications = 
    ///             {
    ///                 new Azure.Consumption.Inputs.BudgetSubscriptionNotificationArgs
    ///                 {
    ///                     Enabled = true,
    ///                     Threshold = 90,
    ///                     Operator = "EqualTo",
    ///                     ContactEmails = 
    ///                     {
    ///                         "foo@example.com",
    ///                         "bar@example.com",
    ///                     },
    ///                     ContactGroups = 
    ///                     {
    ///                         exampleActionGroup.Id,
    ///                     },
    ///                     ContactRoles = 
    ///                     {
    ///                         "Owner",
    ///                     },
    ///                 },
    ///                 new Azure.Consumption.Inputs.BudgetSubscriptionNotificationArgs
    ///                 {
    ///                     Enabled = false,
    ///                     Threshold = 100,
    ///                     Operator = "GreaterThan",
    ///                     ThresholdType = "Forecasted",
    ///                     ContactEmails = 
    ///                     {
    ///                         "foo@example.com",
    ///                         "bar@example.com",
    ///                     },
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Subscription Consumption Budgets can be imported using the `resource id`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import azure:consumption/budgetSubscription:BudgetSubscription example /subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Consumption/budgets/subscription1
    /// ```
    /// </summary>
    [AzureResourceType("azure:consumption/budgetSubscription:BudgetSubscription")]
    public partial class BudgetSubscription : Pulumi.CustomResource
    {
        /// <summary>
        /// The total amount of cost to track with the budget.
        /// </summary>
        [Output("amount")]
        public Output<double> Amount { get; private set; } = null!;

        /// <summary>
        /// The ETag of the Subscription Consumption Budget.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// A `filter` block as defined below.
        /// </summary>
        [Output("filter")]
        public Output<Outputs.BudgetSubscriptionFilter?> Filter { get; private set; } = null!;

        /// <summary>
        /// The name which should be used for this Subscription Consumption Budget. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// One or more `notification` blocks as defined below.
        /// </summary>
        [Output("notifications")]
        public Output<ImmutableArray<Outputs.BudgetSubscriptionNotification>> Notifications { get; private set; } = null!;

        /// <summary>
        /// The ID of the Subscription for which to create a Consumption Budget. Changing this forces a new resource to be created.
        /// </summary>
        [Output("subscriptionId")]
        public Output<string> SubscriptionId { get; private set; } = null!;

        /// <summary>
        /// The time covered by a budget. Tracking of the amount will be reset based on the time grain. Must be one of `Monthly`, `Quarterly`, `Annually`, `BillingMonth`, `BillingQuarter`, or `BillingYear`. Defaults to `Monthly`.
        /// </summary>
        [Output("timeGrain")]
        public Output<string?> TimeGrain { get; private set; } = null!;

        /// <summary>
        /// A `time_period` block as defined below.
        /// </summary>
        [Output("timePeriod")]
        public Output<Outputs.BudgetSubscriptionTimePeriod> TimePeriod { get; private set; } = null!;


        /// <summary>
        /// Create a BudgetSubscription resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public BudgetSubscription(string name, BudgetSubscriptionArgs args, CustomResourceOptions? options = null)
            : base("azure:consumption/budgetSubscription:BudgetSubscription", name, args ?? new BudgetSubscriptionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private BudgetSubscription(string name, Input<string> id, BudgetSubscriptionState? state = null, CustomResourceOptions? options = null)
            : base("azure:consumption/budgetSubscription:BudgetSubscription", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing BudgetSubscription resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static BudgetSubscription Get(string name, Input<string> id, BudgetSubscriptionState? state = null, CustomResourceOptions? options = null)
        {
            return new BudgetSubscription(name, id, state, options);
        }
    }

    public sealed class BudgetSubscriptionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The total amount of cost to track with the budget.
        /// </summary>
        [Input("amount", required: true)]
        public Input<double> Amount { get; set; } = null!;

        /// <summary>
        /// The ETag of the Subscription Consumption Budget.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// A `filter` block as defined below.
        /// </summary>
        [Input("filter")]
        public Input<Inputs.BudgetSubscriptionFilterArgs>? Filter { get; set; }

        /// <summary>
        /// The name which should be used for this Subscription Consumption Budget. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("notifications", required: true)]
        private InputList<Inputs.BudgetSubscriptionNotificationArgs>? _notifications;

        /// <summary>
        /// One or more `notification` blocks as defined below.
        /// </summary>
        public InputList<Inputs.BudgetSubscriptionNotificationArgs> Notifications
        {
            get => _notifications ?? (_notifications = new InputList<Inputs.BudgetSubscriptionNotificationArgs>());
            set => _notifications = value;
        }

        /// <summary>
        /// The ID of the Subscription for which to create a Consumption Budget. Changing this forces a new resource to be created.
        /// </summary>
        [Input("subscriptionId", required: true)]
        public Input<string> SubscriptionId { get; set; } = null!;

        /// <summary>
        /// The time covered by a budget. Tracking of the amount will be reset based on the time grain. Must be one of `Monthly`, `Quarterly`, `Annually`, `BillingMonth`, `BillingQuarter`, or `BillingYear`. Defaults to `Monthly`.
        /// </summary>
        [Input("timeGrain")]
        public Input<string>? TimeGrain { get; set; }

        /// <summary>
        /// A `time_period` block as defined below.
        /// </summary>
        [Input("timePeriod", required: true)]
        public Input<Inputs.BudgetSubscriptionTimePeriodArgs> TimePeriod { get; set; } = null!;

        public BudgetSubscriptionArgs()
        {
        }
    }

    public sealed class BudgetSubscriptionState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The total amount of cost to track with the budget.
        /// </summary>
        [Input("amount")]
        public Input<double>? Amount { get; set; }

        /// <summary>
        /// The ETag of the Subscription Consumption Budget.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// A `filter` block as defined below.
        /// </summary>
        [Input("filter")]
        public Input<Inputs.BudgetSubscriptionFilterGetArgs>? Filter { get; set; }

        /// <summary>
        /// The name which should be used for this Subscription Consumption Budget. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("notifications")]
        private InputList<Inputs.BudgetSubscriptionNotificationGetArgs>? _notifications;

        /// <summary>
        /// One or more `notification` blocks as defined below.
        /// </summary>
        public InputList<Inputs.BudgetSubscriptionNotificationGetArgs> Notifications
        {
            get => _notifications ?? (_notifications = new InputList<Inputs.BudgetSubscriptionNotificationGetArgs>());
            set => _notifications = value;
        }

        /// <summary>
        /// The ID of the Subscription for which to create a Consumption Budget. Changing this forces a new resource to be created.
        /// </summary>
        [Input("subscriptionId")]
        public Input<string>? SubscriptionId { get; set; }

        /// <summary>
        /// The time covered by a budget. Tracking of the amount will be reset based on the time grain. Must be one of `Monthly`, `Quarterly`, `Annually`, `BillingMonth`, `BillingQuarter`, or `BillingYear`. Defaults to `Monthly`.
        /// </summary>
        [Input("timeGrain")]
        public Input<string>? TimeGrain { get; set; }

        /// <summary>
        /// A `time_period` block as defined below.
        /// </summary>
        [Input("timePeriod")]
        public Input<Inputs.BudgetSubscriptionTimePeriodGetArgs>? TimePeriod { get; set; }

        public BudgetSubscriptionState()
        {
        }
    }
}

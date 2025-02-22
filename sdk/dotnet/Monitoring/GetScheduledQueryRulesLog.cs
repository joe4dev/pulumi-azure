// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Monitoring
{
    public static class GetScheduledQueryRulesLog
    {
        /// <summary>
        /// Use this data source to access the properties of a LogToMetricAction scheduled query rule.
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
        ///         var example = Output.Create(Azure.Monitoring.GetScheduledQueryRulesLog.InvokeAsync(new Azure.Monitoring.GetScheduledQueryRulesLogArgs
        ///         {
        ///             ResourceGroupName = "example-rg",
        ///             Name = "tfex-queryrule",
        ///         }));
        ///         this.QueryRuleId = example.Apply(example =&gt; example.Id);
        ///     }
        /// 
        ///     [Output("queryRuleId")]
        ///     public Output&lt;string&gt; QueryRuleId { get; set; }
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetScheduledQueryRulesLogResult> InvokeAsync(GetScheduledQueryRulesLogArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetScheduledQueryRulesLogResult>("azure:monitoring/getScheduledQueryRulesLog:getScheduledQueryRulesLog", args ?? new GetScheduledQueryRulesLogArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to access the properties of a LogToMetricAction scheduled query rule.
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
        ///         var example = Output.Create(Azure.Monitoring.GetScheduledQueryRulesLog.InvokeAsync(new Azure.Monitoring.GetScheduledQueryRulesLogArgs
        ///         {
        ///             ResourceGroupName = "example-rg",
        ///             Name = "tfex-queryrule",
        ///         }));
        ///         this.QueryRuleId = example.Apply(example =&gt; example.Id);
        ///     }
        /// 
        ///     [Output("queryRuleId")]
        ///     public Output&lt;string&gt; QueryRuleId { get; set; }
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetScheduledQueryRulesLogResult> Invoke(GetScheduledQueryRulesLogInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetScheduledQueryRulesLogResult>("azure:monitoring/getScheduledQueryRulesLog:getScheduledQueryRulesLog", args ?? new GetScheduledQueryRulesLogInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetScheduledQueryRulesLogArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Specifies the name of the scheduled query rule.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the resource group where the scheduled query rule is located.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetScheduledQueryRulesLogArgs()
        {
        }
    }

    public sealed class GetScheduledQueryRulesLogInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Specifies the name of the scheduled query rule.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the resource group where the scheduled query rule is located.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetScheduledQueryRulesLogInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetScheduledQueryRulesLogResult
    {
        public readonly ImmutableArray<string> AuthorizedResourceIds;
        /// <summary>
        /// A `criteria` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetScheduledQueryRulesLogCriteriaResult> Criterias;
        /// <summary>
        /// The resource URI over which log search query is to be run.
        /// </summary>
        public readonly string DataSourceId;
        /// <summary>
        /// The description of the scheduled query rule.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Whether this scheduled query rule is enabled.
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Location;
        /// <summary>
        /// Name of the dimension.
        /// </summary>
        public readonly string Name;
        public readonly string ResourceGroupName;
        public readonly ImmutableDictionary<string, string> Tags;

        [OutputConstructor]
        private GetScheduledQueryRulesLogResult(
            ImmutableArray<string> authorizedResourceIds,

            ImmutableArray<Outputs.GetScheduledQueryRulesLogCriteriaResult> criterias,

            string dataSourceId,

            string description,

            bool enabled,

            string id,

            string location,

            string name,

            string resourceGroupName,

            ImmutableDictionary<string, string> tags)
        {
            AuthorizedResourceIds = authorizedResourceIds;
            Criterias = criterias;
            DataSourceId = dataSourceId;
            Description = description;
            Enabled = enabled;
            Id = id;
            Location = location;
            Name = name;
            ResourceGroupName = resourceGroupName;
            Tags = tags;
        }
    }
}

// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Monitoring.Outputs
{

    [OutputType]
    public sealed class ActivityLogAlertCriteria
    {
        /// <summary>
        /// The email address or Azure Active Directory identifier of the user who performed the operation.
        /// </summary>
        public readonly string? Caller;
        /// <summary>
        /// The category of the operation. Possible values are `Administrative`, `Autoscale`, `Policy`, `Recommendation`, `ResourceHealth`, `Security` and `ServiceHealth`.
        /// </summary>
        public readonly string Category;
        /// <summary>
        /// The severity level of the event. Possible values are `Verbose`, `Informational`, `Warning`, `Error`, and `Critical`.
        /// </summary>
        public readonly string? Level;
        /// <summary>
        /// The Resource Manager Role-Based Access Control operation name. Supported operation should be of the form: `&lt;resourceProvider&gt;/&lt;resourceType&gt;/&lt;operation&gt;`.
        /// </summary>
        public readonly string? OperationName;
        /// <summary>
        /// The recommendation category of the event. Possible values are `Cost`, `Reliability`, `OperationalExcellence` and `Performance`. It is only allowed when `category` is `Recommendation`.
        /// </summary>
        public readonly string? RecommendationCategory;
        /// <summary>
        /// The recommendation impact of the event. Possible values are `High`, `Medium` and `Low`. It is only allowed when `category` is `Recommendation`.
        /// </summary>
        public readonly string? RecommendationImpact;
        /// <summary>
        /// The recommendation type of the event. It is only allowed when `category` is `Recommendation`.
        /// </summary>
        public readonly string? RecommendationType;
        /// <summary>
        /// The name of resource group monitored by the activity log alert.
        /// </summary>
        public readonly string? ResourceGroup;
        /// <summary>
        /// A block to define fine grain resource health settings.
        /// </summary>
        public readonly ImmutableArray<Outputs.ActivityLogAlertCriteriaResourceHealth> ResourceHealths;
        /// <summary>
        /// The specific resource monitored by the activity log alert. It should be within one of the `scopes`.
        /// </summary>
        public readonly string? ResourceId;
        /// <summary>
        /// The name of the resource provider monitored by the activity log alert.
        /// </summary>
        public readonly string? ResourceProvider;
        /// <summary>
        /// The resource type monitored by the activity log alert.
        /// </summary>
        public readonly string? ResourceType;
        /// <summary>
        /// A block to define fine grain service health settings.
        /// </summary>
        public readonly ImmutableArray<Outputs.ActivityLogAlertCriteriaServiceHealth> ServiceHealths;
        /// <summary>
        /// The status of the event. For example, `Started`, `Failed`, or `Succeeded`.
        /// </summary>
        public readonly string? Status;
        /// <summary>
        /// The sub status of the event.
        /// </summary>
        public readonly string? SubStatus;

        [OutputConstructor]
        private ActivityLogAlertCriteria(
            string? caller,

            string category,

            string? level,

            string? operationName,

            string? recommendationCategory,

            string? recommendationImpact,

            string? recommendationType,

            string? resourceGroup,

            ImmutableArray<Outputs.ActivityLogAlertCriteriaResourceHealth> resourceHealths,

            string? resourceId,

            string? resourceProvider,

            string? resourceType,

            ImmutableArray<Outputs.ActivityLogAlertCriteriaServiceHealth> serviceHealths,

            string? status,

            string? subStatus)
        {
            Caller = caller;
            Category = category;
            Level = level;
            OperationName = operationName;
            RecommendationCategory = recommendationCategory;
            RecommendationImpact = recommendationImpact;
            RecommendationType = recommendationType;
            ResourceGroup = resourceGroup;
            ResourceHealths = resourceHealths;
            ResourceId = resourceId;
            ResourceProvider = resourceProvider;
            ResourceType = resourceType;
            ServiceHealths = serviceHealths;
            Status = status;
            SubStatus = subStatus;
        }
    }
}

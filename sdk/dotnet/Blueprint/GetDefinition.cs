// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Blueprint
{
    public static class GetDefinition
    {
        /// <summary>
        /// Use this data source to access information about an existing Azure Blueprint Definition
        /// 
        /// &gt; **NOTE:** Azure Blueprints are in Preview and potentially subject to breaking change without notice.
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
        ///         var current = Output.Create(Azure.Core.GetClientConfig.InvokeAsync());
        ///         var root = current.Apply(current =&gt; Output.Create(Azure.Management.GetGroup.InvokeAsync(new Azure.Management.GetGroupArgs
        ///         {
        ///             Name = current.TenantId,
        ///         })));
        ///         var example = root.Apply(root =&gt; Output.Create(Azure.Blueprint.GetDefinition.InvokeAsync(new Azure.Blueprint.GetDefinitionArgs
        ///         {
        ///             Name = "exampleManagementGroupBP",
        ///             ScopeId = root.Id,
        ///         })));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetDefinitionResult> InvokeAsync(GetDefinitionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDefinitionResult>("azure:blueprint/getDefinition:getDefinition", args ?? new GetDefinitionArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to access information about an existing Azure Blueprint Definition
        /// 
        /// &gt; **NOTE:** Azure Blueprints are in Preview and potentially subject to breaking change without notice.
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
        ///         var current = Output.Create(Azure.Core.GetClientConfig.InvokeAsync());
        ///         var root = current.Apply(current =&gt; Output.Create(Azure.Management.GetGroup.InvokeAsync(new Azure.Management.GetGroupArgs
        ///         {
        ///             Name = current.TenantId,
        ///         })));
        ///         var example = root.Apply(root =&gt; Output.Create(Azure.Blueprint.GetDefinition.InvokeAsync(new Azure.Blueprint.GetDefinitionArgs
        ///         {
        ///             Name = "exampleManagementGroupBP",
        ///             ScopeId = root.Id,
        ///         })));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetDefinitionResult> Invoke(GetDefinitionInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDefinitionResult>("azure:blueprint/getDefinition:getDefinition", args ?? new GetDefinitionInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDefinitionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Blueprint.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The ID of the Subscription or Management Group, as the scope at which the blueprint definition is stored.
        /// </summary>
        [Input("scopeId", required: true)]
        public string ScopeId { get; set; } = null!;

        public GetDefinitionArgs()
        {
        }
    }

    public sealed class GetDefinitionInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Blueprint.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The ID of the Subscription or Management Group, as the scope at which the blueprint definition is stored.
        /// </summary>
        [Input("scopeId", required: true)]
        public Input<string> ScopeId { get; set; } = null!;

        public GetDefinitionInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDefinitionResult
    {
        /// <summary>
        /// The description of the Blueprint Definition.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// The display name of the Blueprint Definition.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The timestamp of when this last modification was saved to the Blueprint Definition.
        /// </summary>
        public readonly string LastModified;
        public readonly string Name;
        public readonly string ScopeId;
        /// <summary>
        /// The target scope.
        /// </summary>
        public readonly string TargetScope;
        /// <summary>
        /// The timestamp of when this Blueprint Definition was created.
        /// </summary>
        public readonly string TimeCreated;
        /// <summary>
        /// A list of versions published for this Blueprint Definition.
        /// </summary>
        public readonly ImmutableArray<string> Versions;

        [OutputConstructor]
        private GetDefinitionResult(
            string description,

            string displayName,

            string id,

            string lastModified,

            string name,

            string scopeId,

            string targetScope,

            string timeCreated,

            ImmutableArray<string> versions)
        {
            Description = description;
            DisplayName = displayName;
            Id = id;
            LastModified = lastModified;
            Name = name;
            ScopeId = scopeId;
            TargetScope = targetScope;
            TimeCreated = timeCreated;
            Versions = versions;
        }
    }
}

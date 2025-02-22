// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.ApiManagement
{
    public static class GetProduct
    {
        /// <summary>
        /// Use this data source to access information about an existing API Management Product.
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
        ///         var example = Output.Create(Azure.ApiManagement.GetProduct.InvokeAsync(new Azure.ApiManagement.GetProductArgs
        ///         {
        ///             ProductId = "my-product",
        ///             ApiManagementName = "example-apim",
        ///             ResourceGroupName = "search-service",
        ///         }));
        ///         this.ProductTerms = example.Apply(example =&gt; example.Terms);
        ///     }
        /// 
        ///     [Output("productTerms")]
        ///     public Output&lt;string&gt; ProductTerms { get; set; }
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetProductResult> InvokeAsync(GetProductArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetProductResult>("azure:apimanagement/getProduct:getProduct", args ?? new GetProductArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to access information about an existing API Management Product.
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
        ///         var example = Output.Create(Azure.ApiManagement.GetProduct.InvokeAsync(new Azure.ApiManagement.GetProductArgs
        ///         {
        ///             ProductId = "my-product",
        ///             ApiManagementName = "example-apim",
        ///             ResourceGroupName = "search-service",
        ///         }));
        ///         this.ProductTerms = example.Apply(example =&gt; example.Terms);
        ///     }
        /// 
        ///     [Output("productTerms")]
        ///     public Output&lt;string&gt; ProductTerms { get; set; }
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetProductResult> Invoke(GetProductInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetProductResult>("azure:apimanagement/getProduct:getProduct", args ?? new GetProductInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetProductArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Name of the API Management Service in which this Product exists.
        /// </summary>
        [Input("apiManagementName", required: true)]
        public string ApiManagementName { get; set; } = null!;

        /// <summary>
        /// The Identifier for the API Management Product.
        /// </summary>
        [Input("productId", required: true)]
        public string ProductId { get; set; } = null!;

        /// <summary>
        /// The Name of the Resource Group in which the API Management Service exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetProductArgs()
        {
        }
    }

    public sealed class GetProductInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Name of the API Management Service in which this Product exists.
        /// </summary>
        [Input("apiManagementName", required: true)]
        public Input<string> ApiManagementName { get; set; } = null!;

        /// <summary>
        /// The Identifier for the API Management Product.
        /// </summary>
        [Input("productId", required: true)]
        public Input<string> ProductId { get; set; } = null!;

        /// <summary>
        /// The Name of the Resource Group in which the API Management Service exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetProductInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetProductResult
    {
        public readonly string ApiManagementName;
        /// <summary>
        /// Do subscribers need to be approved prior to being able to use the Product?
        /// </summary>
        public readonly bool ApprovalRequired;
        /// <summary>
        /// The description of this Product, which may include HTML formatting tags.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// The Display Name for this API Management Product.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string ProductId;
        /// <summary>
        /// Is this Product Published?
        /// </summary>
        public readonly bool Published;
        public readonly string ResourceGroupName;
        /// <summary>
        /// Is a Subscription required to access API's included in this Product?
        /// </summary>
        public readonly bool SubscriptionRequired;
        /// <summary>
        /// The number of subscriptions a user can have to this Product at the same time.
        /// </summary>
        public readonly int SubscriptionsLimit;
        /// <summary>
        /// Any Terms and Conditions for this Product, which must be accepted by Developers before they can begin the Subscription process.
        /// </summary>
        public readonly string Terms;

        [OutputConstructor]
        private GetProductResult(
            string apiManagementName,

            bool approvalRequired,

            string description,

            string displayName,

            string id,

            string productId,

            bool published,

            string resourceGroupName,

            bool subscriptionRequired,

            int subscriptionsLimit,

            string terms)
        {
            ApiManagementName = apiManagementName;
            ApprovalRequired = approvalRequired;
            Description = description;
            DisplayName = displayName;
            Id = id;
            ProductId = productId;
            Published = published;
            ResourceGroupName = resourceGroupName;
            SubscriptionRequired = subscriptionRequired;
            SubscriptionsLimit = subscriptionsLimit;
            Terms = terms;
        }
    }
}

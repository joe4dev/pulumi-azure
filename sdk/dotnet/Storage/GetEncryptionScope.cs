// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Storage
{
    public static class GetEncryptionScope
    {
        /// <summary>
        /// Use this data source to access information about an existing Storage Encryption Scope.
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
        ///         var exampleAccount = Output.Create(Azure.Storage.GetAccount.InvokeAsync(new Azure.Storage.GetAccountArgs
        ///         {
        ///             Name = "storageaccountname",
        ///             ResourceGroupName = "resourcegroupname",
        ///         }));
        ///         var exampleEncryptionScope = exampleAccount.Apply(exampleAccount =&gt; Output.Create(Azure.Storage.GetEncryptionScope.InvokeAsync(new Azure.Storage.GetEncryptionScopeArgs
        ///         {
        ///             Name = "existingStorageES",
        ///             StorageAccountId = exampleAccount.Id,
        ///         })));
        ///         this.Id = exampleEncryptionScope.Apply(exampleEncryptionScope =&gt; exampleEncryptionScope.Id);
        ///     }
        /// 
        ///     [Output("id")]
        ///     public Output&lt;string&gt; Id { get; set; }
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetEncryptionScopeResult> InvokeAsync(GetEncryptionScopeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetEncryptionScopeResult>("azure:storage/getEncryptionScope:getEncryptionScope", args ?? new GetEncryptionScopeArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to access information about an existing Storage Encryption Scope.
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
        ///         var exampleAccount = Output.Create(Azure.Storage.GetAccount.InvokeAsync(new Azure.Storage.GetAccountArgs
        ///         {
        ///             Name = "storageaccountname",
        ///             ResourceGroupName = "resourcegroupname",
        ///         }));
        ///         var exampleEncryptionScope = exampleAccount.Apply(exampleAccount =&gt; Output.Create(Azure.Storage.GetEncryptionScope.InvokeAsync(new Azure.Storage.GetEncryptionScopeArgs
        ///         {
        ///             Name = "existingStorageES",
        ///             StorageAccountId = exampleAccount.Id,
        ///         })));
        ///         this.Id = exampleEncryptionScope.Apply(exampleEncryptionScope =&gt; exampleEncryptionScope.Id);
        ///     }
        /// 
        ///     [Output("id")]
        ///     public Output&lt;string&gt; Id { get; set; }
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetEncryptionScopeResult> Invoke(GetEncryptionScopeInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetEncryptionScopeResult>("azure:storage/getEncryptionScope:getEncryptionScope", args ?? new GetEncryptionScopeInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetEncryptionScopeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of this Storage Encryption Scope.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The ID of the Storage Account where this Storage Encryption Scope exists.
        /// </summary>
        [Input("storageAccountId", required: true)]
        public string StorageAccountId { get; set; } = null!;

        public GetEncryptionScopeArgs()
        {
        }
    }

    public sealed class GetEncryptionScopeInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of this Storage Encryption Scope.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The ID of the Storage Account where this Storage Encryption Scope exists.
        /// </summary>
        [Input("storageAccountId", required: true)]
        public Input<string> StorageAccountId { get; set; } = null!;

        public GetEncryptionScopeInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetEncryptionScopeResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The ID of the Key Vault Key.
        /// </summary>
        public readonly string KeyVaultKeyId;
        public readonly string Name;
        /// <summary>
        /// The source of the Storage Encryption Scope.
        /// </summary>
        public readonly string Source;
        public readonly string StorageAccountId;

        [OutputConstructor]
        private GetEncryptionScopeResult(
            string id,

            string keyVaultKeyId,

            string name,

            string source,

            string storageAccountId)
        {
            Id = id;
            KeyVaultKeyId = keyVaultKeyId;
            Name = name;
            Source = source;
            StorageAccountId = storageAccountId;
        }
    }
}

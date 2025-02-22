// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Batch.Inputs
{

    public sealed class AccountEncryptionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Azure key vault reference id with version that should be used to encrypt data, as documented [here](https://docs.microsoft.com/en-us/azure/batch/batch-customer-managed-key). Key rotation is not yet supported.
        /// </summary>
        [Input("keyVaultKeyId", required: true)]
        public Input<string> KeyVaultKeyId { get; set; } = null!;

        public AccountEncryptionArgs()
        {
        }
    }
}

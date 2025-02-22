// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.ContainerService.Outputs
{

    [OutputType]
    public sealed class KubernetesClusterKeyVaultSecretsProvider
    {
        /// <summary>
        /// An `secret_identity` block is exported. The exported attributes are defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.KubernetesClusterKeyVaultSecretsProviderSecretIdentity> SecretIdentities;
        /// <summary>
        /// Is secret rotation enabled?
        /// </summary>
        public readonly bool? SecretRotationEnabled;
        /// <summary>
        /// The interval to poll for secret rotation. This attribute is only set when `secret_rotation` is true and defaults to `2m`.
        /// </summary>
        public readonly string? SecretRotationInterval;

        [OutputConstructor]
        private KubernetesClusterKeyVaultSecretsProvider(
            ImmutableArray<Outputs.KubernetesClusterKeyVaultSecretsProviderSecretIdentity> secretIdentities,

            bool? secretRotationEnabled,

            string? secretRotationInterval)
        {
            SecretIdentities = secretIdentities;
            SecretRotationEnabled = secretRotationEnabled;
            SecretRotationInterval = secretRotationInterval;
        }
    }
}

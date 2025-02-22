// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.LogicApps.Outputs
{

    [OutputType]
    public sealed class StandardIdentity
    {
        /// <summary>
        /// The Principal ID for the Service Principal associated with the Managed Service Identity of this App Service.
        /// </summary>
        public readonly string? PrincipalId;
        /// <summary>
        /// The Tenant ID for the Service Principal associated with the Managed Service Identity of this App Service.
        /// </summary>
        public readonly string? TenantId;
        /// <summary>
        /// Specifies the type of Managed Service Identity that should be configured on this Logic App Standard. The only possible value is `SystemAssigned`.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private StandardIdentity(
            string? principalId,

            string? tenantId,

            string type)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
        }
    }
}

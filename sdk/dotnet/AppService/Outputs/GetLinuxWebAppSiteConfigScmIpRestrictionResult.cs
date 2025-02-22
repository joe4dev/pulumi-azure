// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.AppService.Outputs
{

    [OutputType]
    public sealed class GetLinuxWebAppSiteConfigScmIpRestrictionResult
    {
        /// <summary>
        /// A `action` block as defined above.
        /// </summary>
        public readonly string Action;
        public readonly ImmutableArray<Outputs.GetLinuxWebAppSiteConfigScmIpRestrictionHeaderResult> Headers;
        public readonly string IpAddress;
        /// <summary>
        /// The name of this Linux Web App.
        /// </summary>
        public readonly string Name;
        public readonly int Priority;
        public readonly string ServiceTag;
        public readonly string VirtualNetworkSubnetId;

        [OutputConstructor]
        private GetLinuxWebAppSiteConfigScmIpRestrictionResult(
            string action,

            ImmutableArray<Outputs.GetLinuxWebAppSiteConfigScmIpRestrictionHeaderResult> headers,

            string ipAddress,

            string name,

            int priority,

            string serviceTag,

            string virtualNetworkSubnetId)
        {
            Action = action;
            Headers = headers;
            IpAddress = ipAddress;
            Name = name;
            Priority = priority;
            ServiceTag = serviceTag;
            VirtualNetworkSubnetId = virtualNetworkSubnetId;
        }
    }
}

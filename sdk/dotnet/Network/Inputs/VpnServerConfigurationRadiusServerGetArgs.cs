// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Network.Inputs
{

    public sealed class VpnServerConfigurationRadiusServerGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Address of the Radius Server.
        /// </summary>
        [Input("address", required: true)]
        public Input<string> Address { get; set; } = null!;

        /// <summary>
        /// The Score of the Radius Server determines the priority of the server. Ranges from 1 to 30.
        /// </summary>
        [Input("score", required: true)]
        public Input<int> Score { get; set; } = null!;

        /// <summary>
        /// The Secret used to communicate with the Radius Server.
        /// </summary>
        [Input("secret", required: true)]
        public Input<string> Secret { get; set; } = null!;

        public VpnServerConfigurationRadiusServerGetArgs()
        {
        }
    }
}

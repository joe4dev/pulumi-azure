// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Monitoring.Inputs
{

    public sealed class LogzTagRuleTagFilterGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The action for a filtering tag. Possible values are "Include" and "Exclude" is allowed. Note that the `Exclude` takes priority over the `Include`.
        /// </summary>
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        /// <summary>
        /// The name of this `tag_filter`.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The value of this `tag_filter`.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public LogzTagRuleTagFilterGetArgs()
        {
        }
    }
}

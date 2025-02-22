// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.AppService.Inputs
{

    public sealed class LinuxWebAppLogsHttpLogsAzureBlobStorageGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The time in days after which to remove blobs. A value of `0` means no retention.
        /// </summary>
        [Input("retentionInDays")]
        public Input<int>? RetentionInDays { get; set; }

        /// <summary>
        /// SAS url to an Azure blob container with read/write/list/delete permissions.
        /// </summary>
        [Input("sasUrl", required: true)]
        public Input<string> SasUrl { get; set; } = null!;

        public LinuxWebAppLogsHttpLogsAzureBlobStorageGetArgs()
        {
        }
    }
}

// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.AppService.Inputs
{

    public sealed class LinuxWebAppSlotLogsHttpLogsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A `azure_blob_storage` block as defined above.
        /// </summary>
        [Input("azureBlobStorage")]
        public Input<Inputs.LinuxWebAppSlotLogsHttpLogsAzureBlobStorageGetArgs>? AzureBlobStorage { get; set; }

        /// <summary>
        /// A `file_system` block as defined above.
        /// </summary>
        [Input("fileSystem")]
        public Input<Inputs.LinuxWebAppSlotLogsHttpLogsFileSystemGetArgs>? FileSystem { get; set; }

        public LinuxWebAppSlotLogsHttpLogsGetArgs()
        {
        }
    }
}

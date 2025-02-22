// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.AppService.Inputs
{

    public sealed class LinuxFunctionAppSlotAuthSettingsActiveDirectoryGetArgs : Pulumi.ResourceArgs
    {
        [Input("allowedAudiences")]
        private InputList<string>? _allowedAudiences;

        /// <summary>
        /// an `allowed_audiences` block as detailed below.
        /// </summary>
        public InputList<string> AllowedAudiences
        {
            get => _allowedAudiences ?? (_allowedAudiences = new InputList<string>());
            set => _allowedAudiences = value;
        }

        /// <summary>
        /// The ID of the Client to use to authenticate with Azure Active Directory.
        /// </summary>
        [Input("clientId", required: true)]
        public Input<string> ClientId { get; set; } = null!;

        /// <summary>
        /// The Client Secret for the Client ID. Cannot be used with `client_secret_setting_name`.
        /// </summary>
        [Input("clientSecret")]
        public Input<string>? ClientSecret { get; set; }

        /// <summary>
        /// The App Setting name that contains the client secret of the Client. Cannot be used with `client_secret`.
        /// </summary>
        [Input("clientSecretSettingName")]
        public Input<string>? ClientSecretSettingName { get; set; }

        public LinuxFunctionAppSlotAuthSettingsActiveDirectoryGetArgs()
        {
        }
    }
}

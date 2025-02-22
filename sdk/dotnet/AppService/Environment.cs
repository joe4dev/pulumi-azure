// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.AppService
{
    /// <summary>
    /// Manages an App Service Environment.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Azure = Pulumi.Azure;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var exampleResourceGroup = new Azure.Core.ResourceGroup("exampleResourceGroup", new Azure.Core.ResourceGroupArgs
    ///         {
    ///             Location = "West Europe",
    ///         });
    ///         var exampleVirtualNetwork = new Azure.Network.VirtualNetwork("exampleVirtualNetwork", new Azure.Network.VirtualNetworkArgs
    ///         {
    ///             Location = exampleResourceGroup.Location,
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             AddressSpaces = 
    ///             {
    ///                 "10.0.0.0/16",
    ///             },
    ///         });
    ///         var ase = new Azure.Network.Subnet("ase", new Azure.Network.SubnetArgs
    ///         {
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             VirtualNetworkName = exampleVirtualNetwork.Name,
    ///             AddressPrefixes = 
    ///             {
    ///                 "10.0.1.0/24",
    ///             },
    ///         });
    ///         var gateway = new Azure.Network.Subnet("gateway", new Azure.Network.SubnetArgs
    ///         {
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             VirtualNetworkName = exampleVirtualNetwork.Name,
    ///             AddressPrefixes = 
    ///             {
    ///                 "10.0.2.0/24",
    ///             },
    ///         });
    ///         var exampleEnvironment = new Azure.AppService.Environment("exampleEnvironment", new Azure.AppService.EnvironmentArgs
    ///         {
    ///             SubnetId = ase.Id,
    ///             PricingTier = "I2",
    ///             FrontEndScaleFactor = 10,
    ///             InternalLoadBalancingMode = "Web, Publishing",
    ///             AllowedUserIpCidrs = 
    ///             {
    ///                 "11.22.33.44/32",
    ///                 "55.66.77.0/24",
    ///             },
    ///             ClusterSettings = 
    ///             {
    ///                 new Azure.AppService.Inputs.EnvironmentClusterSettingArgs
    ///                 {
    ///                     Name = "DisableTls1.0",
    ///                     Value = "1",
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// The App Service Environment can be imported using the `resource id`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import azure:appservice/environment:Environment myAppServiceEnv /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.Web/hostingEnvironments/myAppServiceEnv
    /// ```
    /// </summary>
    [AzureResourceType("azure:appservice/environment:Environment")]
    public partial class Environment : Pulumi.CustomResource
    {
        /// <summary>
        /// Allowed user added IP ranges on the ASE database. Use the addresses you want to set as the explicit egress address ranges.
        /// </summary>
        [Output("allowedUserIpCidrs")]
        public Output<ImmutableArray<string>> AllowedUserIpCidrs { get; private set; } = null!;

        /// <summary>
        /// Zero or more `cluster_setting` blocks as defined below.
        /// </summary>
        [Output("clusterSettings")]
        public Output<ImmutableArray<Outputs.EnvironmentClusterSetting>> ClusterSettings { get; private set; } = null!;

        /// <summary>
        /// Scale factor for front end instances. Possible values are between `5` and `15`. Defaults to `15`.
        /// </summary>
        [Output("frontEndScaleFactor")]
        public Output<int?> FrontEndScaleFactor { get; private set; } = null!;

        /// <summary>
        /// IP address of internal load balancer of the App Service Environment.
        /// </summary>
        [Output("internalIpAddress")]
        public Output<string> InternalIpAddress { get; private set; } = null!;

        /// <summary>
        /// Specifies which endpoints to serve internally in the Virtual Network for the App Service Environment. Possible values are `None`, `Web`, `Publishing` and combined value `"Web, Publishing"`. Defaults to `None`.
        /// </summary>
        [Output("internalLoadBalancingMode")]
        public Output<string?> InternalLoadBalancingMode { get; private set; } = null!;

        /// <summary>
        /// The location where the App Service Environment exists.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the App Service Environment. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// List of outbound IP addresses of the App Service Environment.
        /// </summary>
        [Output("outboundIpAddresses")]
        public Output<ImmutableArray<string>> OutboundIpAddresses { get; private set; } = null!;

        /// <summary>
        /// Pricing tier for the front end instances. Possible values are `I1`, `I2` and `I3`. Defaults to `I1`.
        /// </summary>
        [Output("pricingTier")]
        public Output<string?> PricingTier { get; private set; } = null!;

        /// <summary>
        /// The name of the Resource Group where the App Service Environment exists. Defaults to the Resource Group of the Subnet (specified by `subnet_id`).
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// IP address of service endpoint of the App Service Environment.
        /// </summary>
        [Output("serviceIpAddress")]
        public Output<string> ServiceIpAddress { get; private set; } = null!;

        /// <summary>
        /// The ID of the Subnet which the App Service Environment should be connected to. Changing this forces a new resource to be created.
        /// </summary>
        [Output("subnetId")]
        public Output<string> SubnetId { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource. Changing this forces a new resource to be created.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Environment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Environment(string name, EnvironmentArgs args, CustomResourceOptions? options = null)
            : base("azure:appservice/environment:Environment", name, args ?? new EnvironmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Environment(string name, Input<string> id, EnvironmentState? state = null, CustomResourceOptions? options = null)
            : base("azure:appservice/environment:Environment", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Environment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Environment Get(string name, Input<string> id, EnvironmentState? state = null, CustomResourceOptions? options = null)
        {
            return new Environment(name, id, state, options);
        }
    }

    public sealed class EnvironmentArgs : Pulumi.ResourceArgs
    {
        [Input("allowedUserIpCidrs")]
        private InputList<string>? _allowedUserIpCidrs;

        /// <summary>
        /// Allowed user added IP ranges on the ASE database. Use the addresses you want to set as the explicit egress address ranges.
        /// </summary>
        public InputList<string> AllowedUserIpCidrs
        {
            get => _allowedUserIpCidrs ?? (_allowedUserIpCidrs = new InputList<string>());
            set => _allowedUserIpCidrs = value;
        }

        [Input("clusterSettings")]
        private InputList<Inputs.EnvironmentClusterSettingArgs>? _clusterSettings;

        /// <summary>
        /// Zero or more `cluster_setting` blocks as defined below.
        /// </summary>
        public InputList<Inputs.EnvironmentClusterSettingArgs> ClusterSettings
        {
            get => _clusterSettings ?? (_clusterSettings = new InputList<Inputs.EnvironmentClusterSettingArgs>());
            set => _clusterSettings = value;
        }

        /// <summary>
        /// Scale factor for front end instances. Possible values are between `5` and `15`. Defaults to `15`.
        /// </summary>
        [Input("frontEndScaleFactor")]
        public Input<int>? FrontEndScaleFactor { get; set; }

        /// <summary>
        /// Specifies which endpoints to serve internally in the Virtual Network for the App Service Environment. Possible values are `None`, `Web`, `Publishing` and combined value `"Web, Publishing"`. Defaults to `None`.
        /// </summary>
        [Input("internalLoadBalancingMode")]
        public Input<string>? InternalLoadBalancingMode { get; set; }

        /// <summary>
        /// The name of the App Service Environment. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Pricing tier for the front end instances. Possible values are `I1`, `I2` and `I3`. Defaults to `I1`.
        /// </summary>
        [Input("pricingTier")]
        public Input<string>? PricingTier { get; set; }

        /// <summary>
        /// The name of the Resource Group where the App Service Environment exists. Defaults to the Resource Group of the Subnet (specified by `subnet_id`).
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The ID of the Subnet which the App Service Environment should be connected to. Changing this forces a new resource to be created.
        /// </summary>
        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource. Changing this forces a new resource to be created.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public EnvironmentArgs()
        {
        }
    }

    public sealed class EnvironmentState : Pulumi.ResourceArgs
    {
        [Input("allowedUserIpCidrs")]
        private InputList<string>? _allowedUserIpCidrs;

        /// <summary>
        /// Allowed user added IP ranges on the ASE database. Use the addresses you want to set as the explicit egress address ranges.
        /// </summary>
        public InputList<string> AllowedUserIpCidrs
        {
            get => _allowedUserIpCidrs ?? (_allowedUserIpCidrs = new InputList<string>());
            set => _allowedUserIpCidrs = value;
        }

        [Input("clusterSettings")]
        private InputList<Inputs.EnvironmentClusterSettingGetArgs>? _clusterSettings;

        /// <summary>
        /// Zero or more `cluster_setting` blocks as defined below.
        /// </summary>
        public InputList<Inputs.EnvironmentClusterSettingGetArgs> ClusterSettings
        {
            get => _clusterSettings ?? (_clusterSettings = new InputList<Inputs.EnvironmentClusterSettingGetArgs>());
            set => _clusterSettings = value;
        }

        /// <summary>
        /// Scale factor for front end instances. Possible values are between `5` and `15`. Defaults to `15`.
        /// </summary>
        [Input("frontEndScaleFactor")]
        public Input<int>? FrontEndScaleFactor { get; set; }

        /// <summary>
        /// IP address of internal load balancer of the App Service Environment.
        /// </summary>
        [Input("internalIpAddress")]
        public Input<string>? InternalIpAddress { get; set; }

        /// <summary>
        /// Specifies which endpoints to serve internally in the Virtual Network for the App Service Environment. Possible values are `None`, `Web`, `Publishing` and combined value `"Web, Publishing"`. Defaults to `None`.
        /// </summary>
        [Input("internalLoadBalancingMode")]
        public Input<string>? InternalLoadBalancingMode { get; set; }

        /// <summary>
        /// The location where the App Service Environment exists.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the App Service Environment. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("outboundIpAddresses")]
        private InputList<string>? _outboundIpAddresses;

        /// <summary>
        /// List of outbound IP addresses of the App Service Environment.
        /// </summary>
        public InputList<string> OutboundIpAddresses
        {
            get => _outboundIpAddresses ?? (_outboundIpAddresses = new InputList<string>());
            set => _outboundIpAddresses = value;
        }

        /// <summary>
        /// Pricing tier for the front end instances. Possible values are `I1`, `I2` and `I3`. Defaults to `I1`.
        /// </summary>
        [Input("pricingTier")]
        public Input<string>? PricingTier { get; set; }

        /// <summary>
        /// The name of the Resource Group where the App Service Environment exists. Defaults to the Resource Group of the Subnet (specified by `subnet_id`).
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// IP address of service endpoint of the App Service Environment.
        /// </summary>
        [Input("serviceIpAddress")]
        public Input<string>? ServiceIpAddress { get; set; }

        /// <summary>
        /// The ID of the Subnet which the App Service Environment should be connected to. Changing this forces a new resource to be created.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource. Changing this forces a new resource to be created.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public EnvironmentState()
        {
        }
    }
}

// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages a Web App Active Slot.
 *
 * ## Example Usage
 * ### Windows Web App
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 *
 * const exampleResourceGroup = new azure.core.ResourceGroup("exampleResourceGroup", {location: "West Europe"});
 * const exampleServicePlan = new azure.appservice.ServicePlan("exampleServicePlan", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     location: "West Europe",
 *     osType: "Windows",
 *     skuName: "P1V2",
 * });
 * const exampleWindowsWebApp = new azure.appservice.WindowsWebApp("exampleWindowsWebApp", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     location: exampleServicePlan.location,
 *     servicePlanId: exampleServicePlan.id,
 *     siteConfig: {},
 * });
 * const exampleWindowsWebAppSlot = new azure.appservice.WindowsWebAppSlot("exampleWindowsWebAppSlot", {
 *     appServiceId: exampleWindowsWebApp.name,
 *     siteConfig: {},
 * });
 * const exampleWebAppActiveSlot = new azure.appservice.WebAppActiveSlot("exampleWebAppActiveSlot", {slotId: exampleWindowsWebAppSlot.id});
 * ```
 * ### Linux Web App
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 *
 * const exampleResourceGroup = new azure.core.ResourceGroup("exampleResourceGroup", {location: "West Europe"});
 * const exampleServicePlan = new azure.appservice.ServicePlan("exampleServicePlan", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     location: "West Europe",
 *     osType: "Linux",
 *     skuName: "P1V2",
 * });
 * const exampleLinuxWebApp = new azure.appservice.LinuxWebApp("exampleLinuxWebApp", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     location: exampleServicePlan.location,
 *     servicePlanId: exampleServicePlan.id,
 *     siteConfig: {},
 * });
 * const exampleLinuxWebAppSlot = new azure.appservice.LinuxWebAppSlot("exampleLinuxWebAppSlot", {
 *     appServiceName: exampleLinuxWebApp.name,
 *     resourceGroupName: exampleResourceGroup.name,
 *     location: exampleServicePlan.location,
 *     servicePlanId: exampleServicePlan.id,
 *     siteConfig: {},
 * });
 * const exampleWebAppActiveSlot = new azure.appservice.WebAppActiveSlot("exampleWebAppActiveSlot", {slotId: exampleLinuxWebAppSlot.id});
 * ```
 *
 * ## Import
 *
 * a Web App Active Slot can be imported using the `resource id`, e.g.
 *
 * ```sh
 *  $ pulumi import azure:appservice/webAppActiveSlot:WebAppActiveSlot example "/subscriptions/12345678-1234-9876-4563-123456789012/resourceGroups/resGroup1/providers/Microsoft.Web/sites/site1"
 * ```
 */
export class WebAppActiveSlot extends pulumi.CustomResource {
    /**
     * Get an existing WebAppActiveSlot resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: WebAppActiveSlotState, opts?: pulumi.CustomResourceOptions): WebAppActiveSlot {
        return new WebAppActiveSlot(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:appservice/webAppActiveSlot:WebAppActiveSlot';

    /**
     * Returns true if the given object is an instance of WebAppActiveSlot.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebAppActiveSlot {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebAppActiveSlot.__pulumiType;
    }

    /**
     * The timestamp of the last successful swap with `Production`.
     */
    public /*out*/ readonly lastSuccessfulSwap!: pulumi.Output<string>;
    /**
     * The swap action should overwrite the Production slot's network configuration with the configuration from this slot. Defaults to `true`. Changing this forces a new resource to be created.
     */
    public readonly overwriteNetworkConfig!: pulumi.Output<boolean | undefined>;
    /**
     * The ID of the Slot to swap with `Production`.
     */
    public readonly slotId!: pulumi.Output<string>;

    /**
     * Create a WebAppActiveSlot resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebAppActiveSlotArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: WebAppActiveSlotArgs | WebAppActiveSlotState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as WebAppActiveSlotState | undefined;
            resourceInputs["lastSuccessfulSwap"] = state ? state.lastSuccessfulSwap : undefined;
            resourceInputs["overwriteNetworkConfig"] = state ? state.overwriteNetworkConfig : undefined;
            resourceInputs["slotId"] = state ? state.slotId : undefined;
        } else {
            const args = argsOrState as WebAppActiveSlotArgs | undefined;
            if ((!args || args.slotId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'slotId'");
            }
            resourceInputs["overwriteNetworkConfig"] = args ? args.overwriteNetworkConfig : undefined;
            resourceInputs["slotId"] = args ? args.slotId : undefined;
            resourceInputs["lastSuccessfulSwap"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(WebAppActiveSlot.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering WebAppActiveSlot resources.
 */
export interface WebAppActiveSlotState {
    /**
     * The timestamp of the last successful swap with `Production`.
     */
    lastSuccessfulSwap?: pulumi.Input<string>;
    /**
     * The swap action should overwrite the Production slot's network configuration with the configuration from this slot. Defaults to `true`. Changing this forces a new resource to be created.
     */
    overwriteNetworkConfig?: pulumi.Input<boolean>;
    /**
     * The ID of the Slot to swap with `Production`.
     */
    slotId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a WebAppActiveSlot resource.
 */
export interface WebAppActiveSlotArgs {
    /**
     * The swap action should overwrite the Production slot's network configuration with the configuration from this slot. Defaults to `true`. Changing this forces a new resource to be created.
     */
    overwriteNetworkConfig?: pulumi.Input<boolean>;
    /**
     * The ID of the Slot to swap with `Production`.
     */
    slotId: pulumi.Input<string>;
}

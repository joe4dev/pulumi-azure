// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages a Container within an Azure Storage Account.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 *
 * const exampleResourceGroup = new azure.core.ResourceGroup("exampleResourceGroup", {location: "West Europe"});
 * const exampleAccount = new azure.storage.Account("exampleAccount", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     location: exampleResourceGroup.location,
 *     accountTier: "Standard",
 *     accountReplicationType: "LRS",
 *     tags: {
 *         environment: "staging",
 *     },
 * });
 * const exampleContainer = new azure.storage.Container("exampleContainer", {
 *     storageAccountName: exampleAccount.name,
 *     containerAccessType: "private",
 * });
 * ```
 *
 * ## Import
 *
 * Storage Containers can be imported using the `resource id`, e.g.
 *
 * ```sh
 *  $ pulumi import azure:storage/container:Container container1 https://example.blob.core.windows.net/container
 * ```
 */
export class Container extends pulumi.CustomResource {
    /**
     * Get an existing Container resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ContainerState, opts?: pulumi.CustomResourceOptions): Container {
        return new Container(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:storage/container:Container';

    /**
     * Returns true if the given object is an instance of Container.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Container {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Container.__pulumiType;
    }

    /**
     * The Access Level configured for this Container. Possible values are `blob`, `container` or `private`. Defaults to `private`.
     */
    public readonly containerAccessType!: pulumi.Output<string | undefined>;
    /**
     * Is there an Immutability Policy configured on this Storage Container?
     */
    public /*out*/ readonly hasImmutabilityPolicy!: pulumi.Output<boolean>;
    /**
     * Is there a Legal Hold configured on this Storage Container?
     */
    public /*out*/ readonly hasLegalHold!: pulumi.Output<boolean>;
    /**
     * A mapping of MetaData for this Container. All metadata keys should be lowercase.
     */
    public readonly metadata!: pulumi.Output<{[key: string]: string}>;
    /**
     * The name of the Container which should be created within the Storage Account.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The Resource Manager ID of this Storage Container.
     */
    public /*out*/ readonly resourceManagerId!: pulumi.Output<string>;
    /**
     * The name of the Storage Account where the Container should be created.
     */
    public readonly storageAccountName!: pulumi.Output<string>;

    /**
     * Create a Container resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ContainerArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ContainerArgs | ContainerState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ContainerState | undefined;
            resourceInputs["containerAccessType"] = state ? state.containerAccessType : undefined;
            resourceInputs["hasImmutabilityPolicy"] = state ? state.hasImmutabilityPolicy : undefined;
            resourceInputs["hasLegalHold"] = state ? state.hasLegalHold : undefined;
            resourceInputs["metadata"] = state ? state.metadata : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["resourceManagerId"] = state ? state.resourceManagerId : undefined;
            resourceInputs["storageAccountName"] = state ? state.storageAccountName : undefined;
        } else {
            const args = argsOrState as ContainerArgs | undefined;
            if ((!args || args.storageAccountName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'storageAccountName'");
            }
            resourceInputs["containerAccessType"] = args ? args.containerAccessType : undefined;
            resourceInputs["metadata"] = args ? args.metadata : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["storageAccountName"] = args ? args.storageAccountName : undefined;
            resourceInputs["hasImmutabilityPolicy"] = undefined /*out*/;
            resourceInputs["hasLegalHold"] = undefined /*out*/;
            resourceInputs["resourceManagerId"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Container.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Container resources.
 */
export interface ContainerState {
    /**
     * The Access Level configured for this Container. Possible values are `blob`, `container` or `private`. Defaults to `private`.
     */
    containerAccessType?: pulumi.Input<string>;
    /**
     * Is there an Immutability Policy configured on this Storage Container?
     */
    hasImmutabilityPolicy?: pulumi.Input<boolean>;
    /**
     * Is there a Legal Hold configured on this Storage Container?
     */
    hasLegalHold?: pulumi.Input<boolean>;
    /**
     * A mapping of MetaData for this Container. All metadata keys should be lowercase.
     */
    metadata?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the Container which should be created within the Storage Account.
     */
    name?: pulumi.Input<string>;
    /**
     * The Resource Manager ID of this Storage Container.
     */
    resourceManagerId?: pulumi.Input<string>;
    /**
     * The name of the Storage Account where the Container should be created.
     */
    storageAccountName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Container resource.
 */
export interface ContainerArgs {
    /**
     * The Access Level configured for this Container. Possible values are `blob`, `container` or `private`. Defaults to `private`.
     */
    containerAccessType?: pulumi.Input<string>;
    /**
     * A mapping of MetaData for this Container. All metadata keys should be lowercase.
     */
    metadata?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the Container which should be created within the Storage Account.
     */
    name?: pulumi.Input<string>;
    /**
     * The name of the Storage Account where the Container should be created.
     */
    storageAccountName: pulumi.Input<string>;
}

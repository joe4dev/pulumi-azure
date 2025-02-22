// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Manages an HTTP Action within a Logic App Workflow
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 *
 * const exampleResourceGroup = new azure.core.ResourceGroup("exampleResourceGroup", {location: "West Europe"});
 * const exampleWorkflow = new azure.logicapps.Workflow("exampleWorkflow", {
 *     location: exampleResourceGroup.location,
 *     resourceGroupName: exampleResourceGroup.name,
 * });
 * const exampleActionHttp = new azure.logicapps.ActionHttp("exampleActionHttp", {
 *     logicAppId: exampleWorkflow.id,
 *     method: "GET",
 *     uri: "http://example.com/some-webhook",
 * });
 * ```
 *
 * ## Import
 *
 * Logic App HTTP Actions can be imported using the `resource id`, e.g.
 *
 * ```sh
 *  $ pulumi import azure:logicapps/actionHttp:ActionHttp webhook1 /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/mygroup1/providers/Microsoft.Logic/workflows/workflow1/actions/webhook1
 * ```
 */
export class ActionHttp extends pulumi.CustomResource {
    /**
     * Get an existing ActionHttp resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ActionHttpState, opts?: pulumi.CustomResourceOptions): ActionHttp {
        return new ActionHttp(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:logicapps/actionHttp:ActionHttp';

    /**
     * Returns true if the given object is an instance of ActionHttp.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ActionHttp {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ActionHttp.__pulumiType;
    }

    /**
     * Specifies the HTTP Body that should be sent to the `uri` when this HTTP Action is triggered.
     */
    public readonly body!: pulumi.Output<string | undefined>;
    /**
     * Specifies a Map of Key-Value Pairs that should be sent to the `uri` when this HTTP Action is triggered.
     */
    public readonly headers!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Specifies the ID of the Logic App Workflow. Changing this forces a new resource to be created.
     */
    public readonly logicAppId!: pulumi.Output<string>;
    /**
     * Specifies the HTTP Method which should be used for this HTTP Action. Possible values include `DELETE`, `GET`, `PATCH`, `POST` and `PUT`.
     */
    public readonly method!: pulumi.Output<string>;
    /**
     * Specifies the name of the HTTP Action to be created within the Logic App Workflow. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Specifies the place of the HTTP Action in the Logic App Workflow. If not specified, the HTTP Action is right after the Trigger. A `runAfter` block is as defined below.
     */
    public readonly runAfters!: pulumi.Output<outputs.logicapps.ActionHttpRunAfter[] | undefined>;
    /**
     * Specifies the URI which will be called when this HTTP Action is triggered.
     */
    public readonly uri!: pulumi.Output<string>;

    /**
     * Create a ActionHttp resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ActionHttpArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ActionHttpArgs | ActionHttpState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ActionHttpState | undefined;
            resourceInputs["body"] = state ? state.body : undefined;
            resourceInputs["headers"] = state ? state.headers : undefined;
            resourceInputs["logicAppId"] = state ? state.logicAppId : undefined;
            resourceInputs["method"] = state ? state.method : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["runAfters"] = state ? state.runAfters : undefined;
            resourceInputs["uri"] = state ? state.uri : undefined;
        } else {
            const args = argsOrState as ActionHttpArgs | undefined;
            if ((!args || args.logicAppId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'logicAppId'");
            }
            if ((!args || args.method === undefined) && !opts.urn) {
                throw new Error("Missing required property 'method'");
            }
            if ((!args || args.uri === undefined) && !opts.urn) {
                throw new Error("Missing required property 'uri'");
            }
            resourceInputs["body"] = args ? args.body : undefined;
            resourceInputs["headers"] = args ? args.headers : undefined;
            resourceInputs["logicAppId"] = args ? args.logicAppId : undefined;
            resourceInputs["method"] = args ? args.method : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["runAfters"] = args ? args.runAfters : undefined;
            resourceInputs["uri"] = args ? args.uri : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ActionHttp.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ActionHttp resources.
 */
export interface ActionHttpState {
    /**
     * Specifies the HTTP Body that should be sent to the `uri` when this HTTP Action is triggered.
     */
    body?: pulumi.Input<string>;
    /**
     * Specifies a Map of Key-Value Pairs that should be sent to the `uri` when this HTTP Action is triggered.
     */
    headers?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Specifies the ID of the Logic App Workflow. Changing this forces a new resource to be created.
     */
    logicAppId?: pulumi.Input<string>;
    /**
     * Specifies the HTTP Method which should be used for this HTTP Action. Possible values include `DELETE`, `GET`, `PATCH`, `POST` and `PUT`.
     */
    method?: pulumi.Input<string>;
    /**
     * Specifies the name of the HTTP Action to be created within the Logic App Workflow. Changing this forces a new resource to be created.
     */
    name?: pulumi.Input<string>;
    /**
     * Specifies the place of the HTTP Action in the Logic App Workflow. If not specified, the HTTP Action is right after the Trigger. A `runAfter` block is as defined below.
     */
    runAfters?: pulumi.Input<pulumi.Input<inputs.logicapps.ActionHttpRunAfter>[]>;
    /**
     * Specifies the URI which will be called when this HTTP Action is triggered.
     */
    uri?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ActionHttp resource.
 */
export interface ActionHttpArgs {
    /**
     * Specifies the HTTP Body that should be sent to the `uri` when this HTTP Action is triggered.
     */
    body?: pulumi.Input<string>;
    /**
     * Specifies a Map of Key-Value Pairs that should be sent to the `uri` when this HTTP Action is triggered.
     */
    headers?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Specifies the ID of the Logic App Workflow. Changing this forces a new resource to be created.
     */
    logicAppId: pulumi.Input<string>;
    /**
     * Specifies the HTTP Method which should be used for this HTTP Action. Possible values include `DELETE`, `GET`, `PATCH`, `POST` and `PUT`.
     */
    method: pulumi.Input<string>;
    /**
     * Specifies the name of the HTTP Action to be created within the Logic App Workflow. Changing this forces a new resource to be created.
     */
    name?: pulumi.Input<string>;
    /**
     * Specifies the place of the HTTP Action in the Logic App Workflow. If not specified, the HTTP Action is right after the Trigger. A `runAfter` block is as defined below.
     */
    runAfters?: pulumi.Input<pulumi.Input<inputs.logicapps.ActionHttpRunAfter>[]>;
    /**
     * Specifies the URI which will be called when this HTTP Action is triggered.
     */
    uri: pulumi.Input<string>;
}

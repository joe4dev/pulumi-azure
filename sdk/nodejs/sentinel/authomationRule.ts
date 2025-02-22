// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Manages a Sentinel Automation Rule.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 *
 * const exampleResourceGroup = new azure.core.ResourceGroup("exampleResourceGroup", {location: "west europe"});
 * const exampleAnalyticsWorkspace = new azure.operationalinsights.AnalyticsWorkspace("exampleAnalyticsWorkspace", {
 *     location: exampleResourceGroup.location,
 *     resourceGroupName: exampleResourceGroup.name,
 *     sku: "pergb2018",
 * });
 * const sentinel = new azure.operationalinsights.AnalyticsSolution("sentinel", {
 *     solutionName: "SecurityInsights",
 *     location: exampleResourceGroup.location,
 *     resourceGroupName: exampleResourceGroup.name,
 *     workspaceResourceId: exampleAnalyticsWorkspace.id,
 *     workspaceName: exampleAnalyticsWorkspace.name,
 *     plan: {
 *         publisher: "Microsoft",
 *         product: "OMSGallery/SecurityInsights",
 *     },
 * });
 * const exampleAutomationRule = new azure.sentinel.AutomationRule("exampleAutomationRule", {
 *     logAnalyticsWorkspaceId: sentinel.workspaceResourceId,
 *     displayName: "automation_rule1",
 *     order: 1,
 *     actionIncidents: [{
 *         order: 1,
 *         status: "Active",
 *     }],
 * });
 * ```
 *
 * ## Import
 *
 * Sentinel Automation Rules can be imported using the `resource id`, e.g.
 *
 * ```sh
 *  $ pulumi import azure:sentinel/authomationRule:AuthomationRule example /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/group1/providers/Microsoft.OperationalInsights/workspaces/workspace1/providers/Microsoft.SecurityInsights/AutomationRules/rule1
 * ```
 *
 * @deprecated azure.sentinel.AuthomationRule has been deprecated in favor of azure.sentinel.AutomationRule
 */
export class AuthomationRule extends pulumi.CustomResource {
    /**
     * Get an existing AuthomationRule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AuthomationRuleState, opts?: pulumi.CustomResourceOptions): AuthomationRule {
        pulumi.log.warn("AuthomationRule is deprecated: azure.sentinel.AuthomationRule has been deprecated in favor of azure.sentinel.AutomationRule")
        return new AuthomationRule(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:sentinel/authomationRule:AuthomationRule';

    /**
     * Returns true if the given object is an instance of AuthomationRule.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AuthomationRule {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AuthomationRule.__pulumiType;
    }

    /**
     * One or more `actionIncident` blocks as defined below.
     */
    public readonly actionIncidents!: pulumi.Output<outputs.sentinel.AuthomationRuleActionIncident[] | undefined>;
    /**
     * One or more `actionPlaybook` blocks as defined below.
     */
    public readonly actionPlaybooks!: pulumi.Output<outputs.sentinel.AuthomationRuleActionPlaybook[] | undefined>;
    /**
     * One or more `condition` blocks as defined below.
     */
    public readonly conditions!: pulumi.Output<outputs.sentinel.AuthomationRuleCondition[] | undefined>;
    /**
     * The display name which should be used for this Sentinel Automation Rule.
     */
    public readonly displayName!: pulumi.Output<string>;
    /**
     * Whether this Sentinel Automation Rule is enabled? Defaults to `true`.
     */
    public readonly enabled!: pulumi.Output<boolean | undefined>;
    /**
     * The time in RFC3339 format of kind `UTC` that determines when this Automation Rule should expire and be disabled.
     */
    public readonly expiration!: pulumi.Output<string | undefined>;
    /**
     * The ID of the Log Analytics Workspace where this Sentinel applies to. Changing this forces a new Sentinel Automation Rule to be created.
     */
    public readonly logAnalyticsWorkspaceId!: pulumi.Output<string>;
    /**
     * The UUID which should be used for this Sentinel Automation Rule. Changing this forces a new Sentinel Automation Rule to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The order of this Sentinel Automation Rule. Possible values varies between `1` and `1000`.
     */
    public readonly order!: pulumi.Output<number>;

    /**
     * Create a AuthomationRule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated azure.sentinel.AuthomationRule has been deprecated in favor of azure.sentinel.AutomationRule */
    constructor(name: string, args: AuthomationRuleArgs, opts?: pulumi.CustomResourceOptions)
    /** @deprecated azure.sentinel.AuthomationRule has been deprecated in favor of azure.sentinel.AutomationRule */
    constructor(name: string, argsOrState?: AuthomationRuleArgs | AuthomationRuleState, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("AuthomationRule is deprecated: azure.sentinel.AuthomationRule has been deprecated in favor of azure.sentinel.AutomationRule")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AuthomationRuleState | undefined;
            resourceInputs["actionIncidents"] = state ? state.actionIncidents : undefined;
            resourceInputs["actionPlaybooks"] = state ? state.actionPlaybooks : undefined;
            resourceInputs["conditions"] = state ? state.conditions : undefined;
            resourceInputs["displayName"] = state ? state.displayName : undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["expiration"] = state ? state.expiration : undefined;
            resourceInputs["logAnalyticsWorkspaceId"] = state ? state.logAnalyticsWorkspaceId : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["order"] = state ? state.order : undefined;
        } else {
            const args = argsOrState as AuthomationRuleArgs | undefined;
            if ((!args || args.displayName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'displayName'");
            }
            if ((!args || args.logAnalyticsWorkspaceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'logAnalyticsWorkspaceId'");
            }
            if ((!args || args.order === undefined) && !opts.urn) {
                throw new Error("Missing required property 'order'");
            }
            resourceInputs["actionIncidents"] = args ? args.actionIncidents : undefined;
            resourceInputs["actionPlaybooks"] = args ? args.actionPlaybooks : undefined;
            resourceInputs["conditions"] = args ? args.conditions : undefined;
            resourceInputs["displayName"] = args ? args.displayName : undefined;
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["expiration"] = args ? args.expiration : undefined;
            resourceInputs["logAnalyticsWorkspaceId"] = args ? args.logAnalyticsWorkspaceId : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["order"] = args ? args.order : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(AuthomationRule.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AuthomationRule resources.
 */
export interface AuthomationRuleState {
    /**
     * One or more `actionIncident` blocks as defined below.
     */
    actionIncidents?: pulumi.Input<pulumi.Input<inputs.sentinel.AuthomationRuleActionIncident>[]>;
    /**
     * One or more `actionPlaybook` blocks as defined below.
     */
    actionPlaybooks?: pulumi.Input<pulumi.Input<inputs.sentinel.AuthomationRuleActionPlaybook>[]>;
    /**
     * One or more `condition` blocks as defined below.
     */
    conditions?: pulumi.Input<pulumi.Input<inputs.sentinel.AuthomationRuleCondition>[]>;
    /**
     * The display name which should be used for this Sentinel Automation Rule.
     */
    displayName?: pulumi.Input<string>;
    /**
     * Whether this Sentinel Automation Rule is enabled? Defaults to `true`.
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * The time in RFC3339 format of kind `UTC` that determines when this Automation Rule should expire and be disabled.
     */
    expiration?: pulumi.Input<string>;
    /**
     * The ID of the Log Analytics Workspace where this Sentinel applies to. Changing this forces a new Sentinel Automation Rule to be created.
     */
    logAnalyticsWorkspaceId?: pulumi.Input<string>;
    /**
     * The UUID which should be used for this Sentinel Automation Rule. Changing this forces a new Sentinel Automation Rule to be created.
     */
    name?: pulumi.Input<string>;
    /**
     * The order of this Sentinel Automation Rule. Possible values varies between `1` and `1000`.
     */
    order?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a AuthomationRule resource.
 */
export interface AuthomationRuleArgs {
    /**
     * One or more `actionIncident` blocks as defined below.
     */
    actionIncidents?: pulumi.Input<pulumi.Input<inputs.sentinel.AuthomationRuleActionIncident>[]>;
    /**
     * One or more `actionPlaybook` blocks as defined below.
     */
    actionPlaybooks?: pulumi.Input<pulumi.Input<inputs.sentinel.AuthomationRuleActionPlaybook>[]>;
    /**
     * One or more `condition` blocks as defined below.
     */
    conditions?: pulumi.Input<pulumi.Input<inputs.sentinel.AuthomationRuleCondition>[]>;
    /**
     * The display name which should be used for this Sentinel Automation Rule.
     */
    displayName: pulumi.Input<string>;
    /**
     * Whether this Sentinel Automation Rule is enabled? Defaults to `true`.
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * The time in RFC3339 format of kind `UTC` that determines when this Automation Rule should expire and be disabled.
     */
    expiration?: pulumi.Input<string>;
    /**
     * The ID of the Log Analytics Workspace where this Sentinel applies to. Changing this forces a new Sentinel Automation Rule to be created.
     */
    logAnalyticsWorkspaceId: pulumi.Input<string>;
    /**
     * The UUID which should be used for this Sentinel Automation Rule. Changing this forces a new Sentinel Automation Rule to be created.
     */
    name?: pulumi.Input<string>;
    /**
     * The order of this Sentinel Automation Rule. Possible values varies between `1` and `1000`.
     */
    order: pulumi.Input<number>;
}

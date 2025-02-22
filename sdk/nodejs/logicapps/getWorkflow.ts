// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing Logic App Workflow.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 *
 * const example = azure.logicapps.getWorkflow({
 *     name: "workflow1",
 *     resourceGroupName: "my-resource-group",
 * });
 * export const accessEndpoint = example.then(example => example.accessEndpoint);
 * ```
 */
export function getWorkflow(args: GetWorkflowArgs, opts?: pulumi.InvokeOptions): Promise<GetWorkflowResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure:logicapps/getWorkflow:getWorkflow", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

/**
 * A collection of arguments for invoking getWorkflow.
 */
export interface GetWorkflowArgs {
    /**
     * The name of the Logic App Workflow.
     */
    name: string;
    /**
     * The name of the Resource Group in which the Logic App Workflow exists.
     */
    resourceGroupName: string;
}

/**
 * A collection of values returned by getWorkflow.
 */
export interface GetWorkflowResult {
    /**
     * The Access Endpoint for the Logic App Workflow
     */
    readonly accessEndpoint: string;
    /**
     * The list of access endpoint ip addresses of connector.
     */
    readonly connectorEndpointIpAddresses: string[];
    /**
     * The list of outgoing ip addresses of connector.
     */
    readonly connectorOutboundIpAddresses: string[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * An `identity` block as defined below.
     */
    readonly identities: outputs.logicapps.GetWorkflowIdentity[];
    /**
     * The Azure location where the Logic App Workflow exists.
     */
    readonly location: string;
    /**
     * The ID of the integration account linked by this Logic App Workflow.
     */
    readonly logicAppIntegrationAccountId: string;
    readonly name: string;
    /**
     * A map of Key-Value pairs.
     */
    readonly parameters: {[key: string]: string};
    readonly resourceGroupName: string;
    /**
     * A mapping of tags assigned to the resource.
     */
    readonly tags: {[key: string]: string};
    /**
     * The list of access endpoint ip addresses of workflow.
     */
    readonly workflowEndpointIpAddresses: string[];
    /**
     * The list of outgoing ip addresses of workflow.
     */
    readonly workflowOutboundIpAddresses: string[];
    /**
     * The Schema used for this Logic App Workflow.
     */
    readonly workflowSchema: string;
    /**
     * The version of the Schema used for this Logic App Workflow. Defaults to `1.0.0.0`.
     */
    readonly workflowVersion: string;
}

export function getWorkflowOutput(args: GetWorkflowOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetWorkflowResult> {
    return pulumi.output(args).apply(a => getWorkflow(a, opts))
}

/**
 * A collection of arguments for invoking getWorkflow.
 */
export interface GetWorkflowOutputArgs {
    /**
     * The name of the Logic App Workflow.
     */
    name: pulumi.Input<string>;
    /**
     * The name of the Resource Group in which the Logic App Workflow exists.
     */
    resourceGroupName: pulumi.Input<string>;
}

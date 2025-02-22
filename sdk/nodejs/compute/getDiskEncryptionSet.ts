// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing Disk Encryption Set.
 */
export function getDiskEncryptionSet(args: GetDiskEncryptionSetArgs, opts?: pulumi.InvokeOptions): Promise<GetDiskEncryptionSetResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure:compute/getDiskEncryptionSet:getDiskEncryptionSet", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

/**
 * A collection of arguments for invoking getDiskEncryptionSet.
 */
export interface GetDiskEncryptionSetArgs {
    /**
     * The name of the Disk Encryption Set exists.
     */
    name: string;
    /**
     * The name of the Resource Group where the Disk Encryption Set exists.
     */
    resourceGroupName: string;
}

/**
 * A collection of values returned by getDiskEncryptionSet.
 */
export interface GetDiskEncryptionSetResult {
    /**
     * Is the Azure Disk Encryption Set Key automatically rotated to latest version?
     */
    readonly autoKeyRotationEnabled: boolean;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * The location where the Disk Encryption Set exists.
     */
    readonly location: string;
    readonly name: string;
    readonly resourceGroupName: string;
    /**
     * A mapping of tags assigned to the Disk Encryption Set.
     */
    readonly tags: {[key: string]: string};
}

export function getDiskEncryptionSetOutput(args: GetDiskEncryptionSetOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDiskEncryptionSetResult> {
    return pulumi.output(args).apply(a => getDiskEncryptionSet(a, opts))
}

/**
 * A collection of arguments for invoking getDiskEncryptionSet.
 */
export interface GetDiskEncryptionSetOutputArgs {
    /**
     * The name of the Disk Encryption Set exists.
     */
    name: pulumi.Input<string>;
    /**
     * The name of the Resource Group where the Disk Encryption Set exists.
     */
    resourceGroupName: pulumi.Input<string>;
}

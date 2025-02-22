// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./getService";
export * from "./replicaSet";
export * from "./service";

// Import resources to register:
import { ReplicaSet } from "./replicaSet";
import { Service } from "./service";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure:domainservices/replicaSet:ReplicaSet":
                return new ReplicaSet(name, <any>undefined, { urn })
            case "azure:domainservices/service:Service":
                return new Service(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure", "domainservices/replicaSet", _module)
pulumi.runtime.registerResourceModule("azure", "domainservices/service", _module)

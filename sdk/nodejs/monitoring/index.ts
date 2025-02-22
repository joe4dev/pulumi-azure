// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./aadDiagnosticSetting";
export * from "./actionGroup";
export * from "./actionRuleActionGroup";
export * from "./actionRuleSuppression";
export * from "./activityLogAlert";
export * from "./autoscaleSetting";
export * from "./diagnosticSetting";
export * from "./getActionGroup";
export * from "./getDiagnosticCategories";
export * from "./getLogProfile";
export * from "./getScheduledQueryRulesAlert";
export * from "./getScheduledQueryRulesLog";
export * from "./logProfile";
export * from "./logzMonitor";
export * from "./logzTagRule";
export * from "./metricAlert";
export * from "./privateLinkScope";
export * from "./privateLinkScopedService";
export * from "./scheduledQueryRulesAlert";
export * from "./scheduledQueryRulesLog";
export * from "./smartDetectorAlertRule";

// Import resources to register:
import { AadDiagnosticSetting } from "./aadDiagnosticSetting";
import { ActionGroup } from "./actionGroup";
import { ActionRuleActionGroup } from "./actionRuleActionGroup";
import { ActionRuleSuppression } from "./actionRuleSuppression";
import { ActivityLogAlert } from "./activityLogAlert";
import { AutoscaleSetting } from "./autoscaleSetting";
import { DiagnosticSetting } from "./diagnosticSetting";
import { LogProfile } from "./logProfile";
import { LogzMonitor } from "./logzMonitor";
import { LogzTagRule } from "./logzTagRule";
import { MetricAlert } from "./metricAlert";
import { PrivateLinkScope } from "./privateLinkScope";
import { PrivateLinkScopedService } from "./privateLinkScopedService";
import { ScheduledQueryRulesAlert } from "./scheduledQueryRulesAlert";
import { ScheduledQueryRulesLog } from "./scheduledQueryRulesLog";
import { SmartDetectorAlertRule } from "./smartDetectorAlertRule";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure:monitoring/aadDiagnosticSetting:AadDiagnosticSetting":
                return new AadDiagnosticSetting(name, <any>undefined, { urn })
            case "azure:monitoring/actionGroup:ActionGroup":
                return new ActionGroup(name, <any>undefined, { urn })
            case "azure:monitoring/actionRuleActionGroup:ActionRuleActionGroup":
                return new ActionRuleActionGroup(name, <any>undefined, { urn })
            case "azure:monitoring/actionRuleSuppression:ActionRuleSuppression":
                return new ActionRuleSuppression(name, <any>undefined, { urn })
            case "azure:monitoring/activityLogAlert:ActivityLogAlert":
                return new ActivityLogAlert(name, <any>undefined, { urn })
            case "azure:monitoring/autoscaleSetting:AutoscaleSetting":
                return new AutoscaleSetting(name, <any>undefined, { urn })
            case "azure:monitoring/diagnosticSetting:DiagnosticSetting":
                return new DiagnosticSetting(name, <any>undefined, { urn })
            case "azure:monitoring/logProfile:LogProfile":
                return new LogProfile(name, <any>undefined, { urn })
            case "azure:monitoring/logzMonitor:LogzMonitor":
                return new LogzMonitor(name, <any>undefined, { urn })
            case "azure:monitoring/logzTagRule:LogzTagRule":
                return new LogzTagRule(name, <any>undefined, { urn })
            case "azure:monitoring/metricAlert:MetricAlert":
                return new MetricAlert(name, <any>undefined, { urn })
            case "azure:monitoring/privateLinkScope:PrivateLinkScope":
                return new PrivateLinkScope(name, <any>undefined, { urn })
            case "azure:monitoring/privateLinkScopedService:PrivateLinkScopedService":
                return new PrivateLinkScopedService(name, <any>undefined, { urn })
            case "azure:monitoring/scheduledQueryRulesAlert:ScheduledQueryRulesAlert":
                return new ScheduledQueryRulesAlert(name, <any>undefined, { urn })
            case "azure:monitoring/scheduledQueryRulesLog:ScheduledQueryRulesLog":
                return new ScheduledQueryRulesLog(name, <any>undefined, { urn })
            case "azure:monitoring/smartDetectorAlertRule:SmartDetectorAlertRule":
                return new SmartDetectorAlertRule(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure", "monitoring/aadDiagnosticSetting", _module)
pulumi.runtime.registerResourceModule("azure", "monitoring/actionGroup", _module)
pulumi.runtime.registerResourceModule("azure", "monitoring/actionRuleActionGroup", _module)
pulumi.runtime.registerResourceModule("azure", "monitoring/actionRuleSuppression", _module)
pulumi.runtime.registerResourceModule("azure", "monitoring/activityLogAlert", _module)
pulumi.runtime.registerResourceModule("azure", "monitoring/autoscaleSetting", _module)
pulumi.runtime.registerResourceModule("azure", "monitoring/diagnosticSetting", _module)
pulumi.runtime.registerResourceModule("azure", "monitoring/logProfile", _module)
pulumi.runtime.registerResourceModule("azure", "monitoring/logzMonitor", _module)
pulumi.runtime.registerResourceModule("azure", "monitoring/logzTagRule", _module)
pulumi.runtime.registerResourceModule("azure", "monitoring/metricAlert", _module)
pulumi.runtime.registerResourceModule("azure", "monitoring/privateLinkScope", _module)
pulumi.runtime.registerResourceModule("azure", "monitoring/privateLinkScopedService", _module)
pulumi.runtime.registerResourceModule("azure", "monitoring/scheduledQueryRulesAlert", _module)
pulumi.runtime.registerResourceModule("azure", "monitoring/scheduledQueryRulesLog", _module)
pulumi.runtime.registerResourceModule("azure", "monitoring/smartDetectorAlertRule", _module)

// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package appservice

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Manages a Linux Web App Slot.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-azure/sdk/v5/go/azure/appservice"
// 	"github.com/pulumi/pulumi-azure/sdk/v5/go/azure/core"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		exampleResourceGroup, err := core.NewResourceGroup(ctx, "exampleResourceGroup", &core.ResourceGroupArgs{
// 			Location: pulumi.String("West Europe"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		exampleServicePlan, err := appservice.NewServicePlan(ctx, "exampleServicePlan", &appservice.ServicePlanArgs{
// 			ResourceGroupName: exampleResourceGroup.Name,
// 			Location:          pulumi.String("West Europe"),
// 			OsType:            pulumi.String("Linux"),
// 			SkuName:           pulumi.String("P1V2"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		exampleLinuxWebApp, err := appservice.NewLinuxWebApp(ctx, "exampleLinuxWebApp", &appservice.LinuxWebAppArgs{
// 			ResourceGroupName: exampleResourceGroup.Name,
// 			Location:          exampleServicePlan.Location,
// 			ServicePlanId:     exampleServicePlan.ID(),
// 			SiteConfig:        nil,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = appservice.NewLinuxWebAppSlot(ctx, "exampleLinuxWebAppSlot", &appservice.LinuxWebAppSlotArgs{
// 			AppServiceId: exampleLinuxWebApp.ID(),
// 			SiteConfig:   nil,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// ## Import
//
// Linux Web Apps can be imported using the `resource id`, e.g.
//
// ```sh
//  $ pulumi import azure:appservice/linuxWebAppSlot:LinuxWebAppSlot example /subscriptions/12345678-1234-9876-4563-123456789012/resourceGroups/resGroup1/providers/Microsoft.Web/sites/site1
// ```
type LinuxWebAppSlot struct {
	pulumi.CustomResourceState

	// A `appMetadata` block as defined below.
	AppMetadata pulumi.StringMapOutput `pulumi:"appMetadata"`
	// The ID of the Linux Web App this Deployment Slot will be part of. Changing this forces a new Linux Web App to be created.
	AppServiceId pulumi.StringOutput `pulumi:"appServiceId"`
	// A map of key-value pairs of App Settings.
	AppSettings pulumi.StringMapOutput `pulumi:"appSettings"`
	// A `authSettings` block as defined below.
	AuthSettings LinuxWebAppSlotAuthSettingsOutput `pulumi:"authSettings"`
	// A `backup` block as defined below.
	Backup LinuxWebAppSlotBackupPtrOutput `pulumi:"backup"`
	// Should Client Affinity be enabled?
	ClientAffinityEnabled pulumi.BoolPtrOutput `pulumi:"clientAffinityEnabled"`
	// Should Client Certificates be enabled?
	ClientCertificateEnabled pulumi.BoolPtrOutput `pulumi:"clientCertificateEnabled"`
	// The Client Certificate mode. Possible values include `Optional` and `Required`. This property has no effect when `clientCertEnabled` is `false`
	ClientCertificateMode pulumi.StringPtrOutput `pulumi:"clientCertificateMode"`
	// One or more `connectionString` blocks as defined below.
	ConnectionStrings LinuxWebAppSlotConnectionStringArrayOutput `pulumi:"connectionStrings"`
	// The identifier used by App Service to perform domain ownership verification via DNS TXT record.
	CustomDomainVerificationId pulumi.StringOutput `pulumi:"customDomainVerificationId"`
	// The default hostname of the Linux Web App.
	DefaultHostname pulumi.StringOutput `pulumi:"defaultHostname"`
	// Should the Linux Web App be enabled? Defaults to `true`.
	Enabled pulumi.BoolPtrOutput `pulumi:"enabled"`
	// Should the Linux Web App require HTTPS connections.
	HttpsOnly pulumi.BoolPtrOutput `pulumi:"httpsOnly"`
	// An `identity` block as defined below.
	Identity LinuxWebAppSlotIdentityPtrOutput `pulumi:"identity"`
	// The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the `identity` block. [For more information see - Access vaults with a user-assigned identity](https://docs.microsoft.com/en-us/azure/app-service/app-service-key-vault-references#access-vaults-with-a-user-assigned-identity)
	KeyVaultReferenceIdentityId pulumi.StringOutput `pulumi:"keyVaultReferenceIdentityId"`
	// The Kind value for this Linux Web App.
	Kind pulumi.StringOutput `pulumi:"kind"`
	// A `logs` block as defined below.
	Logs LinuxWebAppSlotLogsPtrOutput `pulumi:"logs"`
	// The name which should be used for this Linux Web App. Changing this forces a new Linux Web App to be created.
	Name pulumi.StringOutput `pulumi:"name"`
	// A list of outbound IP addresses - such as `["52.23.25.3", "52.143.43.12"]`
	OutboundIpAddressLists pulumi.StringArrayOutput `pulumi:"outboundIpAddressLists"`
	// A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12`.
	OutboundIpAddresses pulumi.StringOutput `pulumi:"outboundIpAddresses"`
	// A `possibleOutboundIpAddressList` block as defined below.
	PossibleOutboundIpAddressLists pulumi.StringArrayOutput `pulumi:"possibleOutboundIpAddressLists"`
	// A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12,52.143.43.17` - not all of which are necessarily in use. Superset of `outboundIpAddresses`.
	PossibleOutboundIpAddresses pulumi.StringOutput `pulumi:"possibleOutboundIpAddresses"`
	// A `siteConfig` block as defined below.
	SiteConfig LinuxWebAppSlotSiteConfigOutput `pulumi:"siteConfig"`
	// A `siteCredential` block as defined below.
	SiteCredentials LinuxWebAppSlotSiteCredentialArrayOutput `pulumi:"siteCredentials"`
	// One or more `storageAccount` blocks as defined below.
	StorageAccounts LinuxWebAppSlotStorageAccountArrayOutput `pulumi:"storageAccounts"`
	// A mapping of tags which should be assigned to the Linux Web App.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
}

// NewLinuxWebAppSlot registers a new resource with the given unique name, arguments, and options.
func NewLinuxWebAppSlot(ctx *pulumi.Context,
	name string, args *LinuxWebAppSlotArgs, opts ...pulumi.ResourceOption) (*LinuxWebAppSlot, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AppServiceId == nil {
		return nil, errors.New("invalid value for required argument 'AppServiceId'")
	}
	if args.SiteConfig == nil {
		return nil, errors.New("invalid value for required argument 'SiteConfig'")
	}
	var resource LinuxWebAppSlot
	err := ctx.RegisterResource("azure:appservice/linuxWebAppSlot:LinuxWebAppSlot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLinuxWebAppSlot gets an existing LinuxWebAppSlot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLinuxWebAppSlot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LinuxWebAppSlotState, opts ...pulumi.ResourceOption) (*LinuxWebAppSlot, error) {
	var resource LinuxWebAppSlot
	err := ctx.ReadResource("azure:appservice/linuxWebAppSlot:LinuxWebAppSlot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LinuxWebAppSlot resources.
type linuxWebAppSlotState struct {
	// A `appMetadata` block as defined below.
	AppMetadata map[string]string `pulumi:"appMetadata"`
	// The ID of the Linux Web App this Deployment Slot will be part of. Changing this forces a new Linux Web App to be created.
	AppServiceId *string `pulumi:"appServiceId"`
	// A map of key-value pairs of App Settings.
	AppSettings map[string]string `pulumi:"appSettings"`
	// A `authSettings` block as defined below.
	AuthSettings *LinuxWebAppSlotAuthSettings `pulumi:"authSettings"`
	// A `backup` block as defined below.
	Backup *LinuxWebAppSlotBackup `pulumi:"backup"`
	// Should Client Affinity be enabled?
	ClientAffinityEnabled *bool `pulumi:"clientAffinityEnabled"`
	// Should Client Certificates be enabled?
	ClientCertificateEnabled *bool `pulumi:"clientCertificateEnabled"`
	// The Client Certificate mode. Possible values include `Optional` and `Required`. This property has no effect when `clientCertEnabled` is `false`
	ClientCertificateMode *string `pulumi:"clientCertificateMode"`
	// One or more `connectionString` blocks as defined below.
	ConnectionStrings []LinuxWebAppSlotConnectionString `pulumi:"connectionStrings"`
	// The identifier used by App Service to perform domain ownership verification via DNS TXT record.
	CustomDomainVerificationId *string `pulumi:"customDomainVerificationId"`
	// The default hostname of the Linux Web App.
	DefaultHostname *string `pulumi:"defaultHostname"`
	// Should the Linux Web App be enabled? Defaults to `true`.
	Enabled *bool `pulumi:"enabled"`
	// Should the Linux Web App require HTTPS connections.
	HttpsOnly *bool `pulumi:"httpsOnly"`
	// An `identity` block as defined below.
	Identity *LinuxWebAppSlotIdentity `pulumi:"identity"`
	// The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the `identity` block. [For more information see - Access vaults with a user-assigned identity](https://docs.microsoft.com/en-us/azure/app-service/app-service-key-vault-references#access-vaults-with-a-user-assigned-identity)
	KeyVaultReferenceIdentityId *string `pulumi:"keyVaultReferenceIdentityId"`
	// The Kind value for this Linux Web App.
	Kind *string `pulumi:"kind"`
	// A `logs` block as defined below.
	Logs *LinuxWebAppSlotLogs `pulumi:"logs"`
	// The name which should be used for this Linux Web App. Changing this forces a new Linux Web App to be created.
	Name *string `pulumi:"name"`
	// A list of outbound IP addresses - such as `["52.23.25.3", "52.143.43.12"]`
	OutboundIpAddressLists []string `pulumi:"outboundIpAddressLists"`
	// A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12`.
	OutboundIpAddresses *string `pulumi:"outboundIpAddresses"`
	// A `possibleOutboundIpAddressList` block as defined below.
	PossibleOutboundIpAddressLists []string `pulumi:"possibleOutboundIpAddressLists"`
	// A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12,52.143.43.17` - not all of which are necessarily in use. Superset of `outboundIpAddresses`.
	PossibleOutboundIpAddresses *string `pulumi:"possibleOutboundIpAddresses"`
	// A `siteConfig` block as defined below.
	SiteConfig *LinuxWebAppSlotSiteConfig `pulumi:"siteConfig"`
	// A `siteCredential` block as defined below.
	SiteCredentials []LinuxWebAppSlotSiteCredential `pulumi:"siteCredentials"`
	// One or more `storageAccount` blocks as defined below.
	StorageAccounts []LinuxWebAppSlotStorageAccount `pulumi:"storageAccounts"`
	// A mapping of tags which should be assigned to the Linux Web App.
	Tags map[string]string `pulumi:"tags"`
}

type LinuxWebAppSlotState struct {
	// A `appMetadata` block as defined below.
	AppMetadata pulumi.StringMapInput
	// The ID of the Linux Web App this Deployment Slot will be part of. Changing this forces a new Linux Web App to be created.
	AppServiceId pulumi.StringPtrInput
	// A map of key-value pairs of App Settings.
	AppSettings pulumi.StringMapInput
	// A `authSettings` block as defined below.
	AuthSettings LinuxWebAppSlotAuthSettingsPtrInput
	// A `backup` block as defined below.
	Backup LinuxWebAppSlotBackupPtrInput
	// Should Client Affinity be enabled?
	ClientAffinityEnabled pulumi.BoolPtrInput
	// Should Client Certificates be enabled?
	ClientCertificateEnabled pulumi.BoolPtrInput
	// The Client Certificate mode. Possible values include `Optional` and `Required`. This property has no effect when `clientCertEnabled` is `false`
	ClientCertificateMode pulumi.StringPtrInput
	// One or more `connectionString` blocks as defined below.
	ConnectionStrings LinuxWebAppSlotConnectionStringArrayInput
	// The identifier used by App Service to perform domain ownership verification via DNS TXT record.
	CustomDomainVerificationId pulumi.StringPtrInput
	// The default hostname of the Linux Web App.
	DefaultHostname pulumi.StringPtrInput
	// Should the Linux Web App be enabled? Defaults to `true`.
	Enabled pulumi.BoolPtrInput
	// Should the Linux Web App require HTTPS connections.
	HttpsOnly pulumi.BoolPtrInput
	// An `identity` block as defined below.
	Identity LinuxWebAppSlotIdentityPtrInput
	// The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the `identity` block. [For more information see - Access vaults with a user-assigned identity](https://docs.microsoft.com/en-us/azure/app-service/app-service-key-vault-references#access-vaults-with-a-user-assigned-identity)
	KeyVaultReferenceIdentityId pulumi.StringPtrInput
	// The Kind value for this Linux Web App.
	Kind pulumi.StringPtrInput
	// A `logs` block as defined below.
	Logs LinuxWebAppSlotLogsPtrInput
	// The name which should be used for this Linux Web App. Changing this forces a new Linux Web App to be created.
	Name pulumi.StringPtrInput
	// A list of outbound IP addresses - such as `["52.23.25.3", "52.143.43.12"]`
	OutboundIpAddressLists pulumi.StringArrayInput
	// A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12`.
	OutboundIpAddresses pulumi.StringPtrInput
	// A `possibleOutboundIpAddressList` block as defined below.
	PossibleOutboundIpAddressLists pulumi.StringArrayInput
	// A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12,52.143.43.17` - not all of which are necessarily in use. Superset of `outboundIpAddresses`.
	PossibleOutboundIpAddresses pulumi.StringPtrInput
	// A `siteConfig` block as defined below.
	SiteConfig LinuxWebAppSlotSiteConfigPtrInput
	// A `siteCredential` block as defined below.
	SiteCredentials LinuxWebAppSlotSiteCredentialArrayInput
	// One or more `storageAccount` blocks as defined below.
	StorageAccounts LinuxWebAppSlotStorageAccountArrayInput
	// A mapping of tags which should be assigned to the Linux Web App.
	Tags pulumi.StringMapInput
}

func (LinuxWebAppSlotState) ElementType() reflect.Type {
	return reflect.TypeOf((*linuxWebAppSlotState)(nil)).Elem()
}

type linuxWebAppSlotArgs struct {
	// The ID of the Linux Web App this Deployment Slot will be part of. Changing this forces a new Linux Web App to be created.
	AppServiceId string `pulumi:"appServiceId"`
	// A map of key-value pairs of App Settings.
	AppSettings map[string]string `pulumi:"appSettings"`
	// A `authSettings` block as defined below.
	AuthSettings *LinuxWebAppSlotAuthSettings `pulumi:"authSettings"`
	// A `backup` block as defined below.
	Backup *LinuxWebAppSlotBackup `pulumi:"backup"`
	// Should Client Affinity be enabled?
	ClientAffinityEnabled *bool `pulumi:"clientAffinityEnabled"`
	// Should Client Certificates be enabled?
	ClientCertificateEnabled *bool `pulumi:"clientCertificateEnabled"`
	// The Client Certificate mode. Possible values include `Optional` and `Required`. This property has no effect when `clientCertEnabled` is `false`
	ClientCertificateMode *string `pulumi:"clientCertificateMode"`
	// One or more `connectionString` blocks as defined below.
	ConnectionStrings []LinuxWebAppSlotConnectionString `pulumi:"connectionStrings"`
	// Should the Linux Web App be enabled? Defaults to `true`.
	Enabled *bool `pulumi:"enabled"`
	// Should the Linux Web App require HTTPS connections.
	HttpsOnly *bool `pulumi:"httpsOnly"`
	// An `identity` block as defined below.
	Identity *LinuxWebAppSlotIdentity `pulumi:"identity"`
	// The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the `identity` block. [For more information see - Access vaults with a user-assigned identity](https://docs.microsoft.com/en-us/azure/app-service/app-service-key-vault-references#access-vaults-with-a-user-assigned-identity)
	KeyVaultReferenceIdentityId *string `pulumi:"keyVaultReferenceIdentityId"`
	// A `logs` block as defined below.
	Logs *LinuxWebAppSlotLogs `pulumi:"logs"`
	// The name which should be used for this Linux Web App. Changing this forces a new Linux Web App to be created.
	Name *string `pulumi:"name"`
	// A `siteConfig` block as defined below.
	SiteConfig LinuxWebAppSlotSiteConfig `pulumi:"siteConfig"`
	// One or more `storageAccount` blocks as defined below.
	StorageAccounts []LinuxWebAppSlotStorageAccount `pulumi:"storageAccounts"`
	// A mapping of tags which should be assigned to the Linux Web App.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a LinuxWebAppSlot resource.
type LinuxWebAppSlotArgs struct {
	// The ID of the Linux Web App this Deployment Slot will be part of. Changing this forces a new Linux Web App to be created.
	AppServiceId pulumi.StringInput
	// A map of key-value pairs of App Settings.
	AppSettings pulumi.StringMapInput
	// A `authSettings` block as defined below.
	AuthSettings LinuxWebAppSlotAuthSettingsPtrInput
	// A `backup` block as defined below.
	Backup LinuxWebAppSlotBackupPtrInput
	// Should Client Affinity be enabled?
	ClientAffinityEnabled pulumi.BoolPtrInput
	// Should Client Certificates be enabled?
	ClientCertificateEnabled pulumi.BoolPtrInput
	// The Client Certificate mode. Possible values include `Optional` and `Required`. This property has no effect when `clientCertEnabled` is `false`
	ClientCertificateMode pulumi.StringPtrInput
	// One or more `connectionString` blocks as defined below.
	ConnectionStrings LinuxWebAppSlotConnectionStringArrayInput
	// Should the Linux Web App be enabled? Defaults to `true`.
	Enabled pulumi.BoolPtrInput
	// Should the Linux Web App require HTTPS connections.
	HttpsOnly pulumi.BoolPtrInput
	// An `identity` block as defined below.
	Identity LinuxWebAppSlotIdentityPtrInput
	// The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the `identity` block. [For more information see - Access vaults with a user-assigned identity](https://docs.microsoft.com/en-us/azure/app-service/app-service-key-vault-references#access-vaults-with-a-user-assigned-identity)
	KeyVaultReferenceIdentityId pulumi.StringPtrInput
	// A `logs` block as defined below.
	Logs LinuxWebAppSlotLogsPtrInput
	// The name which should be used for this Linux Web App. Changing this forces a new Linux Web App to be created.
	Name pulumi.StringPtrInput
	// A `siteConfig` block as defined below.
	SiteConfig LinuxWebAppSlotSiteConfigInput
	// One or more `storageAccount` blocks as defined below.
	StorageAccounts LinuxWebAppSlotStorageAccountArrayInput
	// A mapping of tags which should be assigned to the Linux Web App.
	Tags pulumi.StringMapInput
}

func (LinuxWebAppSlotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*linuxWebAppSlotArgs)(nil)).Elem()
}

type LinuxWebAppSlotInput interface {
	pulumi.Input

	ToLinuxWebAppSlotOutput() LinuxWebAppSlotOutput
	ToLinuxWebAppSlotOutputWithContext(ctx context.Context) LinuxWebAppSlotOutput
}

func (*LinuxWebAppSlot) ElementType() reflect.Type {
	return reflect.TypeOf((**LinuxWebAppSlot)(nil)).Elem()
}

func (i *LinuxWebAppSlot) ToLinuxWebAppSlotOutput() LinuxWebAppSlotOutput {
	return i.ToLinuxWebAppSlotOutputWithContext(context.Background())
}

func (i *LinuxWebAppSlot) ToLinuxWebAppSlotOutputWithContext(ctx context.Context) LinuxWebAppSlotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LinuxWebAppSlotOutput)
}

// LinuxWebAppSlotArrayInput is an input type that accepts LinuxWebAppSlotArray and LinuxWebAppSlotArrayOutput values.
// You can construct a concrete instance of `LinuxWebAppSlotArrayInput` via:
//
//          LinuxWebAppSlotArray{ LinuxWebAppSlotArgs{...} }
type LinuxWebAppSlotArrayInput interface {
	pulumi.Input

	ToLinuxWebAppSlotArrayOutput() LinuxWebAppSlotArrayOutput
	ToLinuxWebAppSlotArrayOutputWithContext(context.Context) LinuxWebAppSlotArrayOutput
}

type LinuxWebAppSlotArray []LinuxWebAppSlotInput

func (LinuxWebAppSlotArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*LinuxWebAppSlot)(nil)).Elem()
}

func (i LinuxWebAppSlotArray) ToLinuxWebAppSlotArrayOutput() LinuxWebAppSlotArrayOutput {
	return i.ToLinuxWebAppSlotArrayOutputWithContext(context.Background())
}

func (i LinuxWebAppSlotArray) ToLinuxWebAppSlotArrayOutputWithContext(ctx context.Context) LinuxWebAppSlotArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LinuxWebAppSlotArrayOutput)
}

// LinuxWebAppSlotMapInput is an input type that accepts LinuxWebAppSlotMap and LinuxWebAppSlotMapOutput values.
// You can construct a concrete instance of `LinuxWebAppSlotMapInput` via:
//
//          LinuxWebAppSlotMap{ "key": LinuxWebAppSlotArgs{...} }
type LinuxWebAppSlotMapInput interface {
	pulumi.Input

	ToLinuxWebAppSlotMapOutput() LinuxWebAppSlotMapOutput
	ToLinuxWebAppSlotMapOutputWithContext(context.Context) LinuxWebAppSlotMapOutput
}

type LinuxWebAppSlotMap map[string]LinuxWebAppSlotInput

func (LinuxWebAppSlotMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*LinuxWebAppSlot)(nil)).Elem()
}

func (i LinuxWebAppSlotMap) ToLinuxWebAppSlotMapOutput() LinuxWebAppSlotMapOutput {
	return i.ToLinuxWebAppSlotMapOutputWithContext(context.Background())
}

func (i LinuxWebAppSlotMap) ToLinuxWebAppSlotMapOutputWithContext(ctx context.Context) LinuxWebAppSlotMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LinuxWebAppSlotMapOutput)
}

type LinuxWebAppSlotOutput struct{ *pulumi.OutputState }

func (LinuxWebAppSlotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**LinuxWebAppSlot)(nil)).Elem()
}

func (o LinuxWebAppSlotOutput) ToLinuxWebAppSlotOutput() LinuxWebAppSlotOutput {
	return o
}

func (o LinuxWebAppSlotOutput) ToLinuxWebAppSlotOutputWithContext(ctx context.Context) LinuxWebAppSlotOutput {
	return o
}

type LinuxWebAppSlotArrayOutput struct{ *pulumi.OutputState }

func (LinuxWebAppSlotArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*LinuxWebAppSlot)(nil)).Elem()
}

func (o LinuxWebAppSlotArrayOutput) ToLinuxWebAppSlotArrayOutput() LinuxWebAppSlotArrayOutput {
	return o
}

func (o LinuxWebAppSlotArrayOutput) ToLinuxWebAppSlotArrayOutputWithContext(ctx context.Context) LinuxWebAppSlotArrayOutput {
	return o
}

func (o LinuxWebAppSlotArrayOutput) Index(i pulumi.IntInput) LinuxWebAppSlotOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *LinuxWebAppSlot {
		return vs[0].([]*LinuxWebAppSlot)[vs[1].(int)]
	}).(LinuxWebAppSlotOutput)
}

type LinuxWebAppSlotMapOutput struct{ *pulumi.OutputState }

func (LinuxWebAppSlotMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*LinuxWebAppSlot)(nil)).Elem()
}

func (o LinuxWebAppSlotMapOutput) ToLinuxWebAppSlotMapOutput() LinuxWebAppSlotMapOutput {
	return o
}

func (o LinuxWebAppSlotMapOutput) ToLinuxWebAppSlotMapOutputWithContext(ctx context.Context) LinuxWebAppSlotMapOutput {
	return o
}

func (o LinuxWebAppSlotMapOutput) MapIndex(k pulumi.StringInput) LinuxWebAppSlotOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *LinuxWebAppSlot {
		return vs[0].(map[string]*LinuxWebAppSlot)[vs[1].(string)]
	}).(LinuxWebAppSlotOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*LinuxWebAppSlotInput)(nil)).Elem(), &LinuxWebAppSlot{})
	pulumi.RegisterInputType(reflect.TypeOf((*LinuxWebAppSlotArrayInput)(nil)).Elem(), LinuxWebAppSlotArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*LinuxWebAppSlotMapInput)(nil)).Elem(), LinuxWebAppSlotMap{})
	pulumi.RegisterOutputType(LinuxWebAppSlotOutput{})
	pulumi.RegisterOutputType(LinuxWebAppSlotArrayOutput{})
	pulumi.RegisterOutputType(LinuxWebAppSlotMapOutput{})
}

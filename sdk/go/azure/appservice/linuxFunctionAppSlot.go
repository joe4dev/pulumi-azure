// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package appservice

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Manages a Linux Function App Slot.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-azure/sdk/v5/go/azure/appservice"
// 	"github.com/pulumi/pulumi-azure/sdk/v5/go/azure/core"
// 	"github.com/pulumi/pulumi-azure/sdk/v5/go/azure/storage"
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
// 		exampleAccount, err := storage.NewAccount(ctx, "exampleAccount", &storage.AccountArgs{
// 			ResourceGroupName:      exampleResourceGroup.Name,
// 			Location:               exampleResourceGroup.Location,
// 			AccountTier:            pulumi.String("Standard"),
// 			AccountReplicationType: pulumi.String("LRS"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		exampleServicePlan, err := appservice.NewServicePlan(ctx, "exampleServicePlan", &appservice.ServicePlanArgs{
// 			ResourceGroupName: exampleResourceGroup.Name,
// 			Location:          exampleResourceGroup.Location,
// 			OsType:            pulumi.String("Linux"),
// 			SkuName:           pulumi.String("Y1"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		exampleLinuxFunctionApp, err := appservice.NewLinuxFunctionApp(ctx, "exampleLinuxFunctionApp", &appservice.LinuxFunctionAppArgs{
// 			ResourceGroupName:  exampleResourceGroup.Name,
// 			Location:           exampleResourceGroup.Location,
// 			ServicePlanId:      exampleServicePlan.ID(),
// 			StorageAccountName: exampleAccount.Name,
// 			SiteConfig:         nil,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = appservice.NewLinuxFunctionAppSlot(ctx, "exampleLinuxFunctionAppSlot", &appservice.LinuxFunctionAppSlotArgs{
// 			FunctionAppId:      exampleLinuxFunctionApp.ID(),
// 			StorageAccountName: exampleAccount.Name,
// 			SiteConfig:         nil,
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
// A Linux Function App Slot can be imported using the `resource id`, e.g.
//
// ```sh
//  $ pulumi import azure:appservice/linuxFunctionAppSlot:LinuxFunctionAppSlot example "/subscriptions/12345678-1234-9876-4563-123456789012/resourceGroups/resGroup1/providers/Microsoft.Web/sites/site1/slots/slot1"
// ```
type LinuxFunctionAppSlot struct {
	pulumi.CustomResourceState

	// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
	AppSettings pulumi.StringMapOutput `pulumi:"appSettings"`
	// an `authSettings` block as detailed below.
	AuthSettings LinuxFunctionAppSlotAuthSettingsOutput `pulumi:"authSettings"`
	// a `backup` block as detailed below.
	Backup LinuxFunctionAppSlotBackupPtrOutput `pulumi:"backup"`
	// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.
	BuiltinLoggingEnabled pulumi.BoolPtrOutput `pulumi:"builtinLoggingEnabled"`
	// Should the Function App Slot use Client Certificates.
	ClientCertificateEnabled pulumi.BoolPtrOutput `pulumi:"clientCertificateEnabled"`
	// The mode of the Function App Slot's client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.
	ClientCertificateMode pulumi.StringPtrOutput `pulumi:"clientCertificateMode"`
	// a `connectionString` block as detailed below.
	ConnectionStrings LinuxFunctionAppSlotConnectionStringArrayOutput `pulumi:"connectionStrings"`
	// Force disable the content share settings.
	ContentShareForceDisabled pulumi.BoolPtrOutput `pulumi:"contentShareForceDisabled"`
	// The identifier used by App Service to perform domain ownership verification via DNS TXT record.
	CustomDomainVerificationId pulumi.StringOutput `pulumi:"customDomainVerificationId"`
	// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
	DailyMemoryTimeQuota pulumi.IntPtrOutput `pulumi:"dailyMemoryTimeQuota"`
	// The default hostname of the Linux Function App Slot.
	DefaultHostname pulumi.StringOutput `pulumi:"defaultHostname"`
	// Is the Linux Function App Slot enabled.
	Enabled pulumi.BoolPtrOutput `pulumi:"enabled"`
	// The ID of the Linux Function App this Slot is a member of. Changing this forces a new resource to be created.
	FunctionAppId pulumi.StringOutput `pulumi:"functionAppId"`
	// The runtime version associated with the Function App Slot.
	FunctionsExtensionVersion pulumi.StringPtrOutput `pulumi:"functionsExtensionVersion"`
	// Can the Function App Slot only be accessed via HTTPS?
	HttpsOnly pulumi.BoolPtrOutput `pulumi:"httpsOnly"`
	// An `identity` block as detailed below.
	Identity LinuxFunctionAppSlotIdentityPtrOutput `pulumi:"identity"`
	// The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the `identity` block. [For more information see - Access vaults with a user-assigned identity](https://docs.microsoft.com/en-us/azure/app-service/app-service-key-vault-references#access-vaults-with-a-user-assigned-identity)
	KeyVaultReferenceIdentityId pulumi.StringOutput `pulumi:"keyVaultReferenceIdentityId"`
	// The Kind value for this Linux Function App Slot.
	Kind pulumi.StringOutput `pulumi:"kind"`
	// Specifies the name of the Function App Slot. Changing this forces a new resource to be created.
	Name pulumi.StringOutput `pulumi:"name"`
	// A list of outbound IP addresses. For example `["52.23.25.3", "52.143.43.12"]`
	OutboundIpAddressLists pulumi.StringArrayOutput `pulumi:"outboundIpAddressLists"`
	// A comma separated list of outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12`.
	OutboundIpAddresses pulumi.StringOutput `pulumi:"outboundIpAddresses"`
	// A list of possible outbound IP addresses, not all of which are necessarily in use. This is a superset of `outboundIpAddressList`. For example `["52.23.25.3", "52.143.43.12"]`.
	PossibleOutboundIpAddressLists pulumi.StringArrayOutput `pulumi:"possibleOutboundIpAddressLists"`
	// A comma separated list of possible outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12,52.143.43.17`. This is a superset of `outboundIpAddresses`. For example `["52.23.25.3", "52.143.43.12","52.143.43.17"]`.
	PossibleOutboundIpAddresses pulumi.StringOutput `pulumi:"possibleOutboundIpAddresses"`
	// a `siteConfig` block as detailed below.
	SiteConfig LinuxFunctionAppSlotSiteConfigOutput `pulumi:"siteConfig"`
	// A `siteCredential` block as defined below.
	SiteCredentials LinuxFunctionAppSlotSiteCredentialArrayOutput `pulumi:"siteCredentials"`
	// The access key which will be used to access the storage account for the Function App Slot.
	StorageAccountAccessKey pulumi.StringPtrOutput `pulumi:"storageAccountAccessKey"`
	// The backend storage account name which will be used by this Function App Slot.
	StorageAccountName pulumi.StringPtrOutput `pulumi:"storageAccountName"`
	// The Key Vault Secret ID, optionally including version, that contains the Connection String to connect to the storage account for this Function App.
	StorageKeyVaultSecretId pulumi.StringPtrOutput `pulumi:"storageKeyVaultSecretId"`
	// Should the Function App Slot use its Managed Identity to access storage.
	StorageUsesManagedIdentity pulumi.BoolPtrOutput `pulumi:"storageUsesManagedIdentity"`
	// A mapping of tags which should be assigned to the Linux Function App.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
}

// NewLinuxFunctionAppSlot registers a new resource with the given unique name, arguments, and options.
func NewLinuxFunctionAppSlot(ctx *pulumi.Context,
	name string, args *LinuxFunctionAppSlotArgs, opts ...pulumi.ResourceOption) (*LinuxFunctionAppSlot, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.FunctionAppId == nil {
		return nil, errors.New("invalid value for required argument 'FunctionAppId'")
	}
	if args.SiteConfig == nil {
		return nil, errors.New("invalid value for required argument 'SiteConfig'")
	}
	var resource LinuxFunctionAppSlot
	err := ctx.RegisterResource("azure:appservice/linuxFunctionAppSlot:LinuxFunctionAppSlot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLinuxFunctionAppSlot gets an existing LinuxFunctionAppSlot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLinuxFunctionAppSlot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LinuxFunctionAppSlotState, opts ...pulumi.ResourceOption) (*LinuxFunctionAppSlot, error) {
	var resource LinuxFunctionAppSlot
	err := ctx.ReadResource("azure:appservice/linuxFunctionAppSlot:LinuxFunctionAppSlot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LinuxFunctionAppSlot resources.
type linuxFunctionAppSlotState struct {
	// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
	AppSettings map[string]string `pulumi:"appSettings"`
	// an `authSettings` block as detailed below.
	AuthSettings *LinuxFunctionAppSlotAuthSettings `pulumi:"authSettings"`
	// a `backup` block as detailed below.
	Backup *LinuxFunctionAppSlotBackup `pulumi:"backup"`
	// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.
	BuiltinLoggingEnabled *bool `pulumi:"builtinLoggingEnabled"`
	// Should the Function App Slot use Client Certificates.
	ClientCertificateEnabled *bool `pulumi:"clientCertificateEnabled"`
	// The mode of the Function App Slot's client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.
	ClientCertificateMode *string `pulumi:"clientCertificateMode"`
	// a `connectionString` block as detailed below.
	ConnectionStrings []LinuxFunctionAppSlotConnectionString `pulumi:"connectionStrings"`
	// Force disable the content share settings.
	ContentShareForceDisabled *bool `pulumi:"contentShareForceDisabled"`
	// The identifier used by App Service to perform domain ownership verification via DNS TXT record.
	CustomDomainVerificationId *string `pulumi:"customDomainVerificationId"`
	// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
	DailyMemoryTimeQuota *int `pulumi:"dailyMemoryTimeQuota"`
	// The default hostname of the Linux Function App Slot.
	DefaultHostname *string `pulumi:"defaultHostname"`
	// Is the Linux Function App Slot enabled.
	Enabled *bool `pulumi:"enabled"`
	// The ID of the Linux Function App this Slot is a member of. Changing this forces a new resource to be created.
	FunctionAppId *string `pulumi:"functionAppId"`
	// The runtime version associated with the Function App Slot.
	FunctionsExtensionVersion *string `pulumi:"functionsExtensionVersion"`
	// Can the Function App Slot only be accessed via HTTPS?
	HttpsOnly *bool `pulumi:"httpsOnly"`
	// An `identity` block as detailed below.
	Identity *LinuxFunctionAppSlotIdentity `pulumi:"identity"`
	// The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the `identity` block. [For more information see - Access vaults with a user-assigned identity](https://docs.microsoft.com/en-us/azure/app-service/app-service-key-vault-references#access-vaults-with-a-user-assigned-identity)
	KeyVaultReferenceIdentityId *string `pulumi:"keyVaultReferenceIdentityId"`
	// The Kind value for this Linux Function App Slot.
	Kind *string `pulumi:"kind"`
	// Specifies the name of the Function App Slot. Changing this forces a new resource to be created.
	Name *string `pulumi:"name"`
	// A list of outbound IP addresses. For example `["52.23.25.3", "52.143.43.12"]`
	OutboundIpAddressLists []string `pulumi:"outboundIpAddressLists"`
	// A comma separated list of outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12`.
	OutboundIpAddresses *string `pulumi:"outboundIpAddresses"`
	// A list of possible outbound IP addresses, not all of which are necessarily in use. This is a superset of `outboundIpAddressList`. For example `["52.23.25.3", "52.143.43.12"]`.
	PossibleOutboundIpAddressLists []string `pulumi:"possibleOutboundIpAddressLists"`
	// A comma separated list of possible outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12,52.143.43.17`. This is a superset of `outboundIpAddresses`. For example `["52.23.25.3", "52.143.43.12","52.143.43.17"]`.
	PossibleOutboundIpAddresses *string `pulumi:"possibleOutboundIpAddresses"`
	// a `siteConfig` block as detailed below.
	SiteConfig *LinuxFunctionAppSlotSiteConfig `pulumi:"siteConfig"`
	// A `siteCredential` block as defined below.
	SiteCredentials []LinuxFunctionAppSlotSiteCredential `pulumi:"siteCredentials"`
	// The access key which will be used to access the storage account for the Function App Slot.
	StorageAccountAccessKey *string `pulumi:"storageAccountAccessKey"`
	// The backend storage account name which will be used by this Function App Slot.
	StorageAccountName *string `pulumi:"storageAccountName"`
	// The Key Vault Secret ID, optionally including version, that contains the Connection String to connect to the storage account for this Function App.
	StorageKeyVaultSecretId *string `pulumi:"storageKeyVaultSecretId"`
	// Should the Function App Slot use its Managed Identity to access storage.
	StorageUsesManagedIdentity *bool `pulumi:"storageUsesManagedIdentity"`
	// A mapping of tags which should be assigned to the Linux Function App.
	Tags map[string]string `pulumi:"tags"`
}

type LinuxFunctionAppSlotState struct {
	// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
	AppSettings pulumi.StringMapInput
	// an `authSettings` block as detailed below.
	AuthSettings LinuxFunctionAppSlotAuthSettingsPtrInput
	// a `backup` block as detailed below.
	Backup LinuxFunctionAppSlotBackupPtrInput
	// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.
	BuiltinLoggingEnabled pulumi.BoolPtrInput
	// Should the Function App Slot use Client Certificates.
	ClientCertificateEnabled pulumi.BoolPtrInput
	// The mode of the Function App Slot's client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.
	ClientCertificateMode pulumi.StringPtrInput
	// a `connectionString` block as detailed below.
	ConnectionStrings LinuxFunctionAppSlotConnectionStringArrayInput
	// Force disable the content share settings.
	ContentShareForceDisabled pulumi.BoolPtrInput
	// The identifier used by App Service to perform domain ownership verification via DNS TXT record.
	CustomDomainVerificationId pulumi.StringPtrInput
	// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
	DailyMemoryTimeQuota pulumi.IntPtrInput
	// The default hostname of the Linux Function App Slot.
	DefaultHostname pulumi.StringPtrInput
	// Is the Linux Function App Slot enabled.
	Enabled pulumi.BoolPtrInput
	// The ID of the Linux Function App this Slot is a member of. Changing this forces a new resource to be created.
	FunctionAppId pulumi.StringPtrInput
	// The runtime version associated with the Function App Slot.
	FunctionsExtensionVersion pulumi.StringPtrInput
	// Can the Function App Slot only be accessed via HTTPS?
	HttpsOnly pulumi.BoolPtrInput
	// An `identity` block as detailed below.
	Identity LinuxFunctionAppSlotIdentityPtrInput
	// The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the `identity` block. [For more information see - Access vaults with a user-assigned identity](https://docs.microsoft.com/en-us/azure/app-service/app-service-key-vault-references#access-vaults-with-a-user-assigned-identity)
	KeyVaultReferenceIdentityId pulumi.StringPtrInput
	// The Kind value for this Linux Function App Slot.
	Kind pulumi.StringPtrInput
	// Specifies the name of the Function App Slot. Changing this forces a new resource to be created.
	Name pulumi.StringPtrInput
	// A list of outbound IP addresses. For example `["52.23.25.3", "52.143.43.12"]`
	OutboundIpAddressLists pulumi.StringArrayInput
	// A comma separated list of outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12`.
	OutboundIpAddresses pulumi.StringPtrInput
	// A list of possible outbound IP addresses, not all of which are necessarily in use. This is a superset of `outboundIpAddressList`. For example `["52.23.25.3", "52.143.43.12"]`.
	PossibleOutboundIpAddressLists pulumi.StringArrayInput
	// A comma separated list of possible outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12,52.143.43.17`. This is a superset of `outboundIpAddresses`. For example `["52.23.25.3", "52.143.43.12","52.143.43.17"]`.
	PossibleOutboundIpAddresses pulumi.StringPtrInput
	// a `siteConfig` block as detailed below.
	SiteConfig LinuxFunctionAppSlotSiteConfigPtrInput
	// A `siteCredential` block as defined below.
	SiteCredentials LinuxFunctionAppSlotSiteCredentialArrayInput
	// The access key which will be used to access the storage account for the Function App Slot.
	StorageAccountAccessKey pulumi.StringPtrInput
	// The backend storage account name which will be used by this Function App Slot.
	StorageAccountName pulumi.StringPtrInput
	// The Key Vault Secret ID, optionally including version, that contains the Connection String to connect to the storage account for this Function App.
	StorageKeyVaultSecretId pulumi.StringPtrInput
	// Should the Function App Slot use its Managed Identity to access storage.
	StorageUsesManagedIdentity pulumi.BoolPtrInput
	// A mapping of tags which should be assigned to the Linux Function App.
	Tags pulumi.StringMapInput
}

func (LinuxFunctionAppSlotState) ElementType() reflect.Type {
	return reflect.TypeOf((*linuxFunctionAppSlotState)(nil)).Elem()
}

type linuxFunctionAppSlotArgs struct {
	// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
	AppSettings map[string]string `pulumi:"appSettings"`
	// an `authSettings` block as detailed below.
	AuthSettings *LinuxFunctionAppSlotAuthSettings `pulumi:"authSettings"`
	// a `backup` block as detailed below.
	Backup *LinuxFunctionAppSlotBackup `pulumi:"backup"`
	// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.
	BuiltinLoggingEnabled *bool `pulumi:"builtinLoggingEnabled"`
	// Should the Function App Slot use Client Certificates.
	ClientCertificateEnabled *bool `pulumi:"clientCertificateEnabled"`
	// The mode of the Function App Slot's client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.
	ClientCertificateMode *string `pulumi:"clientCertificateMode"`
	// a `connectionString` block as detailed below.
	ConnectionStrings []LinuxFunctionAppSlotConnectionString `pulumi:"connectionStrings"`
	// Force disable the content share settings.
	ContentShareForceDisabled *bool `pulumi:"contentShareForceDisabled"`
	// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
	DailyMemoryTimeQuota *int `pulumi:"dailyMemoryTimeQuota"`
	// Is the Linux Function App Slot enabled.
	Enabled *bool `pulumi:"enabled"`
	// The ID of the Linux Function App this Slot is a member of. Changing this forces a new resource to be created.
	FunctionAppId string `pulumi:"functionAppId"`
	// The runtime version associated with the Function App Slot.
	FunctionsExtensionVersion *string `pulumi:"functionsExtensionVersion"`
	// Can the Function App Slot only be accessed via HTTPS?
	HttpsOnly *bool `pulumi:"httpsOnly"`
	// An `identity` block as detailed below.
	Identity *LinuxFunctionAppSlotIdentity `pulumi:"identity"`
	// The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the `identity` block. [For more information see - Access vaults with a user-assigned identity](https://docs.microsoft.com/en-us/azure/app-service/app-service-key-vault-references#access-vaults-with-a-user-assigned-identity)
	KeyVaultReferenceIdentityId *string `pulumi:"keyVaultReferenceIdentityId"`
	// Specifies the name of the Function App Slot. Changing this forces a new resource to be created.
	Name *string `pulumi:"name"`
	// a `siteConfig` block as detailed below.
	SiteConfig LinuxFunctionAppSlotSiteConfig `pulumi:"siteConfig"`
	// The access key which will be used to access the storage account for the Function App Slot.
	StorageAccountAccessKey *string `pulumi:"storageAccountAccessKey"`
	// The backend storage account name which will be used by this Function App Slot.
	StorageAccountName *string `pulumi:"storageAccountName"`
	// The Key Vault Secret ID, optionally including version, that contains the Connection String to connect to the storage account for this Function App.
	StorageKeyVaultSecretId *string `pulumi:"storageKeyVaultSecretId"`
	// Should the Function App Slot use its Managed Identity to access storage.
	StorageUsesManagedIdentity *bool `pulumi:"storageUsesManagedIdentity"`
	// A mapping of tags which should be assigned to the Linux Function App.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a LinuxFunctionAppSlot resource.
type LinuxFunctionAppSlotArgs struct {
	// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
	AppSettings pulumi.StringMapInput
	// an `authSettings` block as detailed below.
	AuthSettings LinuxFunctionAppSlotAuthSettingsPtrInput
	// a `backup` block as detailed below.
	Backup LinuxFunctionAppSlotBackupPtrInput
	// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.
	BuiltinLoggingEnabled pulumi.BoolPtrInput
	// Should the Function App Slot use Client Certificates.
	ClientCertificateEnabled pulumi.BoolPtrInput
	// The mode of the Function App Slot's client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.
	ClientCertificateMode pulumi.StringPtrInput
	// a `connectionString` block as detailed below.
	ConnectionStrings LinuxFunctionAppSlotConnectionStringArrayInput
	// Force disable the content share settings.
	ContentShareForceDisabled pulumi.BoolPtrInput
	// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
	DailyMemoryTimeQuota pulumi.IntPtrInput
	// Is the Linux Function App Slot enabled.
	Enabled pulumi.BoolPtrInput
	// The ID of the Linux Function App this Slot is a member of. Changing this forces a new resource to be created.
	FunctionAppId pulumi.StringInput
	// The runtime version associated with the Function App Slot.
	FunctionsExtensionVersion pulumi.StringPtrInput
	// Can the Function App Slot only be accessed via HTTPS?
	HttpsOnly pulumi.BoolPtrInput
	// An `identity` block as detailed below.
	Identity LinuxFunctionAppSlotIdentityPtrInput
	// The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the `identity` block. [For more information see - Access vaults with a user-assigned identity](https://docs.microsoft.com/en-us/azure/app-service/app-service-key-vault-references#access-vaults-with-a-user-assigned-identity)
	KeyVaultReferenceIdentityId pulumi.StringPtrInput
	// Specifies the name of the Function App Slot. Changing this forces a new resource to be created.
	Name pulumi.StringPtrInput
	// a `siteConfig` block as detailed below.
	SiteConfig LinuxFunctionAppSlotSiteConfigInput
	// The access key which will be used to access the storage account for the Function App Slot.
	StorageAccountAccessKey pulumi.StringPtrInput
	// The backend storage account name which will be used by this Function App Slot.
	StorageAccountName pulumi.StringPtrInput
	// The Key Vault Secret ID, optionally including version, that contains the Connection String to connect to the storage account for this Function App.
	StorageKeyVaultSecretId pulumi.StringPtrInput
	// Should the Function App Slot use its Managed Identity to access storage.
	StorageUsesManagedIdentity pulumi.BoolPtrInput
	// A mapping of tags which should be assigned to the Linux Function App.
	Tags pulumi.StringMapInput
}

func (LinuxFunctionAppSlotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*linuxFunctionAppSlotArgs)(nil)).Elem()
}

type LinuxFunctionAppSlotInput interface {
	pulumi.Input

	ToLinuxFunctionAppSlotOutput() LinuxFunctionAppSlotOutput
	ToLinuxFunctionAppSlotOutputWithContext(ctx context.Context) LinuxFunctionAppSlotOutput
}

func (*LinuxFunctionAppSlot) ElementType() reflect.Type {
	return reflect.TypeOf((**LinuxFunctionAppSlot)(nil)).Elem()
}

func (i *LinuxFunctionAppSlot) ToLinuxFunctionAppSlotOutput() LinuxFunctionAppSlotOutput {
	return i.ToLinuxFunctionAppSlotOutputWithContext(context.Background())
}

func (i *LinuxFunctionAppSlot) ToLinuxFunctionAppSlotOutputWithContext(ctx context.Context) LinuxFunctionAppSlotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LinuxFunctionAppSlotOutput)
}

// LinuxFunctionAppSlotArrayInput is an input type that accepts LinuxFunctionAppSlotArray and LinuxFunctionAppSlotArrayOutput values.
// You can construct a concrete instance of `LinuxFunctionAppSlotArrayInput` via:
//
//          LinuxFunctionAppSlotArray{ LinuxFunctionAppSlotArgs{...} }
type LinuxFunctionAppSlotArrayInput interface {
	pulumi.Input

	ToLinuxFunctionAppSlotArrayOutput() LinuxFunctionAppSlotArrayOutput
	ToLinuxFunctionAppSlotArrayOutputWithContext(context.Context) LinuxFunctionAppSlotArrayOutput
}

type LinuxFunctionAppSlotArray []LinuxFunctionAppSlotInput

func (LinuxFunctionAppSlotArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*LinuxFunctionAppSlot)(nil)).Elem()
}

func (i LinuxFunctionAppSlotArray) ToLinuxFunctionAppSlotArrayOutput() LinuxFunctionAppSlotArrayOutput {
	return i.ToLinuxFunctionAppSlotArrayOutputWithContext(context.Background())
}

func (i LinuxFunctionAppSlotArray) ToLinuxFunctionAppSlotArrayOutputWithContext(ctx context.Context) LinuxFunctionAppSlotArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LinuxFunctionAppSlotArrayOutput)
}

// LinuxFunctionAppSlotMapInput is an input type that accepts LinuxFunctionAppSlotMap and LinuxFunctionAppSlotMapOutput values.
// You can construct a concrete instance of `LinuxFunctionAppSlotMapInput` via:
//
//          LinuxFunctionAppSlotMap{ "key": LinuxFunctionAppSlotArgs{...} }
type LinuxFunctionAppSlotMapInput interface {
	pulumi.Input

	ToLinuxFunctionAppSlotMapOutput() LinuxFunctionAppSlotMapOutput
	ToLinuxFunctionAppSlotMapOutputWithContext(context.Context) LinuxFunctionAppSlotMapOutput
}

type LinuxFunctionAppSlotMap map[string]LinuxFunctionAppSlotInput

func (LinuxFunctionAppSlotMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*LinuxFunctionAppSlot)(nil)).Elem()
}

func (i LinuxFunctionAppSlotMap) ToLinuxFunctionAppSlotMapOutput() LinuxFunctionAppSlotMapOutput {
	return i.ToLinuxFunctionAppSlotMapOutputWithContext(context.Background())
}

func (i LinuxFunctionAppSlotMap) ToLinuxFunctionAppSlotMapOutputWithContext(ctx context.Context) LinuxFunctionAppSlotMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LinuxFunctionAppSlotMapOutput)
}

type LinuxFunctionAppSlotOutput struct{ *pulumi.OutputState }

func (LinuxFunctionAppSlotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**LinuxFunctionAppSlot)(nil)).Elem()
}

func (o LinuxFunctionAppSlotOutput) ToLinuxFunctionAppSlotOutput() LinuxFunctionAppSlotOutput {
	return o
}

func (o LinuxFunctionAppSlotOutput) ToLinuxFunctionAppSlotOutputWithContext(ctx context.Context) LinuxFunctionAppSlotOutput {
	return o
}

type LinuxFunctionAppSlotArrayOutput struct{ *pulumi.OutputState }

func (LinuxFunctionAppSlotArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*LinuxFunctionAppSlot)(nil)).Elem()
}

func (o LinuxFunctionAppSlotArrayOutput) ToLinuxFunctionAppSlotArrayOutput() LinuxFunctionAppSlotArrayOutput {
	return o
}

func (o LinuxFunctionAppSlotArrayOutput) ToLinuxFunctionAppSlotArrayOutputWithContext(ctx context.Context) LinuxFunctionAppSlotArrayOutput {
	return o
}

func (o LinuxFunctionAppSlotArrayOutput) Index(i pulumi.IntInput) LinuxFunctionAppSlotOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *LinuxFunctionAppSlot {
		return vs[0].([]*LinuxFunctionAppSlot)[vs[1].(int)]
	}).(LinuxFunctionAppSlotOutput)
}

type LinuxFunctionAppSlotMapOutput struct{ *pulumi.OutputState }

func (LinuxFunctionAppSlotMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*LinuxFunctionAppSlot)(nil)).Elem()
}

func (o LinuxFunctionAppSlotMapOutput) ToLinuxFunctionAppSlotMapOutput() LinuxFunctionAppSlotMapOutput {
	return o
}

func (o LinuxFunctionAppSlotMapOutput) ToLinuxFunctionAppSlotMapOutputWithContext(ctx context.Context) LinuxFunctionAppSlotMapOutput {
	return o
}

func (o LinuxFunctionAppSlotMapOutput) MapIndex(k pulumi.StringInput) LinuxFunctionAppSlotOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *LinuxFunctionAppSlot {
		return vs[0].(map[string]*LinuxFunctionAppSlot)[vs[1].(string)]
	}).(LinuxFunctionAppSlotOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*LinuxFunctionAppSlotInput)(nil)).Elem(), &LinuxFunctionAppSlot{})
	pulumi.RegisterInputType(reflect.TypeOf((*LinuxFunctionAppSlotArrayInput)(nil)).Elem(), LinuxFunctionAppSlotArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*LinuxFunctionAppSlotMapInput)(nil)).Elem(), LinuxFunctionAppSlotMap{})
	pulumi.RegisterOutputType(LinuxFunctionAppSlotOutput{})
	pulumi.RegisterOutputType(LinuxFunctionAppSlotArrayOutput{})
	pulumi.RegisterOutputType(LinuxFunctionAppSlotMapOutput{})
}

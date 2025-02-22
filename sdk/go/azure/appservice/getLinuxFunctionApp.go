// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package appservice

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Use this data source to access information about an existing Linux Function App.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-azure/sdk/v5/go/azure/appservice"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := appservice.LookupLinuxFunctionApp(ctx, &appservice.LookupLinuxFunctionAppArgs{
// 			Name:              "existing",
// 			ResourceGroupName: "existing",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		ctx.Export("id", data.Linux_function_app.Example.Id)
// 		return nil
// 	})
// }
// ```
// ## Arguments Referencez
//
// The following arguments are supported:
//
// * `name` - (Required) The name which should be used for this Linux Function App.
//
// * `resourceGroupName` - (Required) The name of the Resource Group where the Linux Function App should exist.
func LookupLinuxFunctionApp(ctx *pulumi.Context, args *LookupLinuxFunctionAppArgs, opts ...pulumi.InvokeOption) (*LookupLinuxFunctionAppResult, error) {
	var rv LookupLinuxFunctionAppResult
	err := ctx.Invoke("azure:appservice/getLinuxFunctionApp:getLinuxFunctionApp", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getLinuxFunctionApp.
type LookupLinuxFunctionAppArgs struct {
	// The Site Credentials Username used for publishing.
	Name              string `pulumi:"name"`
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// A collection of values returned by getLinuxFunctionApp.
type LookupLinuxFunctionAppResult struct {
	// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
	AppSettings map[string]string `pulumi:"appSettings"`
	// A `authSettings` block as defined below.
	AuthSettings []GetLinuxFunctionAppAuthSetting `pulumi:"authSettings"`
	// A `backup` block as defined below.
	Backups []GetLinuxFunctionAppBackup `pulumi:"backups"`
	// Is built in logging enabled?
	BuiltinLoggingEnabled bool `pulumi:"builtinLoggingEnabled"`
	// Are Client Certificates enabled?
	ClientCertificateEnabled bool `pulumi:"clientCertificateEnabled"`
	// The mode of the Function App's client certificates requirement for incoming requests.
	ClientCertificateMode string `pulumi:"clientCertificateMode"`
	// A `connectionString` blocks as defined below.
	ConnectionStrings         []GetLinuxFunctionAppConnectionString `pulumi:"connectionStrings"`
	ContentShareForceDisabled bool                                  `pulumi:"contentShareForceDisabled"`
	// The identifier used by App Service to perform domain ownership verification via DNS TXT record.
	CustomDomainVerificationId string `pulumi:"customDomainVerificationId"`
	// The amount of memory in gigabyte-seconds that your application is allowed to consume per day.
	DailyMemoryTimeQuota int `pulumi:"dailyMemoryTimeQuota"`
	// The default hostname of the Linux Function App.
	DefaultHostname string `pulumi:"defaultHostname"`
	// Is this backup job enabled?
	Enabled bool `pulumi:"enabled"`
	// The runtime version associated with the Function App.
	FunctionsExtensionVersion string `pulumi:"functionsExtensionVersion"`
	// Can the Function App only be accessed via HTTPS?
	HttpsOnly bool `pulumi:"httpsOnly"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// A `identity` block as defined below.
	Identities []GetLinuxFunctionAppIdentity `pulumi:"identities"`
	// The Kind value for this Linux Function App.
	Kind string `pulumi:"kind"`
	// The Azure Region where the Linux Function App exists.
	Location string `pulumi:"location"`
	// The Site Credentials Username used for publishing.
	Name string `pulumi:"name"`
	// A list of outbound IP addresses. For example `["52.23.25.3", "52.143.43.12"]`
	OutboundIpAddressLists []string `pulumi:"outboundIpAddressLists"`
	// A comma separated list of outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12`.
	OutboundIpAddresses string `pulumi:"outboundIpAddresses"`
	// A list of possible outbound IP addresses, not all of which are necessarily in use. This is a superset of `outboundIpAddressList`. For example `["52.23.25.3", "52.143.43.12"]`.
	PossibleOutboundIpAddressLists []string `pulumi:"possibleOutboundIpAddressLists"`
	// A comma separated list of possible outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12,52.143.43.17`. This is a superset of `outboundIpAddresses`. For example `["52.23.25.3", "52.143.43.12","52.143.43.17"]`.
	PossibleOutboundIpAddresses string `pulumi:"possibleOutboundIpAddresses"`
	ResourceGroupName           string `pulumi:"resourceGroupName"`
	// The ID of the App Service Plan within which this Function App has been created.
	ServicePlanId string `pulumi:"servicePlanId"`
	// A `siteConfig` block as defined below.
	SiteConfigs []GetLinuxFunctionAppSiteConfig `pulumi:"siteConfigs"`
	// A `siteCredential` block as defined below.
	SiteCredentials []GetLinuxFunctionAppSiteCredential `pulumi:"siteCredentials"`
	// The access key used to access the backend storage account for the Function App.
	StorageAccountAccessKey string `pulumi:"storageAccountAccessKey"`
	// The backend storage account name used by this Function App.
	StorageAccountName string `pulumi:"storageAccountName"`
	// The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.
	StorageKeyVaultSecretId string `pulumi:"storageKeyVaultSecretId"`
	// Does the Function App use Managed Identity to access the storage account?
	StorageUsesManagedIdentity bool `pulumi:"storageUsesManagedIdentity"`
	// A mapping of tags which are assigned to the Linux Function App.
	Tags map[string]string `pulumi:"tags"`
}

func LookupLinuxFunctionAppOutput(ctx *pulumi.Context, args LookupLinuxFunctionAppOutputArgs, opts ...pulumi.InvokeOption) LookupLinuxFunctionAppResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupLinuxFunctionAppResult, error) {
			args := v.(LookupLinuxFunctionAppArgs)
			r, err := LookupLinuxFunctionApp(ctx, &args, opts...)
			return *r, err
		}).(LookupLinuxFunctionAppResultOutput)
}

// A collection of arguments for invoking getLinuxFunctionApp.
type LookupLinuxFunctionAppOutputArgs struct {
	// The Site Credentials Username used for publishing.
	Name              pulumi.StringInput `pulumi:"name"`
	ResourceGroupName pulumi.StringInput `pulumi:"resourceGroupName"`
}

func (LookupLinuxFunctionAppOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupLinuxFunctionAppArgs)(nil)).Elem()
}

// A collection of values returned by getLinuxFunctionApp.
type LookupLinuxFunctionAppResultOutput struct{ *pulumi.OutputState }

func (LookupLinuxFunctionAppResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupLinuxFunctionAppResult)(nil)).Elem()
}

func (o LookupLinuxFunctionAppResultOutput) ToLookupLinuxFunctionAppResultOutput() LookupLinuxFunctionAppResultOutput {
	return o
}

func (o LookupLinuxFunctionAppResultOutput) ToLookupLinuxFunctionAppResultOutputWithContext(ctx context.Context) LookupLinuxFunctionAppResultOutput {
	return o
}

// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
func (o LookupLinuxFunctionAppResultOutput) AppSettings() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) map[string]string { return v.AppSettings }).(pulumi.StringMapOutput)
}

// A `authSettings` block as defined below.
func (o LookupLinuxFunctionAppResultOutput) AuthSettings() GetLinuxFunctionAppAuthSettingArrayOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) []GetLinuxFunctionAppAuthSetting { return v.AuthSettings }).(GetLinuxFunctionAppAuthSettingArrayOutput)
}

// A `backup` block as defined below.
func (o LookupLinuxFunctionAppResultOutput) Backups() GetLinuxFunctionAppBackupArrayOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) []GetLinuxFunctionAppBackup { return v.Backups }).(GetLinuxFunctionAppBackupArrayOutput)
}

// Is built in logging enabled?
func (o LookupLinuxFunctionAppResultOutput) BuiltinLoggingEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) bool { return v.BuiltinLoggingEnabled }).(pulumi.BoolOutput)
}

// Are Client Certificates enabled?
func (o LookupLinuxFunctionAppResultOutput) ClientCertificateEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) bool { return v.ClientCertificateEnabled }).(pulumi.BoolOutput)
}

// The mode of the Function App's client certificates requirement for incoming requests.
func (o LookupLinuxFunctionAppResultOutput) ClientCertificateMode() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) string { return v.ClientCertificateMode }).(pulumi.StringOutput)
}

// A `connectionString` blocks as defined below.
func (o LookupLinuxFunctionAppResultOutput) ConnectionStrings() GetLinuxFunctionAppConnectionStringArrayOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) []GetLinuxFunctionAppConnectionString { return v.ConnectionStrings }).(GetLinuxFunctionAppConnectionStringArrayOutput)
}

func (o LookupLinuxFunctionAppResultOutput) ContentShareForceDisabled() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) bool { return v.ContentShareForceDisabled }).(pulumi.BoolOutput)
}

// The identifier used by App Service to perform domain ownership verification via DNS TXT record.
func (o LookupLinuxFunctionAppResultOutput) CustomDomainVerificationId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) string { return v.CustomDomainVerificationId }).(pulumi.StringOutput)
}

// The amount of memory in gigabyte-seconds that your application is allowed to consume per day.
func (o LookupLinuxFunctionAppResultOutput) DailyMemoryTimeQuota() pulumi.IntOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) int { return v.DailyMemoryTimeQuota }).(pulumi.IntOutput)
}

// The default hostname of the Linux Function App.
func (o LookupLinuxFunctionAppResultOutput) DefaultHostname() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) string { return v.DefaultHostname }).(pulumi.StringOutput)
}

// Is this backup job enabled?
func (o LookupLinuxFunctionAppResultOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) bool { return v.Enabled }).(pulumi.BoolOutput)
}

// The runtime version associated with the Function App.
func (o LookupLinuxFunctionAppResultOutput) FunctionsExtensionVersion() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) string { return v.FunctionsExtensionVersion }).(pulumi.StringOutput)
}

// Can the Function App only be accessed via HTTPS?
func (o LookupLinuxFunctionAppResultOutput) HttpsOnly() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) bool { return v.HttpsOnly }).(pulumi.BoolOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupLinuxFunctionAppResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) string { return v.Id }).(pulumi.StringOutput)
}

// A `identity` block as defined below.
func (o LookupLinuxFunctionAppResultOutput) Identities() GetLinuxFunctionAppIdentityArrayOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) []GetLinuxFunctionAppIdentity { return v.Identities }).(GetLinuxFunctionAppIdentityArrayOutput)
}

// The Kind value for this Linux Function App.
func (o LookupLinuxFunctionAppResultOutput) Kind() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) string { return v.Kind }).(pulumi.StringOutput)
}

// The Azure Region where the Linux Function App exists.
func (o LookupLinuxFunctionAppResultOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) string { return v.Location }).(pulumi.StringOutput)
}

// The Site Credentials Username used for publishing.
func (o LookupLinuxFunctionAppResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) string { return v.Name }).(pulumi.StringOutput)
}

// A list of outbound IP addresses. For example `["52.23.25.3", "52.143.43.12"]`
func (o LookupLinuxFunctionAppResultOutput) OutboundIpAddressLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) []string { return v.OutboundIpAddressLists }).(pulumi.StringArrayOutput)
}

// A comma separated list of outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12`.
func (o LookupLinuxFunctionAppResultOutput) OutboundIpAddresses() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) string { return v.OutboundIpAddresses }).(pulumi.StringOutput)
}

// A list of possible outbound IP addresses, not all of which are necessarily in use. This is a superset of `outboundIpAddressList`. For example `["52.23.25.3", "52.143.43.12"]`.
func (o LookupLinuxFunctionAppResultOutput) PossibleOutboundIpAddressLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) []string { return v.PossibleOutboundIpAddressLists }).(pulumi.StringArrayOutput)
}

// A comma separated list of possible outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12,52.143.43.17`. This is a superset of `outboundIpAddresses`. For example `["52.23.25.3", "52.143.43.12","52.143.43.17"]`.
func (o LookupLinuxFunctionAppResultOutput) PossibleOutboundIpAddresses() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) string { return v.PossibleOutboundIpAddresses }).(pulumi.StringOutput)
}

func (o LookupLinuxFunctionAppResultOutput) ResourceGroupName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) string { return v.ResourceGroupName }).(pulumi.StringOutput)
}

// The ID of the App Service Plan within which this Function App has been created.
func (o LookupLinuxFunctionAppResultOutput) ServicePlanId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) string { return v.ServicePlanId }).(pulumi.StringOutput)
}

// A `siteConfig` block as defined below.
func (o LookupLinuxFunctionAppResultOutput) SiteConfigs() GetLinuxFunctionAppSiteConfigArrayOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) []GetLinuxFunctionAppSiteConfig { return v.SiteConfigs }).(GetLinuxFunctionAppSiteConfigArrayOutput)
}

// A `siteCredential` block as defined below.
func (o LookupLinuxFunctionAppResultOutput) SiteCredentials() GetLinuxFunctionAppSiteCredentialArrayOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) []GetLinuxFunctionAppSiteCredential { return v.SiteCredentials }).(GetLinuxFunctionAppSiteCredentialArrayOutput)
}

// The access key used to access the backend storage account for the Function App.
func (o LookupLinuxFunctionAppResultOutput) StorageAccountAccessKey() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) string { return v.StorageAccountAccessKey }).(pulumi.StringOutput)
}

// The backend storage account name used by this Function App.
func (o LookupLinuxFunctionAppResultOutput) StorageAccountName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) string { return v.StorageAccountName }).(pulumi.StringOutput)
}

// The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.
func (o LookupLinuxFunctionAppResultOutput) StorageKeyVaultSecretId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) string { return v.StorageKeyVaultSecretId }).(pulumi.StringOutput)
}

// Does the Function App use Managed Identity to access the storage account?
func (o LookupLinuxFunctionAppResultOutput) StorageUsesManagedIdentity() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) bool { return v.StorageUsesManagedIdentity }).(pulumi.BoolOutput)
}

// A mapping of tags which are assigned to the Linux Function App.
func (o LookupLinuxFunctionAppResultOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupLinuxFunctionAppResult) map[string]string { return v.Tags }).(pulumi.StringMapOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupLinuxFunctionAppResultOutput{})
}

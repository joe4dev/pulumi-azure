// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package keyvault

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Encrypts or Decrypts a value using a Key Vault Key.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-azure/sdk/v5/go/azure/keyvault"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		exampleKeyVault, err := keyvault.LookupKeyVault(ctx, &keyvault.LookupKeyVaultArgs{
// 			Name:              "mykeyvault",
// 			ResourceGroupName: "some-resource-group",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = keyvault.LookupKey(ctx, &keyvault.LookupKeyArgs{
// 			Name:       "some-key",
// 			KeyVaultId: exampleKeyVault.Id,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = keyvault.GetEncryptedValue(ctx, &keyvault.GetEncryptedValueArgs{
// 			KeyVaultKeyId:  azurerm_key_vault_key.Test.Id,
// 			Algorithm:      "RSA1_5",
// 			PlainTextValue: pulumi.StringRef("some-encrypted-value"),
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		ctx.Export("id", data.Azurerm_key_vault_encrypted_value.Example.Encrypted_data)
// 		return nil
// 	})
// }
// ```
func GetEncryptedValue(ctx *pulumi.Context, args *GetEncryptedValueArgs, opts ...pulumi.InvokeOption) (*GetEncryptedValueResult, error) {
	var rv GetEncryptedValueResult
	err := ctx.Invoke("azure:keyvault/getEncryptedValue:getEncryptedValue", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getEncryptedValue.
type GetEncryptedValueArgs struct {
	// The Algorithm which should be used to Decrypt/Encrypt this Value. Possible values are `RSA1_5`, `RSA-OAEP` and `RSA-OAEP-256`.
	Algorithm string `pulumi:"algorithm"`
	// The Base64 URL Encoded Encrypted Data which should be decrypted into `plainTextValue`.
	EncryptedData *string `pulumi:"encryptedData"`
	// The ID of the Key Vault Key which should be used to Decrypt/Encrypt this Value.
	KeyVaultKeyId string `pulumi:"keyVaultKeyId"`
	// The plain-text value which should be Encrypted into `encryptedData`.
	PlainTextValue *string `pulumi:"plainTextValue"`
}

// A collection of values returned by getEncryptedValue.
type GetEncryptedValueResult struct {
	Algorithm     string  `pulumi:"algorithm"`
	EncryptedData *string `pulumi:"encryptedData"`
	// The provider-assigned unique ID for this managed resource.
	Id             string  `pulumi:"id"`
	KeyVaultKeyId  string  `pulumi:"keyVaultKeyId"`
	PlainTextValue *string `pulumi:"plainTextValue"`
}

func GetEncryptedValueOutput(ctx *pulumi.Context, args GetEncryptedValueOutputArgs, opts ...pulumi.InvokeOption) GetEncryptedValueResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetEncryptedValueResult, error) {
			args := v.(GetEncryptedValueArgs)
			r, err := GetEncryptedValue(ctx, &args, opts...)
			return *r, err
		}).(GetEncryptedValueResultOutput)
}

// A collection of arguments for invoking getEncryptedValue.
type GetEncryptedValueOutputArgs struct {
	// The Algorithm which should be used to Decrypt/Encrypt this Value. Possible values are `RSA1_5`, `RSA-OAEP` and `RSA-OAEP-256`.
	Algorithm pulumi.StringInput `pulumi:"algorithm"`
	// The Base64 URL Encoded Encrypted Data which should be decrypted into `plainTextValue`.
	EncryptedData pulumi.StringPtrInput `pulumi:"encryptedData"`
	// The ID of the Key Vault Key which should be used to Decrypt/Encrypt this Value.
	KeyVaultKeyId pulumi.StringInput `pulumi:"keyVaultKeyId"`
	// The plain-text value which should be Encrypted into `encryptedData`.
	PlainTextValue pulumi.StringPtrInput `pulumi:"plainTextValue"`
}

func (GetEncryptedValueOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetEncryptedValueArgs)(nil)).Elem()
}

// A collection of values returned by getEncryptedValue.
type GetEncryptedValueResultOutput struct{ *pulumi.OutputState }

func (GetEncryptedValueResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetEncryptedValueResult)(nil)).Elem()
}

func (o GetEncryptedValueResultOutput) ToGetEncryptedValueResultOutput() GetEncryptedValueResultOutput {
	return o
}

func (o GetEncryptedValueResultOutput) ToGetEncryptedValueResultOutputWithContext(ctx context.Context) GetEncryptedValueResultOutput {
	return o
}

func (o GetEncryptedValueResultOutput) Algorithm() pulumi.StringOutput {
	return o.ApplyT(func(v GetEncryptedValueResult) string { return v.Algorithm }).(pulumi.StringOutput)
}

func (o GetEncryptedValueResultOutput) EncryptedData() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetEncryptedValueResult) *string { return v.EncryptedData }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetEncryptedValueResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetEncryptedValueResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetEncryptedValueResultOutput) KeyVaultKeyId() pulumi.StringOutput {
	return o.ApplyT(func(v GetEncryptedValueResult) string { return v.KeyVaultKeyId }).(pulumi.StringOutput)
}

func (o GetEncryptedValueResultOutput) PlainTextValue() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetEncryptedValueResult) *string { return v.PlainTextValue }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetEncryptedValueResultOutput{})
}

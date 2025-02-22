// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package appservice

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Manages an App Service Source Control Slot.
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
// 		exampleLinuxWebAppSlot, err := appservice.NewLinuxWebAppSlot(ctx, "exampleLinuxWebAppSlot", &appservice.LinuxWebAppSlotArgs{
// 			AppServiceId: exampleLinuxWebApp.ID(),
// 			SiteConfig:   nil,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = appservice.NewSourceControlSlot(ctx, "exampleSourceControlSlot", &appservice.SourceControlSlotArgs{
// 			SlotId:  exampleLinuxWebAppSlot.ID(),
// 			RepoUrl: pulumi.String("https://github.com/Azure-Samples/python-docs-hello-world"),
// 			Branch:  pulumi.String("master"),
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
// an App Service Source Control Slot can be imported using the `resource id`, e.g.
//
// ```sh
//  $ pulumi import azure:appservice/sourceControlSlot:SourceControlSlot example "/subscriptions/12345678-1234-9876-4563-123456789012/resourceGroups/resGroup1/providers/Microsoft.Web/sites/site1/slots/slot1"
// ```
type SourceControlSlot struct {
	pulumi.CustomResourceState

	// The URL for the repository. Changing this forces a new resource to be created.
	Branch pulumi.StringOutput `pulumi:"branch"`
	// A `githubActionConfiguration` block as detailed below.
	GithubActionConfiguration SourceControlSlotGithubActionConfigurationPtrOutput `pulumi:"githubActionConfiguration"`
	// The branch name to use for deployments. Changing this forces a new resource to be created.
	RepoUrl pulumi.StringOutput `pulumi:"repoUrl"`
	// Should the Deployment Rollback be enabled? Defaults to `false` Changing this forces a new resource to be created.
	RollbackEnabled pulumi.BoolPtrOutput `pulumi:"rollbackEnabled"`
	// The SCM Type in use. This value is decoded by the service from the repository information supplied.
	ScmType pulumi.StringOutput `pulumi:"scmType"`
	// The ID of the Linux or Windows Web App Slot. Changing this forces a new resource to be created.
	SlotId pulumi.StringOutput `pulumi:"slotId"`
	// Should the Slot use local Git configuration. Changing this forces a new resource to be created.
	UseLocalGit pulumi.BoolPtrOutput `pulumi:"useLocalGit"`
	// Should code be deployed manually. Set to `true` to disable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`. Changing this forces a new resource to be created.
	UseManualIntegration pulumi.BoolPtrOutput `pulumi:"useManualIntegration"`
	// The repository specified is Mercurial. Defaults to `false`. Changing this forces a new resource to be created.
	UseMercurial pulumi.BoolPtrOutput `pulumi:"useMercurial"`
	// Indicates if the Slot uses a GitHub action for deployment. This value is decoded by the service from the repository information supplied.
	UsesGithubAction pulumi.BoolOutput `pulumi:"usesGithubAction"`
}

// NewSourceControlSlot registers a new resource with the given unique name, arguments, and options.
func NewSourceControlSlot(ctx *pulumi.Context,
	name string, args *SourceControlSlotArgs, opts ...pulumi.ResourceOption) (*SourceControlSlot, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.SlotId == nil {
		return nil, errors.New("invalid value for required argument 'SlotId'")
	}
	var resource SourceControlSlot
	err := ctx.RegisterResource("azure:appservice/sourceControlSlot:SourceControlSlot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSourceControlSlot gets an existing SourceControlSlot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSourceControlSlot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SourceControlSlotState, opts ...pulumi.ResourceOption) (*SourceControlSlot, error) {
	var resource SourceControlSlot
	err := ctx.ReadResource("azure:appservice/sourceControlSlot:SourceControlSlot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SourceControlSlot resources.
type sourceControlSlotState struct {
	// The URL for the repository. Changing this forces a new resource to be created.
	Branch *string `pulumi:"branch"`
	// A `githubActionConfiguration` block as detailed below.
	GithubActionConfiguration *SourceControlSlotGithubActionConfiguration `pulumi:"githubActionConfiguration"`
	// The branch name to use for deployments. Changing this forces a new resource to be created.
	RepoUrl *string `pulumi:"repoUrl"`
	// Should the Deployment Rollback be enabled? Defaults to `false` Changing this forces a new resource to be created.
	RollbackEnabled *bool `pulumi:"rollbackEnabled"`
	// The SCM Type in use. This value is decoded by the service from the repository information supplied.
	ScmType *string `pulumi:"scmType"`
	// The ID of the Linux or Windows Web App Slot. Changing this forces a new resource to be created.
	SlotId *string `pulumi:"slotId"`
	// Should the Slot use local Git configuration. Changing this forces a new resource to be created.
	UseLocalGit *bool `pulumi:"useLocalGit"`
	// Should code be deployed manually. Set to `true` to disable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`. Changing this forces a new resource to be created.
	UseManualIntegration *bool `pulumi:"useManualIntegration"`
	// The repository specified is Mercurial. Defaults to `false`. Changing this forces a new resource to be created.
	UseMercurial *bool `pulumi:"useMercurial"`
	// Indicates if the Slot uses a GitHub action for deployment. This value is decoded by the service from the repository information supplied.
	UsesGithubAction *bool `pulumi:"usesGithubAction"`
}

type SourceControlSlotState struct {
	// The URL for the repository. Changing this forces a new resource to be created.
	Branch pulumi.StringPtrInput
	// A `githubActionConfiguration` block as detailed below.
	GithubActionConfiguration SourceControlSlotGithubActionConfigurationPtrInput
	// The branch name to use for deployments. Changing this forces a new resource to be created.
	RepoUrl pulumi.StringPtrInput
	// Should the Deployment Rollback be enabled? Defaults to `false` Changing this forces a new resource to be created.
	RollbackEnabled pulumi.BoolPtrInput
	// The SCM Type in use. This value is decoded by the service from the repository information supplied.
	ScmType pulumi.StringPtrInput
	// The ID of the Linux or Windows Web App Slot. Changing this forces a new resource to be created.
	SlotId pulumi.StringPtrInput
	// Should the Slot use local Git configuration. Changing this forces a new resource to be created.
	UseLocalGit pulumi.BoolPtrInput
	// Should code be deployed manually. Set to `true` to disable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`. Changing this forces a new resource to be created.
	UseManualIntegration pulumi.BoolPtrInput
	// The repository specified is Mercurial. Defaults to `false`. Changing this forces a new resource to be created.
	UseMercurial pulumi.BoolPtrInput
	// Indicates if the Slot uses a GitHub action for deployment. This value is decoded by the service from the repository information supplied.
	UsesGithubAction pulumi.BoolPtrInput
}

func (SourceControlSlotState) ElementType() reflect.Type {
	return reflect.TypeOf((*sourceControlSlotState)(nil)).Elem()
}

type sourceControlSlotArgs struct {
	// The URL for the repository. Changing this forces a new resource to be created.
	Branch *string `pulumi:"branch"`
	// A `githubActionConfiguration` block as detailed below.
	GithubActionConfiguration *SourceControlSlotGithubActionConfiguration `pulumi:"githubActionConfiguration"`
	// The branch name to use for deployments. Changing this forces a new resource to be created.
	RepoUrl *string `pulumi:"repoUrl"`
	// Should the Deployment Rollback be enabled? Defaults to `false` Changing this forces a new resource to be created.
	RollbackEnabled *bool `pulumi:"rollbackEnabled"`
	// The ID of the Linux or Windows Web App Slot. Changing this forces a new resource to be created.
	SlotId string `pulumi:"slotId"`
	// Should the Slot use local Git configuration. Changing this forces a new resource to be created.
	UseLocalGit *bool `pulumi:"useLocalGit"`
	// Should code be deployed manually. Set to `true` to disable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`. Changing this forces a new resource to be created.
	UseManualIntegration *bool `pulumi:"useManualIntegration"`
	// The repository specified is Mercurial. Defaults to `false`. Changing this forces a new resource to be created.
	UseMercurial *bool `pulumi:"useMercurial"`
}

// The set of arguments for constructing a SourceControlSlot resource.
type SourceControlSlotArgs struct {
	// The URL for the repository. Changing this forces a new resource to be created.
	Branch pulumi.StringPtrInput
	// A `githubActionConfiguration` block as detailed below.
	GithubActionConfiguration SourceControlSlotGithubActionConfigurationPtrInput
	// The branch name to use for deployments. Changing this forces a new resource to be created.
	RepoUrl pulumi.StringPtrInput
	// Should the Deployment Rollback be enabled? Defaults to `false` Changing this forces a new resource to be created.
	RollbackEnabled pulumi.BoolPtrInput
	// The ID of the Linux or Windows Web App Slot. Changing this forces a new resource to be created.
	SlotId pulumi.StringInput
	// Should the Slot use local Git configuration. Changing this forces a new resource to be created.
	UseLocalGit pulumi.BoolPtrInput
	// Should code be deployed manually. Set to `true` to disable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`. Changing this forces a new resource to be created.
	UseManualIntegration pulumi.BoolPtrInput
	// The repository specified is Mercurial. Defaults to `false`. Changing this forces a new resource to be created.
	UseMercurial pulumi.BoolPtrInput
}

func (SourceControlSlotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*sourceControlSlotArgs)(nil)).Elem()
}

type SourceControlSlotInput interface {
	pulumi.Input

	ToSourceControlSlotOutput() SourceControlSlotOutput
	ToSourceControlSlotOutputWithContext(ctx context.Context) SourceControlSlotOutput
}

func (*SourceControlSlot) ElementType() reflect.Type {
	return reflect.TypeOf((**SourceControlSlot)(nil)).Elem()
}

func (i *SourceControlSlot) ToSourceControlSlotOutput() SourceControlSlotOutput {
	return i.ToSourceControlSlotOutputWithContext(context.Background())
}

func (i *SourceControlSlot) ToSourceControlSlotOutputWithContext(ctx context.Context) SourceControlSlotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SourceControlSlotOutput)
}

// SourceControlSlotArrayInput is an input type that accepts SourceControlSlotArray and SourceControlSlotArrayOutput values.
// You can construct a concrete instance of `SourceControlSlotArrayInput` via:
//
//          SourceControlSlotArray{ SourceControlSlotArgs{...} }
type SourceControlSlotArrayInput interface {
	pulumi.Input

	ToSourceControlSlotArrayOutput() SourceControlSlotArrayOutput
	ToSourceControlSlotArrayOutputWithContext(context.Context) SourceControlSlotArrayOutput
}

type SourceControlSlotArray []SourceControlSlotInput

func (SourceControlSlotArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SourceControlSlot)(nil)).Elem()
}

func (i SourceControlSlotArray) ToSourceControlSlotArrayOutput() SourceControlSlotArrayOutput {
	return i.ToSourceControlSlotArrayOutputWithContext(context.Background())
}

func (i SourceControlSlotArray) ToSourceControlSlotArrayOutputWithContext(ctx context.Context) SourceControlSlotArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SourceControlSlotArrayOutput)
}

// SourceControlSlotMapInput is an input type that accepts SourceControlSlotMap and SourceControlSlotMapOutput values.
// You can construct a concrete instance of `SourceControlSlotMapInput` via:
//
//          SourceControlSlotMap{ "key": SourceControlSlotArgs{...} }
type SourceControlSlotMapInput interface {
	pulumi.Input

	ToSourceControlSlotMapOutput() SourceControlSlotMapOutput
	ToSourceControlSlotMapOutputWithContext(context.Context) SourceControlSlotMapOutput
}

type SourceControlSlotMap map[string]SourceControlSlotInput

func (SourceControlSlotMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SourceControlSlot)(nil)).Elem()
}

func (i SourceControlSlotMap) ToSourceControlSlotMapOutput() SourceControlSlotMapOutput {
	return i.ToSourceControlSlotMapOutputWithContext(context.Background())
}

func (i SourceControlSlotMap) ToSourceControlSlotMapOutputWithContext(ctx context.Context) SourceControlSlotMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SourceControlSlotMapOutput)
}

type SourceControlSlotOutput struct{ *pulumi.OutputState }

func (SourceControlSlotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SourceControlSlot)(nil)).Elem()
}

func (o SourceControlSlotOutput) ToSourceControlSlotOutput() SourceControlSlotOutput {
	return o
}

func (o SourceControlSlotOutput) ToSourceControlSlotOutputWithContext(ctx context.Context) SourceControlSlotOutput {
	return o
}

type SourceControlSlotArrayOutput struct{ *pulumi.OutputState }

func (SourceControlSlotArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SourceControlSlot)(nil)).Elem()
}

func (o SourceControlSlotArrayOutput) ToSourceControlSlotArrayOutput() SourceControlSlotArrayOutput {
	return o
}

func (o SourceControlSlotArrayOutput) ToSourceControlSlotArrayOutputWithContext(ctx context.Context) SourceControlSlotArrayOutput {
	return o
}

func (o SourceControlSlotArrayOutput) Index(i pulumi.IntInput) SourceControlSlotOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *SourceControlSlot {
		return vs[0].([]*SourceControlSlot)[vs[1].(int)]
	}).(SourceControlSlotOutput)
}

type SourceControlSlotMapOutput struct{ *pulumi.OutputState }

func (SourceControlSlotMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SourceControlSlot)(nil)).Elem()
}

func (o SourceControlSlotMapOutput) ToSourceControlSlotMapOutput() SourceControlSlotMapOutput {
	return o
}

func (o SourceControlSlotMapOutput) ToSourceControlSlotMapOutputWithContext(ctx context.Context) SourceControlSlotMapOutput {
	return o
}

func (o SourceControlSlotMapOutput) MapIndex(k pulumi.StringInput) SourceControlSlotOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *SourceControlSlot {
		return vs[0].(map[string]*SourceControlSlot)[vs[1].(string)]
	}).(SourceControlSlotOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SourceControlSlotInput)(nil)).Elem(), &SourceControlSlot{})
	pulumi.RegisterInputType(reflect.TypeOf((*SourceControlSlotArrayInput)(nil)).Elem(), SourceControlSlotArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*SourceControlSlotMapInput)(nil)).Elem(), SourceControlSlotMap{})
	pulumi.RegisterOutputType(SourceControlSlotOutput{})
	pulumi.RegisterOutputType(SourceControlSlotArrayOutput{})
	pulumi.RegisterOutputType(SourceControlSlotMapOutput{})
}

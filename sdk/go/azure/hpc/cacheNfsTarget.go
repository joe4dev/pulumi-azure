// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package hpc

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Manages a NFS Target within a HPC Cache.
//
// > **NOTE:**: By request of the service team the provider no longer automatically registering the `Microsoft.StorageCache` Resource Provider for this resource. To register it you can run `az provider register --namespace 'Microsoft.StorageCache'`.
//
// ## Import
//
// NFS Target within a HPC Cache can be imported using the `resource id`, e.g.
//
// ```sh
//  $ pulumi import azure:hpc/cacheNfsTarget:CacheNfsTarget example /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/group1/providers/Microsoft.StorageCache/caches/cache1/storageTargets/target1
// ```
type CacheNfsTarget struct {
	pulumi.CustomResourceState

	// The name HPC Cache, which the HPC Cache NFS Target will be added to. Changing this forces a new resource to be created.
	CacheName pulumi.StringOutput `pulumi:"cacheName"`
	// The name of the HPC Cache NFS Target. Changing this forces a new resource to be created.
	Name pulumi.StringOutput `pulumi:"name"`
	// Can be specified multiple times to define multiple `namespaceJunction`. Each `namespaceJuntion` block supports fields documented below.
	NamespaceJunctions CacheNfsTargetNamespaceJunctionArrayOutput `pulumi:"namespaceJunctions"`
	// The name of the Resource Group in which to create the HPC Cache NFS Target. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringOutput `pulumi:"resourceGroupName"`
	// The IP address or fully qualified domain name (FQDN) of the HPC Cache NFS target. Changing this forces a new resource to be created.
	TargetHostName pulumi.StringOutput `pulumi:"targetHostName"`
	// The type of usage of the HPC Cache NFS Target. Possible values are: `READ_HEAVY_INFREQ`, `READ_HEAVY_CHECK_180`, `WRITE_WORKLOAD_15`, `WRITE_AROUND`, `WRITE_WORKLOAD_CHECK_30`, `WRITE_WORKLOAD_CHECK_60` and `WRITE_WORKLOAD_CLOUDWS`.
	UsageModel pulumi.StringOutput `pulumi:"usageModel"`
}

// NewCacheNfsTarget registers a new resource with the given unique name, arguments, and options.
func NewCacheNfsTarget(ctx *pulumi.Context,
	name string, args *CacheNfsTargetArgs, opts ...pulumi.ResourceOption) (*CacheNfsTarget, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CacheName == nil {
		return nil, errors.New("invalid value for required argument 'CacheName'")
	}
	if args.NamespaceJunctions == nil {
		return nil, errors.New("invalid value for required argument 'NamespaceJunctions'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.TargetHostName == nil {
		return nil, errors.New("invalid value for required argument 'TargetHostName'")
	}
	if args.UsageModel == nil {
		return nil, errors.New("invalid value for required argument 'UsageModel'")
	}
	var resource CacheNfsTarget
	err := ctx.RegisterResource("azure:hpc/cacheNfsTarget:CacheNfsTarget", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCacheNfsTarget gets an existing CacheNfsTarget resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCacheNfsTarget(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CacheNfsTargetState, opts ...pulumi.ResourceOption) (*CacheNfsTarget, error) {
	var resource CacheNfsTarget
	err := ctx.ReadResource("azure:hpc/cacheNfsTarget:CacheNfsTarget", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CacheNfsTarget resources.
type cacheNfsTargetState struct {
	// The name HPC Cache, which the HPC Cache NFS Target will be added to. Changing this forces a new resource to be created.
	CacheName *string `pulumi:"cacheName"`
	// The name of the HPC Cache NFS Target. Changing this forces a new resource to be created.
	Name *string `pulumi:"name"`
	// Can be specified multiple times to define multiple `namespaceJunction`. Each `namespaceJuntion` block supports fields documented below.
	NamespaceJunctions []CacheNfsTargetNamespaceJunction `pulumi:"namespaceJunctions"`
	// The name of the Resource Group in which to create the HPC Cache NFS Target. Changing this forces a new resource to be created.
	ResourceGroupName *string `pulumi:"resourceGroupName"`
	// The IP address or fully qualified domain name (FQDN) of the HPC Cache NFS target. Changing this forces a new resource to be created.
	TargetHostName *string `pulumi:"targetHostName"`
	// The type of usage of the HPC Cache NFS Target. Possible values are: `READ_HEAVY_INFREQ`, `READ_HEAVY_CHECK_180`, `WRITE_WORKLOAD_15`, `WRITE_AROUND`, `WRITE_WORKLOAD_CHECK_30`, `WRITE_WORKLOAD_CHECK_60` and `WRITE_WORKLOAD_CLOUDWS`.
	UsageModel *string `pulumi:"usageModel"`
}

type CacheNfsTargetState struct {
	// The name HPC Cache, which the HPC Cache NFS Target will be added to. Changing this forces a new resource to be created.
	CacheName pulumi.StringPtrInput
	// The name of the HPC Cache NFS Target. Changing this forces a new resource to be created.
	Name pulumi.StringPtrInput
	// Can be specified multiple times to define multiple `namespaceJunction`. Each `namespaceJuntion` block supports fields documented below.
	NamespaceJunctions CacheNfsTargetNamespaceJunctionArrayInput
	// The name of the Resource Group in which to create the HPC Cache NFS Target. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringPtrInput
	// The IP address or fully qualified domain name (FQDN) of the HPC Cache NFS target. Changing this forces a new resource to be created.
	TargetHostName pulumi.StringPtrInput
	// The type of usage of the HPC Cache NFS Target. Possible values are: `READ_HEAVY_INFREQ`, `READ_HEAVY_CHECK_180`, `WRITE_WORKLOAD_15`, `WRITE_AROUND`, `WRITE_WORKLOAD_CHECK_30`, `WRITE_WORKLOAD_CHECK_60` and `WRITE_WORKLOAD_CLOUDWS`.
	UsageModel pulumi.StringPtrInput
}

func (CacheNfsTargetState) ElementType() reflect.Type {
	return reflect.TypeOf((*cacheNfsTargetState)(nil)).Elem()
}

type cacheNfsTargetArgs struct {
	// The name HPC Cache, which the HPC Cache NFS Target will be added to. Changing this forces a new resource to be created.
	CacheName string `pulumi:"cacheName"`
	// The name of the HPC Cache NFS Target. Changing this forces a new resource to be created.
	Name *string `pulumi:"name"`
	// Can be specified multiple times to define multiple `namespaceJunction`. Each `namespaceJuntion` block supports fields documented below.
	NamespaceJunctions []CacheNfsTargetNamespaceJunction `pulumi:"namespaceJunctions"`
	// The name of the Resource Group in which to create the HPC Cache NFS Target. Changing this forces a new resource to be created.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The IP address or fully qualified domain name (FQDN) of the HPC Cache NFS target. Changing this forces a new resource to be created.
	TargetHostName string `pulumi:"targetHostName"`
	// The type of usage of the HPC Cache NFS Target. Possible values are: `READ_HEAVY_INFREQ`, `READ_HEAVY_CHECK_180`, `WRITE_WORKLOAD_15`, `WRITE_AROUND`, `WRITE_WORKLOAD_CHECK_30`, `WRITE_WORKLOAD_CHECK_60` and `WRITE_WORKLOAD_CLOUDWS`.
	UsageModel string `pulumi:"usageModel"`
}

// The set of arguments for constructing a CacheNfsTarget resource.
type CacheNfsTargetArgs struct {
	// The name HPC Cache, which the HPC Cache NFS Target will be added to. Changing this forces a new resource to be created.
	CacheName pulumi.StringInput
	// The name of the HPC Cache NFS Target. Changing this forces a new resource to be created.
	Name pulumi.StringPtrInput
	// Can be specified multiple times to define multiple `namespaceJunction`. Each `namespaceJuntion` block supports fields documented below.
	NamespaceJunctions CacheNfsTargetNamespaceJunctionArrayInput
	// The name of the Resource Group in which to create the HPC Cache NFS Target. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringInput
	// The IP address or fully qualified domain name (FQDN) of the HPC Cache NFS target. Changing this forces a new resource to be created.
	TargetHostName pulumi.StringInput
	// The type of usage of the HPC Cache NFS Target. Possible values are: `READ_HEAVY_INFREQ`, `READ_HEAVY_CHECK_180`, `WRITE_WORKLOAD_15`, `WRITE_AROUND`, `WRITE_WORKLOAD_CHECK_30`, `WRITE_WORKLOAD_CHECK_60` and `WRITE_WORKLOAD_CLOUDWS`.
	UsageModel pulumi.StringInput
}

func (CacheNfsTargetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*cacheNfsTargetArgs)(nil)).Elem()
}

type CacheNfsTargetInput interface {
	pulumi.Input

	ToCacheNfsTargetOutput() CacheNfsTargetOutput
	ToCacheNfsTargetOutputWithContext(ctx context.Context) CacheNfsTargetOutput
}

func (*CacheNfsTarget) ElementType() reflect.Type {
	return reflect.TypeOf((**CacheNfsTarget)(nil)).Elem()
}

func (i *CacheNfsTarget) ToCacheNfsTargetOutput() CacheNfsTargetOutput {
	return i.ToCacheNfsTargetOutputWithContext(context.Background())
}

func (i *CacheNfsTarget) ToCacheNfsTargetOutputWithContext(ctx context.Context) CacheNfsTargetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CacheNfsTargetOutput)
}

// CacheNfsTargetArrayInput is an input type that accepts CacheNfsTargetArray and CacheNfsTargetArrayOutput values.
// You can construct a concrete instance of `CacheNfsTargetArrayInput` via:
//
//          CacheNfsTargetArray{ CacheNfsTargetArgs{...} }
type CacheNfsTargetArrayInput interface {
	pulumi.Input

	ToCacheNfsTargetArrayOutput() CacheNfsTargetArrayOutput
	ToCacheNfsTargetArrayOutputWithContext(context.Context) CacheNfsTargetArrayOutput
}

type CacheNfsTargetArray []CacheNfsTargetInput

func (CacheNfsTargetArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CacheNfsTarget)(nil)).Elem()
}

func (i CacheNfsTargetArray) ToCacheNfsTargetArrayOutput() CacheNfsTargetArrayOutput {
	return i.ToCacheNfsTargetArrayOutputWithContext(context.Background())
}

func (i CacheNfsTargetArray) ToCacheNfsTargetArrayOutputWithContext(ctx context.Context) CacheNfsTargetArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CacheNfsTargetArrayOutput)
}

// CacheNfsTargetMapInput is an input type that accepts CacheNfsTargetMap and CacheNfsTargetMapOutput values.
// You can construct a concrete instance of `CacheNfsTargetMapInput` via:
//
//          CacheNfsTargetMap{ "key": CacheNfsTargetArgs{...} }
type CacheNfsTargetMapInput interface {
	pulumi.Input

	ToCacheNfsTargetMapOutput() CacheNfsTargetMapOutput
	ToCacheNfsTargetMapOutputWithContext(context.Context) CacheNfsTargetMapOutput
}

type CacheNfsTargetMap map[string]CacheNfsTargetInput

func (CacheNfsTargetMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CacheNfsTarget)(nil)).Elem()
}

func (i CacheNfsTargetMap) ToCacheNfsTargetMapOutput() CacheNfsTargetMapOutput {
	return i.ToCacheNfsTargetMapOutputWithContext(context.Background())
}

func (i CacheNfsTargetMap) ToCacheNfsTargetMapOutputWithContext(ctx context.Context) CacheNfsTargetMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CacheNfsTargetMapOutput)
}

type CacheNfsTargetOutput struct{ *pulumi.OutputState }

func (CacheNfsTargetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**CacheNfsTarget)(nil)).Elem()
}

func (o CacheNfsTargetOutput) ToCacheNfsTargetOutput() CacheNfsTargetOutput {
	return o
}

func (o CacheNfsTargetOutput) ToCacheNfsTargetOutputWithContext(ctx context.Context) CacheNfsTargetOutput {
	return o
}

type CacheNfsTargetArrayOutput struct{ *pulumi.OutputState }

func (CacheNfsTargetArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CacheNfsTarget)(nil)).Elem()
}

func (o CacheNfsTargetArrayOutput) ToCacheNfsTargetArrayOutput() CacheNfsTargetArrayOutput {
	return o
}

func (o CacheNfsTargetArrayOutput) ToCacheNfsTargetArrayOutputWithContext(ctx context.Context) CacheNfsTargetArrayOutput {
	return o
}

func (o CacheNfsTargetArrayOutput) Index(i pulumi.IntInput) CacheNfsTargetOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *CacheNfsTarget {
		return vs[0].([]*CacheNfsTarget)[vs[1].(int)]
	}).(CacheNfsTargetOutput)
}

type CacheNfsTargetMapOutput struct{ *pulumi.OutputState }

func (CacheNfsTargetMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CacheNfsTarget)(nil)).Elem()
}

func (o CacheNfsTargetMapOutput) ToCacheNfsTargetMapOutput() CacheNfsTargetMapOutput {
	return o
}

func (o CacheNfsTargetMapOutput) ToCacheNfsTargetMapOutputWithContext(ctx context.Context) CacheNfsTargetMapOutput {
	return o
}

func (o CacheNfsTargetMapOutput) MapIndex(k pulumi.StringInput) CacheNfsTargetOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *CacheNfsTarget {
		return vs[0].(map[string]*CacheNfsTarget)[vs[1].(string)]
	}).(CacheNfsTargetOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CacheNfsTargetInput)(nil)).Elem(), &CacheNfsTarget{})
	pulumi.RegisterInputType(reflect.TypeOf((*CacheNfsTargetArrayInput)(nil)).Elem(), CacheNfsTargetArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*CacheNfsTargetMapInput)(nil)).Elem(), CacheNfsTargetMap{})
	pulumi.RegisterOutputType(CacheNfsTargetOutput{})
	pulumi.RegisterOutputType(CacheNfsTargetArrayOutput{})
	pulumi.RegisterOutputType(CacheNfsTargetMapOutput{})
}

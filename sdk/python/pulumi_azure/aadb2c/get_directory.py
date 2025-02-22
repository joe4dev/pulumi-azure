# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'GetDirectoryResult',
    'AwaitableGetDirectoryResult',
    'get_directory',
    'get_directory_output',
]

@pulumi.output_type
class GetDirectoryResult:
    """
    A collection of values returned by getDirectory.
    """
    def __init__(__self__, billing_type=None, data_residency_location=None, domain_name=None, effective_start_date=None, id=None, resource_group_name=None, sku_name=None, tags=None, tenant_id=None):
        if billing_type and not isinstance(billing_type, str):
            raise TypeError("Expected argument 'billing_type' to be a str")
        pulumi.set(__self__, "billing_type", billing_type)
        if data_residency_location and not isinstance(data_residency_location, str):
            raise TypeError("Expected argument 'data_residency_location' to be a str")
        pulumi.set(__self__, "data_residency_location", data_residency_location)
        if domain_name and not isinstance(domain_name, str):
            raise TypeError("Expected argument 'domain_name' to be a str")
        pulumi.set(__self__, "domain_name", domain_name)
        if effective_start_date and not isinstance(effective_start_date, str):
            raise TypeError("Expected argument 'effective_start_date' to be a str")
        pulumi.set(__self__, "effective_start_date", effective_start_date)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if resource_group_name and not isinstance(resource_group_name, str):
            raise TypeError("Expected argument 'resource_group_name' to be a str")
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        if sku_name and not isinstance(sku_name, str):
            raise TypeError("Expected argument 'sku_name' to be a str")
        pulumi.set(__self__, "sku_name", sku_name)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if tenant_id and not isinstance(tenant_id, str):
            raise TypeError("Expected argument 'tenant_id' to be a str")
        pulumi.set(__self__, "tenant_id", tenant_id)

    @property
    @pulumi.getter(name="billingType")
    def billing_type(self) -> str:
        """
        The type of billing for the AAD B2C tenant. Possible values include: `MAU` or `Auths`.
        """
        return pulumi.get(self, "billing_type")

    @property
    @pulumi.getter(name="dataResidencyLocation")
    def data_residency_location(self) -> str:
        """
        Location in which the B2C tenant is hosted and data resides. See [official docs](https://aka.ms/B2CDataResidenc) for more information.
        """
        return pulumi.get(self, "data_residency_location")

    @property
    @pulumi.getter(name="domainName")
    def domain_name(self) -> str:
        return pulumi.get(self, "domain_name")

    @property
    @pulumi.getter(name="effectiveStartDate")
    def effective_start_date(self) -> str:
        """
        The date from which the billing type took effect. May not be populated until after the first billing cycle.
        """
        return pulumi.get(self, "effective_start_date")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> str:
        return pulumi.get(self, "resource_group_name")

    @property
    @pulumi.getter(name="skuName")
    def sku_name(self) -> str:
        """
        Billing SKU for the B2C tenant. See [official docs](https://aka.ms/b2cBilling) for more information.
        """
        return pulumi.get(self, "sku_name")

    @property
    @pulumi.getter
    def tags(self) -> Mapping[str, str]:
        """
        A mapping of tags assigned to the AAD B2C Directory.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> str:
        """
        The Tenant ID for the AAD B2C tenant.
        """
        return pulumi.get(self, "tenant_id")


class AwaitableGetDirectoryResult(GetDirectoryResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDirectoryResult(
            billing_type=self.billing_type,
            data_residency_location=self.data_residency_location,
            domain_name=self.domain_name,
            effective_start_date=self.effective_start_date,
            id=self.id,
            resource_group_name=self.resource_group_name,
            sku_name=self.sku_name,
            tags=self.tags,
            tenant_id=self.tenant_id)


def get_directory(domain_name: Optional[str] = None,
                  resource_group_name: Optional[str] = None,
                  opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDirectoryResult:
    """
    Use this data source to access information about an existing AAD B2C Directory.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_azure as azure

    example = azure.aadb2c.get_directory(resource_group_name="example-rg",
        domain_name="exampleb2ctenant.onmicrosoft.com")
    pulumi.export("tenantId", example.tenant_id)
    ```


    :param str domain_name: Domain name of the B2C tenant, including the `.onmicrosoft.com` suffix.
    :param str resource_group_name: The name of the Resource Group where the AAD B2C Directory exists.
    """
    __args__ = dict()
    __args__['domainName'] = domain_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure:aadb2c/getDirectory:getDirectory', __args__, opts=opts, typ=GetDirectoryResult).value

    return AwaitableGetDirectoryResult(
        billing_type=__ret__.billing_type,
        data_residency_location=__ret__.data_residency_location,
        domain_name=__ret__.domain_name,
        effective_start_date=__ret__.effective_start_date,
        id=__ret__.id,
        resource_group_name=__ret__.resource_group_name,
        sku_name=__ret__.sku_name,
        tags=__ret__.tags,
        tenant_id=__ret__.tenant_id)


@_utilities.lift_output_func(get_directory)
def get_directory_output(domain_name: Optional[pulumi.Input[str]] = None,
                         resource_group_name: Optional[pulumi.Input[str]] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDirectoryResult]:
    """
    Use this data source to access information about an existing AAD B2C Directory.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_azure as azure

    example = azure.aadb2c.get_directory(resource_group_name="example-rg",
        domain_name="exampleb2ctenant.onmicrosoft.com")
    pulumi.export("tenantId", example.tenant_id)
    ```


    :param str domain_name: Domain name of the B2C tenant, including the `.onmicrosoft.com` suffix.
    :param str resource_group_name: The name of the Resource Group where the AAD B2C Directory exists.
    """
    ...

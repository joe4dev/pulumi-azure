# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'GetNamespaceDisasterRecoveryConfigResult',
    'AwaitableGetNamespaceDisasterRecoveryConfigResult',
    'get_namespace_disaster_recovery_config',
    'get_namespace_disaster_recovery_config_output',
]

@pulumi.output_type
class GetNamespaceDisasterRecoveryConfigResult:
    """
    A collection of values returned by getNamespaceDisasterRecoveryConfig.
    """
    def __init__(__self__, default_primary_key=None, default_secondary_key=None, id=None, name=None, namespace_id=None, namespace_name=None, partner_namespace_id=None, primary_connection_string_alias=None, resource_group_name=None, secondary_connection_string_alias=None):
        if default_primary_key and not isinstance(default_primary_key, str):
            raise TypeError("Expected argument 'default_primary_key' to be a str")
        pulumi.set(__self__, "default_primary_key", default_primary_key)
        if default_secondary_key and not isinstance(default_secondary_key, str):
            raise TypeError("Expected argument 'default_secondary_key' to be a str")
        pulumi.set(__self__, "default_secondary_key", default_secondary_key)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if namespace_id and not isinstance(namespace_id, str):
            raise TypeError("Expected argument 'namespace_id' to be a str")
        pulumi.set(__self__, "namespace_id", namespace_id)
        if namespace_name and not isinstance(namespace_name, str):
            raise TypeError("Expected argument 'namespace_name' to be a str")
        pulumi.set(__self__, "namespace_name", namespace_name)
        if partner_namespace_id and not isinstance(partner_namespace_id, str):
            raise TypeError("Expected argument 'partner_namespace_id' to be a str")
        pulumi.set(__self__, "partner_namespace_id", partner_namespace_id)
        if primary_connection_string_alias and not isinstance(primary_connection_string_alias, str):
            raise TypeError("Expected argument 'primary_connection_string_alias' to be a str")
        pulumi.set(__self__, "primary_connection_string_alias", primary_connection_string_alias)
        if resource_group_name and not isinstance(resource_group_name, str):
            raise TypeError("Expected argument 'resource_group_name' to be a str")
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        if secondary_connection_string_alias and not isinstance(secondary_connection_string_alias, str):
            raise TypeError("Expected argument 'secondary_connection_string_alias' to be a str")
        pulumi.set(__self__, "secondary_connection_string_alias", secondary_connection_string_alias)

    @property
    @pulumi.getter(name="defaultPrimaryKey")
    def default_primary_key(self) -> str:
        return pulumi.get(self, "default_primary_key")

    @property
    @pulumi.getter(name="defaultSecondaryKey")
    def default_secondary_key(self) -> str:
        return pulumi.get(self, "default_secondary_key")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="namespaceId")
    def namespace_id(self) -> Optional[str]:
        return pulumi.get(self, "namespace_id")

    @property
    @pulumi.getter(name="namespaceName")
    def namespace_name(self) -> Optional[str]:
        return pulumi.get(self, "namespace_name")

    @property
    @pulumi.getter(name="partnerNamespaceId")
    def partner_namespace_id(self) -> str:
        return pulumi.get(self, "partner_namespace_id")

    @property
    @pulumi.getter(name="primaryConnectionStringAlias")
    def primary_connection_string_alias(self) -> str:
        return pulumi.get(self, "primary_connection_string_alias")

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> Optional[str]:
        return pulumi.get(self, "resource_group_name")

    @property
    @pulumi.getter(name="secondaryConnectionStringAlias")
    def secondary_connection_string_alias(self) -> str:
        return pulumi.get(self, "secondary_connection_string_alias")


class AwaitableGetNamespaceDisasterRecoveryConfigResult(GetNamespaceDisasterRecoveryConfigResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetNamespaceDisasterRecoveryConfigResult(
            default_primary_key=self.default_primary_key,
            default_secondary_key=self.default_secondary_key,
            id=self.id,
            name=self.name,
            namespace_id=self.namespace_id,
            namespace_name=self.namespace_name,
            partner_namespace_id=self.partner_namespace_id,
            primary_connection_string_alias=self.primary_connection_string_alias,
            resource_group_name=self.resource_group_name,
            secondary_connection_string_alias=self.secondary_connection_string_alias)


def get_namespace_disaster_recovery_config(name: Optional[str] = None,
                                           namespace_id: Optional[str] = None,
                                           namespace_name: Optional[str] = None,
                                           resource_group_name: Optional[str] = None,
                                           opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetNamespaceDisasterRecoveryConfigResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['namespaceId'] = namespace_id
    __args__['namespaceName'] = namespace_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure:servicebus/getNamespaceDisasterRecoveryConfig:getNamespaceDisasterRecoveryConfig', __args__, opts=opts, typ=GetNamespaceDisasterRecoveryConfigResult).value

    return AwaitableGetNamespaceDisasterRecoveryConfigResult(
        default_primary_key=__ret__.default_primary_key,
        default_secondary_key=__ret__.default_secondary_key,
        id=__ret__.id,
        name=__ret__.name,
        namespace_id=__ret__.namespace_id,
        namespace_name=__ret__.namespace_name,
        partner_namespace_id=__ret__.partner_namespace_id,
        primary_connection_string_alias=__ret__.primary_connection_string_alias,
        resource_group_name=__ret__.resource_group_name,
        secondary_connection_string_alias=__ret__.secondary_connection_string_alias)


@_utilities.lift_output_func(get_namespace_disaster_recovery_config)
def get_namespace_disaster_recovery_config_output(name: Optional[pulumi.Input[str]] = None,
                                                  namespace_id: Optional[pulumi.Input[Optional[str]]] = None,
                                                  namespace_name: Optional[pulumi.Input[Optional[str]]] = None,
                                                  resource_group_name: Optional[pulumi.Input[Optional[str]]] = None,
                                                  opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetNamespaceDisasterRecoveryConfigResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
